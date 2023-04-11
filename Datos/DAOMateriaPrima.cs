using Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DAOMateriaPrima
    {
        public int obtenerIDUsuario(string nombreUsuario)
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand("SELECT IdUsuario from usuario WHERE NombreUsuario=@NameUser;");
                    comando.Parameters.AddWithValue("@NameUser", nombreUsuario);
                    comando.Connection = Conexion.conexion;
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);
                    if (resultado.Rows.Count > 0)
                    {
                        return int.Parse(resultado.Rows[0]["IdUsuario"].ToString());
                    }
                    return 0;
                }
                return 0;
            }
            finally
            {
                Conexion.desconectar();
            }
        }

        public bool agregar(Material objMaterial)
        {
            try
            {
                if (Conexion.conectar())
                {
                    string query = "INSERT INTO MateriaPrima VALUES (default, @CodigoMaterial, @NombreMaterial, @ColorMaterial, @CantidadMaterial, @TipoMaterial, @FechaEntrada, @IdProveedor, @IdUsuario);";
                    MySqlCommand comando = new MySqlCommand(query);
                    comando.Parameters.AddWithValue("@CodigoMaterial", objMaterial.CodigoMaterial);
                    comando.Parameters.AddWithValue("@NombreMaterial", objMaterial.NombreMaterial);
                    comando.Parameters.AddWithValue("@ColorMaterial", objMaterial.ColorMaterial);
                    comando.Parameters.AddWithValue("@CantidadMaterial", objMaterial.CantidadMaterial);
                    comando.Parameters.AddWithValue("@TipoMaterial", objMaterial.TipoMaterial);
                    comando.Parameters.AddWithValue("@FechaEntrada", objMaterial.FechaEntrada);
                    comando.Parameters.AddWithValue("@IdProveedor", objMaterial.IdProveedor);
                    comando.Parameters.AddWithValue("@IdUsuario", objMaterial.IdUsuario);
                    comando.Connection = Conexion.conexion;
                    comando.ExecuteNonQuery();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                Conexion.desconectar();
            }
        }

        public List<Material> obtenerTodos()
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand("Select m.CodigoMaterial, m.NombreMaterial, m.ColorMaterial, m.CantidadMaterial, m.TipoMaterial, m.FechaEntrada, p.NombreProveedor, p.DireccionProveedor,  p.TelefonoProveedor, p.CorreoProveedor from MateriaPrima m inner join Proveedor p on p.IdProveedor=m.IdProveedor;");
                    comando.Connection = Conexion.conexion;
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);
                    List<Material> lista = new List<Material>();
                    Material objMaterial = null;
                    foreach (DataRow fila in resultado.Rows)
                    {
                        objMaterial = new Material();
                        objMaterial.CodigoMaterial = fila["CodigoMaterial"].ToString();
                        objMaterial.NombreMaterial = fila["NombreMaterial"].ToString();
                        objMaterial.ColorMaterial = fila["ColorMaterial"].ToString();
                        objMaterial.CantidadMaterial = int.Parse(fila["CantidadMaterial"].ToString());
                        objMaterial.TipoMaterial = fila["TipoMaterial"].ToString();
                        objMaterial.FechaEntrada = fila["FechaEntrada"].ToString();
                        objMaterial.NombreProveedor = fila["NombreProveedor"].ToString();
                        objMaterial.DireccionProveedor = fila["DireccionProveedor"].ToString();
                        objMaterial.TelefonoProveedor = fila["TelefonoProveedor"].ToString();
                        objMaterial.CorreoProveedor = fila["CorreoProveedor"].ToString();
                        lista.Add(objMaterial);
                    }
                    return lista;
                }
                else
                {
                    throw new Exception("No se ha podido conectar con el servidor");
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("No se pudo obtener la información de la materia prima");
            }
            finally
            {
                Conexion.desconectar();
            }
        }

        public List<Proveedor> obtenerProveedores()
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand("select IFNULL(IdProveedor,0) IdProveedor, IFNULL(NombreProveedor,'') NombreProveedor from Proveedor where BorradoLogico=1;");
                    comando.Connection = Conexion.conexion;

                    //Este objeto nos ayudará a llenar una tabla con el resultado de la consulta
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);
                    List<Proveedor> lista = new List<Proveedor>();
                    Proveedor objProveedor = null;
                    foreach (DataRow fila in resultado.Rows)
                    {
                        objProveedor = new Proveedor();
                        objProveedor.IdProveedor = int.Parse(fila["IdProveedor"].ToString());
                        objProveedor.NombreProveedor = fila["NombreProveedor"].ToString();
                        lista.Add(objProveedor);
                    }
                    return lista;
                }
                else
                {
                    throw new Exception("No se ha podido conectar con el servidor");
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("No se pudo obtener la información de los proveedores");
            }
            finally
            {
                Conexion.desconectar();
            }
        }

        public bool eliminarProveedor(int id)
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand(@"DELETE FROM Proveedor WHERE IdProveedor=@idproveedor;");
                    comando.Parameters.AddWithValue("@idproveedor", id);
                    comando.Connection = Conexion.conexion;
                    int filasBorradas = comando.ExecuteNonQuery();
                    return (filasBorradas > 0);
                }
            }
            catch (MySqlException ex)
            {
                if (Conexion.conectar())
                {
                    string query = @"UPDATE Proveedor SET BorradoLogico=0 WHERE IdProveedor=@idproveedor;";
                    MySqlCommand comando = new MySqlCommand(query);
                    comando.Parameters.AddWithValue("@idproveedor", id);
                    comando.Connection = Conexion.conexion;
                    int filasBorradas = comando.ExecuteNonQuery();
                    return (filasBorradas > 0);
                }
                return false;
            }
            finally
            {
                Conexion.desconectar();
            }
            return true;
        }
    }
}
