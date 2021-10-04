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
    public partial class frmBorrarAdministrador : Form
    {
        public frmBorrarAdministrador()
        {
            InitializeComponent();
            ObtenerListas();
        }
        /// <summary>
        /// Carga los ListBoxes con los datos de los administradores en la lista.
        /// </summary>
        private void ObtenerListas()
        {
            foreach (Administrador admin in Listas.administradores)
            {
                lbxNombre.Items.Add(admin.Nombre);
                lbxApellido.Items.Add(admin.Apellido);
                lbxDni.Items.Add(admin.Dni);
                lbxUsuario.Items.Add(admin.nombreDeUsuario);
            }
        }
        /// <summary>
        /// Verifica que el DNI ingresado coincida con un admin valido de la lista y lo elimina.
        /// </summary>
        /// <returns></returns>
        private bool EliminarPorDni()
        {
            int auxDni;
            if (Int32.TryParse(txtbDni.Text, out auxDni))
            {

                foreach (Administrador admin in Listas.administradores)
                {
                    if (admin.Dni == auxDni && PedirConfirmacion())
                    {
                        Listas.administradores.Remove(admin);
                        LimpiarListas();
                        ObtenerListas();
                        MessageBox.Show($"El administrador DNI:{admin.Dni} fue eliminado.");
                        return true;
                    }
                }
                MessageBox.Show("el DNI ingresado no coincide con ningun administrador. " +
                    "Verifique que el administrador que desea eliminar se encuentra en la lista de la izquierda.");
                return false;
            }
            MessageBox.Show("DNI ingresado invalido.");
            return false;
        }
        /// <summary>
        /// Solicita confirmacion al usuario para la eliminacion del Admin.
        /// </summary>
        /// <returns></returns>
        private bool PedirConfirmacion()
        {
            DialogResult result = MessageBox.Show($"¿Confirma la eliminacion del Admin DNI:{txtbDni.Text}?", "Confirmation", MessageBoxButtons.YesNoCancel);
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
