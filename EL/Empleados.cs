using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EL
{
    [Table("Empleados")]

    public class Empleados
    {

        [Key]
        public int EmpleadoId { get; set; }
        [Required][MaxLength(50)]
        public string Nombre { get; set; }

        [Required][MaxLength(50)]
        public string Apellido { get; set; }

        [Required]
        public int Telefono { get; set; }

        [Required][MaxLength (50)]
        public string Email { get; set; }
        [Required]
        public DateTime FechaDeIngreso { get; set; }
        [Required]
        public int VacacionesAcumuladas {  get; set; }
        [Required]
        public bool Estado {  get; set; }

        [ForeignKey("CatalogoHorario")]
        public int CatalogoHorarioId { get; set; }
        public virtual CatalogoHorarios CatalogoHorario { get; set; }

        public DateTime? FechaCreacion { get; set; }

        public string CreadoPor {  get; set; }

        public DateTime? FechaModificacion { get; set; }

        public string ModificadoPor { get; set; }




    }
}
