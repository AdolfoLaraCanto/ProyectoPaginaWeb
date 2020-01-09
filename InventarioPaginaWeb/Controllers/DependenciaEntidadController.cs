using InventarioPaginaWeb.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace InventarioPaginaWeb.Controllers
{
    public class DependenciaEntidadController : Controller
    {
        HostingEnvironment hostingEnvironment;

        public DependenciaEntidadController (HostingEnvironment he)
        {
            hostingEnvironment = he;
        }

        public IActionResult Index()
        {
            var context = HttpContext.RequestServices.GetService(typeof(inventarioContext)) as inventarioContext;

            var lista = context.DependenciaEntidad.ToList<DependenciaEntidad>();
                return View(lista);
            
        }

        [HttpGet]
        public IActionResult Create () {
            return View ();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(DependenciaEntidad emp)
        {
            var context = HttpContext.RequestServices.GetService(typeof(inventarioContext)) as inventarioContext;

            context.DependenciaEntidad.Add(emp);
                context.SaveChanges();
                TempData["message"] = "La nueva Dependencia ha sido agreada";
                return RedirectToAction("Index");
            
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(inventarioContext)) as inventarioContext;

            var dependencia = context.DependenciaEntidad.Where(e => e.IdDependenciaEntidad == id).First();
                return View(dependencia);
            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(DependenciaEntidad emp)
        {
            var context = HttpContext.RequestServices.GetService(typeof(inventarioContext)) as inventarioContext;

            context.DependenciaEntidad.Update(emp);
                context.SaveChanges();
                TempData["message"] = "La información de la Dependencia ha sido actualizada";
                return RedirectToAction("Index");
            
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(inventarioContext)) as inventarioContext;

            var dependencia = context.DependenciaEntidad.Where(e => e.IdDependenciaEntidad == id).First<DependenciaEntidad>();
                return View(dependencia);
                
        }

        public ActionResult Delete(int? id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(inventarioContext)) as inventarioContext;

            DependenciaEntidad personalDetail = context.DependenciaEntidad.Find(id);
           
                return View(personalDetail);
            
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(inventarioContext)) as inventarioContext;

            DependenciaEntidad dependencia = context.DependenciaEntidad.Find(id);
            context.DependenciaEntidad.Remove(dependencia);
            context.SaveChanges();
            TempData["message"] = "La información de la Dependencia ha sido Eliminada";
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