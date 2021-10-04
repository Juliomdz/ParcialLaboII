using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public enum TipoProducto { Alimento = 0, Juguetes = 1, Aseo = 2, Farmacia = 3 }
    public sealed class Producto
    {
        public string nombre;
        public long id;
        public string descripcion;
        public int stock;
        public TipoProducto tipo;
        public double precio;

        public Producto(string nombre, string descripcion, int stock, TipoProducto tipo, double precio)
        {
            this.nombre = nombre;
            this.id = Producto.contadorId;
            this.descripcion = descripcion;
            this.stock = stock;
            this.tipo = tipo;
            this.precio = precio;
            Producto.contadorId += 1;
        }
        private static int contadorId = 1;

        /// <summary>
        /// Valida que el nombre del producto no contenga caracteres extraños.
        /// </summary>
        /// <param name="nombre">el nombre a validar</param>
        /// <returns></returns>
    public static bool IsValidNombreProducto(string nombre)
    {
        foreach (char letra in nombre)
        {
            if (!Char.IsLetter(letra))
            {
                return false;
            }
            else
            {
                continue;
            }
        }
        return true;
    }
}
}
