using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EL
{
    [Table("Vacaciones")]
    public class Vacaciones
    {
        [Key]
        public int VacacionId { get; set; }
        [Required]

        public DateTime FechaInicio { get; set; }
        [Required]

        public DateTime FechaFin {  get; set; }
        [Required]

        public bool Estado { get; set; }

        [ForeignKey("Empleados")]
        public int EmpleadoId { get; set; }
        public virtual Empleados Empleados { get; set; }

        public DateTime? FechaCreacion { get; set; }

        public string CreadoPor { get; set; }

        public DateTime? FechaModificacion { get; set; }

        public string ModificadoPor { get; set; }
    }
}
