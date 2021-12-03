using Microsoft.AspNetCore.Mvc;

namespace CryptoModule.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "Hello from CryptoModule";
            return View(); 
        }
    }
}
