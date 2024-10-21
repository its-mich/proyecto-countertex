namespace MicroServiceCounterTex.Models.PerfilAdministrador
{
    public class Administrador
    {
        public int IdAdministrador { get; set; }
        public string? NombreAdministrador { get; set; }
        public int ProduccionDiaria { get; set; }
        public int ProduccionMensual { get; set; }
        public int ControlPrendas { get; set; }
        public int Ganancias { get; set; }
        public int Pagos { get; set; }
        public int Gastos { get; set; }
        public int MetaPorCorte { get; set; }
        public bool CancelarInformacion { get; set; }
        public int ControlHorarios { get; set; }
        public string? ChatInterno { get; set; }
        public string? Proveedor { get; set; }
        public string? BotonAyuda { get; set; }
    }
}
