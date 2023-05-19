using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class Conexion
    {
        public static MySqlConnection conexion;
        static string usuario = "adminerfra";
        static string password = "tallererfra#12345";
        static string bd = "erfra";
        static string servidor = "erfraserver.mysql.database.azure.com";
        static string puerto = "3306";

        /// <summary>
        /// Método usado para la conexión a la base de datos
        /// </summary>
        /// <returns>Retorna true si la conexión fue exitosa y no en caso contrario</returns>
        public static bool conectar()
        {
            try
            {
                conexion = new MySqlConnection("Database=" + bd + ";Data Source=" + servidor + ";Port=" + puerto + ";User Id=" + usuario + ";Password=" + password);
                conexion.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Método usado para desconectarse de la base de datos
        /// </summary>
        public static void desconectar()
        {
            try
            {
                conexion.Close();
            }
            catch (Exception)
            {
            }
        }

        /// <summary>
        /// Este metodo verifica si hay conexion a internet
        /// </summary>
        /// <returns>Regresa un booleano</returns>
        public static bool conexionInternet()
        {
            bool conexion = System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();
            return conexion;
        }
    }
}
