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
    public partial class ConsultaUsuarios : Form
    {
        public ConsultaUsuarios()
        {
            InitializeComponent();
            CargarFiltrar();
        }
        public List<Usuarios> lista = new List<Usuarios>();


        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (validar() == true)
                BuscarSelecionComBox();
        }
        private void CargarFiltrar()
        {
            FiltrarcomboBox.Items.Insert(0, "UsuarioId");
            FiltrarcomboBox.Items.Insert(1, "Nombre");
            FiltrarcomboBox.DataSource = FiltrarcomboBox.Items;
            FiltrarcomboBox.DisplayMember = "Id";
            ConsultaUsuariosdataGridView.DataSource = UsuariosBLL.GetLista();
        }

        private void BuscarSelecionComBox()
        {


            if (FiltrarcomboBox.SelectedIndex == 0)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {

                    lista = UsuariosBLL.GetLista(Utilidades.ToInt(FiltrotextBox.Text));
                }
                else
                {
                    lista = UsuariosBLL.GetLista();
                }

                ConsultaUsuariosdataGridView.DataSource = lista;
            }
            if (FiltrarcomboBox.SelectedIndex == 1)
            {
                if (!String.IsNullOrEmpty(FiltrotextBox.Text))
                {

                    lista = UsuariosBLL.GetListaNombreUsuario(FiltrotextBox.Text);
                }
                else
                {
                    lista = UsuariosBLL.GetLista();
                }

                ConsultaUsuariosdataGridView.DataSource = lista;
            }

        }

        private bool validar()
        {




            if (string.IsNullOrEmpty(FiltrotextBox.Text))
            {
                BuscarerrorProvider.SetError(FiltrotextBox, "Ingresar el campo que desea filtar");
                return false;
            }

            if (FiltrarcomboBox.SelectedIndex == 0 && UsuariosBLL.GetLista(Utilidades.ToInt(FiltrotextBox.Text)).Count == 0)
            {
                MessageBox.Show("No hay registros que coincidan con este campo de filtro..." + "\n" + "\n" + "Intente con otro campo");
                return false;

            }

            if (FiltrarcomboBox.SelectedIndex == 1 && UsuariosBLL.GetListaNombreUsuario(FiltrotextBox.Text).Count == 0)
            {
                MessageBox.Show("No hay registros que coincidan con este campo de filtro..." + "\n" + "\n" + "Intente con otro campo");
                return false;

            }





            BuscarerrorProvider.Clear();


            return true;
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            MyViewerUsuarios viewer = new MyViewerUsuarios();

            viewer.UsuariosreportViewer.Reset();
            viewer.UsuariosreportViewer.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;

            viewer.UsuariosreportViewer.LocalReport.ReportPath = @"C:\Users\adolfo\Documents\Proyecto Final\Proyecto-Final-Aplicada-1-Sistema-De-VentasSm\Proyecto Final\Reportes\ListadosUsuarios.rdlc";


            viewer.UsuariosreportViewer.LocalReport.DataSources.Clear();


            viewer.UsuariosreportViewer.LocalReport.DataSources.Add(
                new Microsoft.Reporting.WinForms.ReportDataSource("DataSetUsuarios",
                UsuariosBLL.GetLista()));

            viewer.UsuariosreportViewer.LocalReport.Refresh();

            viewer.Show();
        }
    }
}
