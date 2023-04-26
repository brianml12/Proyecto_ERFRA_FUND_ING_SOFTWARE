using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;

namespace Datos {
    public class DAOProveedor {
        /// <summary>
        /// Método usado para agregar un proveedor a la bae de datos
        /// </summary>
        /// <param name="objProveedor"></param>
        /// <returns>Retorna true si se pudo agregar el proveedor a la base de datos y retorna false en caso contrario</returns>
        public bool agregar(Proveedor objProveedor) {
            try {
                if (Conexion.conectar()) {
                    string query = "INSERT INTO Proveedor VALUES (default, @NombreProveedor, @DireccionProveedor, @TelefonoProveedor, @CorreoProveedor, 1);";
                    MySqlCommand comando = new MySqlCommand(query);
                    comando.Parameters.AddWithValue("@NombreProveedor", objProveedor.NombreProveedor);
                    comando.Parameters.AddWithValue("@DireccionProveedor", objProveedor.DireccionProveedor);
                    comando.Parameters.AddWithValue("@TelefonoProveedor", objProveedor.TelefonoProveedor);
                    comando.Parameters.AddWithValue("@CorreoProveedor", objProveedor.CorreoProveedor);
                    comando.Connection = Conexion.conexion;
                    comando.ExecuteNonQuery();
                    return true;
                }
                else {
                    return false;
                }
            }
            catch {
                return false;
            }
            finally {
                Conexion.desconectar();
            }
        }
    }
}
