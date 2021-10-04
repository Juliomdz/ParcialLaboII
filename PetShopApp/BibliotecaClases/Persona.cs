using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public abstract class Persona
    {
        private string nombre;
        private string apellido;
        private long dni;

        protected Persona(string nombre, string apellido, long dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }
        #region propiedades
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                if (IsValidName(value))
                {
                    this.nombre = value;
                }
            }
        }
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                if (IsValidName(value))
                {
                    this.apellido = value;
                }
            }
        }
        public long Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                if (ValidarDni(value))
                {
                    this.dni = value;
                }
            }
        }
        #endregion
        /// <summary>
        /// Valida que el DNI ingresado sean 8 numeros.
        /// </summary>
        /// <param name="dni"> el DNI recibido como 'long'</param>
        /// <returns></returns>
        public static bool ValidarDni(long dni)
        {
            long dniAux;

            if ((dni.ToString().Length == 8) && (long.TryParse(dni.ToString(), out dniAux)))
                {
                    //dni = dniAux;
                    return true;
                }
            return false;
        }
        /// <summary>
        /// Valida que el string recibido sea un nombre valido.
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public static bool IsValidName(string nombre)
        {
            foreach (char letra in nombre)
            {
                if (!Char.IsLetter(letra) && letra != ' ')
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
