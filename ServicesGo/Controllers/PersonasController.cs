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
    public class PersonasController : Controller
    {
        private HomeServicesContext db = new HomeServicesContext();

        // GET: Personas
        public ActionResult Index()
        {
            //return View(db.Personas.ToList());
            ControladoraMostrarPersonas servicioMostrarPersonas = new ControladoraMostrarPersonas();
            return View(servicioMostrarPersonas.mostrarPersonas());
        }

        // GET: Personas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Persona persona = db.Personas.Find(id);
            ControladoraMostrarPersona servicioMostrarPersona = new ControladoraMostrarPersona();
            Persona persona = servicioMostrarPersona.mostrarPersona(id);
            if (persona == null)
            {
                return HttpNotFound();
            }
            return View(persona);
        }

        // GET: Personas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Personas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,cedula,nombreUsuario,nombre,apellidos,direccion,telefono,correoElectronico,foto,TimeStamp")] Persona persona)
        {
            if (ModelState.IsValid)
            {
                /*
                db.Personas.Add(persona);
                db.SaveChanges();
                */
                ControladorCrearPersona servicioCrearPersona = new ControladorCrearPersona();
                servicioCrearPersona.agregarPersona(persona);
                return RedirectToAction("Index");
            }

            return View(persona);
        }

        // GET: Personas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Persona persona = db.Personas.Find(id);
            if (persona == null)
            {
                return HttpNotFound();
            }
            return View(persona);
        }

        // POST: Personas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,cedula,nombreUsuario,nombre,apellidos,direccion,telefono,correoElectronico,foto,TimeStamp")] Persona persona)
        {
            if (ModelState.IsValid)
            {
                /*
                db.Entry(persona).State = EntityState.Modified;
                db.SaveChanges();
                */
                ControladorActualizarPersona servicioActualizarPersona = new ControladorActualizarPersona();
                servicioActualizarPersona.modificarPersona(persona);
                return RedirectToAction("Index");
            }
            return View(persona);
        }

        // GET: Personas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Persona persona = db.Personas.Find(id);
            if (persona == null)
            {
                return HttpNotFound();
            }
            return View(persona);
        }

        // POST: Personas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            /*
            Persona persona = db.Personas.Find(id);
            db.Personas.Remove(persona);
            db.SaveChanges();
            */
            ControladorEliminarPersona servicioEliminarPersona = new ControladorEliminarPersona();
            servicioEliminarPersona.eliminarPersona(id);
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
