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
    public class ProfesionesController : Controller
    {
        private HomeServicesContext db = new HomeServicesContext();

        // GET: Profesiones
        public ActionResult Index()
        {
            return View(db.Profesiones.ToList());
        }

        // GET: Profesiones/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Profesion profesion = db.Profesiones.Find(id);
            if (profesion == null)
            {
                return HttpNotFound();
            }
            return View(profesion);
        }

        // GET: Profesiones/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Profesiones/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,nombreProfesion,Experiencia,conocimientos")] Profesion profesion)
        {
            if (ModelState.IsValid)
            {
                db.Profesiones.Add(profesion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(profesion);
        }

        // GET: Profesiones/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Profesion profesion = db.Profesiones.Find(id);
            if (profesion == null)
            {
                return HttpNotFound();
            }
            return View(profesion);
        }

        // POST: Profesiones/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,nombreProfesion,Experiencia,conocimientos")] Profesion profesion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(profesion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(profesion);
        }

        // GET: Profesiones/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Profesion profesion = db.Profesiones.Find(id);
            if (profesion == null)
            {
                return HttpNotFound();
            }
            return View(profesion);
        }

        // POST: Profesiones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Profesion profesion = db.Profesiones.Find(id);
            db.Profesiones.Remove(profesion);
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
