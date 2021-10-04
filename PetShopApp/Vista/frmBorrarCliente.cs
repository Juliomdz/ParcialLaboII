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
    public partial class frmBorrarCliente : Form
    {
        public frmBorrarCliente()
        {
            InitializeComponent();
            ObtenerListas();
        }
        /// <summary>
        /// Carga los ListBoxes con los datos de los clientes en la lista.
        /// </summary>
        private void ObtenerListas()
        {
            foreach (Cliente cliente in Listas.clientes)
            {
                lbxNombre.Items.Add(cliente.Nombre);
                lbxApellido.Items.Add(cliente.Apellido);
                lbxDni.Items.Add(cliente.Dni);
                lbxTotalGastado.Items.Add(cliente.totalGastado.ToString());
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

                foreach (Cliente cliente in Listas.clientes)
                {
                    if (cliente.Dni == auxDni && PedirConfirmacion())
                    {
                        Listas.clientes.Remove(cliente);
                        LimpiarListas();
                        ObtenerListas();
                        MessageBox.Show($"El cliente DNI:{cliente.Dni} fue eliminado.");
                        return true;
                    }
                }
                MessageBox.Show("el DNI ingresado no coincide con ningun cliente. " +
                    "Verifique que el cliente que desea eliminar se encuentra en la lista de la izquierda.");
                return false;
            }
            MessageBox.Show("DNI ingresado invalido.");
            return false;
        }
        /// <summary>
        /// Solicita confirmacion al usuario para la eliminacion del Cliente.
        /// </summary>
        /// <returns></returns>
        private bool PedirConfirmacion()
        {
            DialogResult result = MessageBox.Show($"¿Confirma la eliminacion del cliente DNI:{txtbDni.Text}?", "Confirmation", MessageBoxButtons.YesNoCancel);
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
            lbxTotalGastado.Items.Clear();
            lbxNombre.Items.Add("NOMBRE");
            lbxApellido.Items.Add("APELLIDO");
            lbxDni.Items.Add("DNI");
            lbxTotalGastado.Items.Add("TOTAL GASTADO");
        }
    }
}
