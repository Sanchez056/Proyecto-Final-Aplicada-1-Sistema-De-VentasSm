﻿using BLL;
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
    public partial class ConsultaProvvedor : Form
    {
        public ConsultaProvvedor()
        {
            InitializeComponent();
            CargarFiltrar();
        }
        public List<Proveedores> lista = new List<Proveedores>();

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (validar() == true)
                BuscarSelecionComBox();
        }
        private void CargarFiltrar()
        {
            FiltrarcomboBox.Items.Insert(0, "ProveedorId");
            FiltrarcomboBox.Items.Insert(1, "NombreProveedor");
            FiltrarcomboBox.Items.Insert(2, "FechaIngreso");
            FiltrarcomboBox.DataSource = FiltrarcomboBox.Items;
            FiltrarcomboBox.DisplayMember = "Id";
            ConsultaProveedoressdataGridView.DataSource = ProveedoresBLL.GetLista();
        }

        private void BuscarSelecionComBox()
        {


            if (FiltrarcomboBox.SelectedIndex == 0)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {

                    lista = ProveedoresBLL.GetLista(Utilidades.ToInt(FiltrotextBox.Text));
                }
                else
                {
                    lista = ProveedoresBLL.GetLista();
                }

                ConsultaProveedoressdataGridView.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 1)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {

                    lista = ProveedoresBLL.GetListaNombreProveedor(FiltrotextBox.Text);
                }
                else
                {
                    lista = ProveedoresBLL.GetLista();
                }

                ConsultaProveedoressdataGridView.DataSource = lista;
            }

            if (FiltrarcomboBox.SelectedIndex == 2)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {

                    lista = ProveedoresBLL.GetListaFecha(DesdeDateTimePicke.Value, HastadateTimePicker.Value);
                }
                else
                {
                    lista = ProveedoresBLL.GetLista();
                }

                ConsultaProveedoressdataGridView.DataSource = lista;
            }



        }

        private bool validar()
        {

            if (FiltrarcomboBox.SelectedIndex == 2)
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
                BuscarerrorProvider.SetError(FiltrotextBox, "Ingresar el campo que desea filtar");
                return false;
            }


            if (FiltrarcomboBox.SelectedIndex == 1 && ProveedoresBLL.GetListaNombreProveedor(FiltrotextBox.Text).Count == 0)
            {
                MessageBox.Show("No hay registros que coincidan con este campo de filtro..." + "\n" + "\n" + "Intente con otro campo");
                return false;

            }


            if (FiltrarcomboBox.SelectedIndex == 0 && ProveedoresBLL.GetLista(Utilidades.ToInt(FiltrotextBox.Text)).Count == 0)
            {
                MessageBox.Show("No hay registros que coincidan con este campo de filtro..." + "\n" + "\n" + "Intente con otro campo");
                return false;

            }

            BuscarerrorProvider.Clear();


            return true;
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            MyViewerProveedores viewer = new MyViewerProveedores();

            viewer.ProveedorreportViewer.Reset();
            viewer.ProveedorreportViewer.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;

            viewer.ProveedorreportViewer.LocalReport.ReportPath = @"C:\Users\adolfo\Documents\Proyecto Final\Proyecto-Final-Aplicada-1-Sistema-De-VentasSm\Proyecto Final\Reportes\ListadoProveedores.rdlc";


            viewer.ProveedorreportViewer.LocalReport.DataSources.Clear();


            viewer.ProveedorreportViewer.LocalReport.DataSources.Add(
                new Microsoft.Reporting.WinForms.ReportDataSource("DataSetProveedores",
                ProveedoresBLL.GetLista()));

            viewer.ProveedorreportViewer.LocalReport.Refresh();

            viewer.Show();
        }
    }
}
