using Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos {
    public class DAOEmpleado {
        /// <summary>
        /// Método usado para determinar si el usuario puede iniciar sesión o no
        /// </summary>
        /// <param name="objUsuario"></param>
        /// <returns>Retorna el tipo de usuario (admin o empleado), DENEGADO o ERROR</returns>
        public String IniciarSesion(Empleado objUsuario) {
            try {
                if (Conexion.conectar()) {
                    MySqlCommand comando = new MySqlCommand("SELECT NombreUsuario, Password, Rol from Usuario WHERE NombreUsuario=@NameUser and Password=sha1(@Password);");
                    comando.Parameters.AddWithValue("@NameUser", objUsuario.NombreUsuario);
                    comando.Parameters.AddWithValue("@Password", objUsuario.Password);
                    comando.Connection = Conexion.conexion;
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);
                    if (resultado.Rows.Count > 0) {
                        if (resultado.Rows[0]["Rol"].ToString().Equals("Administrador")) {
                            return "Administrador";
                        }
                        else if (resultado.Rows[0]["Rol"].ToString().Equals("Empleado")) {
                            return "Empleado";
                        }
                    }
                    return "DENEGADO";
                }
                else {
                    return "ERROR";
                }
            }
            finally {
                Conexion.desconectar();
            }
        }

        /// <summary>
        /// Método usado para buscar un usuario usando su nombre
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns>Retonr al usuario como un objeto de tipo empleado</returns>
        /// <exception cref="Exception"></exception>
        public Empleado buscarPorUsuario(string usuario) {
            try {
                if (Conexion.conectar()) {
                    MySqlCommand comando = new MySqlCommand("SELECT * from Usuario WHERE NombreUsuario=@NameUser;");
                    comando.Parameters.AddWithValue("@NameUser", usuario);
                    comando.Connection = Conexion.conexion;
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);
                    Empleado objEmpleado = null;
                    if (resultado.Rows.Count > 0) {
                        DataRow fila = resultado.Rows[0];
                        objEmpleado = new Empleado();
                        objEmpleado.IDEmpleado = int.Parse(fila["IdUsuario"].ToString());
                        objEmpleado.Nombre = fila["Nombre"].ToString();
                        objEmpleado.Apellidos = fila["Apellidos"].ToString();
                        objEmpleado.NombreUsuario = fila["NombreUsuario"].ToString();
                        objEmpleado.Rol = fila["Rol"].ToString();
                        objEmpleado.Correo = fila["Correo"].ToString();
                        objEmpleado.Password = fila["Password"].ToString();
                        objEmpleado.Genero = fila["Genero"].ToString();
                        objEmpleado.Rol = fila["Rol"].ToString();
                    }
                    return objEmpleado;
                }
                else {
                    throw new Exception("No se ha podido conectar con el servidor");
                }
            }
            catch (MySqlException ex) {
                throw new Exception("No se pudo obtener la información del usuario");
            }
            finally {
                Conexion.desconectar();
            }
        }

        /// <summary>
        /// Método usado para registrar a un usuario nuevo
        /// </summary>
        /// <param name="objEmpleado"></param>
        /// <returns>Retorna true en caso de haber agregado al empleado, caso contrario se retorna un false</returns>
        public bool agregar(Empleado objEmpleado) {
            try {
                if (Conexion.conectar()) {
                    string query = "INSERT INTO Usuario VALUES (default, @Nombre, @Apellidos, @NombreUsuario, @Correo, sha1(@Password), @Genero, @Rol);";
                    MySqlCommand comando = new MySqlCommand(query);
                    comando.Parameters.AddWithValue("@Nombre", objEmpleado.Nombre);
                    comando.Parameters.AddWithValue("@Apellidos", objEmpleado.Apellidos);
                    comando.Parameters.AddWithValue("@NombreUsuario", objEmpleado.NombreUsuario);
                    comando.Parameters.AddWithValue("@Correo", objEmpleado.Correo);
                    comando.Parameters.AddWithValue("@Password", objEmpleado.Password);
                    comando.Parameters.AddWithValue("@Genero", objEmpleado.Genero);
                    comando.Parameters.AddWithValue("@Rol", objEmpleado.Rol);
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

        /// <summary>
        /// Método usado para verificar que un usuario exista en la base de datos
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns>Retorna true si el usuario existe, caso contrario retorna false</returns>
        /// <exception cref="Exception"></exception>
        public bool verificaUsuario(string usuario) {
            try {
                if (Conexion.conectar()) {
                    MySqlCommand comando = new MySqlCommand("SELECT * from Usuario WHERE NombreUsuario=@usuario;");
                    comando.Parameters.AddWithValue("@usuario", usuario);
                    comando.Connection = Conexion.conexion;
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);
                    if (resultado.Rows.Count > 0) {
                        return true;
                    }
                    return false;
                }
                else {
                    throw new Exception("No se ha podido conectar con el servidor");
                }
            }
            catch (MySqlException ex) {
                throw new Exception("No se pudo obtener la información del usuario");
            }
            finally {
                Conexion.desconectar();
            }
        }

    }
}
