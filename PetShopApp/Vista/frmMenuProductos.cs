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
    public partial class frmMenuProductos : Form
    {
        public frmMenuProductos()
        {
            InitializeComponent();
            ObtenerListas();
        }
        /// <summary>
        /// Carga los listboxes con los datos de los productos en la lista de prodictos. 
        /// </summary>
        private void ObtenerListas()
        {
            foreach (Producto producto in Listas.productos)
            {
                lbxIdProducto.Items.Add(producto.id);
                lbxCategoria.Items.Add(producto.tipo);
                lbxNombre.Items.Add(producto.nombre);
                lbxDescripcion.Items.Add(producto.descripcion);
                lbxStock.Items.Add(producto.stock);
                lbxPrecio.Items.Add(producto.precio);
            }
        }
        /// <summary>
        /// Verifica que el ID de producto ingresado sea valido y lo elimina.
        /// </summary>
        /// <returns></returns>
        private bool EliminarPorId()
        {
            int auxId;
            if (Int32.TryParse(txtbId.Text, out auxId))
            {

                foreach (Producto producto in Listas.productos)
                {
                    if (producto.id == auxId && PedirConfirmacion())
                    {
                        Listas.productos.Remove(producto);
                        LimpiarListas();
                        ObtenerListas();
                        MessageBox.Show($"El producto ID:{producto.id} fue eliminado.");
                        return true;
                    }
                }
                MessageBox.Show("el ID ingresado no coincide con ningun producto. " +
                    "Verifique que el producto que desea eliminar se encuentra en la lista de la izquierda.");
                return false;
            }
            MessageBox.Show("ID ingresado invalido.");
            return false;
        }
        /// <summary>
        /// solicita confirmacion para la eliminacion de un producto.
        /// </summary>
        /// <returns></returns>
        private bool PedirConfirmacion()
        {
            DialogResult result = MessageBox.Show($"¿Confirma la eliminacion del Producto ID:{txtbId.Text}?",
                "Confirmation", MessageBoxButtons.YesNoCancel);
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
            EliminarPorId();
        }
        /// <summary>
        /// Limpia las listboxes y vuelve a colocar las etiquetas correspondientes.
        /// </summary>
        private void LimpiarListas()
        {
            lbxNombre.Items.Clear();
            lbxCategoria.Items.Clear();
            lbxIdProducto.Items.Clear();
            lbxDescripcion.Items.Clear();
            lbxPrecio.Items.Clear();
            lbxStock.Items.Clear();
            lbxNombre.Items.Add("NOMBRE");
            lbxCategoria.Items.Add("CATEGORIA");
            lbxIdProducto.Items.Add("ID");
            lbxDescripcion.Items.Add("DESCRIPCION");
            lbxStock.Items.Add("STOCK");
            lbxPrecio.Items.Add("PRECIO");
        }
        /// <summary>
        /// Abre el formulario de lata de producto y actualiza las listas.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            frmAltaProducto nuevoProducto = new frmAltaProducto();
            nuevoProducto.ShowDialog();
            LimpiarListas();
            ObtenerListas();
        }
    }
}
