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
    public class UsuariosBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Usuarios us = new Usuarios();
            us.Nombre = "Yavier";
            us.Contrasena = "Amor12";
            Assert.IsTrue(UsuariosBLL.Guardar(us));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.IsTrue(UsuariosBLL.Eliminar(2));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            //Usuarios us = new Usuarios();
            //Assert.IsTrue(UsuariosBLL.Buscar(1));
        }

        [TestMethod()]
        public void GetListaTest()
        {
            Assert.IsTrue(UsuariosBLL.GetLista().Count > 0);
        }

        [TestMethod()]
        public void GetListaTest1()
        {
            Assert.IsTrue(UsuariosBLL.GetLista().Count > 0);
        }
    }
}