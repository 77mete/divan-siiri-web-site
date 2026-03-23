using System.Diagnostics;
using divanSiiri.Models;
using Microsoft.AspNetCore.Mvc;

namespace divanSiiri.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

		public IActionResult Index()
		{
			return View();
		}
		public IActionResult Fuzuli()
		{
			return View();
		}
		public IActionResult Baki()
		{
			return View();
		}
		public IActionResult Nefi()
		{
			return View();
		}
		public IActionResult seyhGalip()
		{
			return View();
		}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
