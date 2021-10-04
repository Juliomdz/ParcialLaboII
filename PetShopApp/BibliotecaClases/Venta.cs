using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public sealed class Venta
    {
        public int cantidad;
        public Producto producto;
        public Cliente cliente;

        public Venta(int cantidad, Producto producto, Cliente cliente)
        {
            this.cantidad = cantidad;
            this.producto = producto;
            this.cliente = cliente;
        }
    }



}
