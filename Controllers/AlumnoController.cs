using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Practico1.Models;
using Practico1.Services;

namespace Practico1.Controllers
{
    [Route("api/[controller]")]
    public class AlumnoController : Controller
    {
        public AlumnoController()
        {

        }
        [HttpGet]
        public IActionResult Index()
        {
            var listado = AlumnoServices.GetAll();
            return View(listado);
        }
        [Route("api/[Controller]/Detalle")]
        public IActionResult Detail(string nombre)
        {
            if (nombre == null)
            {
                return RedirectToAction("Index");
            }
            var mostrar = AlumnoServices.Get(nombre);
            return View(mostrar);
        }
        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult Delete(string nombre)
        {
            if (nombre != null)
            {
                AlumnoServices.Delete(nombre);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Privacy");

        }

        [HttpGet]
        [Route("api/[Controller]/Crear")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult OnPostCreate(Alumno value)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Create");

            }
            AlumnoServices.Agregar(value);
            return RedirectToAction("Index");
        }

        [Route("api/Modificar/{nombre}")]
        public IActionResult Update(string nombre)
        {
            var alumno = AlumnoServices.Get(nombre);
            return View(alumno);
        }

        [Route("api/Modificar")]
        public IActionResult OnPostUpdate(Alumno obj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            AlumnoServices.Update(obj);
            return RedirectToAction("Index");
        }
    }
}