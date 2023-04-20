using Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos {
    public class DAOSolicitudes {
        // ESTE MÉTODO SE QUEDA
        public bool agregar(Solicitudes objSolicitud) {
            try {
                if (Conexion.conectar()) {
                    string query = "INSERT INTO SolicitudesVentas VALUES (default, @NombreCliente, @NombreProducto, @Descripcion, @Lote, @PrecioUnitario, @Importe, @IdUsuario, @estado,1);";
                    objSolicitud.Estado = "Sin Iniciar";
                    MySqlCommand comando = new MySqlCommand(query);
                    comando.Parameters.AddWithValue("@NombreCliente", objSolicitud.NombreCliente);
                    comando.Parameters.AddWithValue("@NombreProducto", objSolicitud.NombreProducto);
                    comando.Parameters.AddWithValue("@Descripcion", objSolicitud.Descripcion);
                    comando.Parameters.AddWithValue("@Lote", objSolicitud.Lote);
                    comando.Parameters.AddWithValue("@PrecioUnitario", objSolicitud.PrecioUnitario);
                    comando.Parameters.AddWithValue("@Importe", objSolicitud.Importe);
                    comando.Parameters.AddWithValue("@IdUsuario", objSolicitud.IdUsuario);
                    comando.Parameters.AddWithValue("@estado", objSolicitud.Estado);
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

        // ESTE MÉTODO SE QUEDA
        public List<Solicitudes> obtenerTodos() {
            try {
                if (Conexion.conectar()) {
                    MySqlCommand comando = new MySqlCommand("SELECT s.IdSolicitud, s.NombreCliente, s.NombreProducto, s.Descripcion, s.Lote, s.PrecioUnitario, s.Importe, s.IdUsuario, s.Estado FROM SolicitudesVentas s INNER JOIN Usuario u on s.IdUsuario=u.IdUsuario where s.Estado!='Entregada' and s.borradoLogico=1;");
                    comando.Connection = Conexion.conexion;
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);
                    List<Solicitudes> lista = new List<Solicitudes>();
                    Solicitudes objSolicitud = null;
                    foreach (DataRow fila in resultado.Rows) {
                        objSolicitud = new Solicitudes();
                        objSolicitud.IdSolicitud = int.Parse(fila["IdSolicitud"].ToString());
                        objSolicitud.NombreCliente = fila["NombreCliente"].ToString();
                        objSolicitud.NombreProducto = fila["NombreProducto"].ToString();
                        objSolicitud.Descripcion = fila["Descripcion"].ToString();
                        objSolicitud.Lote = int.Parse(fila["Lote"].ToString());
                        objSolicitud.PrecioUnitario = int.Parse(fila["PrecioUnitario"].ToString());
                        objSolicitud.Importe = int.Parse(fila["Importe"].ToString());
                        objSolicitud.IdUsuario = int.Parse(fila["IdUsuario"].ToString());
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
                throw new Exception("No se pudo obtener la información de las solicitudes");
            }
            finally {
                Conexion.desconectar();
            }
        }

        public Solicitudes obtenerUno(int idSolicitud) 
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand("SELECT s.IdSolicitud, s.NombreCliente, s.NombreProducto, s.Descripcion, s.Lote, s.PrecioUnitario, s.Importe, s.IdUsuario, s.Estado FROM SolicitudesVentas s WHERE IdSolicitud = @idSolicitud;");
                    comando.Parameters.AddWithValue("@idSolicitud", idSolicitud);
                    comando.Connection = Conexion.conexion;
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);
                    Solicitudes objSolicitud = null;
                    if (resultado.Rows.Count > 0)
                    {
                        DataRow fila = resultado.Rows[0];
                        objSolicitud = new Solicitudes();
                        objSolicitud.IdSolicitud = int.Parse(fila["IdSolicitud"].ToString());
                        objSolicitud.NombreCliente = fila["NombreCliente"].ToString();
                        objSolicitud.NombreProducto = fila["NombreProducto"].ToString();
                        objSolicitud.Descripcion = fila["Descripcion"].ToString();
                        objSolicitud.Lote = int.Parse(fila["Lote"].ToString());
                        objSolicitud.PrecioUnitario = int.Parse(fila["PrecioUnitario"].ToString());
                        objSolicitud.Importe = int.Parse(fila["Importe"].ToString());
                        objSolicitud.IdUsuario = int.Parse(fila["IdUsuario"].ToString());
                        objSolicitud.Estado = fila["Estado"].ToString();
                    }
                    return objSolicitud;
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

        public List<Solicitudes> obtenerHistorial() {
            try {
                if (Conexion.conectar()) {
                    MySqlCommand comando = new MySqlCommand("select idSolicitud, NombreCliente, NombreProducto, Descripcion, Lote, importe*2 as Total from solicitudesVentas where borradoLogico=1 and estado='Entregada';");
                    comando.Connection = Conexion.conexion;
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);
                    List<Solicitudes> lista = new List<Solicitudes>();
                    Solicitudes objSolicitud = null;
                    foreach (DataRow fila in resultado.Rows) {
                        objSolicitud = new Solicitudes();
                        objSolicitud.IdSolicitud = int.Parse(fila["IdSolicitud"].ToString());
                        objSolicitud.NombreCliente = fila["NombreCliente"].ToString();
                        objSolicitud.NombreProducto = fila["NombreProducto"].ToString();
                        objSolicitud.Descripcion = fila["Descripcion"].ToString();
                        objSolicitud.Lote = int.Parse(fila["Lote"].ToString());
                        objSolicitud.Total = int.Parse(fila["Total"].ToString());
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

        public bool finalizarVenta(int idSolicitud) {
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

        public bool modificar(Solicitudes objSolicitud)
        {
            try
            {
                if (Conexion.conectar())
                {
                    string query = @"UPDATE SolicitudesVentas SET NombreCliente=@nombrecliente, NombreProducto=@nombreproducto, Descripcion=@descripcion, Lote=@lote, PrecioUnitario=@preciounitario, Importe=@importe, IdUsuario=@idusuario, Estado=@estado WHERE IdSolicitud=@idsolicitud;";
                    MySqlCommand comando = new MySqlCommand(query);
                    comando.Parameters.AddWithValue("@nombrecliente", objSolicitud.NombreCliente);
                    comando.Parameters.AddWithValue("@nombreproducto", objSolicitud.NombreProducto);
                    comando.Parameters.AddWithValue("@descripcion", objSolicitud.Descripcion);
                    comando.Parameters.AddWithValue("@lote", objSolicitud.Lote);
                    comando.Parameters.AddWithValue("@preciounitario", objSolicitud.PrecioUnitario);
                    comando.Parameters.AddWithValue("@importe", objSolicitud.Importe);
                    comando.Parameters.AddWithValue("@idusuario", objSolicitud.IdUsuario);
                    comando.Parameters.AddWithValue("@idsolicitud", objSolicitud.IdSolicitud);
                    comando.Parameters.AddWithValue("@estado", objSolicitud.Estado);
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

        public bool eliminar(int id_solicitud)
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand(@"update SolicitudesVentas set borradoLogico=0 where idSolicitud=@idSolicitud;");
                    comando.Parameters.AddWithValue("@idSolicitud", id_solicitud);
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

        public List<Solicitudes> buscarTodos(String textobuscar)
        {
            try
            {
                if (Conexion.conectar())
                {
                    
                    MySqlCommand comando = new MySqlCommand("SELECT s.IdSolicitud, s.NombreCliente, s.NombreProducto, s.Descripcion, s.Lote, s.PrecioUnitario, s.Importe, s.IdUsuario, s.Estado FROM SolicitudesVentas s INNER JOIN Usuario u on s.IdUsuario=u.IdUsuario where s.Estado!='Entregada' and s.borradoLogico=1;");
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

        public int obtenerMaxIDSolicitud()
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand("SELECT max(idSolicitud) as idSolicitud FROM solicitudesventas;");
                    comando.Connection = Conexion.conexion;
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable resultado = new DataTable();
                    adapter.Fill(resultado);
                    if (resultado.Rows.Count > 0)
                    {
                        return int.Parse(resultado.Rows[0]["idSolicitud"].ToString()) + 1;
                    }
                    return 0;
                }
                else
                {
                    return 0;
                }
            }
            finally
            {
                Conexion.desconectar();
            }
        }

        public List<Solicitudes> buscarTodosHistorial(String textobuscar)
        {
            try
            {
                if (Conexion.conectar())
                {
                    MySqlCommand comando = new MySqlCommand("select idSolicitud, NombreCliente, NombreProducto, Descripcion, Lote, importe*2 as Total from solicitudesVentas where borradoLogico=1 and estado='Entregada' and idSolicitud LIKE ('%" + textobuscar + "%');");
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
                        objSolicitud.Total = int.Parse(fila["Total"].ToString());
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
                throw new Exception("No se pudo obtener la información del historial almacenada en la base de datos");
            }
            finally
            {
                Conexion.desconectar();
            }
        }

        public void Asignacion(String Prenda, String Cliente, String Lote, String Descripcion, String PrecioU, String Total, String Importe)
        {
            Datos.VariablesGlobales.Prenda = Prenda;
            Datos.VariablesGlobales.Cliente = Cliente;
            Datos.VariablesGlobales.CantidadPrendas = Lote;
            Datos.VariablesGlobales.Descripcion = Descripcion;
            Datos.VariablesGlobales.PrecioU = PrecioU;
            Datos.VariablesGlobales.Total = Total;
            Datos.VariablesGlobales.Importe = Importe;
        }
    }
}
