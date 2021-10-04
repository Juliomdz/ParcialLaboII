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
    public partial class frmCrearAdministrador : Form
    {

        public frmCrearAdministrador()
        {
            InitializeComponent();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarAdministrador())
            {
                AltaAdministrador();
            }
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

        /// <summary>
        /// da de alta un nuevo administrador agregandolo a la lista.
        /// </summary>
        private void AltaAdministrador()
        {
            List<Administrador> administradores = Listas.administradores;
            Administrador AdministradorNuevo = new Administrador(txtbNombre.Text, txtbApellido.Text, Int32.Parse(txtbDni.Text), txtbUser.Text, txtbPassword.Text);
            administradores.Add(AdministradorNuevo);
            Listas.administradores = administradores;
            MessageBox.Show($"{txtbNombre.Text} {txtbApellido.Text} Dado de alta correctamente.");
            this.Close();
        }
        /// <summary>
        /// Valida que los datos de los ListBoxes sean validos para un administrador.
        /// </summary>
        /// <returns></returns>
        private bool ValidarAdministrador()
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
    }
}




