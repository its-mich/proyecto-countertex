using Microsoft.EntityFrameworkCore; 

namespace MicroServiceCouunterTex.Data
{
    public class AppDBContext: DbContext
    {
        public int IdEmpleado { get; set; }
        public string Correo { get; set; }
        public string Pasword { get; set; }
    }
}
