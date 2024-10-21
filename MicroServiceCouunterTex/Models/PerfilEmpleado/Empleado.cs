namespace MicroServiceCounterTex.Models.PerfilEmpleado
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public string NombreCompleto { get; set; } = string.Empty;
        public string Correo { get; set; } = string.Empty;
        public DateTime FechaContrato { get; set; }
        public bool Activo { get; set; }

        public int ProduccionDiaria { get; set; }
        public int TipoPrenda { get; set; }

    }
}
