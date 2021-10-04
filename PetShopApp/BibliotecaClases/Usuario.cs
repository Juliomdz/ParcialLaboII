using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public abstract class Usuario : Persona
    {
        public string nombreDeUsuario;
        public string password;
        public Usuario(string nombre, string apellido, long dni, string nombreDeUsuario, string password) : base(nombre, apellido, dni)
        {
            this.nombreDeUsuario = nombreDeUsuario;
            this.password = password;
        }

        #region validadores no implementados

        public static bool ValidarDNI(long dni)
        {
            return Persona.ValidarDni(dni);
        }
        public static bool ValidarUsuario(string usuario)
        {

            return true;
        }
        public static bool ValidarPassword(string password)
        {

            return true;
        }
        #endregion
    }
}
