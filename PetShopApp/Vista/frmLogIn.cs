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
    public partial class frmLogIn : Form
    {
        static List<Empleado> empleados = Listas.Empleados;
        static List<Administrador> administradores = Listas.administradores;
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string nombreReal;
            switch (AuthUser(out nombreReal))
            {
                case 'A':
                    adminLogIn(nombreReal);
                    break;
                case 'E':
                    empleadoLogIn(nombreReal);
                    break;
            }
        }

        /// <summary>
        /// Verifica que se haya ingresado con un usuario valido y lo identifica como Administrador o Empleado y recibe el nombre.
        /// </summary>
        /// <param name="nombreReal">El nombre real del usuario para saludarlo en el menu</param>
        /// <returns></returns>
        private char AuthUser(out string nombreReal)
        {
            string auxUsuario = this.txtbUser.Text;
            string auxPassword = this.txtbPassword.Text;

            foreach (Administrador administrador in administradores)
            {
                if (auxUsuario == administrador.nombreDeUsuario && auxPassword == administrador.password)
                {
                    nombreReal = administrador.Nombre;
                    return 'A';
                }
            }
            foreach (Empleado empleado in empleados)
            {
                if (auxUsuario == empleado.nombreDeUsuario && auxPassword == empleado.password)
                {
                    nombreReal = empleado.Nombre;
                    return 'E';
                }

            }
            MessageBox.Show("Usuario y/o Contraseña Incorrectas.");
            this.txtbPassword.Text = "";
            this.txtbUser.Text = string.Empty;
            nombreReal = "";
            return 'N';
        }
        /// <summary>
        /// Inicia el formulario de menu administrador y le pasa el nombre del usuario logueado.
        /// </summary>
        /// <param name="nombreReal">el nombre real para ser saludado</param>
        private void adminLogIn(string nombreReal)
        {
            MessageBox.Show($"Ingreso valido como Administrador.");
            frmMainMenuAdmin menuAdmin = new frmMainMenuAdmin(nombreReal);
            txtbPassword.Clear();
            menuAdmin.ShowDialog();
        }
        /// <summary>
        /// Inicia el formulario de menu de empleados y le pasa el nombre del usuario logueado.
        /// </summary>
        /// <param name="nombreReal">el nombre real para ser saludado</param>
        private void empleadoLogIn(string nombreReal)
        {
            MessageBox.Show($"Ingreso valido como Empleado.");
            frmMainMenuEmpleado menuEmpleado = new frmMainMenuEmpleado(nombreReal);
            txtbPassword.Clear();
            menuEmpleado.ShowDialog();
        }
        /// <summary>
        /// selecciona un administrador valido al azar y completa los campos del Log In.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Random random = new Random();
            int index = random.Next(administradores.Count);
            this.txtbUser.Text = administradores[index].nombreDeUsuario;
            this.txtbPassword.Text = administradores[index].password;
        }
        /// <summary>
        /// selecciona un empleado al azar y completa los campos del Log In.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblAutocompletarUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Random random = new Random();
            int index = random.Next(empleados.Count);
            this.txtbUser.Text = empleados[index].nombreDeUsuario;
            this.txtbPassword.Text = empleados[index].password;
        }
    }
}

