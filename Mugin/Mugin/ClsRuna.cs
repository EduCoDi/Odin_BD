using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data;
using Mugin;
using System.IO;

namespace Mugin
{
    public class ClsRuna
    {
        public string respuesta;

        //NOMBRE DEL PROCEDIMIENTO
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        //CUERPO DEL PROCEDIMIENTO ALMACENADO
        private DataTable runaCuerpo = new DataTable();
        public DataTable RunaCuerpo = new DataTable();


        public string QuitaExtensionSQL(string nombreConExtension)
        {

            int longitudNombre;
            longitudNombre = nombreConExtension.Length;

            try
            {
                if (nombreConExtension.Substring(longitudNombre - 4, 4) == ".sql")
                {
                    nombreConExtension = nombreConExtension.Substring(0, longitudNombre - 4);
                    respuesta = nombreConExtension;
                    return respuesta;
                }
                else
                {
                    respuesta = nombreConExtension;
                    return respuesta;
                }
            }
            catch (Exception e)
            {
                respuesta = String.Concat("Error: '{0}", e);
                return respuesta;
            }
        }

        public string PoneExtensionSQL(string nombreSinExtension)
        {
           string nombreConExtension;
           nombreConExtension = Path.ChangeExtension(nombreSinExtension, ".sql");
           return nombreConExtension;
        }


    }
}
