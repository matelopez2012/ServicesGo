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
    public class HabilidadsController : Controller
    {
        private HomeServicesContext db = new HomeServicesContext();

        // GET: Habilidads
        public ActionResult Index()
        {
            return View(db.Habilidades.ToList());
        }

        // GET: Habilidads/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Habilidad habilidad = db.Habilidades.Find(id);
            if (habilidad == null)
            {
                return HttpNotFound();
            }
            return View(habilidad);
        }

        // GET: Habilidads/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Habilidads/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,nombre,experiencia,conocimientosEspecificos,TimeStamp")] Habilidad habilidad)
        {
            if (ModelState.IsValid)
            {
                db.Habilidades.Add(habilidad);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(habilidad);
        }

        // GET: Habilidads/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Habilidad habilidad = db.Habilidades.Find(id);
            if (habilidad == null)
            {
                return HttpNotFound();
            }
            return View(habilidad);
        }

        // POST: Habilidads/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,nombre,experiencia,conocimientosEspecificos,TimeStamp")] Habilidad habilidad)
        {
            if (ModelState.IsValid)
            {
                db.Entry(habilidad).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(habilidad);
        }

        // GET: Habilidads/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Habilidad habilidad = db.Habilidades.Find(id);
            if (habilidad == null)
            {
                return HttpNotFound();
            }
            return View(habilidad);
        }

        // POST: Habilidads/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Habilidad habilidad = db.Habilidades.Find(id);
            db.Habilidades.Remove(habilidad);
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
