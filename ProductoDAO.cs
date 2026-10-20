using System;
using System.Collections.Generic;
using System.Text;

using MySql.Data.MySqlClient;

namespace SistemaPeluqueria
{
    public class ProductoDAO
    {
        public static void Guardar(Producto p)
        {
            using (var con = Conexion.ObtenerConexion())
            {
                con.Open();
                string sql = @"INSERT INTO Productos 
                               (Nombre, Categoria, StockActual, StockMinimo, UnidadMedida, PrecioCompra, Proveedor)
                               VALUES 
                               (@nombre, @categoria, @stockActual, @stockMinimo, @unidad, @precio, @proveedor)";

                using (var cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@nombre", p.Nombre);
                    cmd.Parameters.AddWithValue("@categoria", p.Categoria);
                    cmd.Parameters.AddWithValue("@stockActual", p.StockActual);
                    cmd.Parameters.AddWithValue("@stockMinimo", p.StockMinimo);
                    cmd.Parameters.AddWithValue("@unidad", p.UnidadMedida);
                    cmd.Parameters.AddWithValue("@precio", p.PrecioCompra);
                    cmd.Parameters.AddWithValue("@proveedor", p.Proveedor);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Producto> ObtenerTodos()
        {
            var lista = new List<Producto>();

            using (var con = Conexion.ObtenerConexion())
            {
                con.Open();
                string sql = "SELECT * FROM Productos ORDER BY Categoria, Nombre";

                using (var cmd = new MySqlCommand(sql, con))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Producto
                        {
                            Id = reader.GetInt32("Id"),
                            Nombre = reader.GetString("Nombre"),
                            Categoria = reader.IsDBNull(reader.GetOrdinal("Categoria")) ? "" : reader.GetString("Categoria"),
                            StockActual = reader.GetDecimal("StockActual"),
                            StockMinimo = reader.GetDecimal("StockMinimo"),
                            UnidadMedida = reader.GetString("UnidadMedida"),
                            PrecioCompra = reader.GetDecimal("PrecioCompra"),
                            Proveedor = reader.IsDBNull(reader.GetOrdinal("Proveedor")) ? "" : reader.GetString("Proveedor")
                        });
                    }
                }
            }

            return lista;
        }

        public static void DescontarStock(int productoId, decimal cantidad)
        {
            using (var con = Conexion.ObtenerConexion())
            {
                con.Open();
                string sql = "UPDATE Productos SET StockActual = StockActual - @cantidad WHERE Id = @id";

                using (var cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@id", productoId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Producto> ObtenerBajoStock()
        {
            var lista = ObtenerTodos();
            return lista.FindAll(p => p.BajoStock);
        }
    }
}