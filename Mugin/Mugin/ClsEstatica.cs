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

        public static T[,] ResizeArray<T>(T[,] original, int newWidth, int newHeight, int offsetX = 0, int offsetY = 0)
        {
            T[,] newArray = new T[newWidth, newHeight];
            int width = original.GetLength(0);
            int height = original.GetLength(1);
            for (int x = 0; x < width; x++)
            {
                Array.Copy(original, x * height, newArray, (x + offsetX) * newHeight + offsetY, height);
            }

            return newArray;
        }

    }
}
