using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Mugin;
using System.Data;
using System.Configuration;


namespace Hugin
{
    public class ClsForja
    {

        public List<ClsRuna> Runas = new List<ClsRuna>();
        public string respuesta;
        private string direcccion;
        public string Direccion
        {
            get { return direcccion; }
            set { direcccion = value; }
        }
        public string x;

        public void GeneraProcedimiento(ClsRuna runa, string rutaOrigen, string rutaDestino)
        {
            string nombreFolder = rutaDestino;
            //string extension = ".sql";
            runa.Nombre = runa.PoneExtensionSQL(runa.Nombre);
            
            System.IO.Directory.CreateDirectory(nombreFolder);

            //une ruta con nombre del procedimiento para crear el archivo
            string nombreArchivo = System.IO.Path.Combine(nombreFolder, runa.Nombre);
            if (!System.IO.File.Exists(nombreArchivo))
            {
                ExportDataTabletoFile(runa.RunaCuerpo, "\n", true, nombreArchivo);                
            }       
        }

        public static void ExportDataTabletoFile(DataTable datatable, string delimited, bool exportcolumnsheader, string file)
        {
            StreamWriter strFile = new StreamWriter(file, false, System.Text.Encoding.Default);
            if (exportcolumnsheader)
            {
                string Columns = string.Empty;
                foreach (DataColumn column in datatable.Columns)
                {
                    //Columns += column.ColumnName + delimited;
                    Columns += column.ColumnName;
                }
                if (Columns.Length>0)                
                    strFile.WriteLine(Columns.Remove(Columns.Length - 1, 1));

            }

            foreach (DataRow datarow in datatable.Rows)
            {
                string row = string.Empty;
                foreach (object items in datarow.ItemArray)
                {
                    //row += items.ToString() + delimited;
                    row += items.ToString();
                }
                strFile.WriteLine(row.Remove(row.Length - 1, 1));
            }
            strFile.Flush();
            strFile.Close();
        }      

        //obtiene los nombres de los archivos [ruta dev\sp's]
        public void ObtenerNombresSP(string ruta)
        {
            DirectoryInfo Di = new DirectoryInfo(ruta);
            int cantidad = 0;
            foreach (var fi in Di.GetFiles())
            {                
                 Runas.Add(new ClsRuna() { Nombre = fi.Name });
                 cantidad = cantidad + 1;
            }

        }

        //A partir de una lista de SP's crea los archivos sql si existen.
        public void CargarCuerpoListasSp(List<ClsRuna> lista, string ruta)
        {

        }

        //busca si el nombre del sp esta en la lista.
        public bool Contiene(List<ClsRuna> list, string nombresp)
        {
            if (list.Exists(x => x.Nombre.Contains(nombresp)))
                return true;
            else
                return false;
        }
    }
}
