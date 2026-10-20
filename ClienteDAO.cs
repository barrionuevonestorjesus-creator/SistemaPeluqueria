using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace SistemaPeluqueria
{
    public class ClienteDAO
    {
        public static void Guardar(Cliente c)
        {
            using (var con = Conexion.ObtenerConexion())
            {
                con.Open();

                string sql = @"INSERT INTO Clientes 
                               (Nombre, Apellido, DNI, Telefono, Email, Direccion, 
                                FechaNacimiento, Observaciones, Alergias)
                               VALUES 
                               (@nombre, @apellido, @dni, @telefono, @email, @direccion,
                                @fechaNac, @observaciones, @alergias)";

                using (var cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@nombre", c.Nombre);
                    cmd.Parameters.AddWithValue("@apellido", c.Apellido);
                    cmd.Parameters.AddWithValue("@dni", c.DNI);
                    cmd.Parameters.AddWithValue("@telefono", c.Telefono);
                    cmd.Parameters.AddWithValue("@email", c.Email);
                    cmd.Parameters.AddWithValue("@direccion", c.Direccion);
                    cmd.Parameters.AddWithValue("@fechaNac",
                        c.FechaNacimiento.HasValue ? c.FechaNacimiento : DBNull.Value);
                    cmd.Parameters.AddWithValue("@observaciones", c.Observaciones);
                    cmd.Parameters.AddWithValue("@alergias", c.Alergias);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Cliente> ObtenerTodos()
        {
            var lista = new List<Cliente>();

            using (var con = Conexion.ObtenerConexion())
            {
                con.Open();

                string sql = "SELECT * FROM Clientes ORDER BY Apellido, Nombre";

                using (var cmd = new MySqlCommand(sql, con))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read()) 
                    {
                        lista.Add(new Cliente
                        {
                            Id = reader.GetInt32("Id"),
                            Nombre = reader.GetString("Nombre"),
                            Apellido = reader.GetString("Apellido"),
                            DNI = reader.IsDBNull(reader.GetOrdinal("DNI")) ? "" : reader.GetString("DNI"),
                            Telefono = reader.IsDBNull(reader.GetOrdinal("Telefono")) ? "" : reader.GetString("Telefono"),
                            Email = reader.IsDBNull(reader.GetOrdinal("Email")) ? "" : reader.GetString("Email"),
                            Direccion = reader.IsDBNull(reader.GetOrdinal("Direccion")) ? "" : reader.GetString("Direccion"),
                            Observaciones = reader.IsDBNull(reader.GetOrdinal("Observaciones")) ? "" : reader.GetString("Observaciones"),
                            Alergias = reader.IsDBNull(reader.GetOrdinal("Alergias")) ? "" : reader.GetString("Alergias"),
                            FechaNacimiento = reader.IsDBNull(reader.GetOrdinal("FechaNacimiento"))
                                ? null
                                : reader.GetDateTime("FechaNacimiento")
                        });
                    }
                }
            }

            return lista;
        }

        public static List<Cliente> Buscar(string texto)
        {
            var lista = new List<Cliente>();

            using (var con = Conexion.ObtenerConexion())
            {
                con.Open();

                string sql = @"SELECT * FROM Clientes 
                               WHERE Nombre LIKE @texto 
                                  OR Apellido LIKE @texto 
                                  OR DNI LIKE @texto
                               ORDER BY Apellido, Nombre";

                using (var cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@texto", $"%{texto}%");

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Cliente
                            {
                                Id = reader.GetInt32("Id"),
                                Nombre = reader.GetString("Nombre"),
                                Apellido = reader.GetString("Apellido"),
                                DNI = reader.IsDBNull(reader.GetOrdinal("DNI")) ? "" : reader.GetString("DNI"),
                                Telefono = reader.IsDBNull(reader.GetOrdinal("Telefono")) ? "" : reader.GetString("Telefono"),
                                Email = reader.IsDBNull(reader.GetOrdinal("Email")) ? "" : reader.GetString("Email"),
                            });
                        }
                    }
                }
            }

            return lista;
        }
    }
}
