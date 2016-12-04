using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;

namespace BLL.Tests
{
    [TestClass()]
    public class VendedorBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Vendedores vendedor = new Vendedores();
            vendedor.Nombre = "Robert";
            vendedor.Apellido = "Frias";
            vendedor.Sexo = "Hombre";
            vendedor.Cedula = "1215545";
            vendedor.TelefonoFijo = "4456";
            vendedor.TelefonoMovil = "4456";
            vendedor.Direccion = "4456";
            vendedor.Zona = "4456";
            vendedor.TipoVehiculo = "4456";
            Assert.IsTrue(VendedorBLL.Guardar(vendedor));
        }

        [TestMethod()]
        public void EliminarTest()
        {
           // Assert.IsTrue(VendedorBLL.Eliminar(1));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            //Assert.IsTrue(VendedorBLL.Buscar(1));
        }

        [TestMethod()]
        public void GetListaTest()
        {
            Assert.IsTrue(VendedorBLL.GetLista().Count > 0);
        }

        [TestMethod()]
        public void GetListaTest1()
        {
            Assert.IsTrue(VendedorBLL.GetLista(1).Count > 0);
        }
    }
}