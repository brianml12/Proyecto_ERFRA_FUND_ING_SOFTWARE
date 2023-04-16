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
                    MySqlCommand comando = new MySqlCommand("SELECT m.IdMaterial, m.CodigoMaterial, m.NombreMaterial, m.ColorMaterial, m.CantidadMaterial, m.TipoMaterial, m.FechaEntrada, p.NombreProveedor, p.DireccionProveedor, p.TelefonoProveedor, p.CorreoProveedor, u.NombreUsuario FROM MateriaPrima m INNER JOIN Proveedor p ON m.IdProveedor=p.IdProveedor INNER JOIN Usuario u ON m.IdUsuario=u.IdUsuario;");
                    comando.Connection = Conexion.conexion;
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);
                    List<Material> lista = new List<Material>();
                    Material objMaterial = null;
                    foreach (DataRow fila in resultado.Rows)
                    {
                        objMaterial = new Material();
                        objMaterial.IdMaterial = int.Parse(fila["IdMaterial"].ToString());
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
                        objMaterial.NombreUsuario = fila["NombreUsuario"].ToString();
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
                throw new Exception("No se pudo obtener la información de la materia prima almacenada en la base de datos");
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

        public Material obtenerUno(int idMaterial)
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand("SELECT m.IdMaterial, m.CodigoMaterial, m.NombreMaterial, m.ColorMaterial, m.CantidadMaterial, m.TipoMaterial, m.FechaEntrada, m.IdProveedor, m.IdUsuario FROM MateriaPrima m WHERE IdMaterial=@idMaterial;");
                    comando.Parameters.AddWithValue("@idMaterial", idMaterial);
                    comando.Connection = Conexion.conexion;
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);
                    Material objMaterial = null;
                    if (resultado.Rows.Count > 0)
                    {
                        DataRow fila = resultado.Rows[0];
                        objMaterial = new Material();
                        objMaterial.IdMaterial = int.Parse(fila["IdMaterial"].ToString());
                        objMaterial.CodigoMaterial = fila["CodigoMaterial"].ToString();
                        objMaterial.NombreMaterial = fila["NombreMaterial"].ToString();
                        objMaterial.ColorMaterial = fila["ColorMaterial"].ToString();
                        objMaterial.CantidadMaterial = int.Parse(fila["CantidadMaterial"].ToString());
                        objMaterial.TipoMaterial = fila["TipoMaterial"].ToString();
                        objMaterial.FechaEntrada = fila["FechaEntrada"].ToString();
                        objMaterial.IdProveedor = int.Parse(fila["IdProveedor"].ToString());
                        objMaterial.IdUsuario = int.Parse(fila["IdUsuario"].ToString());
                    }
                    return objMaterial;
                }
                else
                {
                    throw new Exception("No se ha podido conectar con el servidor");
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception("No se pudo obtener la información del usuario");
            }
            finally
            {
                Conexion.desconectar();
            }
        }

        public bool modificar(Material objMaterial)
        {
            try
            {
                if (Conexion.conectar())
                {
                    string query = @"UPDATE MateriaPrima SET CodigoMaterial=@codigoMaterial, NombreMaterial=@nombreMaterial, ColorMaterial=@colorMaterial, CantidadMaterial=@cantidadMaterial, TipoMaterial=@tipoMaterial, FechaEntrada=@fechaEntrada, IdProveedor=@idProveedor, IdUsuario=@idUsuario WHERE IdMaterial=@idMaterial;";
                    MySqlCommand comando = new MySqlCommand(query);
                    comando.Parameters.AddWithValue("@codigoMaterial", objMaterial.CodigoMaterial);
                    comando.Parameters.AddWithValue("@nombreMaterial", objMaterial.NombreMaterial);
                    comando.Parameters.AddWithValue("@colorMaterial", objMaterial.ColorMaterial);
                    comando.Parameters.AddWithValue("@cantidadMaterial", objMaterial.CantidadMaterial);
                    comando.Parameters.AddWithValue("@tipoMaterial", objMaterial.TipoMaterial);
                    comando.Parameters.AddWithValue("@fechaEntrada", objMaterial.FechaEntrada);
                    comando.Parameters.AddWithValue("@idProveedor", objMaterial.IdProveedor);
                    comando.Parameters.AddWithValue("@idUsuario", objMaterial.IdUsuario);
                    comando.Parameters.AddWithValue("@idMaterial", objMaterial.IdMaterial);
                    comando.Connection = Conexion.conexion;
                    int filasEditadas = comando.ExecuteNonQuery();
                    return (filasEditadas > 0);
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
            return true;
        }

        public bool eliminar(int id_material)
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand(@"DELETE FROM MateriaPrima WHERE IdMaterial=@idMaterial;");
                    comando.Parameters.AddWithValue("@idMaterial", id_material);
                    comando.Connection = Conexion.conexion;
                    int filasBorradas = comando.ExecuteNonQuery();
                    return (filasBorradas > 0);
                }
            }
            catch (MySqlException ex)
            {
                return false;
            }
            finally
            {
                Conexion.desconectar();
            }
            return true;
        }

        public List<Material> buscarTodos(String textobuscar)
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand("SELECT m.IdMaterial, m.CodigoMaterial, m.NombreMaterial, m.ColorMaterial, m.CantidadMaterial, m.TipoMaterial, m.FechaEntrada, p.NombreProveedor, p.DireccionProveedor, p.TelefonoProveedor, p.CorreoProveedor, u.NombreUsuario FROM MateriaPrima m INNER JOIN Proveedor p ON m.IdProveedor=p.IdProveedor INNER JOIN Usuario u ON m.IdUsuario=u.IdUsuario WHERE m.CodigoMaterial LIKE ('%" + textobuscar + "%');");
                    comando.Connection = Conexion.conexion;
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);
                    List<Material> lista = new List<Material>();
                    Material objMaterial = null;
                    foreach (DataRow fila in resultado.Rows)
                    {
                        objMaterial = new Material();
                        objMaterial.IdMaterial = int.Parse(fila["IdMaterial"].ToString());
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
                        objMaterial.NombreUsuario = fila["NombreUsuario"].ToString();
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
                throw new Exception("No se pudo obtener la información de la materia prima almacenada en la base de datos");
            }
            finally
            {
                Conexion.desconectar();
            }
        }
    }
}
