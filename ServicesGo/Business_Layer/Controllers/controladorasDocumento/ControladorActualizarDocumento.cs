using ServicesGo.Models;
using ServicesGo.Persistence_Layer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ServicesGo.Business_Layer.Controllers.controladorasDocumento
{
    //Servicio para actualizar documento
    public class ControladoraActualizarDocumento
    {

        //Creamos la instancia de HomeServicesContext que permitirá mapear la base de datos
        private static HomeServicesContext db = new HomeServicesContext();


        //Método para actualizar un determinado documento
        //Recibimos como parametros con los nuevos valores de las variables a actualizar
        //Es de tipo void, por lo tanto no retorna nada
        public void actualizarDocumento(int id, string nombreDoc, string ruta, Habilidad habilidad)
        {
            //Buscamos el objeto en el ORM cuyo id es el que obtenemos por parámetro
            Documento documento = db.Documentos.Find(id);
            //Asignamos los nuevos atributos a la instancia creada anteriormente 
            documento.nombreDoc = nombreDoc;
            documento.ruta = ruta;
            documento.habilidad = habilidad;

            //Añadimos la instancia documento con los nuevos atributos al ORM
            //reemplazand a la isntancia del documento original
            db.Documentos.Add(documento);
            //Comprobamos si existe alguna modificacion de los atributos 
            db.Entry(documento).State = EntityState.Modified;
            //Guardamos los cambios en el ORM, quedando así actualizado
            db.SaveChanges();

        }
        
        public static void actualizarHabilidadDocumento(int id, Habilidad habilidad)
        {

            Documento documento = db.Documentos.Find(id);
            documento.habilidad = habilidad;
           
            db.Documentos.Add(documento);

            db.Entry(documento).State = EntityState.Modified;

            db.SaveChanges();

        }

    }
}