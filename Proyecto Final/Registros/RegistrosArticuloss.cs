using BLL;
using DAL;
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
    public partial class RegistrosArticuloss : Form
    {
        
        private List<Proveedores> prove;
        public RegistrosArticuloss()
        {
            InitializeComponent();
            CargarConboBoxCategorias();
            CargarConboBoxProveedores();
            prove = new List<Proveedores>();
        }

        private void Limpiar()
        {
            ArticuloIdtextBox.Clear();
            NombretextBox.Clear();
            PrecioVentatextBox.Clear();
            CantidadtextBox.Clear();
            MarcatextBox.Clear();
            DespcripciontextBox.Clear();
            limpiarErroresProvider();

        }



        private Articulos LLenarClase()
        {
            Articulos Prod = new Articulos();
            Prod.ArticuloId = Utilidades.ToInt(ArticuloIdtextBox.Text);
            Prod.Cantidad = Utilidades.ToInt(CantidadtextBox.Text);
            Prod.Precio = Utilidades.ToInt(PrecioVentatextBox.Text);
            Prod.Nombre = NombretextBox.Text;
            Prod.Marca = MarcatextBox.Text;
            Prod.Descripcion = DespcripciontextBox.Text;
            CargarConboBoxProveedores();
            CargarConboBoxCategorias();
            return Prod;
          

        }
        public List<Proveedores> lista = new List<Proveedores>();
        private void CargarConboBoxProveedores()
        {
            var db = new SistemaVentasDb();
            lista = db.Proveedore.ToList();
            if (lista.Count > 0)
            {
                NombreProveedorcomboBox1.DataSource = lista;
                NombreProveedorcomboBox1.ValueMember = "ProveedorId";
                NombreProveedorcomboBox1.DisplayMember = "Nombre";
            }
        }
        public List<Categorias> list = new List<Categorias>();
        private void CargarConboBoxCategorias()
        {
            var db = new SistemaVentasDb();
            list = db.Categorias.ToList();
            if (list.Count > 0)
            {
                CategoriacomboBox.DataSource = list;
                CategoriacomboBox.ValueMember = "CategoriaId";
                CategoriacomboBox.DisplayMember = "Descripcion";
            }
        }









        private void button4_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Articulos articulo = new Articulos();

            articulo = LLenarClase();
            if (ValidarTextbox() && ValidarExiste(NombretextBox.Text))
            {

                if (articulo != null)
                {
                    limpiarErroresProvider();
                    if (BLL.ArticulosBLL.Insertar(articulo))
                    {
                        MessageBox.Show("Gurardado con exito");
                    }
                }
            }
        }

        private void Buscarbutton_Click_1(object sender, EventArgs e)
        {
                var articulo = ArticulosBLL.Buscar(Utilidades.ToInt(ArticuloIdtextBox.Text));
                if (articulo != null)
                {

                    NombretextBox.Text = articulo.Nombre;
                    MarcatextBox.Text = articulo.Marca;
                    DespcripciontextBox.Text = articulo.Descripcion;
                    CantidadtextBox.Text = articulo.Cantidad.ToString();
                    PrecioVentatextBox.Text = articulo.Precio.ToString();
                    CargarConboBoxCategorias();
                    CargarConboBoxProveedores();
                }
                else
                {
                    MessageBox.Show("Este Id no esta Registrado  ");
                }
            
        }

        private void Editarbutton_Click(object sender, EventArgs e)
        {
            Articulos articulo = new Articulos();
            if (validarId("Favor Buscar el Id para que desea actualizar") && ValidarTextbox())
            {

               articulo= LLenarClase();
                if (ValidarExiste(NombretextBox.Text))
                {
                    ArticulosBLL.Modificar(Utilidades.ToInt(ArticuloIdtextBox.Text), articulo);
                    Limpiar();
                    limpiarErroresProvider();
                    MessageBox.Show("Actualizado con exito");
                }

            }
        }

        private void Eliminarbutton_Click_1(object sender, EventArgs e)
        {
            ArticulosBLL.Eliminar(ArticulosBLL.Buscar(Convert.ToInt32(ArticuloIdtextBox.Text)));
            Limpiar();
            MessageBox.Show("Vendedor ha sido eliminado");

        }
        //-----------------------------Validad-------------------------------------------------------
        private bool ValidarTextbox()
        {


            if (string.IsNullOrEmpty(NombretextBox.Text) &&
                string.IsNullOrEmpty(DespcripciontextBox.Text) &&
                string.IsNullOrEmpty(MarcatextBox.Text) &&
                string.IsNullOrEmpty(NombreProveedorcomboBox1.Text) &&
                string.IsNullOrEmpty(CategoriacomboBox.Text) &&
                string.IsNullOrEmpty(CantidadtextBox.Text) &&
                string.IsNullOrEmpty(PrecioVentatextBox.Text)



                )
            {
                NombreerrorProvider.SetError(NombretextBox, "Favor Ingresar el  nombre del articulos");
                DescripcionerrorProvider.SetError(DespcripciontextBox, "Favor Ingresar la descripcion del articulo");
                MarcaerrorProvider.SetError(MarcatextBox, "Favor Ingresar la marca del articulo");
                NombreProveedorerrorProvider.SetError(NombreProveedorcomboBox1, "Favor elegir el proveedor a que  correponde el  articulo");
                CategoriaerrorProvider.SetError(CategoriacomboBox, "Favor elegir la categoria a que correponde el articulo");
                CantidaderrorProvider.SetError(CantidadtextBox, "Favor Ingresar la cantidad del articulo");
                PrecioVentaerrorProvider.SetError(PrecioVentatextBox, "Favor Ingresar el precio de venta del articulo");
                MessageBox.Show("Favor llenar todos los campos obligatorios");

            }

            if (string.IsNullOrEmpty(NombretextBox.Text))
            {
                NombreerrorProvider.Clear();
                NombreerrorProvider.SetError(NombretextBox, "Favor Ingresar el  nombre del articulos");
                return false;
            }

            if (string.IsNullOrEmpty(DespcripciontextBox.Text))
            {
                DescripcionerrorProvider.Clear();
                DescripcionerrorProvider.SetError(DespcripciontextBox, "Favor Ingresar la descripcion del articulo");
                return false;
            }
            if (string.IsNullOrEmpty(MarcatextBox.Text))
            {
                MarcaerrorProvider.Clear();
                MarcaerrorProvider.SetError(MarcatextBox, "Favor Ingresar la marca del articulo");
                return false;
            }
            if (string.IsNullOrEmpty(NombreProveedorcomboBox1.Text))
            {
                NombreProveedorerrorProvider.Clear();
                NombreProveedorerrorProvider.SetError(NombreProveedorcomboBox1, "Favor elegir el proveedor a que  correponde el  articulo");

                return false;
            }

            if (string.IsNullOrEmpty(CategoriacomboBox.Text))
            {
                CategoriaerrorProvider.Clear();
                CategoriaerrorProvider.SetError(CategoriacomboBox, "Favor elegir la categoria a que correponde el articulo");
                return false;
            }
            if (string.IsNullOrEmpty(CantidadtextBox.Text))
            {
                CantidaderrorProvider.Clear();
                CantidaderrorProvider.SetError(CantidadtextBox, "Favor Ingresar la cantidad del articulo");
                return false;
            }

           
            if (string.IsNullOrEmpty(PrecioVentatextBox.Text))
            {
                PrecioVentaerrorProvider.Clear();
                PrecioVentaerrorProvider.SetError(PrecioVentatextBox, "Favor Ingresar el precio de venta del articulo");
                return false;
            }




            return true;
        }
        private bool ValidarBuscar()
        {
            if (ArticulosBLL.Buscar(Utilidades.ToInt(ArticuloIdtextBox.Text)) == null)
            {
                MessageBox.Show("Este registro no existe");
                return false;
            }

            return true;


        }
        private bool validarId(string message)
        {
            if (string.IsNullOrEmpty(ArticuloIdtextBox.Text))
            {

                MessageBox.Show(message);
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool ValidarExiste(string aux)
        {
            if (ArticulosBLL.GetListaNombreArticulo(aux).Count() > 0)
            {
                MessageBox.Show("Este nombre ya existe, favor intentar con otra nombre o modificar ...");
                return false;
            }


            return true;
        }
        //----------------------------- Limipiar Erro------------------------------------------------
        private void limpiarErroresProvider()
        {
            BuscarerrorProvider.Clear();
            NombreerrorProvider.Clear();
            DescripcionerrorProvider.Clear();
            MarcaerrorProvider.Clear();
            CantidaderrorProvider.Clear();
            PrecioCompraerrorProvider.Clear();
            PrecioVentaerrorProvider.Clear();

        }

        private void NombreProveedorcomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
