using Microsoft.AspNetCore.Mvc;

namespace B_Trip_MVC.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        } 
        public IActionResult Sign()
        {
            return View();
        }
    }
}
