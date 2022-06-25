using Microsoft.AspNetCore.Mvc;
using okulSistem.Business.Abstract;
using okulSistem.Business.Concrete;
using okulSistem.DataAccess;
using okulSistem.Entities;

namespace okulSistem.WebMvc.Controllers
{
    public class AccountController : Controller
    {
        private IUserService _userService;
        private OkulSistemDbContext _context;

        public AccountController()
        {
            _userService = new UserManager();
            _context = new OkulSistemDbContext();
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login(string userMail, string userPassword)
        {
            var user = _context.Users.FirstOrDefault(x=>x.userMail.Equals(userMail) && x.userPassword.Equals(userPassword));
            if (user != null)
            {
                HttpContext.Session.SetInt32("id",user.userId);
                HttpContext.Session.SetString("fullname",user.userAd+" "+user.userSoyad);
                return Redirect("/Home/Index");
            }
            return Redirect("Index"); ;
        }
        public IActionResult SignUp()
        {
            return View();
        }
        public IActionResult Register(User user)
        {
            _userService.CreateUser(user);
            return Redirect("Index");
        }
    }
}
