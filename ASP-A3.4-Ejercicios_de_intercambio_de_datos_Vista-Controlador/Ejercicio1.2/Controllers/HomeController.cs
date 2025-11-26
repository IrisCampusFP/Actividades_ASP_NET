using System.Diagnostics;
using Ejercicio1._2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ejercicio1._2.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Perfil()
        {
            PerfilViewModel model = new PerfilViewModel("Iris", "iris.perezaparicio24@campusfp.es", true);
            ViewBag.TituloPagina = "Perfil de usuario";
            ViewData["FechaActual"] = DateTime.Now.ToShortDateString();
            return View(model);
        }
    }
}
