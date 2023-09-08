using IdleCases;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TestKustoWithPrompt.Models;

namespace TestKustoWithPrompt.Controllers
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
            KustoController controller = new KustoController();
            var kustoData = controller.GetData("gebumgar");
            return PartialView(kustoData[0]);
        }

        public IActionResult Privacy()
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