using InventarioPaginaWeb.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace InventarioPaginaWeb.Controllers
{
    public class TipoRegistroController : Controller
    {
        HostingEnvironment hostingEnvironment;

        public TipoRegistroController (HostingEnvironment he)
        {
            hostingEnvironment = he;
        }

        public IActionResult Index()
        {
            var context = HttpContext.RequestServices.GetService(typeof(inventarioContext)) as inventarioContext;

            var lista = context.TipoRegistro.ToList<TipoRegistro>();
                return View(lista);
            
        }

        [HttpGet]
        public IActionResult Create () {
            return View ();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TipoRegistro emp)
        {
            var context = HttpContext.RequestServices.GetService(typeof(inventarioContext)) as inventarioContext;

            context.TipoRegistro.Add(emp);
                context.SaveChanges();
                TempData["message"] = "El nuevo tipo de registro ha sido agreado";
                return RedirectToAction("Index");
            
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(inventarioContext)) as inventarioContext;

            var tipoRegistro = context.TipoRegistro.Where(e => e.IdRegistro == id).First();
                return View(tipoRegistro);
             
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(TipoRegistro emp)
        {
            var context = HttpContext.RequestServices.GetService(typeof(inventarioContext)) as inventarioContext;

            context.TipoRegistro.Update(emp);
                context.SaveChanges();
                TempData["message"] = "La información del tipo de registro ha sido actualizada";
                return RedirectToAction("Index");
            
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(inventarioContext)) as inventarioContext;

            var tipoRegistro = context.TipoRegistro.Where(e => e.IdRegistro == id).First<TipoRegistro>();
                return View(tipoRegistro);
             
        }

        public ActionResult Delete(int? id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(inventarioContext)) as inventarioContext;

            TipoRegistro personalDetail = context.TipoRegistro.Find(id);
           
                return View(personalDetail);
            
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(inventarioContext)) as inventarioContext;

            TipoRegistro tipoRegistro = context.TipoRegistro.Find(id);
            context.TipoRegistro.Remove(tipoRegistro);
            context.SaveChanges();
            TempData["message"] = "La información del tipo de registro ha sido Eliminada";
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