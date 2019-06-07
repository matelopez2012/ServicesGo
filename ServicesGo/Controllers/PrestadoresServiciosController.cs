using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ServicesGo.Business_Layer.Models;
using ServicesGo.Persistence_Layer;

namespace ServicesGo.Controllers
{
    public class PrestadoresServiciosController : Controller
    {
        private HomeServicesContext db = new HomeServicesContext();

        // GET: PrestadoresServicios
        public ActionResult Index()
        {
            return View(db.Personas.ToList());
        }

        // GET: PrestadoresServicios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PrestadorServicios prestadorServicios = (PrestadorServicios) db.Personas.Find(id);
            if (prestadorServicios == null)
            {
                return HttpNotFound();
            }
            return View(prestadorServicios);
        }

        // GET: PrestadoresServicios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PrestadoresServicios/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nombre,Apellidos,Correo,Direccion,Documento,Telefono")] PrestadorServicios prestadorServicios)
        {
            if (ModelState.IsValid)
            {
                prestadorServicios.Foto = "";
                prestadorServicios.EstiloPresentacion = 1;
                prestadorServicios.FormatoHV = 1;
                prestadorServicios.PerfilModificado = false;
                prestadorServicios.FechaModificacion = DateTime.Now;
                db.Personas.Add(prestadorServicios);
                db.Cuentas.Add(prestadorServicios.CuentaRef);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(prestadorServicios);
        }

        // GET: PrestadoresServicios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PrestadorServicios prestadorServicios = (PrestadorServicios) db.Personas.Find(id);
            if (prestadorServicios == null)
            {
                return HttpNotFound();
            }
            return View(prestadorServicios);
        }

        // POST: PrestadoresServicios/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nombre,Apellidos,Correo,Direccion,Documento,Telefono,Foto,TimeStamp,EstiloPresentacion,FormatoHV,PerfilModificado,FechaModificacion")] PrestadorServicios prestadorServicios)
        {
            if (ModelState.IsValid)
            {
                db.Entry(prestadorServicios).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(prestadorServicios);
        }

        // GET: PrestadoresServicios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PrestadorServicios prestadorServicios = (PrestadorServicios) db.Personas.Find(id);
            if (prestadorServicios == null)
            {
                return HttpNotFound();
            }
            return View(prestadorServicios);
        }

        // POST: PrestadoresServicios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PrestadorServicios prestadorServicios = (PrestadorServicios) db.Personas.Find(id);
            db.Personas.Remove(prestadorServicios);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
