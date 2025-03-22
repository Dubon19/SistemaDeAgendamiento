using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace EL
{
    [Table("Servicios")]
    public class Servicios
    {
        [Key]
        public int ServicioId { get; set; }
        [Required][StringLength(200)]

        public string Nombre { get; set; }
        [Required]

        public int Duracion { get; set; }

        [Required]
        public bool Activo { get; set; }

        public DateTime? FechaCreacion { get; set; }

        public string CreadoPor { get; set; }

        public DateTime? FechaModificacion { get; set; }

        public string ModificadoPor { get; set; }
    }
}
