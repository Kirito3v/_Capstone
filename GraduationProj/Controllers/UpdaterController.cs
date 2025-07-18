using GraduationProj.Data;
using GraduationProj.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GraduationProj.Controllers
{
    public class UpdaterController : Controller
    {

        private readonly MainDataContext _context;

        public UpdaterController(MainDataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }


        public JsonResult GetUpdatedSummary(int cartId)
        {
            var CartItems = _context.CartItems.Include(C=>C.Product).Where(C=>C.CartId == cartId).ToArray();

            // Return the updated product details (new quantity and price)

            if (CartItems.Length>0)
            {
                float total = CartItems.Sum(prop => (float)prop.Product.Price * prop.Quantity);

                float subtotal = total;

                float tax = total*0.05f;

                float shipping = total * 0.01f;

                return Json(new
                {
                    success = true,
                    Subtotal = subtotal,
                    Tax = tax,
                    Shipping = shipping,
                    Total = total*1.06
                });
            }
            else
            {
                return Json(new
                {
                    success = true,
                    Subtotal = 0,
                    Tax = 0,
                    Shipping = 0,
                    Total = 0 * 1.06

                });
            }
        }


        public JsonResult UpdateCartQuantity(int cartId, int productId)
        {
            // Update the quantity of the product in your database or session
            var updatedProduct = _context.CartItems.Include(c=>c.Product).Where(c=>c.CartId==cartId&&c.ProductId == productId).FirstOrDefault();

            // Return the updated product details (new quantity and price)

            if (updatedProduct != null)
            {
                return Json(new
                {
                    success = true,
                    newQuantity = updatedProduct.Quantity,
                    newTotalPrice = updatedProduct.Quantity * (float)updatedProduct.Product.Price
                });
            }
            else
            {
                return Json(new
                {
                    success = false,
                    newQuantity = 0,

                });
            }
        }

    }




}
