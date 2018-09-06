
using System.IO;
using Hugin;
using Mugin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Odin_BD.Formularios;
using System.Xml;


namespace Odin_BD
{
    public partial class FrmValhala : Form
    {
        public ClsBitfrost conexion = new ClsBitfrost();
        string[,] arrayConexiones = new string[3, 5];
        bool flagValidaFormularios=false;

        public FrmValhala()
        {
            InitializeComponent();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            bool flagEjecucion;
            //EJECUTA LAS FUNCIONES DE LAS DISTINTAS CLASES
            if (txtRutaArchivoOrigen.Text != "")
            {
                ClsRuna runa = new ClsRuna();
                ClsForja forja = new ClsForja();

                ClsBitfrost conectar = new ClsBitfrost();
                conectar.ObtenerCadena();
                conectar.Conectar();
                flagEjecucion = conectar.Ejecuta(txtProcedimientoABuscar.Text, conectar.conexion, runa);
                if (flagEjecucion == true)
                {
                    forja.GeneraProcedimiento(runa, txtRutaArchivoOrigen.Text, txtRutaArchivoDestino.Text);
                    MessageBox.Show("Culminado con exito: " + txtProcedimientoABuscar.Text);
                }
                else
                    MessageBox.Show("No existe SP: " + txtProcedimientoABuscar.Text);
                //dtgProcedimiento.DataSource = conectar.datos; //PARA PRUEBAS       
            }
            else
                MessageBox.Show("Ingresa un SP");
        }
        private void btnRutaOrigen_Click(object sender, EventArgs e)
        { 
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                // CAPTURA LA RUTA DONDE SE DESEA DESCARGAR LOS SP.                 
                txtRutaArchivoOrigen.Text = folderBrowserDialog1.SelectedPath;
                string nombreRuta = txtRutaArchivoOrigen.Text;                           
                
            }
        }
        private void btnRutaDestino_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                // CAPTURA LA RUTA DONDE SE DESEA DESCARGAR LOS SP.                 
                txtRutaArchivoOrigen.Text = folderBrowserDialog1.SelectedPath;
                string nombreRuta = txtRutaArchivoDestino.Text;

            }
        }
        private void btnCarga_Click(object sender, EventArgs e)
        {         
               if( ValidaControlesFormulario()==true)
            { 
                //ejecuta bck de varios procedimientos a la vez
                bool flag;
                ClsForja forja = new ClsForja();
                forja.ObtenerNombresSP(txtRutaArchivoOrigen.Text);

                int cantidad;
                cantidad = forja.Runas.Count;

                for (int i = 0; i < cantidad; i++)
                {
                    conexion.Conectar();
                    ClsRuna runa = new ClsRuna();
                    flag = conexion.Ejecuta(forja.Runas[i].Nombre, conexion.conexion, forja.Runas[i]);

                    if (flag == true)
                    {
                        forja.GeneraProcedimiento(forja.Runas[i], txtRutaArchivoOrigen.Text, txtRutaArchivoDestino.Text);
                        conexion.Desconectar();
                    }
                    else
                    {
                        //ClsForja runasNoExisten = new ClsForja();
                        //conexion.Desconectar();
                        // MessageBox.Show("No existe SP : " + forja.Runas[i].Nombre);
                    }
                    if (conexion.estado == true)
                        conexion.Desconectar();

                }

                MessageBox.Show("Proceso Terminado... verificar carperta de destino");
                //los sp que no tienen backup no existen en la base \n  si no me crees checas el código");

            }//fin del ifValidaControlesFormulario            
        }
        private void FrmValhala_Load(object sender, EventArgs e)
        {
            ClsBitfrost bf = new ClsBitfrost();
            bf.ObtenerCadena();
            Text = string.Concat("Valhala           ", bf.descripcionCortaCadenaConexion);
            CargaBaseConexion();
        }
        private void CargaBaseConexion()
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
                CmbBaseCadenaConexion.Items.Add(cdescripcion[0].InnerText);
            }    

        }
        private void btnRutaDestino_Click_1(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                // CAPTURA LA RUTA DONDE SE DESEA DESCARGAR LOS SP.                 
                txtRutaArchivoDestino.Text = folderBrowserDialog1.SelectedPath;
                string nombreRuta = txtRutaArchivoDestino.Text;

            }
        }
        private void CmbBaseCadenaConexion_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = 0;
            indice = CmbBaseCadenaConexion.SelectedIndex;
            ClsEstatica.gbServidor = arrayConexiones[indice, 0];
            ClsEstatica.gbBaseDatos = arrayConexiones[indice,2];
            ClsEstatica.gbUsuarioBD = arrayConexiones[indice,3];
            ClsEstatica.gbClaveBD = arrayConexiones[indice,4];
            
        }
        private void chkTipoGuarda_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTipoGuarda.Checked == true)
            {
                txtProcedimientoABuscar.Enabled = false;
                btnEjecutar.Enabled = false;
            }
            else
            {
                txtProcedimientoABuscar.Enabled = true;
                btnEjecutar.Enabled = true;
            }         
        }

        private bool ValidaControlesFormulario() 
        {
            
            if (CmbBaseCadenaConexion.SelectedIndex == -1)
            {
                MessageBox.Show("Se debe seleccionar una cadena de Conexion en el combo: *** Base de Datos ***");
                flagValidaFormularios = false;
                return flagValidaFormularios;
            }
            if (txtRutaArchivoDestino.Text == "")             
            {
               MessageBox.Show("Se debe ingresar ruta de destino valida");
                flagValidaFormularios = false;
                return flagValidaFormularios;
            }
            if (txtRutaArchivoOrigen.Text == "")
            {
               MessageBox.Show("Se debe ingresar ruta de origen valida");
                flagValidaFormularios = false;
                return flagValidaFormularios;
            }
            return flagValidaFormularios=true;
        }

        private void modificaBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHeimdal FormularioHeimdal = new FrmHeimdal();
            FormularioHeimdal.Show();
        }
    }
}
