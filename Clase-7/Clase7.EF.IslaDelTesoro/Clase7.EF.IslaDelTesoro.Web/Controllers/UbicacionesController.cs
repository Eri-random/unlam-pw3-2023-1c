using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Clase7.EF.IslaDelTesoro.Data.Entidades;

namespace Clase7.EF.IslaDelTesoro.Web.Controllers
{
    public class UbicacionesController : Controller
    {
        private readonly IslaDelTesoroContext _context;

        public UbicacionesController(IslaDelTesoroContext context)
        {
            _context = context;
        }

        // GET: Ubicacions
        public IActionResult Index()
        {
            return View(_context.Ubicacions);
        }

        // GET: Ubicacions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Ubicacions/Create
        [HttpPost]
        public IActionResult Create(Ubicacion ubicacion)
        {
            if (ModelState.IsValid)
            {
                _context.Ubicacions.Add(ubicacion);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ubicacion);
        }

        // GET: Ubicacions/Edit/5
        public IActionResult Edit(int? id)
        {
            var ubicacion = _context.Ubicacions.Find(id);

            if (ubicacion == null)
            {
                return NotFound();
            }
            return View(ubicacion);
        }

        // POST: Ubicacions/Edit/5
       
        [HttpPost]
        public IActionResult Edit(Ubicacion ubicacion)
        {

            if (ModelState.IsValid)
            {
                _context.Ubicacions.Update(ubicacion);
                _context.SaveChanges();
                RedirectToAction("Index");
            }
            return View(ubicacion);
        }


        // GET: Ubicacions/Delete/5
        public IActionResult Delete(int id)
        {
            var ubi = _context.Ubicacions.Find(id);

            if(ubi != null)
            {
                _context.Ubicacions.Remove(ubi);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

    }
}
