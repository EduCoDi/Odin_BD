using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Odin_BD
{
    public static class  ClsEstatica
    {
        public static string gbServidor;
        public static string gbBaseDatos;
        public static string gbUsuarioBD;
        public static string gbClaveBD;
        public static string gbDescripcion;
        public static int NumeroBDEnXML;        

        public static void Inicializar()
        {
            gbServidor = "";
            gbClaveBD = "";
            gbUsuarioBD = "";
            gbClaveBD = "";
            gbDescripcion = "";
        }

        public static int NumeroDeConexionesConfiguradas;        
       

    }
}
