using GraduationProj.Data;
using GraduationProj.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Security.Claims;

namespace GraduationProj.Controllers
{
    public class AccountController : Controller
    {
        private readonly MainDataContext _db;
        private readonly IPasswordHasher<Account> _hasher;
        private readonly StaticHolder _sh;

        public AccountController(MainDataContext db, IPasswordHasher<Account> hasher,StaticHolder sh)
        {
            _db = db;
            _hasher = hasher;
            _sh = sh;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
                return RedirectToAction("Logout", "Account");

            return View("Login");
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register()
        {

            if (User.Identity.IsAuthenticated)
                return RedirectToAction("Index", "Home");

            return View();
        }

        // POST: /Account/Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<IActionResult> Register(AccountViewModel vm)
        {

            if (User.Identity.IsAuthenticated)
                return RedirectToAction("Index", "Home");

            if (!ModelState.IsValid)
                return View(vm);

            // Check for existing email
            if (_db.Accounts.Any(a => a.Email == vm.Email))
            {
                ModelState.AddModelError(nameof(vm.Email), "Email already in use.");
                return View(vm);
            }

            // Create and hash
            var account = new Account
            {
                FullName = vm.FullName,
                Email = vm.Email
            };
            account.PasswordHash = _hasher.HashPassword(account, vm.Password);


            //user items

            UserItems userItems = new UserItems
            {
                Cart = new Cart(),
                Wishlist = new Wishlist(),
                Address = new Address(),
                Account = account,
                AccountId = account.Id
                
            };

            account.UserItems = userItems;


            _db.Add(userItems);

            await _db.SaveChangesAsync();

            userItems.AccountId = account.Id;

            userItems.Wishlist.UserItemsId = userItems.Id;
            userItems.Address.UserItemsId = userItems.Id;
            userItems.Cart.UserItemsId = userItems.Id;

            await _db.SaveChangesAsync();

            


            // Auto-login after register (optional)
            await SignInUser(account);

            return RedirectToAction("Index", "Home");
        }

        // GET: /Account/Login
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login(string returnUrl = null!)
        {
            if (User.Identity.IsAuthenticated)
                return RedirectToAction("Logout", "Account");

            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        // POST: /Account/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel vm, string returnUrl = null!)
        {

            if (User.Identity.IsAuthenticated)
                return RedirectToAction("Logout", "Account");

            if (!ModelState.IsValid)
                return View(vm);

            var account = _db.Accounts.SingleOrDefault(a => a.Email == vm.Email);
            if (account == null ||
                _hasher.VerifyHashedPassword(account, account.PasswordHash, vm.Password)
                != PasswordVerificationResult.Success)
            {
                ModelState.AddModelError(string.Empty, "Invalid email or password.");
                return View(vm);
            }
            account.UserItems = _db.UserItems.Include(ui => ui.Account)
                                             .Include(ui => ui.Cart)
                                             .Include(ui => ui.Wishlist)
                                             .ThenInclude(wl=>wl.ProductWishlists)
                                             .FirstOrDefault(ex => ex.AccountId == account.Id);

            if(account.UserItems == null)
            {
                UserItems userItems = new UserItems
                {
                    AccountId = account.Id,
                    Account = account,
                    Wishlist = new Wishlist(),
                    Address = new Address(),
                    Cart = new Cart()
                };

                account.UserItems = userItems;

                _db.Add(userItems);

                await _db.SaveChangesAsync();
            }
                            

            await SignInUser(account);

            if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                return Redirect(returnUrl);

            return RedirectToAction("Index", "Home");
        }

        // POST: /Account/Logout
        [HttpGet]
        [Authorize]
        public IActionResult Logout()
        {
            // Just show the confirmation page
            return View();
        }

        // 4️⃣ POST: /Account/Logout
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> LogoutConfirmed()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }

        [AllowAnonymous]
        private async Task SignInUser(Account account)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, account.Id.ToString()),
                new Claim(ClaimTypes.Name, account.FullName),
                new Claim(ClaimTypes.Email, account.Email)
            };
            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var principal = new ClaimsPrincipal(identity);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
        }

    }
}
