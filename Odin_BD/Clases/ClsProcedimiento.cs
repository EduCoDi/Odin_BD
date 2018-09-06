using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odin_BD.Clases
{
    class ClsProcedimiento
    {
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private DateTime fechaCreacion;
        public DateTime FechaCreacion
        {
            get { return fechaCreacion; }
            set { fechaCreacion = value; }
        }

        private string contenido;
        public string Contenido
        {
            get { return contenido; }
            set { contenido = value; }
        }

        public ClsProcedimiento(){
            this.ID = 0;
            this.Nombre = "";
            this.FechaCreacion = Convert.ToDateTime("01/01/2010");
            this.Contenido = "";
        }
    }
}
