using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EL
{
    [Table("Permisos")]
    public class Permisos
    {
        [Key]
        public int PermisoId { get; set; }
        [Required][MaxLength(50)]

        public string NombrePermiso { get; set; }
        [MaxLength(400)]

        public string Descripcion {  get; set; }

        public DateTime? FechaCreacion { get; set; }

        public string CreadoPor { get; set; }

        public DateTime? FechaModificacion { get; set; }

        public string ModificadoPor { get; set; }
    }
}
