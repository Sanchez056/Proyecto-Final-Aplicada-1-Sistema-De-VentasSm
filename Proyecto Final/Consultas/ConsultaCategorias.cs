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
    public partial class ConsultaCategorias : Form
    {
        public ConsultaCategorias()
        {
            InitializeComponent();
            CargarFiltrar();
        }
        List<Categorias> lista = new List<Categorias>();


        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (validar() == true)
                BuscarSelecionComBox();

        }
        private void CargarFiltrar()
        {
            FiltrarcomboBox.Items.Insert(0, "CategoriaId");
            FiltrarcomboBox.Items.Insert(1, "Descripcion");
            FiltrarcomboBox.DataSource = FiltrarcomboBox.Items;
            FiltrarcomboBox.DisplayMember = "Id";
            ConsultaCategoriadataGridView.DataSource = CategoriasBLL.GetLista();
        }
        private void BuscarSelecionComBox()
        {
            Utilidades ut = new Utilidades();


            if (FiltrarcomboBox.SelectedIndex == 0)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {

                    lista = CategoriasBLL.GetLista(Utilidades.ToInt(FiltrotextBox.Text));
                }
                else
                {
                    lista = CategoriasBLL.GetLista();
                }

                ConsultaCategoriadataGridView.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 1)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {

                    lista = CategoriasBLL.GetListaDescripcion(FiltrotextBox.Text);
                }
                else
                {
                    lista = CategoriasBLL.GetLista();
                }

                ConsultaCategoriadataGridView.DataSource = lista;
            }

        }
        private bool validar()
        {
          



            if (string.IsNullOrEmpty(FiltrotextBox.Text))
            {
                BuscarerrorProvider.SetError(FiltrotextBox, "Ingresar el campo que desea filtar");
                return false;
            }

            if (FiltrarcomboBox.SelectedIndex == 0 && CategoriasBLL.GetLista(Utilidades.ToInt(FiltrotextBox.Text)).Count == 0)
            {
                MessageBox.Show("No hay registros que coincidan con este campo de filtro..." + "\n" + "\n" + "Intente con otro campo");
                return false;

            }

            if (FiltrarcomboBox.SelectedIndex == 1 && CategoriasBLL.GetListaDescripcion(FiltrotextBox.Text).Count == 0)
            {
                MessageBox.Show("No hay registros que coincidan con este campo de filtro..." + "\n" + "\n" + "Intente con otro campo");
                return false;

            }





            BuscarerrorProvider.Clear();


            return true;
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            MyViewerCategorias viewer = new MyViewerCategorias();

            viewer.CategoriareportViewer.Reset();
            viewer.CategoriareportViewer.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;

            viewer.CategoriareportViewer.LocalReport.ReportPath = @"C:\Users\adolfo\Documents\Proyecto Final\Proyecto-Final-Aplicada-1-Sistema-De-VentasSm\Proyecto Final\Reportes\ListadoCategoria.rdlc";


            viewer.CategoriareportViewer.LocalReport.DataSources.Clear();


            viewer.CategoriareportViewer.LocalReport.DataSources.Add(
                new Microsoft.Reporting.WinForms.ReportDataSource("DataSetCategoria",
                BLL.CategoriasBLL.GetLista()));

            viewer.CategoriareportViewer.LocalReport.Refresh();

            viewer.Show();
        }
    }
}
