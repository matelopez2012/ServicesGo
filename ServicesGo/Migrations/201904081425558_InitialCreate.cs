namespace ServicesGo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Personas",
                c => new
                    {
                        cedula = c.String(nullable: false, maxLength: 25),
                        nombreUsuario = c.String(nullable: false, maxLength: 25),
                        nombre = c.String(nullable: false, maxLength: 25),
                        apellidos = c.String(nullable: false, maxLength: 50),
                        direccion = c.String(nullable: false, maxLength: 35),
                        telefono = c.String(nullable: false, maxLength: 15),
                        correoElectronico = c.String(nullable: false, maxLength: 35),
                        foto = c.String(nullable: false),
                        Discriminator = c.String(maxLength: 128),
                        arl_id = c.Int(),
                        socialSecurity_id = c.Int(),
                        Persona_Id_cedula = c.String(maxLength: 25),
                    })
                .PrimaryKey(t => t.cedula)
                .ForeignKey("dbo.Documentos", t => t.arl_id)
                .ForeignKey("dbo.Documentos", t => t.socialSecurity_id)
                .ForeignKey("dbo.Personas", t => t.Persona_Id_cedula)
                .Index(t => t.arl_id)
                .Index(t => t.socialSecurity_id)
                .Index(t => t.Persona_Id_cedula);
            
            CreateTable(
                "dbo.Documentos",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nombreDoc = c.String(nullable: false, maxLength: 30),
                        ruta = c.String(nullable: false, maxLength: 100),
                        TimeStamp = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        habilidad_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Habilidades", t => t.habilidad_id)
                .Index(t => t.habilidad_id);
            
            CreateTable(
                "dbo.Habilidades",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nombre = c.String(nullable: false, maxLength: 80),
                        experiencia = c.Int(nullable: false),
                        conocimientosEspecificos = c.String(nullable: false, maxLength: 300),
                        TimeStamp = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        PrestadorServicios_id_cedula = c.String(maxLength: 25),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Personas", t => t.PrestadorServicios_id_cedula)
                .Index(t => t.PrestadorServicios_id_cedula);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        cedula = c.String(nullable: false, maxLength: 25),
                    })
                .PrimaryKey(t => t.cedula)
                .ForeignKey("dbo.Personas", t => t.cedula)
                .Index(t => t.cedula);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuarios", "cedula", "dbo.Personas");
            DropForeignKey("dbo.Personas", "Persona_Id_cedula", "dbo.Personas");
            DropForeignKey("dbo.Personas", "socialSecurity_id", "dbo.Documentos");
            DropForeignKey("dbo.Personas", "arl_id", "dbo.Documentos");
            DropForeignKey("dbo.Habilidades", "PrestadorServicios_id_cedula", "dbo.Personas");
            DropForeignKey("dbo.Documentos", "habilidad_id", "dbo.Habilidades");
            DropIndex("dbo.Usuarios", new[] { "cedula" });
            DropIndex("dbo.Habilidades", new[] { "PrestadorServicios_id_cedula" });
            DropIndex("dbo.Documentos", new[] { "habilidad_id" });
            DropIndex("dbo.Personas", new[] { "Persona_Id_cedula" });
            DropIndex("dbo.Personas", new[] { "socialSecurity_id" });
            DropIndex("dbo.Personas", new[] { "arl_id" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.Habilidades");
            DropTable("dbo.Documentos");
            DropTable("dbo.Personas");
        }
    }
}
