using InventarioPaginaWeb.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
namespace InventarioPaginaWeb.Controllers
{
    public class VerificadorController : Controller
    {
        HostingEnvironment hostingEnvironment;

        public VerificadorController(HostingEnvironment he)
        {
            hostingEnvironment = he;
        }

        public IActionResult Index()
        {
            var context = HttpContext.RequestServices.GetService(typeof(inventarioContext)) as inventarioContext;

            var lista = context.Verificador.ToList<Verificador>();
                return View(lista);
            
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Verificador emp)
        {
            var context = HttpContext.RequestServices.GetService(typeof(inventarioContext)) as inventarioContext;

            context.Verificador.Add(emp);
                context.SaveChanges();
                TempData["message"] = "El nuevo empleado ha sido agreado";
                return RedirectToAction("Index");
            
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(inventarioContext)) as inventarioContext;

            var verificador = context.Verificador.Where(e => e.IdVerificador == id).First();
                return View(verificador);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Verificador emp)
        {
            var context = HttpContext.RequestServices.GetService(typeof(inventarioContext)) as inventarioContext;

            context.Verificador.Update(emp);
                context.SaveChanges();
                TempData["message"] = "La información del empleado ha actualizada";
                return RedirectToAction("Index");
            
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(inventarioContext)) as inventarioContext;

            var verificador = context.Verificador.Where(e => e.IdVerificador == id).First<Verificador>();
                return View(verificador);

        }


        public ActionResult Delete(int? id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(inventarioContext)) as inventarioContext;

            Verificador personalDetail = context.Verificador.Find(id);

                return View(personalDetail);
            
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(inventarioContext)) as inventarioContext;

            Verificador verificador = context.Verificador.Find(id);
                context.Verificador.Remove(verificador);
                context.SaveChanges();
                TempData["message"] = "La información del verificador ha sido Eliminada";
                return RedirectToAction("Index");
            
        }

        [HttpGet]
        [Authorize]
        public IActionResult Upload()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upload(IFormFile file)
        {
            return Content(file.FileName + " size: " + file.Length);
        }

    }
}
