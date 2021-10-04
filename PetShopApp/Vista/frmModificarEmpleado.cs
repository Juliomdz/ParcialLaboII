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
    public partial class frmModificarEmpleado : Form
    {
        public frmModificarEmpleado()
        {
            InitializeComponent();
            ObtenerListas();
        }
        private void ObtenerListas()
        {
            foreach (Empleado empleado in Listas.empleados)
            {
                lbxNombre.Items.Add(empleado.Nombre);
                lbxApellido.Items.Add(empleado.Apellido);
                lbxDni.Items.Add(empleado.Dni);
                lbxUsuario.Items.Add(empleado.nombreDeUsuario);
            }
        }
        /// <summary>
        /// Verifica que exista un empleado con el DNI ingresado y llama a la funcion que carga sus datos en los textboxes.
        /// </summary>
        /// <returns></returns>
        private bool SeleccionarPorDni()
        {
            int auxDni;
            if (Int32.TryParse(txtbDni.Text, out auxDni))
            {

                foreach (Empleado empleado in Listas.empleados)
                {
                    if (empleado.Dni == auxDni)
                    {
                        CargarDatosTextboxes(empleado);
                        return true;
                    }
                }
                MessageBox.Show("el DNI ingresado no coincide con ningun empleado. " +
                    "Verifique que el empleado que desea modificar se encuentra en la lista de la izquierda.");
                return false;
            }
            MessageBox.Show("DNI ingresado invalido.");
            return false;
        }
        /// <summary>
        /// Carga los datos del empleado recibido en los textboxes
        /// </summary>
        /// <param name="empleado">Empleado recibido a cargar.</param>
        private void CargarDatosTextboxes(Empleado empleado)
        {
            txtbNombre.Text = empleado.Nombre;
            txtbApellido.Text = empleado.Apellido;
            txtbDniEmpleado.Text = empleado.Dni.ToString();
            txtbUser.Text = empleado.nombreDeUsuario;
            txtbPassword.Text = empleado.password;
            txtbReingresePassword.Text = empleado.password;
        }
        /// <summary>
        /// solicita confirmacion para la modificacion de los datos del empleado.
        /// </summary>
        /// <returns></returns>
        private bool PedirConfirmacion()
        {
            DialogResult result = MessageBox.Show($"¿Confirma la modificacion del Empleado DNI:{txtbDni.Text}?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btnSeleccionarDni_Click(object sender, EventArgs e)
        {
            SeleccionarPorDni();
        }
        /// <summary>
        /// Limpia las listboxes y vuelve a asignarles las etiquetas.
        /// </summary>
        private void LimpiarListas()

        {
            lbxNombre.Items.Clear();
            lbxApellido.Items.Clear();
            lbxDni.Items.Clear();
            lbxUsuario.Items.Clear();
            lbxNombre.Items.Add("NOMBRE");
            lbxApellido.Items.Add("APELLIDO");
            lbxDni.Items.Add("DNI");
            lbxUsuario.Items.Add("USUARIO");
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarEmpleado())
            {
                GuardarCambiosModificarEmpleado();
            }

        }
        /// <summary>
        /// Guarda los cambios en el empleado, borrando su estado anterior y agregandolo nuevamente modificado a la lista.
        /// </summary>
        /// <returns></returns>
        private bool GuardarCambiosModificarEmpleado()
        {
            {
                int auxDni;
                if (Int32.TryParse(txtbDniEmpleado.Text, out auxDni))
                {

                    foreach (Empleado empleado in Listas.empleados)
                    {
                        if (empleado.Dni == auxDni && PedirConfirmacion())
                        {
                            Listas.empleados.Remove(empleado);
                            LimpiarListas();
                            List<Empleado> empleados = Listas.Empleados;
                            Empleado empleadoModificado = new Empleado(txtbNombre.Text, txtbApellido.Text, Int32.Parse(txtbDniEmpleado.Text), txtbUser.Text, txtbPassword.Text);
                            empleados.Add(empleadoModificado);
                            Listas.Empleados = empleados;
                            ObtenerListas();
                            MessageBox.Show($"El empleado DNI:{empleado.Dni} fue modificado.");
                            CargarDatosTextboxes(empleado);
                            return true;
                        }
                    }
                    MessageBox.Show("el DNI ingresado no coincide con ningun empleado. " +
                        "Verifique que el empleado que desea modificar se encuentra en la lista de la izquierda.");
                    return false;
                }
                MessageBox.Show("DNI ingresado invalido.");
                return false;
            }


            return false;
        }
        /// <summary>
        /// Valida los datos del empleado en los txtboxes.
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
    }
}
