using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mugin;
using Hugin;
using System.Collections.Generic;
using System.Data;


namespace UnitTestOdin
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void PruebaConexion()
        {
            ClsBitfrost conexion = new ClsBitfrost();
            conexion.Conectar();
            Assert.IsTrue(conexion.estado);
        }

        [TestMethod]
        public void PruebaCargaNombreEnListaRunas()
        {
            string rutaPruebas = "D:\\Soft\\Odin.net\\Pruebas\\dev";
            ClsBitfrost conexion = new ClsBitfrost();
            conexion.Conectar();
            ClsForja forja = new ClsForja();
            forja.ObtenerNombresSP(rutaPruebas);
            string nombresp= "BloqueoCuenta.sql";            
            Assert.IsTrue(forja.Contiene(forja.Runas,nombresp));
        }

        [TestMethod]
        public void SPExisteEnBD_ValidarExisteSPEnBD()
        {
            bool flag;
            string nombresp = "BloqueoCuenta";
            ClsBitfrost conexion = new ClsBitfrost();
            ClsRuna runa = new ClsRuna();
            conexion.Conectar();
            flag = conexion.Ejecuta(nombresp, conexion.conexion, runa);
            Assert.IsTrue(flag);
        }

        [TestMethod]
        public void SPNoExisteEnBD_ValidarExisteSPEnBD()
        {
            bool flag;
            string nombresp = "";
            ClsBitfrost conexion = new ClsBitfrost();
            ClsRuna runa= new ClsRuna();
            conexion.Conectar();
            flag = conexion.Ejecuta(nombresp, conexion.conexion, runa);
            Assert.IsFalse(flag);

        }

    }
}
