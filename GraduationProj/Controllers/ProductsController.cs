using Python;
using GraduationProj.Data;
using GraduationProj.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.OutputCaching;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace GraduationProj.Controllers
{
    public class ProductsController : Controller
    {

        private readonly ILogger<HomeController> _logger;

        private readonly PyTimeService pyTimeService1;

        private readonly MainDataContext _context;
        private readonly StaticHolder _sh;

        public static bool Wait = false;

        public List<ProductViewModel> productListViewModel { get; set; } = new List<ProductViewModel>();

        public ProductsController(MainDataContext context, ILogger<HomeController> logger, PyTimeService pyTimeService1,StaticHolder sh)
        {
            _context = context;
            _logger = logger;
            this.pyTimeService1 = pyTimeService1;
            _sh = sh;

        }

 
        public IActionResult ProductDetailsView(int product_id=0)
        {
            var product = _context.Products.Where(p => p.Id == product_id).First();

            product.Details = _context.ProductsDetails
                .Include(d=>d.Traits)
                .Include(d=>d.RelatedProducts)
                .Where(d=>d.product.Id == product_id).First();

            if (product.Details.Traits.Count()==0) 
            {
                throw new Exception("Trails is not loaded");
            }

            return View(product);

        }


        
        public IActionResult Cart()
        {

            int AccountID = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)??"-1");


            var Cart = _context.UserItems.Include(ui => ui.Cart)
                .ThenInclude(ui => ui.CartItems)
                .ThenInclude(ui => ui.Product)
                .Where(ui => ui.AccountId == AccountID).First().Cart;


         
            List<CartProductView> items = Cart.CartItems.Where(c=>c.Quantity!=0).Select(ci=>
                new CartProductView
                {
                    Id = ci.CartId,
                    Name = ci.Product.Name,
                    Price = ci.Product.Price,
                    ImageFileName = $"../images/{ci.Product.Name}.png",
                    ProductID = ci.Product.Id,
                    Quantity = ci.Quantity
                }
            ).ToList();
            return View(items);
        }

        public async  Task<IActionResult> Index(string Category="",string Search ="", string? ProductsName = null)
        {
            
            int AccountID = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));

          
            var WishListProducts = (await _context.UserItems.Include(ui=>ui.Wishlist)
                .ThenInclude(ui=>ui!.ProductWishlists)
                .ThenInclude(ui=>ui.Product)
                .Where(ui=> ui.AccountId == AccountID).FirstAsync()).Wishlist?.ProductWishlists;


            var ProductList = _context.Products.ToList();

            if (ProductsName != null)
            {

                var products = new List<Product>();

                var ProductNames = ProductsName.Split(',');


                foreach (var name in ProductNames)
                {
                    var product = ProductList.Find(x => x.Name == name);

                    if (product != null)
                    {
                        products.Add(product);
                    }

                }



                productListViewModel = products.Select(
                    p => new ProductViewModel
                    {
                        Id = p.Id,
                        Name = p.Name.Substring(0, Math.Min(p.Name.Length, 20)) + (p.Name.Length > 20 ? ".." : ""),
                        Price = p.Price,
                        ImageFileName = $"../images/{p.Name}.png",
                        
                        
                    }).ToList();

                foreach (var product in WishListProducts)
                {
                    productListViewModel.ForEach(p =>
                    {
                        if(p.Id == product.Product.Id)
                        {
                            p.IsInWishlist = true;
                        }
                    });
                }
            }
            else
            {
                productListViewModel = _context.Products
                    .Where(p => (p.Category == Category || Category == string.Empty)
                    &&
                    (p.Name.ToLower().Contains(Search.ToLower()) || Search == string.Empty))
                    .AsEnumerable()
                    .Select(
                    p => new ProductViewModel
                    {
                        Id = p.Id,
                        Name = p.Name.Substring(0, Math.Min(p.Name.Length, 20)) + (p.Name.Length > 20 ? ".." : ""),
                        Price = p.Price,
                        ImageFileName = $"../images/{p.Name}.png",
                       

                    }
                ).OrderBy(i=>i.Name).ToList();

                foreach (var product in WishListProducts)
                {
                    productListViewModel.ForEach(p =>
                    {
                        if (p.Id == product.Product.Id)
                        {
                            p.IsInWishlist = true;
                        }
                    });
                }
            }

            return View(productListViewModel);
        }


        public async Task<IActionResult> WishlistView()
        {
            int AccountID = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)??"-1");


            var WishListProducts = (await _context.UserItems.Include(ui => ui.Wishlist)
                .ThenInclude(ui => ui.ProductWishlists)
                .ThenInclude(ui => ui.Product)
                .Where(ui => ui.AccountId == AccountID).FirstAsync()).Wishlist?.ProductWishlists;


            var products = WishListProducts
                .Select(p=> new ProductViewModel
                {
                    Id =p.Product.Id,
                    Name = p.Product.Name,
                    Price = p.Product.Price,
                    ImageFileName = $"../images/{p.Product.Name}.png",

                }).OrderBy(i => i.Name).ToList();


            foreach (var product in WishListProducts)
            {
                products.ForEach(p =>
                {
                    if (p.Id == product.ProductId)
                    {
                        p.IsInWishlist = true;
                    }
                });
            }

            return View(products);

        }
        public async Task<ActionResult> ImageSearch(IFormFile imageFile)
        {
            if (imageFile == null || imageFile.Length == 0)
                return RedirectToAction();

            string uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads");

            if (!Directory.Exists(uploadsFolder))
            {
                Directory.CreateDirectory(uploadsFolder);
            }

            var url = Path.Combine(uploadsFolder, imageFile.FileName);

            using (var stream = new FileStream(url, FileMode.Create))
            {
                await imageFile.CopyToAsync(stream);
            }


            pyTimeService1.PyMeth("ImageSearchFromGenerator");

            pyTimeService1.PyMeth("AllInOne");


            await Task.Delay(10);

            pyTimeService1.PyMeth(url);

            Wait = true;

            await waituntilProcessEnd();

            await Task.Delay(10);

            var result = pyTimeService1.LastMessage;
            _logger.LogInformation(result);



            return Json(result);


        }

        public async Task waituntilProcessEnd()
        {
            while (Wait)
            {
                await Task.Delay(10);
            }
        }

        [HttpPost]
        public async Task<JsonResult> ToggleWishlist(int id)
        {

            int AccountID = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier) ?? "-1");


            var WishList = _context.UserItems.Include(ui => ui.Wishlist)
                .ThenInclude(ui => ui.ProductWishlists)
                .ThenInclude(ui => ui.Product)
                .Where(ui => ui.AccountId == AccountID).First().Wishlist;

            var WishListProducts = WishList.ProductWishlists;

            var productWishlist = WishListProducts.Where(p=>p.ProductId==id).FirstOrDefault();

            var product = _context.Products.Find(id);

            bool added = productWishlist == null;

            if (productWishlist!= null)
            {
                
                _context.productWishlists.Remove(productWishlist);
            }
            else
            {
                productWishlist = new ProductWishlist
                {
                    Wishlist = WishList,
                    WishlistId = WishList.Id,
                    ProductId = product.Id,
                    Product = product
                };
                _context.productWishlists.Add(productWishlist);

            }

            await _context.SaveChangesAsync();
            // 4. Return JSON indicating new state
            return Json(new { added = added });
        }

    }


}
