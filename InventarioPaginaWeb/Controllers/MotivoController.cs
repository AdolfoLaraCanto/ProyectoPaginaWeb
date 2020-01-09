using InventarioPaginaWeb.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace InventarioPaginaWeb.Controllers
{
    public class MotivoController : Controller
    {
        HostingEnvironment hostingEnvironment;

        public MotivoController (HostingEnvironment he)
        {
            hostingEnvironment = he;
        }

        public IActionResult Index()
        {
            var context = HttpContext.RequestServices.GetService(typeof(inventarioContext)) as inventarioContext;

            var lista = context.Motivo.ToList<Motivo>();
                return View(lista);
            
        }

        [HttpGet]
        public IActionResult Create () {
            return View ();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Motivo emp)
        {
            var context = HttpContext.RequestServices.GetService(typeof(inventarioContext)) as inventarioContext;

            context.Motivo.Add(emp);
                context.SaveChanges();
                TempData["message"] = "El nuevo motivo ha sido agreado";
                return RedirectToAction("Index");
            
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(inventarioContext)) as inventarioContext;

            var motivo = context.Motivo.Where(e => e.IdMotivo == id).First();
                return View(motivo);
             
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Motivo emp)
        {
            using (var context = new inventarioContext())
            {
                context.Motivo.Update(emp);
                context.SaveChanges();
                TempData["message"] = "La información del motivo ha sido actualizada";
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(inventarioContext)) as inventarioContext;

            var motivo = context.Motivo.Where(e => e.IdMotivo == id).First<Motivo>();
                return View(motivo);
             
        }

        public ActionResult Delete(int? id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(inventarioContext)) as inventarioContext;

            Motivo personalDetail = context.Motivo.Find(id);
           
                return View(personalDetail);
            
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(inventarioContext)) as inventarioContext;

            Motivo motivo = context.Motivo.Find(id);
            context.Motivo.Remove(motivo);
            context.SaveChanges();
            TempData["message"] = "La información del motivo ha sido Eliminada";
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