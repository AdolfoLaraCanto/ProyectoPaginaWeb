using InventarioPaginaWeb.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace InventarioPaginaWeb.Controllers
{
    public class EncargadoController : Controller
    {
        HostingEnvironment hostingEnvironment;

        public EncargadoController (HostingEnvironment he)
        {
            hostingEnvironment = he;
        }

        public IActionResult Index()
        {
            var context = HttpContext.RequestServices.GetService(typeof(inventarioContext)) as inventarioContext;

            var lista = context.Encargado.ToList<Encargado>();
                return View(lista);
            
        }

        [HttpGet]
        public IActionResult Create () {
            
            return View ();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Encargado emp)
        {
            var context = HttpContext.RequestServices.GetService(typeof(inventarioContext)) as inventarioContext;

            context.Encargado.Add(emp);
            context.SaveChanges();
            TempData["message"] = "El nuevo empleado ha sido agreado";
            return RedirectToAction("Index");
            
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(inventarioContext)) as inventarioContext;

            var encargado = context.Encargado.Where(e => e.IdEncargado == id).First();
                return View(encargado);
                
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Encargado emp)
        {
            var context = HttpContext.RequestServices.GetService(typeof(inventarioContext)) as inventarioContext;

            context.Encargado.Update(emp);
                context.SaveChanges();
                TempData["message"] = "La información del empleado ha actualizada";
                return RedirectToAction("Index");
            
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(inventarioContext)) as inventarioContext;

            var encargado = context.Encargado.Where(e => e.IdEncargado == id).First<Encargado>();
                return View(encargado);
                
            
        }

        public ActionResult Delete(int? id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(inventarioContext)) as inventarioContext;

            Encargado personalDetail = context.Encargado.Find(id);
           
                return View(personalDetail);
            
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(inventarioContext)) as inventarioContext;

            Encargado encargado = context.Encargado.Find(id);
                context.Encargado.Remove(encargado);
                context.SaveChanges();
                TempData["message"] = "La información del empleado ha sido Eliminada";
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