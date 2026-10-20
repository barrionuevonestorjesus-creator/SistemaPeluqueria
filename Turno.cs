using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaPeluqueria
{
    public class Turno
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int EmpleadoId { get; set; }
        public int ServicioId { get; set; }
        public DateTime FechaHora { get; set; }
        public string Estado { get; set; } = "Pendiente";
        public string Notas { get; set; } = "";

        public string ClienteNombre { get; set; } = "";
        public string EmpleadoNombre { get; set; } = "";
        public string ServicioNombre { get; set; } = "";
    }
}
