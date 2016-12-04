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

namespace ProyectoFinal_Aplicada1
{
    public partial class IniciarSecion : Form
    {
        MenuPrincipal MP = new MenuPrincipal();

        public IniciarSecion()
        {
            InitializeComponent();
        }

        //--
        public bool ValidarExisteUsuario()
        {
            if (UsuariosBLL.GetListaNombreUsuario(NombreUsuariostextBox1.Text).Count() == 0)
            {
                MessageBox.Show("Este Usuario No Esta Registrado en El Sistema, por favor verifique que este Escrito correctamente, o Intentelo Con otro Nombre Usuario y Su Contraseñas...");
                return false;
            }

            return true;
        }
        //---
        public bool ValidarContraseña()
        {
            if (UsuariosBLL.getContraseña(ContraseñatextBox2.Text).Count() == 0)
            {
                MessageBox.Show("Contraseña incorrecta");
                return false;
            }

            return true;
        }
        //----
        public bool ValidarTextbox()
        {

            if (string.IsNullOrEmpty(NombreUsuariostextBox1.Text) && string.IsNullOrEmpty(ContraseñatextBox2.Text))
            {
                NombreerrorProvider.SetError(NombreUsuariostextBox1, "Favor ingresar el nombre de Usuario");
                ContrasenaerrorProvider.SetError(ContraseñatextBox2, "Favor Ingresar la contraseña del Usuario");
                MessageBox.Show("Favor Llenar todos los campos Son obligatorios");

            }
            if (string.IsNullOrEmpty(NombreUsuariostextBox1.Text))
            {
                NombreerrorProvider.SetError(NombreUsuariostextBox1, "Favor ingresar el nombre de Usuario");
                return false;
            }

            if (string.IsNullOrEmpty(ContraseñatextBox2.Text))
            {
                NombreerrorProvider.Clear();
                ContrasenaerrorProvider.SetError(ContraseñatextBox2, "Favor ingresar la contraseña del usuario");
                return false;
            }

            return true;

        }
        //---
        public DialogResult validarSesion()
        {
            if (ValidarTextbox() == true && ValidarExisteUsuario() == true && ValidarContraseña() == true)
            {

                return DialogResult.OK;
            }

            return DialogResult.Cancel;

        }
        //---
      
        List<Usuarios> lista = new List<Usuarios>();

        private void CargarConboBox()
        {
            var db = new SistemaVentasDb();
            lista = db.Usuarios.ToList();
            if (lista.Count > 0)
            {
                TiposUsuarioscomboBox1.DataSource = lista;
                TiposUsuarioscomboBox1.ValueMember = "UsuarioId";
                TiposUsuarioscomboBox1.DisplayMember = "Tipo";
            }
        }




        private void IniciarSecion_Load(object sender, EventArgs e)
        {
            CargarConboBox();
        }

        private void IniciarSeccionbutton1_Click(object sender, EventArgs e)
        {
            if (validarSesion() == DialogResult.OK)
            {
                this.Visible = false;

                MP.Show();

            }

        }
    }
}
