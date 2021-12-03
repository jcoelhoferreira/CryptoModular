using CryptoModule.Services;
using Microsoft.AspNetCore.Mvc;

namespace CryptoModule.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAPIService _aPIService;

        public HomeController(IAPIService aPIService)
        {
            _aPIService = aPIService;
        }

        public IActionResult Index()
        {
            ViewBag.Message = "Hello from CryptoModule";
            var cryptoRates = _aPIService.GetCryptoInfo().Result.Result;
            return View(cryptoRates); 
        }
    }
}
