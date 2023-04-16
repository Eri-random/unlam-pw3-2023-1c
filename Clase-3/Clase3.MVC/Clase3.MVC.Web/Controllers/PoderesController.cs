using Clase3.MVC.Dominio.Entidades;
using Clase3.MVC.Dominio.Logica;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Clase3.MVC.Web.Controllers
{
    public class PoderesController: Controller
    {
        ITipoPoderRepositorio _tipoPoderRepositorio;

        IPoderesRepositorio _poderesRepositorio;

        public PoderesController(ITipoPoderRepositorio tipoPoderRepositorio,IPoderesRepositorio poderesRepositorio)
        {
            _poderesRepositorio = poderesRepositorio;
            _tipoPoderRepositorio = tipoPoderRepositorio;

        }

        public ActionResult Index()
        {
            var poderes = _poderesRepositorio.ObtenerTodos();
            return View(poderes);
        }

        [HttpGet]
        public IActionResult Agregar()
        {
            var listaPoderes = _tipoPoderRepositorio.ObtenerTodos();

            ViewBag.poderes = listaPoderes;
            return View();
        }

        [HttpPost]
        public IActionResult Agregar(Poder poder, int tipo)
        {
            var tipoPoder = _tipoPoderRepositorio.ObtenerPoderPorId(tipo);

            poder.Tipo = tipoPoder;

            _poderesRepositorio.Agregar(poder);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Detalle(int id)
        {
            Poder poder = _poderesRepositorio.ObtenerPoderPorId(id);
            return View(poder);
        }

        [HttpGet]
        public IActionResult Eliminar(int id)
        {
            _poderesRepositorio.Eliminar(id);
            return RedirectToAction("Index");
        }
    }
}
