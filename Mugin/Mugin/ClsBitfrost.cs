using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;
using System.Xml;
using Odin_BD;
using System.Windows.Forms;

namespace Mugin
{
    public class ClsBitfrost
    {
        public bool estado;

        private string servidor;
        public string Servidor
        {
            get { return servidor; }
            set { servidor = value; }
        }

        private string usuario;
        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        private string clave;
        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }

        private string baseD;

        public string BaseD
        {
            get { return baseD; }
            set { baseD = value; }
        }

        private int nConexionesDocConfiguracion;
        public int NConexionesDocConfiguracion
        {
            get {
                nConexionesDocConfiguracion = AsignaMatriz();
                return nConexionesDocConfiguracion;
            }
            set { nConexionesDocConfiguracion = value; }
        }

        public string[,] arrayConexiones;

        public SqlConnection conexion;
        public string cadenaConexion = "";
        public string descripcionCortaCadenaConexion="";
        public DataTable datos = new DataTable();
        XmlTextReader reader = new XmlTextReader("XMLConfiguracionDB.xml");
        static void Main(string[] args)
        {
            ClsBitfrost conexion = new ClsBitfrost();

        }
        
       
        public string ObtenerCadena()
        {
            servidor = ClsEstatica.gbServidor;
            usuario = ClsEstatica.gbUsuarioBD;
            clave = ClsEstatica.gbClaveBD;
            baseD = ClsEstatica.gbBaseDatos;    
    
            cadenaConexion = "Persist Security Info=False;User ID=" + usuario + ";Password=" + clave + ";INITIAL CATALOG=" + baseD + ";DATA SOURCE=" + servidor;
            //cadenaConexion = "Persist Security Info=False;User ID=dbaccess;Password=dbaccesscal;INITIAL CATALOG=DbcMactAux;DATA SOURCE=svrdbcal\\bd02";
            descripcionCortaCadenaConexion = servidor;
            return cadenaConexion; 
        }

        public void Conectar()
        {
            cadenaConexion = ObtenerCadena();
            //cadenaConexion = "Persist Security Info=False;User ID=dbaccess;Password=dbaccesscal;INITIAL CATALOG=DbcMactAux;DATA SOURCE=svrdbcal\\bd02";


            if (cadenaConexion == "")
                Console.WriteLine("Error Cadena");
            else
            {
                try
                {
                    conexion = new SqlConnection(cadenaConexion);
                    conexion.Open();
                    estado = true;
                }
                catch (Exception ex)
                {
                    estado = false;
                    MessageBox.Show(" Error intentao abrir la conexion");
                }
                
            }
        }

        public void Desconectar()
        {
            conexion.Close();
        }        

        public bool Ejecuta(string nombreSP, SqlConnection cn, ClsRuna NecesitoRuna)
        {
            //hace la magia
            //quita extensión en elnombre del archivo
            nombreSP = NecesitoRuna.QuitaExtensionSQL(nombreSP);
            try
            {
                //genera comando para sacar el bck del archivo nombreSP
                SqlCommand cmd = new SqlCommand("sp_helptext " + nombreSP, cn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(NecesitoRuna.RunaCuerpo);
                NecesitoRuna.Nombre = nombreSP;

                if (NecesitoRuna.RunaCuerpo.Columns.Count > 0)
                {
                    return true;
                }
                else
                    return false;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: '{0}", e);
                return false;
            }
        }

        public ClsRuna CargaRunaDesdeBD(SqlConnection cn, ClsRuna Runa)
        {
            Runa.Nombre = Runa.QuitaExtensionSQL(Runa.Nombre);
            try
            {   
                SqlCommand cmd = new SqlCommand("sp_helptext " + Runa.Nombre, cn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(Runa.RunaCuerpo);
                Runa.Nombre = Runa.Nombre;

                if (Runa.RunaCuerpo.Columns.Count > 0)
                {
                    return Runa;
                }
                else
                    return Runa;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: '{0}", e);
                return Runa;
            }

        }

        public int AsignaMatriz()
        {
            int nConexionesDocConfiguracion = 0;
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("..\\..\\XMLConfiguracionBD.xml");

            XmlNodeList conexion = xDoc.GetElementsByTagName("Conexion");
            XmlNodeList lista = ((XmlElement)conexion[0]).GetElementsByTagName("BaseDatos");

            foreach (XmlElement nodo in lista)
            {
                nConexionesDocConfiguracion = nConexionesDocConfiguracion + 1;
            }
            
            return nConexionesDocConfiguracion;
    
        }

        
    }
}