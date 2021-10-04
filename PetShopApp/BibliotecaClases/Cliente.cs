using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public sealed class Cliente : Persona
    {
        public Dictionary<TipoProducto, int> listaProductosComprados;
        public decimal totalGastado;

        public Cliente(string nombre, string apellido, long dni) : base(nombre, apellido, dni)
        {
        }
        public Cliente(string nombre, string apellido, long dni, Dictionary<TipoProducto, int> listaProductosComprados,
                decimal totalGastado) : this(nombre, apellido, dni)
        {
            {
                this.totalGastado = totalGastado;
                this.listaProductosComprados = listaProductosComprados;
            }
        }
    }
}
