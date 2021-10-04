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
    public partial class frmMainMenuAdmin : Form
    {
        public frmMainMenuAdmin()
        {
            InitializeComponent();
        }
        public frmMainMenuAdmin(string nombreReal) : this()
        {
            this.lblTitulo.Text = $"Menu Administrador, hola {nombreReal}!";
        }

        #region Botones hacia los nuevos formularios
        private void btnClientes_Click(object sender, EventArgs e)
        {
            if (pnlClientes.Visible == false)
            {
                pnlClientes.Visible = true;
            }
            else
            {
                pnlClientes.Visible = false;
            }
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            if (pnlEmpleados.Visible == false)
            {
                pnlEmpleados.Visible = true;
            }
            else
            {
                pnlEmpleados.Visible = false;
            }
        }

        private void btnAdministradores_Click(object sender, EventArgs e)
        {
            if (pnlAdministradores.Visible == false)
            {
                pnlAdministradores.Visible = true;
            }
            else
            {
                pnlAdministradores.Visible = false;
            }
        }



        private void btnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            frmCrearEmpleado menuNuevoEmpleado = new frmCrearEmpleado();
            menuNuevoEmpleado.ShowDialog();
        }

        private void btnNuevoAdministrador_Click(object sender, EventArgs e)
        {
            frmCrearAdministrador menuNuevoAdministrador = new frmCrearAdministrador();
            menuNuevoAdministrador.ShowDialog();
        }

        private void btnRegistroVentas_Click(object sender, EventArgs e)
        {
            frmRegistroVentas registroVentas = new frmRegistroVentas();
            registroVentas.ShowDialog();
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

        private void btnBorrarAdministrador_Click(object sender, EventArgs e)
        {
            frmBorrarAdministrador menuBorrarAdministrador = new frmBorrarAdministrador();
            menuBorrarAdministrador.ShowDialog();
        }

        private void btnBorrarEmpleado_Click(object sender, EventArgs e)
        {
            frmBorrarEmpleado menuBorrarEmpleado = new frmBorrarEmpleado();
            menuBorrarEmpleado.ShowDialog();
        }

        private void btnBorrarCliente_Click(object sender, EventArgs e)
        {
            frmBorrarCliente menuBorrarCliente = new frmBorrarCliente();
            menuBorrarCliente.ShowDialog();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            frmMenuProductos menuProductos = new frmMenuProductos();
            menuProductos.ShowDialog();
        }

        private void btnModificarEmpleado_Click(object sender, EventArgs e)
        {
            frmModificarEmpleado menuModificarEmpleado = new frmModificarEmpleado();
            menuModificarEmpleado.ShowDialog();
        }
        #endregion

        #region VisualStudio Auto-Generated Code
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion
    }
}
