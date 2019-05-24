using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ServicesGo.Business_Layer.Controllers.ControladorasHabilidad;
using ServicesGo.Models;
using ServicesGo.Persistence_Layer;

namespace ServicesGo.Controllers
{
    public class HabilidadesController : Controller
    {
        private HomeServicesContext db = new HomeServicesContext();

        // GET: Habilidades
        public ActionResult Index()
        {
            return View(db.Habilidades.ToList());
        }

        // GET: Habilidades/Details/5
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

        // GET: Habilidades/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Habilidades/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,experiencia,conocimientosEspecificos,TimeStamp")] Habilidad habilidad)
        {
            if (ModelState.IsValid)
            {
                db.Habilidades.Add(habilidad);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(habilidad);
        }

        // GET: Habilidades/Edit/5
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

        // POST: Habilidades/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,experiencia,conocimientosEspecificos,TimeStamp")] Habilidad habilidad)
        {
            if (ModelState.IsValid)
            {
                db.Entry(habilidad).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(habilidad);
        }

        // GET: Habilidades/Delete/5
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

        // POST: Habilidades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            /*
            Habilidad habilidad = db.Habilidades.Find(id);
            db.Habilidades.Remove(habilidad);
            db.SaveChanges();
            return RedirectToAction("Index");
        */
            ControladorEliminarHabilidad ServicioEliminar = new ControladorEliminarHabilidad();
            ServicioEliminar.eliminarHabilidad(id);

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
