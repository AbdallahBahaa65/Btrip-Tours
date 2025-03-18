using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace B_Trip_MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
      
        public IActionResult Recent()
        {
            return View();
        }
    }
}
