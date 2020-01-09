using InventarioPaginaWeb.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace InventarioPaginaWeb.Controllers
{
    public class RevisionController : Controller
    {
        HostingEnvironment hostingEnvironment;

        public RevisionController (HostingEnvironment he)
        {
            hostingEnvironment = he;
        }

        public IActionResult Index()
        {
            var context = HttpContext.RequestServices.GetService(typeof(inventarioContext)) as inventarioContext;

            var lista = context.Revision.ToList<Revision>();
                return View(lista);
            
        }

        [HttpGet]
        public IActionResult Create () {
            return View ();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Revision emp)
        {
            var context = HttpContext.RequestServices.GetService(typeof(inventarioContext)) as inventarioContext;

            context.Revision.Add(emp);
                context.SaveChanges();
                TempData["message"] = "Una nueva revision ha sido agreada";
                return RedirectToAction("Index");
            
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(inventarioContext)) as inventarioContext;

            var revision = context.Revision.Where(e => e.IdRevision == id).First();
                return View(revision);
             
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Revision emp)
        {
            var context = HttpContext.RequestServices.GetService(typeof(inventarioContext)) as inventarioContext;

            context.Revision.Update(emp);
                context.SaveChanges();
                TempData["message"] = "La información de la revision ha sido actualizada";
                return RedirectToAction("Index");
            
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(inventarioContext)) as inventarioContext;

            var revision = context.Revision.Where(e => e.IdRevision == id).First<Revision>();
                return View(revision);
              
        }

        public ActionResult Delete(int? id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(inventarioContext)) as inventarioContext;

            Revision personalDetail = context.Revision.Find(id);

                return View(personalDetail);
            
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(inventarioContext)) as inventarioContext;

            Revision revision = context.Revision.Find(id);
                context.Revision.Remove(revision);
                context.SaveChanges();
                TempData["message"] = "La información del tipo de revision ha sido Eliminada";
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