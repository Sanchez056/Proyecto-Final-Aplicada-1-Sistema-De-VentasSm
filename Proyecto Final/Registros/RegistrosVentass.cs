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
    public partial class RegistrosVentass : Form
    {
        Ventas factura;
        public RegistrosVentass()
        {
            InitializeComponent();
            CargarEmpleados();
            CargarClientes();
            CargarArticulos();
            CargarCondicion();

            factura = new Ventas();
        }
        public void CargarArticulos()
        {

            ArticulocomboBox.DataSource = null;
            ArticulocomboBox.DataSource = BLL.ArticulosBLL.GetLista();
            ArticulocomboBox.ValueMember = "ArticuloId";
            ArticulocomboBox.DisplayMember = "Nombre";

        }
        public void CargarEmpleados()
        {

            EmpleadocomboBox.DataSource = null;
            EmpleadocomboBox.DataSource = BLL.EmpleadosBLL.GetLista();
            EmpleadocomboBox.ValueMember = "EmpleadoId";
            EmpleadocomboBox.DisplayMember = "Nombre";

        }

        public void CargarClientes()
        {

            ClientecomboBox.DataSource = null;
            ClientecomboBox.DataSource = BLL.ClientesBLL.GetLista();
            ClientecomboBox.ValueMember = "ClienteId";
            ClientecomboBox.DisplayMember = "Nombre";

        }
        public void CargarCondicion()
        {
            CondicioncomboBox.DataSource = null;
            CondicioncomboBox.DataSource = BLL.TipoPagosBLL.GetLista();
            CondicioncomboBox.ValueMember = "TipoId";
            CondicioncomboBox.DisplayMember = "Descripcion";

        }







        


        private void BuscarIdbutton_Click_1(object sender, EventArgs e)
        {
            if (validarId("Favor ingresar el id de la Venta que desea buscar") && ValidarBuscar())
                factura = BLL.VentasBLL.Buscar(Utilidades.ToInt(FacturaIdtextBox.Text));
                 Llenar();
        }
        private void Llenar()
        {

            if (factura != null)
            {
                SubTotaltextBox.Text = factura.SubTotal.ToString();
                SubTotaltextBox.Text = factura.TotalItebis.ToString();
                TotaltextBox.Text = factura.Total.ToString();
                ArticulodataGridView.DataSource = null;
                ArticulodataGridView.DataSource = factura.Articulos;
            }

        }

        private void Nuevabutton_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Cobrarbutton_Click_1(object sender, EventArgs e)
        {
            LlenarClase();
            if (ValidarTextbox())
            {
                if (BLL.VentasBLL.Insertar(factura))
                {
                    MessageBox.Show("Guardo");
                    Limpiar();
                }
            }
        }
        private void LlenarClase()
        {
            factura.Fecha = FechadateTimePicker.Value;
            factura.Empleado = EmpleadocomboBox.Text;
            factura.Cliente = ClientecomboBox.Text;
            factura.Cantidad = factura.Articulos.Count();
        }

        private void Eliminarbutton_Click_1(object sender, EventArgs e)
        {
            if (validarId("Favor digitar el id de la Venta  que desea eliminar") && ValidarBuscar())
            {
                BLL.VentasBLL.Eliminar(BLL.VentasBLL.Buscar(Utilidades.ToInt(FacturaIdtextBox.Text)));
                Limpiar();
                MessageBox.Show("ELiminado con exito");
            }
           
        }
        //------------------------Carcular Para el Agregar-----------------------------------------
        private void Calcular(Ventas venta)
        {
            double subTotal = 0, itebis = 18, total = 0, totalItebis = 0;
            foreach (var detalle in venta.Articulos)
            {
                subTotal += detalle.Importe;
                totalItebis += subTotal * itebis / 100;
                total = subTotal + totalItebis;
            }
            venta.SubTotal = subTotal;
            venta.Itebis = itebis;
            venta.Total = total;
            venta.TotalItebis += venta.SubTotal * venta.Itebis / 100;
            venta.Total = venta.SubTotal + venta.TotalItebis;

        }
        //-----------------------Agregar-----------------------------------------------------------
        private void Agregarbutton_Click_1(object sender, EventArgs e)
        {
            if (ValidarTextbox())
            {
                int id = (int)ArticulocomboBox.SelectedValue;
                factura.Articulos.Add(new Articulos(id, ArticulocomboBox.Text, BLL.ArticulosBLL.GetPrecio(id), Utilidades.ToInt(CantidadArticulotextBox.Text)));
                ArticulodataGridView.DataSource = null;
                ArticulodataGridView.DataSource = factura.Articulos;
                Calcular(factura);
                CantidadAgregafotextBox.Text = factura.Articulos.Count().ToString();
                SubTotaltextBox.Text = factura.SubTotal.ToString();
                TotalItebistextBox.Text = factura.TotalItebis.ToString();
                TotaltextBox.Text = factura.Total.ToString();
            }
        }

        private void Imprimirbutton_Click_1(object sender, EventArgs e)
        {
            var reporte = new VentanasReportes.FacturaReporte();
            reporte.VentaId = Utilidades.ToInt(FacturaIdtextBox.Text);
            reporte.Show();

        }
        //-------------------------Validar---------------------------------------------------

        private bool ValidarTextbox()
        {

            if (string.IsNullOrEmpty(CantidadArticulotextBox.Text))

            {
                //SetError(FacturaIdtextBox, "Favor Ingresar el codigo de la venta");

                MessageBox.Show("Favor Campos sellalados Con el punto rojo");

            }
            if (string.IsNullOrEmpty(CantidadArticulotextBox.Text))
            {

                //CodigoerrorProvider.SetError(FacturaIdtextBox, "Favor ingresar el codigo de la venta");
                return false;
            }

            return true;

        }





        private bool ValidarBuscar()
        {
            if (BLL.VentasBLL.Buscar(Utilidades.ToInt(FacturaIdtextBox.Text)) == null)
            {
                MessageBox.Show("Este registro no existe");
                return false;
            }

            return true;


        }
        private bool validarId(string message)
        {
            if (string.IsNullOrEmpty(FacturaIdtextBox.Text))
            {

                MessageBox.Show(message);
                return false;
            }
            else
            {
                return true;
            }
        }
        //--------------------------------Limpiar----------------------------------------------
        private void Limpiar()
        {
            ArticulodataGridView.DataSource = null;
            CantidadArticulotextBox.Clear();
            CantidadAgregafotextBox.Clear();
            SubTotaltextBox.Clear();
            TotaltextBox.Clear();
            FechadateTimePicker.Value = DateTime.Today;
            FacturaIdtextBox.Clear();
            factura = new Ventas();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void RegistrosVentass_Load(object sender, EventArgs e)
        {
            CargarClientes();
            CargarEmpleados();
        }
    }
}
