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
    public partial class frmCrearCliente : Form
    {

        public frmCrearCliente()
        {
            InitializeComponent();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarCliente())
            {
                AltaCliente();
            }
        }
        /// <summary>
        /// Da de alta un nuevo cliente agregandolo a la lista.
        /// </summary>
        private void AltaCliente()
        {
            List<Cliente> clientes = Listas.clientes;
            Cliente clienteNuevo = new Cliente(txtbNombre.Text, txtbApellido.Text, Int32.Parse(txtbDni.Text));
            clientes.Add(clienteNuevo);
            Listas.clientes = clientes;
            MessageBox.Show($"{txtbNombre.Text} {txtbApellido.Text} Dado de alta correctamente.");
            this.Close();
        }
        /// <summary>
        /// Valida que los datos de los ListBoxes sean validos para un Cliente.
        /// </summary>
        /// <returns></returns>
        private bool ValidarCliente()
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




