using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace SistemaPeluqueria
{
    public class Conexion
    {
        private static string servidor = "localhost";
        private static string baseDatos = "peluqueria";
        private static string usuario = "root";
        private static string contrasena = "46050349";

        private static string cadena = $"Server ={servidor};Database={baseDatos};Uid={usuario};Pwd={contrasena}";

        public static MySqlConnection ObtenerConexion() {
            return new MySqlConnection(cadena); 

        }
        public static bool ProbarConexion()
        {
            try
            {
                using (var con = ObtenerConexion())
                {
                    con.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
