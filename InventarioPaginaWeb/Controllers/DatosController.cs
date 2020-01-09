using InventarioPaginaWeb.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace InventarioPaginaWeb.Controllers
{
    public class DatosController : Controller
    {
        HostingEnvironment hostingEnvironment;

        public DatosController (HostingEnvironment he)
        {
            hostingEnvironment = he;
        }

        public IActionResult Index()
        {
            var context = HttpContext.RequestServices.GetService(typeof(inventarioContext)) as inventarioContext;

            var lista = context.Datos.ToList<Datos>();
                return View(lista);
            
        }

        [HttpGet]
        public IActionResult Create () {
            return View ();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Datos emp)
        {
            var context = HttpContext.RequestServices.GetService(typeof(inventarioContext)) as inventarioContext;

            context.Datos.Add(emp);
                context.SaveChanges();
                TempData["message"] = "Los datos e Informacion ya han sido agregados";
                return RedirectToAction("Index");
            
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(inventarioContext)) as inventarioContext;

            var datos = context.Datos.Where(e => e.IdDatos == id).First();
                return View(datos);
             
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Datos emp)
        {
            var context = HttpContext.RequestServices.GetService(typeof(inventarioContext)) as inventarioContext;

            context.Datos.Update(emp);
                context.SaveChanges();
                TempData["message"] = "Los datos e Informacion ya han sido Actualizados";
                return RedirectToAction("Index");
            
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(inventarioContext)) as inventarioContext;

            var datos = context.Datos.Where(e => e.IdDatos == id).First<Datos>();
                return View(datos);
             
        }

        public ActionResult Delete(int? id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(inventarioContext)) as inventarioContext;

            Datos personalDetail = context.Datos.Find(id);
           
                return View(personalDetail);
            
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(inventarioContext)) as inventarioContext;

            Datos datos = context.Datos.Find(id);
            context.Datos.Remove(datos);
            context.SaveChanges();
            TempData["message"] = "Los datos e Informacion ya han sido Eliminados";
            return RedirectToAction("Index");
        
        }

        [HttpGet]
        [Authorize]
        public IActionResult Upload ()
        {
            return View ();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upload (IFormFile file)
        {
            return Content (file.FileName + " size: " + file.Length);
        }

    }

}