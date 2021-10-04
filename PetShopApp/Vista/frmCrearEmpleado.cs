using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaClases;

namespace Vista
{
    public partial class frmCrearEmpleado : Form
    {

        public frmCrearEmpleado()
        {
            InitializeComponent();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarEmpleado())
            {
                AltaEmpleado();
            }
        }
        /// <summary>
        /// da de alta un nuevo empleado agregandolo a la lista.
        /// </summary>
        private void AltaEmpleado()
        {
            List<Empleado> empleados = Listas.Empleados;
            Empleado empleadoNuevo = new Empleado(txtbNombre.Text, txtbApellido.Text, Int32.Parse(txtbDni.Text), txtbUser.Text, txtbPassword.Text);
            empleados.Add(empleadoNuevo);
            Listas.Empleados = empleados;
            MessageBox.Show($"{txtbNombre.Text} {txtbApellido.Text} Dado de alta correctamente.");
            this.Close();
        }
        /// <summary>
        /// Valida que los datos de los ListBoxes sean validos para un empleado.
        /// </summary>
        /// <returns></returns>
        private bool ValidarEmpleado()
        {
            if (!Persona.IsValidName(txtbNombre.Text))
            {
                MessageBox.Show($"Nombre ingresado Invalido.");
                return false;
            }
            if (!Persona.IsValidName(txtbApellido.Text))
            {
                MessageBox.Show($"Apellido ingresado Invalido.");
                return false;
            }
            if (!Persona.ValidarDni(Int32.Parse(txtbDni.Text)))
            {
                MessageBox.Show($"DNI ingresado Invalido.");
                return false;
            }
            if (!Persona.IsValidName(txtbUser.Text))
            {
                MessageBox.Show($"Usuario ingresado Invalido.");
                return false;
            }
            if ((txtbReingresePassword.Text != txtbPassword.Text))
            {
                MessageBox.Show($"ERROR. Ambas contraseñas deben coincidir.");
                return false;
            }
            return true;
        }
        #region VisualStudio Auto-Generated Code

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lblAutocompletarUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        #endregion

    }
}




