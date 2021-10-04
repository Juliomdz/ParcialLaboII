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
    public partial class frmRegistroVentas : Form
    {
        static public List<VentaSimplificada> ventasSimplificadas;

        public frmRegistroVentas()
        {

            InitializeComponent();
            ObtenerListas();
            ObtenerTotal();
        }
        /// <summary>
        /// Toma la lista de ventas y arma una lista simplificada para poder mostrarla en los ListBoxes.
        /// </summary>
        private void ObtenerListas()
        {
            double auxTotalGastado = 0;
            ventasSimplificadas = new List<VentaSimplificada>();
            foreach (Venta venta in Listas.ventas)
            {
                foreach (Producto producto in Listas.productos)
                {
                    if (venta.producto.nombre == producto.nombre)
                    {
                        auxTotalGastado = producto.precio * venta.cantidad;
                    }
                }
                VentaSimplificada ventaSimplificada = new VentaSimplificada(venta.cliente.Nombre,
                    venta.cliente.Apellido, venta.producto.nombre, venta.cantidad, venta.cliente.Dni, auxTotalGastado);
                ventasSimplificadas.Add(ventaSimplificada);
                lbxNombre.Items.Add(ventaSimplificada.nombreCliente);
                lbxApellido.Items.Add(ventaSimplificada.apellidoCliente);
                lbxDni.Items.Add(ventaSimplificada.dni);
                lbxProducto.Items.Add(ventaSimplificada.producto);
                lbxCantidad.Items.Add(ventaSimplificada.cantidad);
                lbxFacturado.Items.Add(ventaSimplificada.facturado);
            }
        }
        /// <summary>
        /// Calcula el total facturado en todas las ventas hasta el momento.
        /// </summary>
        private void ObtenerTotal()
        {
            int asdasd = 0;
            for (int i = 1; i < lbxFacturado.Items.Count; i++)
            {
                asdasd += Int32.Parse(lbxFacturado.Items[i].ToString());
            }
            txtbTotal.Text = asdasd.ToString();


        }
        public class VentaSimplificada
        {
            public string nombreCliente;
            public string apellidoCliente;
            public string producto;
            public int cantidad;
            public long dni;
            public double facturado;

            public VentaSimplificada()
            {
            }

            public VentaSimplificada(string nombreCliente, string apellidoCliente, string producto, int cantidad, long dni, double facturado)
            {
                this.nombreCliente = nombreCliente;
                this.apellidoCliente = apellidoCliente;
                this.producto = producto;
                this.cantidad = cantidad;
                this.dni = dni;
                this.facturado = facturado;
            }
        }
        #region VisualStudio Auto-Generated Code
        private void grvListaVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lsbVentas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbxFacturado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
