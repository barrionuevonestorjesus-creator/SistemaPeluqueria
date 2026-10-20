namespace SistemaPeluqueria
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = "";
        public string Apellido { get; set; } = "";
        public string DNI { get; set; } = "";
        public string Telefono { get; set; } = "";
        public string Email { get; set; } = "";
        public string Direccion { get; set; } = "";
        public DateTime? FechaNacimiento { get; set; }
        public string Observaciones { get; set; } = "";
        public string Alergias { get; set; } = "";
        public DateTime FechaRegistro { get; set; } = DateTime.Now;

        public string NombreCompleto => $"{Apellido}, {Nombre}";
    }
}