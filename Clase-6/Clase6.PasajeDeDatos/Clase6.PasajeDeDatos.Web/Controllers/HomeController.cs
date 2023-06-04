using System.Diagnostics;
using Clase6.PasajeDeDatos.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Clase6.PasajeDeDatos.Web.Controllers
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
            var colores = new List<ColorViewModel>()
            {
                new ColorViewModel()
                {
                    Id = 1,
                    Nombre = "Rojo",
                    Valor = "#FF2D00"
                },
                new ColorViewModel()
                {
                    Id = 2,
                    Nombre = "Verde",
                    Valor = "#005406"
                },
                new ColorViewModel()
                {
                    Id = 3,
                    Nombre = "Amarillo",
                    Valor = "#FAFE17"
                }
            };

            return View(colores);
        }

        [HttpPost]
        public IActionResult Index(IFormCollection form)
        {
            string color = form.Keys.FirstOrDefault(k => !string.IsNullOrEmpty(form[k]));
            if (!string.IsNullOrEmpty(color))
                HttpContext.Session.SetString("ColorSeleccionado", color);
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}