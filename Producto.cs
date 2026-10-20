using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaPeluqueria
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = "";
        public string Categoria { get; set; } = "";
        public decimal StockActual { get; set; }
        public decimal StockMinimo { get; set; } = 5;
        public string UnidadMedida { get; set; } = "unidad";
        public decimal PrecioCompra { get; set; }
        public string Proveedor { get; set; } = "";

        public bool BajoStock => StockActual <= StockMinimo;
    }
}