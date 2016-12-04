using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal_Aplicada1.Registros
{
    public partial class RegistrosCategorias : Form
    {
        public RegistrosCategorias()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor ingresar el id de la Categoria que desea buscar") && ValidarBuscar())
                LLenar(BLL.CategoriasBLL.Buscar(Utilidades.ToInt(CategoriaIdtextBox.Text)));
        }
        private void LLenar(Categorias categoria)
        {

            CategoriaIdtextBox.Text = categoria.CategoriaId.ToString();
            DescripciontextBox.Text = categoria.Descripcion;
        }

        private bool ValidarExiste(string aux)
        {
            if (BLL.CategoriasBLL.GetListaDescripcion(aux).Count() > 0)
            {
                MessageBox.Show("Este Categoria ya  existe, favor intentar con otra Descripcion de Categoria o Modificar...");
                return false;
            }
            return true;
        }
        private bool ValidarBuscar()
        {
            if (BLL.CategoriasBLL.Buscar(Utilidades.ToInt(CategoriaIdtextBox.Text)) == null)
            {
                MessageBox.Show("Este registro no existe");
                return false;
            }

            return true;


        }
        private bool validarId(string message)
        {
            if (string.IsNullOrEmpty(CategoriaIdtextBox.Text))
            {

                MessageBox.Show(message);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
               
        }
        public void Limpiar()
        {
            CategoriaIdtextBox.Clear();
            DescripciontextBox.Clear();
            limpiarErroresProvider();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Categorias categoria = new Categorias();
            BuscarerrorProvider.Clear();
            LlenarClase(categoria);
            if (ValidarTextbox() && ValidarExiste(DescripciontextBox.Text))
            {
                BLL.CategoriasBLL.Insertar(categoria);
                Limpiar();
                limpiarErroresProvider();
                MessageBox.Show("Guardado con exito");
            }
        }
        private void LlenarClase(Categorias c)
        {
            c.Descripcion = DescripciontextBox.Text;
        }





        private bool ValidarTextbox()
        {

            if (string.IsNullOrEmpty(DescripciontextBox.Text)


                )
            {
                DescripcionerrorProvider.SetError(DescripciontextBox, "Favor la descripcion de  la Categoria de los articulo");
                MessageBox.Show("Favor llenar todos los campos obligatorios");
                return false;
            }


            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validarId("Favor digitar el id de la Categoria que desea eliminar") && ValidarBuscar())
            {
                BLL.CategoriasBLL.Eliminar(Utilidades.ToInt(CategoriaIdtextBox.Text));
                Limpiar();
                MessageBox.Show("ELiminado con exito");
            }
        }

        private void limpiarErroresProvider()
        {
            BuscarerrorProvider.Clear();
            DescripcionerrorProvider.Clear();

        }
        private void Editarbutton_Click(object sender, EventArgs e)
        {
            Categorias categoria = new Categorias();
            if (validarId("Favor Buscar el Id para que desea actualizar") && ValidarTextbox())
            {

                LlenarClase(categoria);
                if (ValidarExiste(DescripciontextBox.Text))
                {
                    BLL.CategoriasBLL.Modificar(Utilidades.ToInt(CategoriaIdtextBox.Text), categoria);
                    Limpiar();
                    limpiarErroresProvider();
                    MessageBox.Show("Actualizado con exito");
                }

            }

        }
    }
}
