using BLL;
using SistemaDeVentas.Entidades;
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
    public partial class ConsultaTipoUsuarios : Form
    {
        public ConsultaTipoUsuarios()
        {
            InitializeComponent();
        }
        public List<TipoUsuarios> lista = new List<TipoUsuarios>();

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (validar() == true)
                BuscarSelecionComBox();
        }
        private void CargarFiltrar()
        {
            FiltrarcomboBox.Items.Insert(0, "TipoUsuarioId");
            FiltrarcomboBox.Items.Insert(1, "Detalle");
            FiltrarcomboBox.DataSource = FiltrarcomboBox.Items;
            FiltrarcomboBox.DisplayMember = "Id";
            ConsultaTipoUsuariodataGridView.DataSource = TipoUsuariosBLL.GetLista();
        }
        private void BuscarSelecionComBox()
        {


            if (FiltrarcomboBox.SelectedIndex == 0)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {

                    lista = TipoUsuariosBLL.GetLista(Utilidades.ToInt(FiltrotextBox.Text));
                }
                else
                {
                    lista = TipoUsuariosBLL.GetLista();
                }

                ConsultaTipoUsuariodataGridView.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 1)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {

                    lista = TipoUsuariosBLL.GetListaDetalle(FiltrotextBox.Text);
                }
                else
                {
                    lista = TipoUsuariosBLL.GetLista();
                }

                ConsultaTipoUsuariodataGridView.DataSource = lista;
            }

        }
        private bool validar()
        {




            if (string.IsNullOrEmpty(FiltrotextBox.Text))
            {
                BuscarerrorProvider.SetError(FiltrotextBox, "Ingresar el campo que desea filtar");
                return false;
            }

            if (FiltrarcomboBox.SelectedIndex == 0 && TipoUsuariosBLL.GetLista(Utilidades.ToInt(FiltrotextBox.Text)).Count == 0)
            {
                MessageBox.Show("No hay registros que coincidan con este campo de filtro..." + "\n" + "\n" + "Intente con otro campo");
                return false;

            }

            if (FiltrarcomboBox.SelectedIndex == 1 && TipoUsuariosBLL.GetListaDetalle(FiltrotextBox.Text).Count == 0)
            {
                MessageBox.Show("No hay registros que coincidan con este campo de filtro..." + "\n" + "\n" + "Intente con otro campo");
                return false;

            }





            BuscarerrorProvider.Clear();


            return true;
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            MyViewerTipoUsuarios viewer = new MyViewerTipoUsuarios();

            viewer.TipoUsuariosreportViewer.Reset();
            viewer.TipoUsuariosreportViewer.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;

            viewer.TipoUsuariosreportViewer.LocalReport.ReportPath = @"C:\Users\adolfo\Documents\Proyecto Final\Proyecto-Final-Aplicada-1-Sistema-De-VentasSm\Proyecto Final\Reportes\ListadosTipoUsuarios.rdlc";


            viewer.TipoUsuariosreportViewer.LocalReport.DataSources.Clear();


            viewer.TipoUsuariosreportViewer.LocalReport.DataSources.Add(
                new Microsoft.Reporting.WinForms.ReportDataSource("TipoUsuariosDataSet",
                UsuariosBLL.GetLista()));

            viewer.TipoUsuariosreportViewer.LocalReport.Refresh();

            viewer.Show();
        }

        private void ConsultaTipoUsuarios_Load(object sender, EventArgs e)
        {

        }
    }
}
