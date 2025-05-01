using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace TallerMVC2.Models
{
    public class Equipo
    {
            [Key]
            public int Id { get; set; }

            [MaxLength(100)]
            [DisplayName("Nombre del equipo:")]
            public string? Nombre { get; set; }

            [Range(0, 20)]
            public int PartidosJugados { get; set; }

            [Range(0, 20)]
            public int PartidosGanados { get; set; }

            [Range(0, 20)]
            public int PartidosEmpatados { get; set; }

            [Range(0, 20)]
            public int PartidosPerdidos { get; set; }

            public string? Descripcion { get; set; }
            [Range(0, 150)]

            public int Puntos
            {
                get
                {
                    return (PartidosGanados * 3) + PartidosEmpatados;
                }
            }
    }
}
