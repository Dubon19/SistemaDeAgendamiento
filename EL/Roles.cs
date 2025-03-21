using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EL
{
    [Table("Roles")]
    public class Roles
    {
        [Key]
        public int RolId { get; set; }
        [Required][StringLength(50)]

        public string Nombre { get; set; }

        public bool Activo {  get; set; }

        public DateTime? FechaCreacion { get; set; }

        public string CreadoPor { get; set; }

        public DateTime? FechaModificacion { get; set; }

        public string ModificadoPor { get; set; }

    }
}
