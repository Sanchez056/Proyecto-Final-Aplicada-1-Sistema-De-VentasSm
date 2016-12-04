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
    public partial class ConsultasArticulos : Form
    {
        public ConsultasArticulos()
        {
            InitializeComponent();
            CargarFiltrar();
        }
        public List<Articulos> lista = new List<Articulos>();


        private void Buscarbutton_Click(object sender, EventArgs e)
        {

            if (validar() == true)
                BuscarSelecionComBox();
        }
        private void CargarFiltrar()
        {
            FiltrarcomboBox.Items.Insert(0, "ArticuloId");
            FiltrarcomboBox.Items.Insert(1, "NombreArticulo");
            FiltrarcomboBox.Items.Insert(2, "MarcaArticulo");
            FiltrarcomboBox.Items.Insert(3, "FechaIngreso");
            FiltrarcomboBox.DataSource = FiltrarcomboBox.Items;
            FiltrarcomboBox.DisplayMember = "Id";
            ConsultaArticulosdataGridView.DataSource = ArticulosBLL.GetLista();
        }

        private void BuscarSelecionComBox()
        {


            if (FiltrarcomboBox.SelectedIndex == 0)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {

                    lista = ArticulosBLL.GetLista(Utilidades.ToInt(FiltrotextBox.Text));
                }
                else
                {
                    lista = ArticulosBLL.GetLista();
                }

                ConsultaArticulosdataGridView.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 1)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {

                    lista = ArticulosBLL.GetListaNombreArticulo(FiltrotextBox.Text);
                }
                else
                {
                    lista = ArticulosBLL.GetLista();
                }

                ConsultaArticulosdataGridView.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 2)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {

                    lista = ArticulosBLL.GetListaMarcaArticulo(FiltrotextBox.Text);
                }
                else
                {
                    lista = ArticulosBLL.GetLista();
                }

                ConsultaArticulosdataGridView.DataSource = lista;
            }


            if (FiltrarcomboBox.SelectedIndex == 4)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {

                    //lista = ArticuloBLL.GetListaFecha(DesdeDateTimePicke.Value, HastadateTimePicker.Value);
                }
                else
                {
                    lista = ArticulosBLL.GetLista();
                }

                ConsultaArticulosdataGridView.DataSource = lista;
            }



        }

        private bool validar()
        {

            if (FiltrarcomboBox.SelectedIndex == 0 && ArticulosBLL.GetLista(Utilidades.ToInt(FiltrotextBox.Text)).Count == 0)
            {
                MessageBox.Show("No hay registros que coincidan con este campo de filtro..." + "\n" + "\n" + "Intente con otro campo");
                return false;

            }



            if (string.IsNullOrEmpty(FiltrotextBox.Text))
            {
                BuscarerrorProvider.SetError(FiltrotextBox, "Ingresar el campo que desea filtar");
                return false;
            }


            if (FiltrarcomboBox.SelectedIndex == 1 && ArticulosBLL.GetListaNombreArticulo(FiltrotextBox.Text).Count == 0)
            {
                MessageBox.Show("No hay registros que coincidan con este campo de filtro..." + "\n" + "\n" + "Intente con otro campo");
                return false;

            }
            if (FiltrarcomboBox.SelectedIndex == 2 && ArticulosBLL.GetListaMarcaArticulo(FiltrotextBox.Text).Count == 0)
            {
                MessageBox.Show("No hay registros que coincidan con este campo de filtro..." + "\n" + "\n" + "Intente con otro campo");
                return false;

            }

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


            BuscarerrorProvider.Clear();


            return true;
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            MyViewerArticulos viewer = new MyViewerArticulos();

            viewer.ArticulosreportViewer.Reset();
            viewer.ArticulosreportViewer.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;

            viewer.ArticulosreportViewer.LocalReport.ReportPath = @"C:\Users\adolfo\Documents\Proyecto Final\Proyecto-Final-Aplicada-1-Sistema-De-VentasSm\Proyecto Final\Reportes\ListadoArticulos.rdlc";


            viewer.ArticulosreportViewer.LocalReport.DataSources.Clear();


            viewer.ArticulosreportViewer.LocalReport.DataSources.Add(
                new Microsoft.Reporting.WinForms.ReportDataSource("DataSetArticulos",
                ArticulosBLL.GetLista()));

            viewer.ArticulosreportViewer.LocalReport.Refresh();

            viewer.Show();
        }
    }
}
