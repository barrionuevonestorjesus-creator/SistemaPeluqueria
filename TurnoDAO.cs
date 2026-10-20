using System;
using System.Collections.Generic;
using System.Text;

using MySql.Data.MySqlClient;

namespace SistemaPeluqueria
{
    public class TurnoDAO
    {
        public static void Guardar(Turno t)
        {
            using (var con = Conexion.ObtenerConexion())
            {
                con.Open();
                string sql = @"INSERT INTO Turnos 
                               (ClienteId, EmpleadoId, ServicioId, FechaHora, Estado, Notas)
                               VALUES 
                               (@clienteId, @empleadoId, @servicioId, @fechaHora, @estado, @notas)";

                using (var cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@clienteId", t.ClienteId);
                    cmd.Parameters.AddWithValue("@empleadoId", t.EmpleadoId);
                    cmd.Parameters.AddWithValue("@servicioId", t.ServicioId);
                    cmd.Parameters.AddWithValue("@fechaHora", t.FechaHora);
                    cmd.Parameters.AddWithValue("@estado", t.Estado);
                    cmd.Parameters.AddWithValue("@notas", t.Notas);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Turno> ObtenerTodos()
        {
            var lista = new List<Turno>();

            using (var con = Conexion.ObtenerConexion())
            {
                con.Open();

                string sql = @"SELECT t.*, 
                               CONCAT(c.Nombre, ' ', c.Apellido) AS ClienteNombre,
                               CONCAT(e.Nombre, ' ', e.Apellido) AS EmpleadoNombre,
                               s.Nombre AS ServicioNombre
                               FROM Turnos t
                               JOIN Clientes c ON t.ClienteId = c.Id
                               LEFT JOIN Empleados e ON t.EmpleadoId = e.Id
                               JOIN Servicios s ON t.ServicioId = s.Id
                               ORDER BY t.FechaHora DESC";

                using (var cmd = new MySqlCommand(sql, con))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Turno
                        {
                            Id = reader.GetInt32("Id"),
                            ClienteId = reader.GetInt32("ClienteId"),
                            EmpleadoId = reader.IsDBNull(reader.GetOrdinal("EmpleadoId")) ? 0 : reader.GetInt32("EmpleadoId"),
                            ServicioId = reader.GetInt32("ServicioId"),
                            FechaHora = reader.GetDateTime("FechaHora"),
                            Estado = reader.GetString("Estado"),
                            Notas = reader.IsDBNull(reader.GetOrdinal("Notas")) ? "" : reader.GetString("Notas"),
                            ClienteNombre = reader.GetString("ClienteNombre"),
                            EmpleadoNombre = reader.IsDBNull(reader.GetOrdinal("EmpleadoNombre")) ? "" : reader.GetString("EmpleadoNombre"),
                            ServicioNombre = reader.GetString("ServicioNombre")
                        });
                    }
                }
            }

            return lista;
        }

        public static List<Turno> ObtenerPorFecha(DateTime fecha)
        {
            var lista = new List<Turno>();

            using (var con = Conexion.ObtenerConexion())
            {
                con.Open();
                string sql = @"SELECT t.*, 
                               CONCAT(c.Nombre, ' ', c.Apellido) AS ClienteNombre,
                               CONCAT(e.Nombre, ' ', e.Apellido) AS EmpleadoNombre,
                               s.Nombre AS ServicioNombre
                               FROM Turnos t
                               JOIN Clientes c ON t.ClienteId = c.Id
                               LEFT JOIN Empleados e ON t.EmpleadoId = e.Id
                               JOIN Servicios s ON t.ServicioId = s.Id
                               WHERE DATE(t.FechaHora) = @fecha
                               ORDER BY t.FechaHora";

                using (var cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@fecha", fecha.ToString("yyyy-MM-dd"));

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Turno
                            {
                                Id = reader.GetInt32("Id"),
                                ClienteId = reader.GetInt32("ClienteId"),
                                EmpleadoId = reader.IsDBNull(reader.GetOrdinal("EmpleadoId")) ? 0 : reader.GetInt32("EmpleadoId"),
                                ServicioId = reader.GetInt32("ServicioId"),
                                FechaHora = reader.GetDateTime("FechaHora"),
                                Estado = reader.GetString("Estado"),
                                Notas = reader.IsDBNull(reader.GetOrdinal("Notas")) ? "" : reader.GetString("Notas"),
                                ClienteNombre = reader.GetString("ClienteNombre"),
                                EmpleadoNombre = reader.IsDBNull(reader.GetOrdinal("EmpleadoNombre")) ? "" : reader.GetString("EmpleadoNombre"),
                                ServicioNombre = reader.GetString("ServicioNombre")
                            });
                        }
                    }
                }
            }

            return lista;
        }

        public static void CambiarEstado(int turnoId, string estado)
        {
            using (var con = Conexion.ObtenerConexion())
            {
                con.Open();
                string sql = "UPDATE Turnos SET Estado = @estado WHERE Id = @id";

                using (var cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@estado", estado);
                    cmd.Parameters.AddWithValue("@id", turnoId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
