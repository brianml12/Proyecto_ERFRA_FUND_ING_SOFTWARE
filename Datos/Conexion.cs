using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Datos {
    public class Conexion {
        public static MySqlConnection conexion;
        static string usuario = "root";
        static string password = "root";
        static string bd = "erfra";
        static string servidor = "localhost";
        static string puerto = "3306";

        /// <summary>
        /// Método usado para la conexión a la base de datos
        /// </summary>
        /// <returns>Retorna true si la conexión fue exitosa y no en caso contrario</returns>
        public static bool conectar() {
            try {
                conexion = new MySqlConnection("Database=" + bd + ";Data Source=" + servidor + ";Port=" + puerto + ";User Id=" + usuario + ";Password=" + password);
                conexion.Open();
                return true;
            }
            catch (Exception) {
                return false;
            }
        }

        /// <summary>
        /// Método usado para desconectarse de la base de datos
        /// </summary>
        public static void desconectar() {
            try {
                conexion.Close();
            }
            catch (Exception) {
            }
        }
    }
}
