using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using Entidades;

namespace ProyectoFinal_Aplicada1
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        
        

        
       
       

        private void RegistroarticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.RegistrosArticuloss ResUs = new Registros.RegistrosArticuloss();

            ResUs.MdiParent = this;
            ResUs.Show();
            ResUs.Location = new Point(40, 40);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Registros.RegistrosVentass ResUs = new Registros.RegistrosVentass();

            ResUs.MdiParent = this;
            ResUs.Show();
            ResUs.Location = new Point(40, 40);
        }

        private void RegistrosclientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Registros.RegistrosClientes ResUs = new Registros.RegistrosClientes();

            ResUs.MdiParent = this;
            ResUs.Show();
            ResUs.Location = new Point(40, 40);
        }

        private void RegistrosusuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.RegistrosUsuarios ResUs = new Registros.RegistrosUsuarios();

            ResUs.MdiParent = this;
            ResUs.Show();
            ResUs.Location = new Point(40, 40);
        }

        private void tiposUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.RegistrosTiposUsuarios ResUs = new Registros.RegistrosTiposUsuarios();

            ResUs.MdiParent = this;
            ResUs.Show();
            ResUs.Location = new Point(40, 40);
        }

        private void RegistrosproveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.RegistrosProvvedores ResUs = new Registros.RegistrosProvvedores();

            ResUs.MdiParent = this;
            ResUs.Show();
            ResUs.Location = new Point(40, 40);
        }

        private void registrosEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.RegistrosEmpleados ResUs = new Registros.RegistrosEmpleados();

            ResUs.MdiParent = this;
            ResUs.Show();
            ResUs.Location = new Point(40, 40);
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.RegistrosCategorias ResUs = new Registros.RegistrosCategorias();

            ResUs.MdiParent = this;
            ResUs.Show();
            ResUs.Location = new Point(40, 40);
        }

        private void ConsultausuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
             Consultas.ConsultaUsuarios  ConUs = new Consultas.ConsultaUsuarios();

            ConUs.MdiParent = this;
            ConUs.Show();
            ConUs.Location = new Point(40, 40);
        }

        private void tipoDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Consultas.ConsultaTipoUsuarios ConUs = new Consultas.ConsultaTipoUsuarios();

            ConUs.MdiParent = this;
            ConUs.Show();
            ConUs.Location = new Point(40, 40);
        }

        private void ConsultaclientesToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            Consultas.ConsultaClientes ConUs = new Consultas.ConsultaClientes();

            ConUs.MdiParent = this;
            ConUs.Show();
            ConUs.Location = new Point(40, 40);
        }

        private void ConsultaproveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Consultas.ConsultaProvvedor ConUs = new Consultas.ConsultaProvvedor();

            ConUs.MdiParent = this;
            ConUs.Show();
            ConUs.Location = new Point(40, 40);
        }

        private void ConsultaempleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Consultas.ConsultaEmpleados ConUs = new Consultas.ConsultaEmpleados();

            ConUs.MdiParent = this;
            ConUs.Show();
            ConUs.Location = new Point(40, 40);
        }

        private void ConsultaarticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Consultas.ConsultasArticulos ConUs = new Consultas.ConsultasArticulos();

            ConUs.MdiParent = this;
            ConUs.Show();
            ConUs.Location = new Point(40, 40);
        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Consultas.ConsultaVentas ConUs = new Consultas.ConsultaVentas();

            ConUs.MdiParent = this;
            ConUs.Show();
            ConUs.Location = new Point(40, 40);
        }

        private void categoriaDeArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Consultas.ConsultaCategorias ConUs = new Consultas.ConsultaCategorias();

            ConUs.MdiParent = this;
            ConUs.Show();
            ConUs.Location = new Point(40, 40);
        }
    }
}
