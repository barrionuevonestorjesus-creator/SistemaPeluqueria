using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaPeluqueria
{
    public class Comprobante
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public decimal Total { get; set; }
        public string MedioPago { get; set; } = "Efectivo";

        public string ClienteNombre { get; set; } = "";
    }

    public class DetalleComprobante
    {
        public int Id { get; set; }
        public int ComprobanteId { get; set; }
        public string Descripcion { get; set; } = "";
        public decimal Precio { get; set; }
    }
}