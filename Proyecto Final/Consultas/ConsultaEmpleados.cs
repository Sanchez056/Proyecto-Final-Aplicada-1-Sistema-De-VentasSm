using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal_Aplicada1.Consultas
{
    public partial class ConsultaEmpleados : Form
    {
        public ConsultaEmpleados()
        {
            InitializeComponent();
            CargarFiltrar();
        }
        List<Empleados> lista = new List<Empleados>();

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (validar() == true)
                BuscarSelecionComBox();

        }
        private void CargarFiltrar()
        {
            FiltrarcomboBox.Items.Insert(0, "EmpleadoId");
            FiltrarcomboBox.Items.Insert(1, "Nombre");
            FiltrarcomboBox.Items.Insert(2, "Apellido");
            FiltrarcomboBox.Items.Insert(3, "Cedula");
            FiltrarcomboBox.Items.Insert(4, "Sexo");
            FiltrarcomboBox.Items.Insert(5, "FechaIngreso");
            FiltrarcomboBox.DataSource = FiltrarcomboBox.Items;
            FiltrarcomboBox.DisplayMember = "Id";
            ConsultaEmpleadodataGridView.DataSource = EmpleadosBLL.GetLista();
        }

        private void BuscarSelecionComBox()
        {
            Utilidades ut = new Utilidades();


            if (FiltrarcomboBox.SelectedIndex == 0)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {

                    lista = EmpleadosBLL.GetLista(Utilidades.ToInt(FiltrotextBox.Text));
                }
                else
                {
                    lista = EmpleadosBLL.GetLista();
                }

                ConsultaEmpleadodataGridView.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 1)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {

                    lista = EmpleadosBLL.GetListaNombreEmpleado(FiltrotextBox.Text);
                }
                else
                {
                    lista = EmpleadosBLL.GetLista();
                }

                ConsultaEmpleadodataGridView.DataSource = lista;
            }

            if (FiltrarcomboBox.SelectedIndex == 2)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {

                    lista = EmpleadosBLL.GetListaCedula(FiltrotextBox.Text);
                }
                else
                {
                    lista = EmpleadosBLL.GetLista();
                }

                ConsultaEmpleadodataGridView.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 3)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {

                    lista = EmpleadosBLL.GetListaSexo(FiltrotextBox.Text);
                }
                else
                {
                    lista = EmpleadosBLL.GetLista();
                }

                ConsultaEmpleadodataGridView.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 4)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {

                    lista = EmpleadosBLL.GetListaFecha(DesdeDateTimePicke.Value, HastadateTimePicker.Value);
                }
                else
                {
                    lista = EmpleadosBLL.GetLista();
                }

                ConsultaEmpleadodataGridView.DataSource = lista;
            }



        }

        private bool validar()
        {
            Utilidades ut = new Utilidades();

            if (FiltrarcomboBox.SelectedIndex == 4)
            {
                if (DesdeDateTimePicke.Value == HastadateTimePicker.Value)
                {
                    MessageBox.Show("Favor definir un intervalo diferente entre las dos fechas");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            if (string.IsNullOrEmpty(FiltrotextBox.Text))
            {
                // BuscarerrorProvider1.SetError(FiltrotextBox, "Ingresar el campo que desea filtar");
                return false;
            }


            if (FiltrarcomboBox.SelectedIndex == 1 && EmpleadosBLL.GetListaNombreEmpleado(FiltrotextBox.Text).Count == 0)
            {
                MessageBox.Show("No hay registros que coincidan con este campo de filtro..." + "\n" + "\n" + "Intente con otro campo");
                return false;

            }

            if (FiltrarcomboBox.SelectedIndex == 2 && EmpleadosBLL.GetListaCedula(FiltrotextBox.Text).Count == 0)
            {
                MessageBox.Show("No hay registros que coincidan con este campo de filtro..." + "\n" + "\n" + "Intente con otro campo");
                return false;

            }
            if (FiltrarcomboBox.SelectedIndex == 3 && EmpleadosBLL.GetListaSexo(FiltrotextBox.Text).Count == 0)
            {
                MessageBox.Show("No hay registros que coincidan con este campo de filtro..." + "\n" + "\n" + "Intente con otro campo");
                return false;

            }

            if (FiltrarcomboBox.SelectedIndex == 0 && EmpleadosBLL.GetLista(Utilidades.ToInt(FiltrotextBox.Text)).Count == 0)
            {
                MessageBox.Show("No hay registros que coincidan con este campo de filtro..." + "\n" + "\n" + "Intente con otro campo");
                return false;

            }

            // BuscarerrorProvider1.Clear();


            return true;
        }


        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            MyViewerEmpleados viewer = new MyViewerEmpleados();

            viewer.EmpleadoreportViewer.Reset();
            viewer.EmpleadoreportViewer.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;

            viewer.EmpleadoreportViewer.LocalReport.ReportPath = @"C:\Users\adolfo\Documents\Proyecto Final\Proyecto-Final-Aplicada-1-Sistema-De-VentasSm\Proyecto Final\Reportes\ListadosEmpleados.rdlc";


            viewer.EmpleadoreportViewer.LocalReport.DataSources.Clear();


            viewer.EmpleadoreportViewer.LocalReport.DataSources.Add(
                new Microsoft.Reporting.WinForms.ReportDataSource("EmpleadoDataSet",
                EmpleadosBLL.GetLista()));

            viewer.EmpleadoreportViewer.LocalReport.Refresh();

            viewer.Show();

        }
        
    }
}
