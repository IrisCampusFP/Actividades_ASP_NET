using Ejercicio3._1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Ejercicio3._1.Controllers
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

        // Acción POST que simula la creación del usuario
        [HttpPost]
        public IActionResult CrearUsuario(Models.UsuarioModel model)
        {
            // Se asigna un mensaje a TempData["MensajeExito"]
            TempData["MensajeExito"] = $"Usuario '{model.Nombre}' creado correctamente.";

            // Redirige a la acción GET ListadoUsuarios()
            return RedirectToAction("ListadoUsuarios");
        }

        // Acción GET que redirige al usuario a la página correspondiente tras iniciar sesión
        [HttpGet]
        public IActionResult ListadoUsuarios() { 
            return View(); 
        }
    }
}
