using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos {
    /// <summary>
    /// Variables globales usadas para registrar quien es el usuario logueado, nombre del usuario, etc.
    /// </summary>
    public class VariablesGlobales {
        public static string NombreUsuarioLogeado;
        public static int IdUsuarioLogeado;
        public static string NombreEmpleado;
        public static string Prenda;
        public static string CantidadPrendas;
        public static string Descripcion;
        public static string PrecioU;
        public static string Total;
        public static string Importe;
        public static string Cliente;
        public static string IdSolicitud;
    }
}
