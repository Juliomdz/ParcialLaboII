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
    public partial class frmAltaProducto : Form
    {

        public frmAltaProducto()
        {
            InitializeComponent();
            CargaComboBoxTipo();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarProducto())
            {
                AltaProducto();
            }
        }
        /// <summary>
        /// Da de alta un producto con los datos ingresados en los textboxes.
        /// </summary>
        private void AltaProducto()
        {
            List<Producto> productos = Listas.productos;
            Producto productoNuevo = new Producto(txtbNombre.Text, txtbDescripcion.Text, Int32.Parse(txtbStock.Text), (TipoProducto)cmbTipoProducto.SelectedIndex, Int32.Parse(txtbPrecio.Text));
            productos.Add(productoNuevo);
            Listas.productos = productos;
            MessageBox.Show($"{txtbNombre.Text} Dado de alta correctamente.");
            this.Close();
        }
        /// <summary>
        /// Valida que los campos ingresados correspondan a datos validos para un producto.
        /// </summary>
        /// <returns></returns>
        private bool ValidarProducto()
        {
            int auxNumeros;
            if (!Producto.IsValidNombreProducto(txtbNombre.Text))
            {
                MessageBox.Show($"Nombre ingresado Invalido.");
                return false;
            }
            if (txtbDescripcion.Text == "")
            {
                MessageBox.Show($"Descripcion Invalida.");
                return false;
            }
            if (!(Int32.TryParse(txtbStock.Text, out auxNumeros) && auxNumeros > 0))
            {
                MessageBox.Show("Stock ingresado Invalido.");
                return false;
            }
            if (!(Int32.TryParse(txtbPrecio.Text, out auxNumeros) && auxNumeros > 0))
            {
                MessageBox.Show("Precio ingresado invalido.");
                return false;
            }
            return true;
        }
        /// <summary>
        /// Carga los comboBox con los tipos de productos validos.
        /// </summary>
        private void CargaComboBoxTipo()
        {
            cmbTipoProducto.Items.Add(TipoProducto.Alimento);
            cmbTipoProducto.Items.Add(TipoProducto.Juguetes);
            cmbTipoProducto.Items.Add(TipoProducto.Aseo);
            cmbTipoProducto.Items.Add(TipoProducto.Farmacia);
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




