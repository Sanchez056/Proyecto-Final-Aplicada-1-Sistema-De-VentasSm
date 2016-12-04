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
    public class ProductosBLLTests
    {
        [TestMethod()]
        public void InsertarTest()
        {
            //Productos pd = new Productos();
            //pd.IdProducto = 1;
            //pd.Nombre = "Galleta de ajo";
            //pd.Marca = "Productos Suavecito";
            //pd.Unidad = 50;
            //pd.Precio = 9500;
            //pd. = "German Valerio";
            //pd.Descripcion = "Bizcocho con pasa";

           // Assert.IsTrue(ProductosBLL.Insertar(pd));
        }

        [TestMethod()]
        public void EliminarTest()
        {
               
            //Assert.IsTrue(ProductosBLL.Eliminar(5));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            //Assert.IsTrue(ProductosBLL.Buscar(1));
        }

        [TestMethod()]
        public void GetListaTest()
        {
            Assert.IsTrue(ArticulosBLL.GetLista().Count > 0);
        }

        [TestMethod()]
        public void GetListaTest1()
        {
            //Assert.IsTrue(ProductosBLL.GetLista().Count > 0);
        }
    }
}