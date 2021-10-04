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
    public partial class frmNuevaVenta : Form
    {

        public frmNuevaVenta()
        {
            InitializeComponent();
            CargaComboBoxClientes();
            CargaComboBoxProductos();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"El costo total es de ${CalcularPrecioFinal()} ¿Confirma la venta?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                RealizarVenta();
            }
            else if (result == DialogResult.No)
            {
                this.Close();
            }
            else
            {

            }
        }
        /// <summary>
        /// Suma los gastos de la venta al total consumido por el cliente.
        /// </summary>
        private void SumarGastosAlCliente()
        {
            decimal auxPrecioFinal = (decimal)CalcularPrecioFinal();
            Listas.clientes[cmbCliente.SelectedIndex].totalGastado += auxPrecioFinal;
        }
        /// <summary>
        /// Calcula el precio final de la venta al multiplicar cantidad por precio.
        /// </summary>
        /// <returns></returns>
        private double CalcularPrecioFinal()
        {
            return Listas.productos[cmbProducto.SelectedIndex].precio * Int32.Parse(txtbCantidad.Text);
        }
        /// <summary>
        /// Carga el comboBox con los datos de todos los clientes dados de alta.
        /// </summary>
        private void CargaComboBoxClientes()
        {
            foreach (Cliente cliente in Listas.clientes)
            {
                StringBuilder stringBuild = new StringBuilder();
                stringBuild.Append(cliente.Nombre);
                stringBuild.Append(" ");
                stringBuild.Append(cliente.Apellido);
                stringBuild.Append(" - ");
                stringBuild.Append(cliente.Dni);
                cmbCliente.Items.Add(stringBuild);
            }
        }
        /// <summary>
        /// Carga el comboBox con los datos de todos los productos dados de alta.
        /// </summary>
        private void CargaComboBoxProductos()
        {
            foreach (Producto producto in Listas.productos)
            {
                StringBuilder stringBuild = new StringBuilder();
                stringBuild.Append(producto.tipo);
                stringBuild.Append(" - ");
                stringBuild.Append(producto.nombre);
                stringBuild.Append(" - $");
                stringBuild.Append(producto.precio);
                cmbProducto.Items.Add(stringBuild);
            }
        }
        /// <summary>
        /// Verifica que se pueda realizar la venta al contar con suficiente stock, y luego realiza la venta agregandola al registro.
        /// </summary>
        private void RealizarVenta()
        {
            int auxStock;
            if (Int32.TryParse(txtbCantidad.Text, out auxStock) && Listas.productos[cmbProducto.SelectedIndex].stock >= auxStock)
            {
                Venta nuevaVenta = new Venta(auxStock, Listas.productos[cmbProducto.SelectedIndex], Listas.clientes[cmbCliente.SelectedIndex]);
                Listas.ventas.Add(nuevaVenta);
                Console.Beep();
                MessageBox.Show("Venta realizada Correctamente!");
                SumarGastosAlCliente();
            }
            else
            {
                MessageBox.Show("No hay suficiente stock para realizar esta venta!");
            }
            //Listas.productos[cmbProducto.SelectedIndex];
            //cmbCliente.SelectedIndex;
        }
        #region VisualStudio Auto-Generated Code
        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

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




