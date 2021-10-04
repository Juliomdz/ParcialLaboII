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
    public partial class frmMainMenuEmpleado : Form
    {
        public frmMainMenuEmpleado()
        {
            InitializeComponent();
        }
        public frmMainMenuEmpleado(string nombreReal) : this()
        {
            this.lblTitulo.Text = $"Menu Administrador, hola {nombreReal}!";
        }

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            frmNuevaVenta nuevaVenta = new frmNuevaVenta();
            nuevaVenta.ShowDialog();
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            frmCrearCliente menuNuevoCliente = new frmCrearCliente();
            menuNuevoCliente.ShowDialog();
        }
        #region controles heredados sin uso
        private void btnBorrarAdministrador_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrarEmpleado_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrarCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {

        }

        private void btnModificarEmpleado_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
        }

        private void btnAdministradores_Click(object sender, EventArgs e)
        {
        }

        private void btnNuevoEmpleado_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevoAdministrador_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistroVentas_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
