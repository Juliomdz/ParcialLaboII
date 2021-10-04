using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaClases;

namespace Vista
{
    public static class Listas
    {
        public static List<Empleado> empleados;
        public static List<Administrador> administradores;
        public static List<Usuario> usuarios;
        public static List<Cliente> clientes;
        public static List<Producto> productos;
        public static List<Venta> ventas;
        public static List<Empleado> Empleados
        {
            get
            { return empleados; }
            set
            { empleados = value; }
        }
        /// <summary>
        /// Metodo que carga los empleados Hardcodeados a una lista.
        /// </summary>
        public static void CargaEmpleadosHardcodeados()
        {
            empleados = new List<Empleado>();



            empleados.Add(new Empleado("Jorge", "Carrascal", 30000001, "Carrasca", "bailecito"));
            empleados.Add(new Empleado("Julian", "Alvarez", 30000002, "Araña", "goles"));
            empleados.Add(new Empleado("Enzo", "Perez", 30000003, "Capitan", "91218"));
            empleados.Add(new Empleado("Franco", "Armani", 30000004, "Pulpo", "yonotecomo"));
        }
        /// <summary>
        /// Metodo que carga los clientes hardcodeados a una lista.
        /// </summary>
        public static void CargaClientesHardcodeados()
        {
            clientes = new List<Cliente>();

            Dictionary<TipoProducto, int> comprasTevez = new Dictionary<TipoProducto, int>();

            comprasTevez.Add(TipoProducto.Alimento, 2);
            comprasTevez.Add(TipoProducto.Juguetes, 1);
            comprasTevez.Add(TipoProducto.Farmacia, 5);

            clientes.Add(new Cliente("Carlos", "Tevez", 20000001, comprasTevez, (decimal)15000));

            Dictionary<TipoProducto, int> comprasRojo = new Dictionary<TipoProducto, int>();

            comprasRojo.Add(TipoProducto.Alimento, 2);
            comprasRojo.Add(TipoProducto.Juguetes, 3);

            clientes.Add(new Cliente("Marcos", "Rojo", 20000002, comprasRojo, (decimal)10000));

            Dictionary<TipoProducto, int> comprasAndrada = new Dictionary<TipoProducto, int>();

            comprasAndrada.Add(TipoProducto.Aseo, 1);
            comprasAndrada.Add(TipoProducto.Farmacia, 2);

            clientes.Add(new Cliente("Esteban", "Andrada", 20000003, comprasAndrada, (decimal)8000));

            Dictionary<TipoProducto, int> comprasSalvio = new Dictionary<TipoProducto, int>();

            comprasSalvio.Add(TipoProducto.Juguetes, 2);
            comprasSalvio.Add(TipoProducto.Aseo, 3);

            clientes.Add(new Cliente("Eduardo", "Salvio", 20000004, comprasSalvio, (decimal)12000));
        }

        /// <summary>
        /// Metodo que carga los administradores hardcodeados a una lista.
        /// </summary>
        public static void CargaAdministradoresHardcodeados()
        {
            administradores = new List<Administrador>();


            administradores.Add(new Administrador("Marcelo", "Gallardo", 25111111, "Napoleon", "el3estuvodemas"));
            administradores.Add(new Administrador("Matias", "Biscay", 25222222, "Maquiavelo", "yogane2finales"));
        }
        /// <summary>
        /// Metodo que carga los productos hardcodeados a una lista.
        /// </summary>
        public static void CargaProductosHardcodeados()
        {
            productos = new List<Producto>();


            productos.Add(new Producto("Shampoo", "Shampoo para mascotas.", 40, TipoProducto.Aseo, 800));
            productos.Add(new Producto("Acondicionador", "Acondicionador para mascotas.", 40, TipoProducto.Aseo, 900));
            productos.Add(new Producto("Dogui", "Alimento balanceado para perros por KG.", 200, TipoProducto.Alimento, 400));
            productos.Add(new Producto("Gati", "Alimento balanceado para gatos por KG.", 200, TipoProducto.Alimento, 400));
            productos.Add(new Producto("Pelota Piola", "Pelota saltarina para perros.", 30, TipoProducto.Juguetes, 200));
            productos.Add(new Producto("ScratchMaster 2000", "Palo rascador profesional para gatos.", 15, TipoProducto.Juguetes, 1500));
            productos.Add(new Producto("ChauPulga", "Pipeta anti pulgas y garrapatas.", 500, TipoProducto.Farmacia, 1900));
            productos.Add(new Producto("don't Wormies, be happy.", "Pastilla antiparasitaria.", 400, TipoProducto.Farmacia, 1300));
        }
        /// <summary>
        /// Metodo que carga las ventas hardcodeadas a una lista.
        /// </summary>
        public static void CargaVentasHardcodeadas()
        {
            ventas = new List<Venta>();

            //tevez
            ventas.Add(new Venta(2, productos[2], clientes[0]));
            ventas.Add(new Venta(1, productos[4], clientes[0]));
            ventas.Add(new Venta(5, productos[7], clientes[0]));
            //rojo
            ventas.Add(new Venta(2, productos[3], clientes[1]));
            ventas.Add(new Venta(3, productos[5], clientes[1]));
            //andrada
            ventas.Add(new Venta(1, productos[0], clientes[2]));
            ventas.Add(new Venta(2, productos[6], clientes[2]));
            //salvio
            ventas.Add(new Venta(2, productos[4], clientes[3]));
            ventas.Add(new Venta(3, productos[1], clientes[3]));
        }
        /// <summary>
        /// Metodo que carga las listas hardcodeadas a las listas estaticas.
        /// </summary>
        public static void CargarDatosHardcodeados()
        {
            CargaAdministradoresHardcodeados();
            CargaEmpleadosHardcodeados();
            CargaClientesHardcodeados();
            CargaProductosHardcodeados();
            CargaVentasHardcodeadas();
        }
        /// <summary>
        /// Metodo que carga los empleados y los administradores a una lista combinada de Usuarios.
        /// </summary>
        public static List<Usuario> UnirListas()
        {
            usuarios = new List<Usuario>();
            usuarios.AddRange(empleados);
            usuarios.AddRange(administradores);
            return usuarios;
        }
    }
}

