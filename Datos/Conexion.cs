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
        // Declaración de variables para establecer la conexión
        public static MySqlConnection conexion;
        static string usuario = "root";
        static string password = "MG1234";
        static string bd = "ERFRA";
        static string servidor = "localhost";
        static string puerto = "3306";

        // Este metodo conecta hace la conexion a la base de datos
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

        // Este metodo desconecta de la base de datos
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
    }
}
