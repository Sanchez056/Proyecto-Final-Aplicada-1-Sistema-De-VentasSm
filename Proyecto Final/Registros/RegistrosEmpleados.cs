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

namespace ProyectoFinal_Aplicada1.Registros
{
    public partial class RegistrosEmpleados : Form
    {
        public RegistrosEmpleados()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor ingresar el id del Empleado que desea buscar") && ValidarBuscar())
                LLenar(EmpleadosBLL.Buscar(Utilidades.ToInt(EmpleadoIdtextBox.Text)));

        }
        private void LLenar(Empleados empleado)
        {

            EmpleadoIdtextBox.Text = empleado.EmpleadoId.ToString();
            NombretextBox.Text = empleado.Nombre;
            CiudadcomboBox.Text = empleado.Ciudad;
            DirecciontextBox.Text = empleado.Direccion;
            CedulamaskedTextBox.Text = empleado.Cedula;
            FechaNacimientomaskedTextBox.Text = empleado.FechaNacimiento;
            TelefonomaskedTextBox1.Text = empleado.Telefono;
            CelularmaskedTextBox2.Text = empleado.Celular;
            if (empleado.Sexo == "M")
                MasculinocheckBox.Checked = true;
            if (empleado.Sexo == "F")
                FemeninocheckBox.Checked = true;
        }
        private bool ValidarExiste(string aux)
        {
            if (EmpleadosBLL.GetListaCedula(aux).Count() > 0)
            {
                MessageBox.Show("Este cedula de Empleado ya existe, favor intentar con otra Cedula o modificar ...");
                return false;
            }
            return true;
        }

        private bool ValidarBuscar()
        {
            if (EmpleadosBLL.Buscar(Utilidades.ToInt(EmpleadoIdtextBox.Text)) == null)
            {
                MessageBox.Show("Este registro no existe");
                return false;
            }

            return true;


        }
        private bool validarId(string message)
        {
            if (string.IsNullOrEmpty(EmpleadoIdtextBox.Text))
            {

                MessageBox.Show(message);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        public void Limpiar()
        {
            DateTimePicker f = new DateTimePicker();
            EmpleadoIdtextBox.Clear();
            NombretextBox.Clear();
            CedulamaskedTextBox.Clear();
            DirecciontextBox.Clear();
            CiudadcomboBox.Text = "Elegir Su Ciudad";
            TelefonomaskedTextBox1.Clear();
            CelularmaskedTextBox2.Clear();
            FechaNacimientomaskedTextBox.Clear();
            MasculinocheckBox.Checked = false;
            FemeninocheckBox.Checked = false;
            FechadateTimePicker.Value = f.Value;
            //-----
            limpiarErroresProvider();

        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Empleados empleado = new Empleados();
            BuscarerrorProvider.Clear();
            LlenarClase(empleado);
            if (ValidarTextbox() && ValidarExiste(CedulamaskedTextBox.Text))
            {
                EmpleadosBLL.Insertar(empleado);
                Limpiar();
                limpiarErroresProvider();
                MessageBox.Show("-_-Guardado Con Exito-_-");
            }
        }
        private void LlenarClase(Empleados e)
        {

            e.Nombre = NombretextBox.Text;
            e.Cedula = CedulamaskedTextBox.Text;
            e.Ciudad = CiudadcomboBox.Text;
            e.Direccion = DirecciontextBox.Text;
            e.FechaNacimiento = FechaNacimientomaskedTextBox.Text;
            e.Telefono = TelefonomaskedTextBox1.Text;
            e.Celular = CelularmaskedTextBox2.Text;
            if (MasculinocheckBox.Checked == true)
            {
                e.Sexo = "M";
            }
            else
            {
                if (FemeninocheckBox.Checked == true)

                    e.Sexo = "F";
                else

                    e.Sexo = "M";
            }

            e.FechaIngreso = FechadateTimePicker.Value;


        }


        private bool ValidarTextbox()
        {

            if (string.IsNullOrEmpty(NombretextBox.Text) &&
                string.IsNullOrEmpty(CedulamaskedTextBox.Text) &&
                 string.IsNullOrEmpty(FechaNacimientomaskedTextBox.Text) &&
                string.IsNullOrEmpty(CiudadcomboBox.Text) &&
                string.IsNullOrEmpty(DirecciontextBox.Text) &&
                string.IsNullOrEmpty(TelefonomaskedTextBox1.Text) &&
                string.IsNullOrEmpty(CelularmaskedTextBox2.Text)

                )
            {
                NombreerrorProvider.SetError(NombretextBox, "Favor Ingresar el Nombre de Empleado");
                CedulaerrorProvider.SetError(CedulamaskedTextBox, "Favor Ingresar la Cedula Empleado");
                FechaNacimientoerrorProvider.SetError(FechaNacimientomaskedTextBox, "Favor Ingresar la Cedula Empleado");
                CiudaderrorProvider.SetError(CiudadcomboBox, "Favor Ingresar la Ciudad actual de donde recide el Empleado");
                DireccionerrorProvider.SetError(DirecciontextBox, "Favor Ingresar la Dirrecion de la ciudad de donde esta el Empleado");
                TelefonoerrorProvider.SetError(TelefonomaskedTextBox1, "Favor Ingresar el Numero de Telefono Recidencia del Empleado");
                MessageBox.Show("Favor llenar todos los campos obligatorios");

            }
            if (string.IsNullOrEmpty(NombretextBox.Text))
            {
                NombreerrorProvider.Clear();
                NombreerrorProvider.SetError(NombretextBox, "Favor ingresar el Nombre del Empleado");
                return false;
            }


            if (string.IsNullOrEmpty(CedulamaskedTextBox.Text))
            {
                CedulaerrorProvider.Clear();
                CedulaerrorProvider.SetError(CedulamaskedTextBox, "Favor ingresar el Numero de Cedula de Identidad");
                return false;
            }
            if (string.IsNullOrEmpty(FechaNacimientomaskedTextBox.Text))
            {
                FechaNacimientoerrorProvider.Clear();
                FechaNacimientoerrorProvider.SetError(FechaNacimientomaskedTextBox, "Favor ingresar la Fecha nacimiento");
                return false;
            }
            if (string.IsNullOrEmpty(CiudadcomboBox.Text))
            {
                CiudaderrorProvider.Clear();
                CiudaderrorProvider.SetError(CiudadcomboBox, "Favor ingrese la Ciudad que Actual de Empleado");
                return false;
            }
            if (string.IsNullOrEmpty(DirecciontextBox.Text))
            {
                DireccionerrorProvider.Clear();
                DireccionerrorProvider.SetError(DirecciontextBox, "Favor ingrese la dirrecion de la ciudad de donde vive Empleado");
                return false;
            }

            if (string.IsNullOrEmpty(TelefonomaskedTextBox1.Text))
            {
                TelefonoerrorProvider.Clear();
                TelefonoerrorProvider.SetError(TelefonomaskedTextBox1, "Favor ingrese el numero telefono de su Recidencia");
                return false;
            }


            if (MasculinocheckBox.Checked == false && FemeninocheckBox.Checked == false)
            {
                SexoerrorProvider.SetError(SexogroupBox, "Seleccionar sexo");
                return false;
            }




            return true;
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor digitar el id del Cliente que desea eliminar") && ValidarBuscar())
            {
                EmpleadosBLL.Eliminar(Utilidades.ToInt(EmpleadoIdtextBox.Text));
                Limpiar();
                MessageBox.Show("ELiminado con exito");
            }

        }
        private void limpiarErroresProvider()
        {
            BuscarerrorProvider.Clear();
            NombreerrorProvider.Clear();
            FechaNacimientoerrorProvider.Clear();
            CedulamaskedTextBox.Clear();
            SexoerrorProvider.Clear();
            CiudaderrorProvider.Clear();
            DireccionerrorProvider.Clear();
            TelefonoerrorProvider.Clear();
            CedularerrorProvider.Clear();

        }

        private void Editarbutton_Click(object sender, EventArgs e)
        {
            Empleados empleado = new Empleados();
            if (validarId("Favor Buscar el Id para que desea actualizar") && ValidarTextbox())
            {

                LlenarClase(empleado);
                if (ValidarExiste(CedulamaskedTextBox.Text))
                {
                    EmpleadosBLL.Modificar(Utilidades.ToInt(EmpleadoIdtextBox.Text), empleado);
                    Limpiar();
                    limpiarErroresProvider();
                    MessageBox.Show("Actualizado con exito");
                }

            }
        }
    }
}
