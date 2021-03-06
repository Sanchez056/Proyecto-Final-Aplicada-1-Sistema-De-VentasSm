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
    public partial class ConsultaClientes : Form
    {
        public ConsultaClientes()
        {
            InitializeComponent();
            CargarFiltrar();
        }
        public List<Clientes> lista = new List<Clientes>();
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (validar() == true)
                BuscarSelecionComBox();
        }
        private void CargarFiltrar()
        {
            FiltrarcomboBox.Items.Insert(0, "ClienteId");
            FiltrarcomboBox.Items.Insert(1, "Nombre");
            FiltrarcomboBox.Items.Insert(2, "Apellido");
            FiltrarcomboBox.Items.Insert(3, "Cedula");
            FiltrarcomboBox.Items.Insert(4, "Sexo");
            FiltrarcomboBox.Items.Insert(5, "FechaIngreso");
            FiltrarcomboBox.DataSource = FiltrarcomboBox.Items;
            FiltrarcomboBox.DisplayMember = "Id";
            ConsultaClientesdataGridView.DataSource = ClientesBLL.GetLista();
        }

        private void BuscarSelecionComBox()
        {
            Utilidades ut = new Utilidades();


            if (FiltrarcomboBox.SelectedIndex == 0)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {

                    lista = ClientesBLL.GetLista(Utilidades.ToInt(FiltrotextBox.Text));
                }
                else
                {
                    lista = ClientesBLL.GetLista();
                }

                ConsultaClientesdataGridView.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 1)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {

                    lista = ClientesBLL.GetListaNombreCliente(FiltrotextBox.Text);
                }
                else
                {
                    lista = ClientesBLL.GetLista();
                }

                ConsultaClientesdataGridView.DataSource = lista;
            }

            if (FiltrarcomboBox.SelectedIndex == 2)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {

                    lista = ClientesBLL.GetListaCedula(FiltrotextBox.Text);
                }
                else
                {
                    lista = ClientesBLL.GetLista();
                }

                ConsultaClientesdataGridView.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 3)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {

                    lista = ClientesBLL.GetListaSexo(FiltrotextBox.Text);
                }
                else
                {
                    lista = ClientesBLL.GetLista();
                }

                ConsultaClientesdataGridView.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 4)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {

                    lista = ClientesBLL.GetListaFecha(DesdeDateTimePicke.Value, HastadateTimePicker.Value);
                }
                else
                {
                    lista = ClientesBLL.GetLista();
                }

                ConsultaClientesdataGridView.DataSource = lista;
            }



        }

        private bool validar()
        {

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
                BuscarerrorProvider.SetError(FiltrotextBox, "Ingresar el campo que desea filtar");
                return false;
            }


            if (FiltrarcomboBox.SelectedIndex == 1 && ClientesBLL.GetListaNombreCliente(FiltrotextBox.Text).Count == 0)
            {
                MessageBox.Show("No hay registros que coincidan con este campo de filtro..." + "\n" + "\n" + "Intente con otro campo");
                return false;

            }
            if (FiltrarcomboBox.SelectedIndex == 2 && ClientesBLL.GetListaCedula(FiltrotextBox.Text).Count == 0)
            {
                MessageBox.Show("No hay registros que coincidan con este campo de filtro..." + "\n" + "\n" + "Intente con otro campo");
                return false;

            }
            if (FiltrarcomboBox.SelectedIndex == 3 && ClientesBLL.GetListaSexo(FiltrotextBox.Text).Count == 0)
            {
                MessageBox.Show("No hay registros que coincidan con este campo de filtro..." + "\n" + "\n" + "Intente con otro campo");
                return false;

            }

            if (FiltrarcomboBox.SelectedIndex == 0 && ClientesBLL.GetLista(Utilidades.ToInt(FiltrotextBox.Text)).Count == 0)
            {
                MessageBox.Show("No hay registros que coincidan con este campo de filtro..." + "\n" + "\n" + "Intente con otro campo");
                return false;

            }

            BuscarerrorProvider.Clear();


            return true;
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            MyViewerClientes viewer = new MyViewerClientes();

            viewer.ClientesreportViewer.Reset();
            viewer.ClientesreportViewer.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;

            viewer.ClientesreportViewer.LocalReport.ReportPath = @"C:\Users\adolfo\Documents\Proyecto Final\Proyecto-Final-Aplicada-1-Sistema-De-VentasSm\Proyecto Final\Reportes\ListadoClientes.rdlc";


            viewer.ClientesreportViewer.LocalReport.DataSources.Clear();


            viewer.ClientesreportViewer.LocalReport.DataSources.Add(
                new Microsoft.Reporting.WinForms.ReportDataSource("DataSetClientes",
                ClientesBLL.GetLista()));

            viewer.ClientesreportViewer.LocalReport.Refresh();

            viewer.Show();
        }
    }
}
