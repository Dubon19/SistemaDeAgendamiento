using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EL
{
    [Table("Citas")]
    public class Citas
    {
        [Key]
        public int CitaId { get; set; }

        [ForeignKey("Empleado")]
        public int EmpleadoId { get; set; }
        public virtual Empleados Empleado { get; set; }

        [ForeignKey("Cliente")]
        public int ClienteId { get; set; }
        public virtual Clientes Cliente { get; set; }

        [ForeignKey("Servicio")]
        public int ServicioId { get; set; }
        public virtual Servicios Servicio { get; set; }

        [Required]
        public DateTime Fecha { get; set; }
        [Required]

        public TimeSpan HoraInicio { get; set; }
        [Required]

        public TimeSpan HoraFin { get; set; }

        [Required]
        public bool Activo { get; set; }

        public DateTime? FechaCreacion { get; set; }

        public string CreadoPor { get; set; }

        public DateTime? FechaModificacion { get; set; }

        public string ModificadoPor { get; set; }
    }
}
