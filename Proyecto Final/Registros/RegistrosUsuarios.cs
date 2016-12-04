using BLL;
using DAL;
using Entidades;
using SistemaDeVentas.Entidades;
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
    public partial class RegistrosUsuarios : Form
    {
        public RegistrosUsuarios()
        {
            InitializeComponent();
            CargarConboBox();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor ingresar el id del usuario que desea buscar") && ValidarBuscar())
                LLenar(UsuariosBLL.Buscar(Utilidades.ToInt(UsuarioIdtextBox.Text)));
        }
        private void LLenar(Usuarios usuario)
        {

            UsuarioIdtextBox.Text = usuario.UsuarioId.ToString();
            NombreUsuariostextBox.Text = usuario.Nombre.ToString();
            ContraseñatextBox.Text = usuario.Contrasena;
            ConfimarContraseñatextBox1.Text = usuario.Contrasena;

            CargarConboBox();
        }

        private bool validarId(string message)
        {
            if (string.IsNullOrEmpty(UsuarioIdtextBox.Text))
            {
                BuscarerrorProvider.SetError(UsuarioIdtextBox, "Por Favor Ingresar Id");
                MessageBox.Show(message);
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool ValidarBuscar()
        {
            if (UsuariosBLL.Buscar(Utilidades.ToInt(UsuarioIdtextBox.Text)) == null)
            {
                MessageBox.Show("Este registro no existe");
                return false;
            }

            return true;


        }
        public void Limpiar()
        {
            UsuarioIdtextBox.Clear();
            NombreUsuariostextBox.Clear();
            ContraseñatextBox.Clear();
            ConfimarContraseñatextBox1.Clear();
            limpiarErroresProvider();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            BuscarerrorProvider.Clear();
            LlenarClase(usuario);
            CargarConboBox();
            if (ValidarTextbox() && ValidarExiste(NombreUsuariostextBox.Text))
            {
                UsuariosBLL.Insertar(usuario);
                Limpiar();
                MessageBox.Show("Guardado con exito");
            }
        }
        //--
        //Botton De Guardar Usuario

        private void LlenarClase(Usuarios u)
        {
           TipoUsuarios tus = new TipoUsuarios();
            u.Nombre = NombreUsuariostextBox.Text;
            u.Contrasena = ContraseñatextBox.Text;
            tus.Detalle = TipoUsuarioscomboBox.Text;
            u.Tipo = tus.Detalle = TipoUsuarioscomboBox.Text;

        }
        private bool ValidarExiste(string aux)
        {
            if (UsuariosBLL.GetListaNombreUsuario(aux).Count() > 0)
            {
                MessageBox.Show("Este nombre de Usuario ya existe, favor intentar con otro nombre de usario o Modificar..");
                return false;
            }
            return true;
        }

        private bool ValidarTextbox()
        {

            if (string.IsNullOrEmpty(NombreUsuariostextBox.Text) && string.IsNullOrEmpty(ContraseñatextBox.Text) && string.IsNullOrEmpty(ConfimarContraseñatextBox1.Text))
            {
                NombreerrorProvider.SetError(NombreUsuariostextBox, "Favor Ingresar El Nombre de Usuario");
                ContraseñaerrorProvider.SetError(ContraseñatextBox, "Favor ingresar la contraseña del usuario");
                ConfimarContraseñaerrorProvider.SetError(ConfimarContraseñatextBox1, "Favor confirmar comtraseña");

                MessageBox.Show("Favor llenar todos los campos obligatorios");

            }
            if (string.IsNullOrEmpty(NombreUsuariostextBox.Text))
            {
                NombreerrorProvider.Clear();
                NombreerrorProvider.SetError(NombreUsuariostextBox, "Favor ingresar el nombre de Usuario");
                return false;
            }

            if (string.IsNullOrEmpty(ContraseñatextBox.Text))
            {
                NombreerrorProvider.Clear();
                ConfimarContraseñaerrorProvider.SetError(ConfimarContraseñatextBox1, "Favor ingresar la contraseña del usuario");
                return false;
            }

            if (string.IsNullOrEmpty(ContraseñatextBox.Text))
            {
                NombreerrorProvider.Clear();
                ContraseñaerrorProvider.Clear();
                ConfimarContraseñaerrorProvider.SetError(ConfimarContraseñatextBox1, "Favor confirmar comtraseña");
                return false;
            }

            if (ContraseñatextBox.Text != ConfimarContraseñatextBox1.Text)
            {
                NombreerrorProvider.Clear();
                ContraseñaerrorProvider.Clear();
                ConfimarContraseñaerrorProvider.Clear();
                ConfimarContraseñaerrorProvider.SetError(ConfimarContraseñatextBox1, "La contraseña no coincide");
                MessageBox.Show("La Contraseña no conciden");
                return false;
            }
            if (TipoUsuarioscomboBox.Text != TipoUsuarioscomboBox.Text)
            {
                NombreerrorProvider.Clear();
                ContraseñaerrorProvider.Clear();
                ConfimarContraseñaerrorProvider.Clear();
               TipoUsuarioerrorProvider.Clear();
                MessageBox.Show("elegir tipo de usuarios");
                return false;
            }
            return true;
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor digitar el id del usuario que desea eliminar") && ValidarBuscar())
            {
                UsuariosBLL.Eliminar(Utilidades.ToInt(UsuarioIdtextBox.Text));
                Limpiar();
                MessageBox.Show("ELiminado con exito");
            }
        }
        public List<TipoUsuarios> lista = new List<TipoUsuarios>();
        private void CargarConboBox()
        {
            var db = new SistemaVentasDb();
            lista = db.TipoUsuarios.ToList();
            if (lista.Count > 0)
            {
                TipoUsuarioscomboBox.DataSource = lista;
                TipoUsuarioscomboBox.ValueMember = "TipoUsuarioId";
                TipoUsuarioscomboBox.DisplayMember = "Detalle";
            }
        }

        private void limpiarErroresProvider()
        {
            NombreerrorProvider.Clear();
            ConfimarContraseñaerrorProvider.Clear();
            ContraseñaerrorProvider.Clear();


        }

        private void Editarbutton_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            if (validarId("Favor Buscar el Id para que desea actualizar") && ValidarTextbox())
            {

                LlenarClase(usuario);
                if (ValidarExiste(NombreUsuariostextBox.Text))
                {
                    UsuariosBLL.Modificar(Utilidades.ToInt(UsuarioIdtextBox.Text), usuario);
                    Limpiar();
                    limpiarErroresProvider();
                    MessageBox.Show("Actualizado con exito");
                }

            }
        }
    }
}
