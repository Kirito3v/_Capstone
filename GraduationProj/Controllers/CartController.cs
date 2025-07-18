using GraduationProj.Data;
using GraduationProj.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace GraduationProj.Controllers
{
    public class CartController : Controller
    {
        private readonly MainDataContext _context;
        public CartController(MainDataContext context)
        {
            _context = context;   
        }
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult shipping()
        {
            int AccountID = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));

            var UserItems = _context.UserItems.Where(ui => AccountID == ui.AccountId).First();

            var si = _context.ShippingInfos.Where(si => si.UserId == UserItems.Id).FirstOrDefault();


            if (si == null)
                return View(new ShippingInfo() { UserId = UserItems.Id, Added = false });
            else
            {
                si.Added = true;
                return View(si);
            }
        }


        [HttpPost]
        public IActionResult shipping(ShippingInfo model)
        {
            if (!ModelState.IsValid)
                return View("Shipping", model);


            model.Date = DateTime.SpecifyKind(model.Date, DateTimeKind.Utc);

            if (model.Added)
            {
                var existing = _context.ShippingInfos.Find(model.UserId);
                if (existing == null)
                    return NotFound();

                existing.Cost = model.Cost;
                existing.Date = model.Date;
                existing.Method = model.Method;

                _context.SaveChanges();
            }
            else
            {
                model.UserId = 0; 
                model.Added = true; 

                _context.ShippingInfos.Add(model);
                _context.SaveChanges();
            }

            return RedirectToAction("payment");
        }

        public async Task<IActionResult> payment()
        {
            int AccountID = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));

            var UserItems = await _context.UserItems
                .Include(ui=>ui.Address)
                .Include(ui=>ui.Cart)
                .ThenInclude(c=>c.CartItems)
                .ThenInclude(ci=>ci.Product)
                .Where(ui => AccountID == ui.AccountId).FirstAsync();

            var SM = await _context.ShippingInfos.FirstOrDefaultAsync(si => si.UserId == UserItems.Id);

            
            PaymentInfoView piv = new PaymentInfoView();

            piv.shippingInfo = SM;
            
            piv.address = UserItems.Address;

            float supTotal = UserItems.Cart.CartItems.Sum(prop => (float)prop.Product.Price * prop.Quantity);

            float tax = supTotal * 0.06f;

            piv.SupTotal = supTotal;
            piv.Tax = tax;

            piv.Total = supTotal * 1.06f;

            piv.CartItems = UserItems.Cart.CartItems.ToList();


            return View(piv);
        }






        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CheckOutView(Address model)
        {
            if (!ModelState.IsValid)
                return View(model);


            _context.Attach(model);
            _context.Entry(model).State = EntityState.Modified;
            _context.SaveChanges();

            return RedirectToAction("Shipping", "Cart");
        }

        [HttpGet]
        public IActionResult CheckOutView()
        {
            int AccountID = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));


            var address = _context.UserItems.Include(ui => ui.Address)
                .Where(ui => ui.AccountId == AccountID).First().Address;


            return View(address);
        }

        public new async Task<JsonResult> Empty()
        {
            int AccountID = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));


            var Cart = _context.UserItems.Include(ui => ui.Cart)
                .ThenInclude(ui => ui.CartItems)
                .Where(ui => ui.AccountId == AccountID).First().Cart;

            Cart.CartItems.Clear();

            await _context.SaveChangesAsync();


            return Json(new { success = true });

        }
        public async Task<IActionResult> AddItem([FromForm] int ProductId, [FromForm] float Quantity)
        {

            int AccountID = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));


            var Cart = _context.UserItems.Include(ui => ui.Cart)
                .ThenInclude(ui => ui.CartItems)
                .ThenInclude(ui => ui.Product)
                .Where(ui => ui.AccountId == AccountID).First().Cart;



            CartItem cartItem = new CartItem
            {
                CartId = Cart.Id,
                ProductId = ProductId,
                Quantity = Quantity
            };

            var item =  Cart.CartItems.FirstOrDefault(ci => ci.ProductId == ProductId);

            if (item != null)
            {
                item.Quantity += cartItem.Quantity;

                if(item.Quantity <= 0)
                {
                    Cart.CartItems.Remove(item);
                }
            }
            else
                Cart.CartItems.Add(cartItem);
            
            await _context.SaveChangesAsync();


            return Json(new { success = true });

      
        }
    }
}
