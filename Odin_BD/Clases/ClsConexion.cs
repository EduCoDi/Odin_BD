using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odin_BD.Clases
{
    class ClsConexion
    {
        private string servidor;
        public string Servidor
        {
            get { return servidor; }
            set { servidor = value; }
        }        

        private string baseDatos;
        public string BaseDatos
        {
            get { return baseDatos; }
            set { baseDatos = value; }
        }

        private string clave;
        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }

        private int estadoConexion;
        public int EstadoConexion
        {
            get { return estadoConexion; }
            set { estadoConexion = value; }
        }

        private string cadenaConexion;
        public string CadenaConexion
        {
            get { return cadenaConexion; }
            set { cadenaConexion = value; }
        }
        


    }
}
