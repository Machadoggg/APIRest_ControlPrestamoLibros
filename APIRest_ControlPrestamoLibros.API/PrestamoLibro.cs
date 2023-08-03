using System.ComponentModel.DataAnnotations;

namespace APIRest_ControlPrestamoLibros.API
{
    public class PrestamoLibro
    {
        [Key]
        public Guid Id { get; set; }
        public Guid Isbn { get; set; }
        public string IdentificacionUsuario { get; set; } = string.Empty;
        public int TipoUsuario { get; set; }
        public DateTime FechaMaximaDevolucion { get; set; }

    }
}
