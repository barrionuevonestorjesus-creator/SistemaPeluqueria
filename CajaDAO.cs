using System;
using System.Collections.Generic;
using System.Text;

using MySql.Data.MySqlClient;

namespace SistemaPeluqueria
{
    public class CajaDAO
    {
        public static int CrearComprobante(Comprobante c, List<DetalleComprobante> detalles)
        {
            using (var con = Conexion.ObtenerConexion())
            {
                con.Open();

                string sqlComprobante = @"INSERT INTO Comprobantes (ClienteId, Total, MedioPago)
                                          VALUES (@clienteId, @total, @medioPago);
                                          SELECT LAST_INSERT_ID();";

                int comprobanteId;

                using (var cmd = new MySqlCommand(sqlComprobante, con))
                {
                    cmd.Parameters.AddWithValue("@clienteId", c.ClienteId);
                    cmd.Parameters.AddWithValue("@total", c.Total);
                    cmd.Parameters.AddWithValue("@medioPago", c.MedioPago);

                    comprobanteId = Convert.ToInt32(cmd.ExecuteScalar());
                }

                foreach (var d in detalles)
                {
                    string sqlDetalle = @"INSERT INTO DetalleComprobante (ComprobanteId, Descripcion, Precio)
                                          VALUES (@comprobanteId, @descripcion, @precio)";

                    using (var cmd = new MySqlCommand(sqlDetalle, con))
                    {
                        cmd.Parameters.AddWithValue("@comprobanteId", comprobanteId);
                        cmd.Parameters.AddWithValue("@descripcion", d.Descripcion);
                        cmd.Parameters.AddWithValue("@precio", d.Precio);
                        cmd.ExecuteNonQuery();
                    }
                }

                return comprobanteId;
            }
        }

        public static List<Comprobante> ObtenerHoy()
        {
            var lista = new List<Comprobante>();

            using (var con = Conexion.ObtenerConexion())
            {
                con.Open();
                string sql = @"SELECT c.*, CONCAT(cl.Nombre, ' ', cl.Apellido) AS ClienteNombre
                               FROM Comprobantes c
                               JOIN Clientes cl ON c.ClienteId = cl.Id
                               WHERE DATE(c.Fecha) = CURDATE()
                               ORDER BY c.Fecha DESC";

                using (var cmd = new MySqlCommand(sql, con))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Comprobante
                        {
                            Id = reader.GetInt32("Id"),
                            ClienteId = reader.GetInt32("ClienteId"),
                            Fecha = reader.GetDateTime("Fecha"),
                            Total = reader.GetDecimal("Total"),
                            MedioPago = reader.GetString("MedioPago"),
                            ClienteNombre = reader.GetString("ClienteNombre")
                        });
                    }
                }
            }

            return lista;
        }

        public static decimal TotalHoy()
        {
            using (var con = Conexion.ObtenerConexion())
            {
                con.Open();
                string sql = "SELECT COALESCE(SUM(Total), 0) FROM Comprobantes WHERE DATE(Fecha) = CURDATE()";

                using (var cmd = new MySqlCommand(sql, con))
                {
                    return Convert.ToDecimal(cmd.ExecuteScalar());
                }
            }
        }
    }
}