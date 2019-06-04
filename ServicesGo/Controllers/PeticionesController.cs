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
    public class PeticionesController : Controller
    {
        private HomeServicesContext db = new HomeServicesContext();

        // GET: Peticiones
        public ActionResult Index()
        {
            return View(db.Peticiones.ToList());
        }

        // GET: Peticiones/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Peticion peticion = db.Peticiones.Find(id);
            if (peticion == null)
            {
                return HttpNotFound();
            }
            return View(peticion);
        }

        // GET: Peticiones/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Peticiones/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,nombreCuenta,auditor,observacion,fechaMod,resuelta")] Peticion peticion)
        {
            if (ModelState.IsValid)
            {
                db.Peticiones.Add(peticion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(peticion);
        }

        // GET: Peticiones/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Peticion peticion = db.Peticiones.Find(id);
            if (peticion == null)
            {
                return HttpNotFound();
            }
            return View(peticion);
        }

        // POST: Peticiones/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,nombreCuenta,auditor,observacion,fechaMod,resuelta")] Peticion peticion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(peticion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(peticion);
        }

        // GET: Peticiones/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Peticion peticion = db.Peticiones.Find(id);
            if (peticion == null)
            {
                return HttpNotFound();
            }
            return View(peticion);
        }

        // POST: Peticiones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Peticion peticion = db.Peticiones.Find(id);
            db.Peticiones.Remove(peticion);
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
