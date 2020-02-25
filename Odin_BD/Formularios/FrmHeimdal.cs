using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Mugin;

using System.Data.Common;
using System.Xml;


namespace Odin_BD.Formularios
{
    public partial class FrmHeimdal : Form
    {
        public string cadenaconexion;
        public string baseDatos;
        public string usuarioBD;
        public string claveBD;
        public string servidorBD;

        //GUARDAR LAS CONEXIONES, FALTA INICIALIZAR DE ACUERDO AL NUMERO DE ITEMS EN EL ARCHIVO DE CONFIGURACIÓN
        public ClsBitfrost conexion = new ClsBitfrost();
        
        public int filasArrayConexiones=0;
        public bool flagFuncionalidad = false;
        string[,] arrayConexiones = new string[3, 5];
        // filasArrayConexiones=   conexion.AsignaMatriz();

        private void DefineArray()
        {
            filasArrayConexiones=conexion.AsignaMatriz();
            if (filasArrayConexiones > 0)
            {
                string[,] arrayConexiones = new string[filasArrayConexiones, 5];
                flagFuncionalidad = true;
            }
            else
            {
                MessageBox.Show("Falta definir base para la conexion", "Odin-Backups", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        

        public FrmHeimdal()
        {
            DefineArray();
            InitializeComponent();
        }

        private void FrmHeimdal_Load(object sender, EventArgs e)
        {
            txtServidor.Text = "svrdbcal\\bd02";
            txtBaseDatos.Text = "DbcMactAux";
            txtUsuario.Text = "dbaccess";
            txtClaveBD.Text = "dbaccesscal";
            cargarConexionXML();
        }

        public void cargarConexionXML()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("..\\..\\XMLConfiguracionBD.xml");

            XmlNodeList conexion = xDoc.GetElementsByTagName("Conexion");
            XmlNodeList lista = ((XmlElement)conexion[0]).GetElementsByTagName("BaseDatos");

            
            int contadorBase =0;

            foreach (XmlElement nodo in lista)
            {
                XmlNodeList nservidor = nodo.GetElementsByTagName("servidor");
                XmlNodeList cdescripcion = nodo.GetElementsByTagName("descripcion");
                XmlNodeList nusuario = nodo.GetElementsByTagName("usuario");
                XmlNodeList nclave = nodo.GetElementsByTagName("clave");
                XmlNodeList cbaseDatos = nodo.GetElementsByTagName("basedatosConexion");

                arrayConexiones[contadorBase, 0] = nservidor[0].InnerText;
                arrayConexiones[contadorBase, 1] = cdescripcion[0].InnerText;
                arrayConexiones[contadorBase, 2] = cbaseDatos[0].InnerText;
                arrayConexiones[contadorBase, 3] = nusuario[0].InnerText;
                arrayConexiones[contadorBase, 4] = nclave[0].InnerText;        
                
                contadorBase = contadorBase+1;
                cmbDescribeConexion.Items.Add(cdescripcion[0].InnerText);
            }
        }
        
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBaseDatos.Text = "";
            txtClaveBD.Text = "";
            txtServidor.Text = "";
            txtUsuario.Text = "";

        }

        private void btnGeneracadenaConexion_Click(object sender, EventArgs e)
        {
            try
            {
                // porsupuesto que esta validacion puede mejorar
                if ((txtBaseDatos.Text != "") && (txtClaveBD.Text != "") && (txtServidor.Text != "") && (txtUsuario.Text != ""))
                {
                    conexion.cadenaConexion = "";

                    ClsEstatica.gbBaseDatos = txtClaveBD.Text;
                    ClsEstatica.gbUsuarioBD = txtUsuario.Text;
                    ClsEstatica.gbClaveBD = txtClaveBD.Text;
                    ClsEstatica.gbServidor = txtServidor.Text;

                    conexion.Usuario = usuarioBD;
                    conexion.Servidor = servidorBD;
                    conexion.Clave = claveBD;
                    conexion.BaseD = baseDatos;

                    conexion.cadenaConexion= conexion.ObtenerCadena();
                    cadenaconexion = conexion.cadenaConexion;   
                    MessageBox.Show("se configuro la cadena de conexion");
                }
                else
                {
                    MessageBox.Show("Verifica datos en tu cadena de conexion");
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(String.Concat("Error: '{0}", a));
            }  
        }
        
        private string validaString(string aValidar)
        { 
            string nuevoValor;
            nuevoValor = "";
            nuevoValor = aValidar.Replace(@"\", @"\\");
            return nuevoValor;
        }


        private void cmbDescribeConexion_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cmbDescribeConexion.SelectedIndex;
            /*
             nservidor[0].InnerText;
             
             cbaseDatos[0].InnerText;
             nusuario[0].InnerText;
             nclave[0].InnerText;      
             */


            try
            {
                txtServidor.Text = arrayConexiones[index, 0];
                txtBaseDatos.Text = arrayConexiones[index, 2];
                txtUsuario.Text = arrayConexiones[index, 3];
                txtClaveBD.Text = arrayConexiones[index, 4];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verificar archivo de configuración", ex.Message);
                throw;
            }  
        }

        private void btnRegistraCadena_Click(object sender, EventArgs e)
        {

        }
    }
}
