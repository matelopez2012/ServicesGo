using ServicesGo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ServicesGo.Persistence_Layer
{
    public class HomeServicesContext : DbContext
    {

        public HomeServicesContext() : base("HomeServices")
        {

        }

        public DbSet<Habilidad> Habilidades { set; get; }
        public DbSet<Administrador> Administradores { set; get; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<PrestadorServicios> PrestadoresServicios { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Documento> Documentos { get; set; }
    }
}