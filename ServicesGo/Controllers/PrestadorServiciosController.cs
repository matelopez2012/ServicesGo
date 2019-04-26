using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ServicesGo.Models;
using ServicesGo.Persistence_Layer;

namespace ServicesGo.Controllers
{
    public class PrestadorServiciosController : Controller
    {
        private HomeServicesContext db = new HomeServicesContext();

        // GET: PrestadorServicios
        public ActionResult Index()
        {
            return View(db.Personas.ToList());
        }

        // GET: PrestadorServicios/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PrestadorServicios prestadorServicios = db.Personas.Find(id);
            if (prestadorServicios == null)
            {
                return HttpNotFound();
            }
            return View(prestadorServicios);
        }

        // GET: PrestadorServicios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PrestadorServicios/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "cedula,nombreUsuario,nombre,apellidos,direccion,telefono,correoElectronico,foto")] PrestadorServicios prestadorServicios)
        {
            if (ModelState.IsValid)
            {
                db.Personas.Add(prestadorServicios);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(prestadorServicios);
        }

        // GET: PrestadorServicios/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PrestadorServicios prestadorServicios = db.Personas.Find(id);
            if (prestadorServicios == null)
            {
                return HttpNotFound();
            }
            return View(prestadorServicios);
        }

        // POST: PrestadorServicios/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "cedula,nombreUsuario,nombre,apellidos,direccion,telefono,correoElectronico,foto")] PrestadorServicios prestadorServicios)
        {
            if (ModelState.IsValid)
            {
                db.Entry(prestadorServicios).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(prestadorServicios);
        }

        // GET: PrestadorServicios/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PrestadorServicios prestadorServicios = db.Personas.Find(id);
            if (prestadorServicios == null)
            {
                return HttpNotFound();
            }
            return View(prestadorServicios);
        }

        // POST: PrestadorServicios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            PrestadorServicios prestadorServicios = db.Personas.Find(id);
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
