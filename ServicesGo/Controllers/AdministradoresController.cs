using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ServicesGo.Business_Layer.Controllers.ControladorasAdministrador;
using ServicesGo.Models;
using ServicesGo.Persistence_Layer;

namespace ServicesGo.Controllers
{
    public class AdministradoresController : Controller
    {
        private readonly HomeServicesContext db = new HomeServicesContext();

        // GET: Administradores
        public ActionResult Index()
        {
            //return View(db.Personas.ToList());
            ControladorMostrarAdministradores servicioMostrarAdministradores = new ControladorMostrarAdministradores();
            return View(servicioMostrarAdministradores.mostrarAdministradores());
        }

        // GET: Administradores/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Administrador administrador = (Administrador)db.Personas.Find(id);
            ControladorMostrarAdministrador servicioMostrarAdministrador = new ControladorMostrarAdministrador();
            Administrador administrador = servicioMostrarAdministrador.mostrarAdministrador(id);
            if (administrador == null)
            {
                return HttpNotFound();
            }
            return View(administrador);
        }

        // GET: Administradores/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Administradores/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "cedula,nombreUsuario,nombre,apellidos,direccion,telefono,correoElectronico,foto")] Administrador administrador)
        {
            if (ModelState.IsValid)
            {
                /*
                db.Personas.Add(administrador);
                db.SaveChanges();
                */
                ControladorCrearAdministrador servicioCrearAdministrador = new ControladorCrearAdministrador();
                servicioCrearAdministrador.agregarAdministrador(administrador);
                return RedirectToAction("Index");
            }

            return View(administrador);
        }

        // GET: Administradores/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Administrador administrador = (Administrador) db.Personas.Find(id);
            if (administrador == null)
            {
                return HttpNotFound();
            }
            return View(administrador);
        }

        // POST: Administradores/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "cedula,nombreUsuario,nombre,apellidos,direccion,telefono,correoElectronico,foto")] Administrador administrador)
        {
            if (ModelState.IsValid)
            {
                /*
                db.Entry(administrador).State = EntityState.Modified;
                db.SaveChanges();
                */
                ControladorActualizarAdministrador servicioActualizarAdministrador = new ControladorActualizarAdministrador();
                servicioActualizarAdministrador.modificarAdministrador(administrador);
                return RedirectToAction("Index");
            }
            return View(administrador);
        }

        // GET: Administradores/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Administrador administrador = (Administrador) db.Personas.Find(id);
            if (administrador == null)
            {
                return HttpNotFound();
            }
            return View(administrador);
        }

        // POST: Administradores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            /*
            Administrador administrador = (Administrador) db.Personas.Find(id);
            db.Personas.Remove(administrador);
            db.SaveChanges();
            */
            ControladorEliminarAdministrador servicioEliminarAdministrador = new ControladorEliminarAdministrador();
            servicioEliminarAdministrador.eliminarAdministrador(id);
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
