using System;
using System.Collections.Generic;
using System.Text;

using MySql.Data.MySqlClient;

namespace SistemaPeluqueria
{
    public class ServicioDAO
    {
        public static void Guardar(Servicio s)
        {
            using (var con = Conexion.ObtenerConexion())
            {
                con.Open();
                string sql = @"INSERT INTO Servicios 
                               (Nombre, Descripcion, Precio, DuracionMinutos, Categoria)
                               VALUES 
                               (@nombre, @descripcion, @precio, @duracion, @categoria)";

                using (var cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@nombre", s.Nombre);
                    cmd.Parameters.AddWithValue("@descripcion", s.Descripcion);
                    cmd.Parameters.AddWithValue("@precio", s.Precio);
                    cmd.Parameters.AddWithValue("@duracion", s.DuracionMinutos);
                    cmd.Parameters.AddWithValue("@categoria", s.Categoria);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Servicio> ObtenerTodos()
        {
            var lista = new List<Servicio>();

            using (var con = Conexion.ObtenerConexion())
            {
                con.Open();
                string sql = "SELECT * FROM Servicios ORDER BY Categoria, Nombre";

                using (var cmd = new MySqlCommand(sql, con))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Servicio
                        {
                            Id = reader.GetInt32("Id"),
                            Nombre = reader.GetString("Nombre"),
                            Descripcion = reader.IsDBNull(reader.GetOrdinal("Descripcion")) ? "" : reader.GetString("Descripcion"),
                            Precio = reader.GetDecimal("Precio"),
                            DuracionMinutos = reader.IsDBNull(reader.GetOrdinal("DuracionMinutos")) ? 0 : reader.GetInt32("DuracionMinutos"),
                            Categoria = reader.IsDBNull(reader.GetOrdinal("Categoria")) ? "" : reader.GetString("Categoria")
                        });
                    }
                }
            }

            return lista;
        }
    }
}
