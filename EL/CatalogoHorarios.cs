using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EL
{
    [Table("atalogoHorarios")]
    public class CatalogoHorarios
    {

        [Key]
        public int CatalogoHorarioId { get; set; }
        [Required][MaxLength(30)]

        public string NombreHorario {  get; set; }
        [Required]

        public int DiaSemanaInicio {  get; set; }
        [Required]

        public int DiaSemanaFin { get; set; }
        [Required]
        public TimeSpan HoraInicio { get; set; }
        [Required]

        public TimeSpan HoraFin { get; set; }
        [Required][MaxLength(30)]

        public string DiaLibre {  get; set; }

        public DateTime? FechaCreacion { get; set; }

        public string CreadoPor { get; set; }

        public DateTime? FechaModificacion { get; set; }

        public string ModificadoPor { get; set; }





    }
}
