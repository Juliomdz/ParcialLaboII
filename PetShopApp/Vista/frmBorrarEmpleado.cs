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
    public partial class frmBorrarEmpleado : Form
    {
        public frmBorrarEmpleado()
        {
            InitializeComponent();
            ObtenerListas();
        }
        /// <summary>
        /// Carga los ListBoxes con los datos de los empleados en la lista.
        /// </summary>
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
        /// Verifica que el DNI ingresado coincida con un empleado valido de la lista y lo elimina.
        /// </summary>
        /// <returns></returns>
        private bool EliminarPorDni()
        {
            int auxDni;
            if (Int32.TryParse(txtbDni.Text, out auxDni))
            {

                foreach (Empleado empleado in Listas.empleados)
                {
                    if (empleado.Dni == auxDni && PedirConfirmacion())
                    {
                        Listas.empleados.Remove(empleado);
                        LimpiarListas();
                        ObtenerListas();
                        MessageBox.Show($"El empleado DNI:{empleado.Dni} fue eliminado.");
                        return true;
                    }
                }
                MessageBox.Show("el DNI ingresado no coincide con ningun empleado. " +
                    "Verifique que el empleado que desea eliminar se encuentra en la lista de la izquierda.");
                return false;
            }
            MessageBox.Show("DNI ingresado invalido.");
            return false;
        }
        /// <summary>
        /// Solicita confirmacion al usuario para la eliminacion del Empleado.
        /// </summary>
        /// <returns></returns>
        private bool PedirConfirmacion()
        {
            DialogResult result = MessageBox.Show($"¿Confirma la eliminacion del Empleado DNI:{txtbDni.Text}?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarPorDni();
        }
        /// <summary>
        /// Limpia los ListBoxes y vuelve a cargarle las etiquetas.
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
    }
}
