using Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos {
    public class DAOVenta {
        public List<Solicitudes> obtenerTodos() {
            try {
                if (Conexion.conectar()) {
                    MySqlCommand comando = new MySqlCommand("select IdSolicitud, NombreProducto, NombreCliente, Importe, Estado from SolicitudesVentas where Estado!='Entregada';");
                    comando.Connection = Conexion.conexion;
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);
                    List<Solicitudes> lista = new List<Solicitudes>();
                    Solicitudes objSolicitud = null;
                    foreach (DataRow fila in resultado.Rows) {
                        objSolicitud = new Solicitudes();
                        objSolicitud.IdSolicitud = int.Parse(fila["IdSolicitud"].ToString());
                        objSolicitud.NombreProducto = fila["NombreProducto"].ToString();
                        objSolicitud.NombreCliente = fila["NombreCliente"].ToString();
                        objSolicitud.Importe = int.Parse(fila["Importe"].ToString());
                        objSolicitud.Estado = fila["Estado"].ToString();
                        lista.Add(objSolicitud);
                    }
                    return lista;
                }
                else {
                    throw new Exception("No se ha podido conectar con el servidor");
                }
            }
            catch (MySqlException ex) {
                throw new Exception("No se pudo obtener la información de las ventas");
            }
            finally {
                Conexion.desconectar();
            }
        }

        public List<Solicitudes> obtenerHistorial() {
            try {
                if (Conexion.conectar()) {
                    MySqlCommand comando = new MySqlCommand("select IdSolicitud, NombreProducto, NombreCliente, Importe, Estado from SolicitudesVentas where Estado='Entregada' and borradoLogico=1;");
                    comando.Connection = Conexion.conexion;
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);
                    List<Solicitudes> lista = new List<Solicitudes>();
                    Solicitudes objSolicitud = null;
                    foreach (DataRow fila in resultado.Rows) {
                        objSolicitud = new Solicitudes();
                        objSolicitud.IdSolicitud = int.Parse(fila["IdSolicitud"].ToString());
                        objSolicitud.NombreProducto = fila["NombreProducto"].ToString();
                        objSolicitud.NombreCliente = fila["NombreCliente"].ToString();
                        objSolicitud.Importe = int.Parse(fila["Importe"].ToString());
                        objSolicitud.Estado = fila["Estado"].ToString();
                        lista.Add(objSolicitud);
                    }
                    return lista;
                }
                else {
                    throw new Exception("No se ha podido conectar con el servidor");
                }
            }
            catch (MySqlException ex) {
                throw new Exception("No se pudo obtener la información de las ventas");
            }
            finally {
                Conexion.desconectar();
            }
        }


        public Solicitudes obtenerUno(int idSolicitud) {
            try {
                if (Conexion.conectar()) {
                    MySqlCommand comando = new MySqlCommand("select IdSolicitud, NombreProducto, NombreCliente, Importe, Estado from SolicitudesVentas where idSolicitud=@idSolicitud;");
                    comando.Parameters.AddWithValue("@idSolicitud", idSolicitud);
                    comando.Connection = Conexion.conexion;
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);
                    Solicitudes objSolicitud = null;
                    if (resultado.Rows.Count > 0) {
                        DataRow fila = resultado.Rows[0];
                        objSolicitud = new Solicitudes();
                        objSolicitud.IdSolicitud = int.Parse(fila["IdSolicitud"].ToString());
                        objSolicitud.NombreProducto = fila["NombreProducto"].ToString();
                        objSolicitud.NombreCliente = fila["NombreCliente"].ToString();
                        objSolicitud.Importe = int.Parse(fila["Importe"].ToString());
                        objSolicitud.Estado = fila["Estado"].ToString();
                    }
                    return objSolicitud;
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

        public bool finalizar(int idSolicitud) {
            try {
                if (Conexion.conectar()) {
                    string query = @"update SolicitudesVentas set Estado='Entregada' where idSolicitud=@idSolicitud and Estado='Terminada';";
                    MySqlCommand comando = new MySqlCommand(query);
                    comando.Parameters.AddWithValue("@idSolicitud", idSolicitud);
                    comando.Connection = Conexion.conexion;
                    int filasEditadas = comando.ExecuteNonQuery();
                    return (filasEditadas > 0);
                }
            }
            catch {
                return false;
            }
            finally {
                Conexion.desconectar();
            }
            return true;
        }

        
        public bool modificar(Solicitudes objSolicitud) {
            try {
                if (Conexion.conectar()) {
                    string query = @"update SolicitudesVentas set NombreProducto=@producto, NombreCliente=@cliente, Estado=@estado where idSolicitud=@idSolicitud;";
                    MySqlCommand comando = new MySqlCommand(query);
                    comando.Parameters.AddWithValue("@cliente", objSolicitud.NombreCliente);
                    comando.Parameters.AddWithValue("@producto", objSolicitud.NombreProducto);
                    comando.Parameters.AddWithValue("@estado", objSolicitud.Estado);
                    comando.Parameters.AddWithValue("@idSolicitud", objSolicitud.IdSolicitud);
                    comando.Connection = Conexion.conexion;
                    int filasEditadas = comando.ExecuteNonQuery();
                    return (filasEditadas > 0);
                }
            }
            catch {
                return false;
            }
            finally {
                Conexion.desconectar();
            }
            return true;
        }

        
        public bool eliminar(int idSolicitud) {
            try {
                // APLICACIÓN DE BORRADO LÓGICO
                if (Conexion.conectar()) {
                    MySqlCommand comando = new MySqlCommand(@"delete from SolicitudesVentas where IdSolicitud=@idSolicitud;");
                    comando.Parameters.AddWithValue("@idSolicitud", idSolicitud);
                    comando.Connection = Conexion.conexion;
                    int filasBorradas = comando.ExecuteNonQuery();
                    return (filasBorradas > 0);
                }
            }
            catch (MySqlException ex) {
                return false;
            }
            finally {
                Conexion.desconectar();
            }
            return true;
        }

        public List<Solicitudes> buscarTodos(String textobuscar)
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand("SELECT s.IdSolicitud, s.NombreCliente, s.NombreProducto, s.Descripcion, s.Lote, s.PrecioUnitario, s.Importe, u.IdUsuario FROM SolicitudesVentas s INNER JOIN Usuario u ON s.IdUsuario=u.IdUsuario WHERE s.IdSolicitud LIKE ('%" + textobuscar + "%');");
                    comando.Connection = Conexion.conexion;
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);
                    List<Solicitudes> lista = new List<Solicitudes>();
                    Solicitudes objSolicitud = null;
                    foreach (DataRow fila in resultado.Rows)
                    {
                        objSolicitud = new Solicitudes();
                        objSolicitud.IdSolicitud = int.Parse(fila["IdSolicitud"].ToString());
                        objSolicitud.NombreCliente = fila["NombreCliente"].ToString();
                        objSolicitud.NombreProducto = fila["NombreProducto"].ToString();
                        objSolicitud.Descripcion = fila["Descripcion"].ToString();
                        objSolicitud.Lote = int.Parse(fila["Lote"].ToString());
                        objSolicitud.PrecioUnitario = int.Parse(fila["PrecioUnitario"].ToString());
                        objSolicitud.Importe = int.Parse(fila["Importe"].ToString());
                        objSolicitud.IdUsuario = int.Parse(fila["IdUsuario"].ToString());
                        lista.Add(objSolicitud);
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