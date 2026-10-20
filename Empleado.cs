using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaPeluqueria
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = "";
        public string Apellido { get; set; } = "";
        public string DNI { get; set; } = "";
        public string Telefono { get; set; } = "";
        public string Email { get; set; } = "";
        public string Especialidad { get; set; } = "";
        public DateTime? FechaIngreso { get; set; }

        public string NombreCompleto => $"{Apellido}, {Nombre}";
    }
}
