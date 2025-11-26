using Ejercicio2._2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Ejercicio2._2.Controllers
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
            return View(model);
        }


        [HttpGet] 
        public IActionResult Login()
        {
            // Devuelve la vista
            return View();
        }
        [HttpPost]
        public IActionResult Login(Models.LoginModel model)
        {
            // Si model.Usuario es admin, redirige a la acción perfil (del Ej1.1)
            if (model.Usuario == "admin" && model.Contrasena == "1234")
            {
                return RedirectToAction("Perfil");
            }

            ViewBag.Error = "Usuario o contraseña incorrectos.";
            return View(model);
        }
    }
}
