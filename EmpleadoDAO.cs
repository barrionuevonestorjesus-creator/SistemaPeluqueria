using System;
using System.Collections.Generic;
using System.Text;

using MySql.Data.MySqlClient;

namespace SistemaPeluqueria
{
    public class EmpleadoDAO
    {
        public static void Guardar(Empleado e)
        {
            using (var con = Conexion.ObtenerConexion())
            {
                con.Open();
                string sql = @"INSERT INTO Empleados 
                               (Nombre, Apellido, DNI, Telefono, Email, Especialidad, FechaIngreso)
                               VALUES 
                               (@nombre, @apellido, @dni, @telefono, @email, @especialidad, @fechaIngreso)";

                using (var cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@nombre", e.Nombre);
                    cmd.Parameters.AddWithValue("@apellido", e.Apellido);
                    cmd.Parameters.AddWithValue("@dni", e.DNI);
                    cmd.Parameters.AddWithValue("@telefono", e.Telefono);
                    cmd.Parameters.AddWithValue("@email", e.Email);
                    cmd.Parameters.AddWithValue("@especialidad", e.Especialidad);
                    cmd.Parameters.AddWithValue("@fechaIngreso",
                        e.FechaIngreso.HasValue ? e.FechaIngreso : DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Empleado> ObtenerTodos()
        {
            var lista = new List<Empleado>();

            using (var con = Conexion.ObtenerConexion())
            {
                con.Open();
                string sql = "SELECT * FROM Empleados ORDER BY Apellido, Nombre";

                using (var cmd = new MySqlCommand(sql, con))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Empleado
                        {
                            Id = reader.GetInt32("Id"),
                            Nombre = reader.GetString("Nombre"),
                            Apellido = reader.GetString("Apellido"),
                            DNI = reader.IsDBNull(reader.GetOrdinal("DNI")) ? "" : reader.GetString("DNI"),
                            Telefono = reader.IsDBNull(reader.GetOrdinal("Telefono")) ? "" : reader.GetString("Telefono"),
                            Email = reader.IsDBNull(reader.GetOrdinal("Email")) ? "" : reader.GetString("Email"),
                            Especialidad = reader.IsDBNull(reader.GetOrdinal("Especialidad")) ? "" : reader.GetString("Especialidad"),
                            FechaIngreso = reader.IsDBNull(reader.GetOrdinal("FechaIngreso")) ? null : reader.GetDateTime("FechaIngreso")
                        });
                    }
                }
            }

            return lista;
        }
    }
}
