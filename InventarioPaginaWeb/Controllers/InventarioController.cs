using InventarioPaginaWeb.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace InventarioPaginaWeb.Controllers
{
    public class InventarioController : Controller
    {
        HostingEnvironment hostingEnvironment;

        public InventarioController(HostingEnvironment he)
        {
            hostingEnvironment = he;
        }

        public IActionResult Index()
        {
            var context = HttpContext.RequestServices.GetService(typeof(inventarioContext)) as inventarioContext;
            
                var lista = (from i in context.Inventario
                             join e in context.Encargado on i.RRevision equals e.IdEncargado
                             join v in context.Verificador on i.RVerificador equals v.IdVerificador
                             join t in context.TipoRegistro on i.RTipoRegistro equals t.IdRegistro
                             join r in context.Revision on i.RRevision equals r.IdRevision
                             join m in context.Motivo on r.RMotivo equals m.IdMotivo
                             join d in context.Datos on t.RDatos equals d.IdDatos
                             join de in context.DependenciaEntidad on d.RDependenciaEntidad equals de.IdDependenciaEntidad

                             select new BigModel()
                             {
                                 IdInventario = i.IdInventario,
                                 Fecha = i.Fecha,
                                 NombreEncargado = e.Nombre,
                                 ApellidoEncargado = e.Apellido,
                                 NombreVerificador = v.Nombre,
                                 ApellidoVerificador = v.Apellido,
                                 NumeroReporte = r.IdRevision,
                                 DescripcionRevision = r.Descripcion,
                                 Motivo = m.NombreMotivo,
                                 TipoRegistro = t.TipoRegistro1,
                                 Marca = d.Marca,
                                 Modelo = d.Modelo,
                                 NoSerie = d.NoSerie,
                                 DescripcionDatos = d.Descripcion,
                                 Observaciones = d.Observaciones,
                                 UbicacionFisica = de.UbicacionFisica,
                                 UbicacionSistema = de.UbicacionSistema,
                                 Departamento = de.Departamento,
                                 Status = i.Status

                             }).ToList<BigModel>();

                return View(lista);
            
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Inventario emp)
        {
            var context = HttpContext.RequestServices.GetService(typeof(inventarioContext)) as inventarioContext;

            context.Inventario.Add(emp);
                context.SaveChanges();
                TempData["message"] = "El nuevo empleado ha sido agreado";
                return RedirectToAction("Index");
            
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(inventarioContext)) as inventarioContext;

            var inventario = context.Inventario.Where(e => e.IdInventario == id).First();
                return View(inventario);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Inventario emp)
        {
            using (var context = new inventarioContext())
            {
                context.Inventario.Update(emp);
                context.SaveChanges();
                TempData["message"] = "La información del empleado ha sido actualizada";
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(inventarioContext)) as inventarioContext;

            var inventario = context.Inventario.Where(e => e.IdInventario == id).First<Inventario>();
                return View(inventario);

        }

        public ActionResult Delete(int? id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(inventarioContext)) as inventarioContext;

            Inventario personalDetail = context.Inventario.Find(id);

                return View(personalDetail);
            
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(inventarioContext)) as inventarioContext;

            Inventario inventario = context.Inventario.Find(id);
                context.Inventario.Remove(inventario);
                context.SaveChanges();
                TempData["message"] = "La información del inventario ha sido Eliminada";
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