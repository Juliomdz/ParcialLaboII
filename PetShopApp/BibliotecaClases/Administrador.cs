using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public sealed class Administrador : Usuario
    {
        public Administrador(string nombre, string apellido, long dni, string nombreDeUsuario, string password) 
            : base(nombre, apellido, dni, nombreDeUsuario, password)
        {
        }
    }
}
