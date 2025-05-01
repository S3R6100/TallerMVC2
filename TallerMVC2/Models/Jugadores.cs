using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TallerMVC2.Models
{
    public class Jugadores
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        [DisplayName("Nombre del Jugador:")]
        public string? Nombre { get; set; }
        public int Sueldo { get; set; }
        public int NumeroCamisa { get; set; }
        public int Goles { get; set; }
        public int Asistencias { get; set; }
        public string Equipo { get; set; }

    }
}
