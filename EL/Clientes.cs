using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EL
{
    [Table("Clientes")]
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }
        [Required][MaxLength(50)]

        public string Nombre {  get; set; }
        [Required][MaxLength(50)]

        public string Apellido { get; set; }
        [Required]

        public string Telefono { get; set; }
        [Required][MaxLength(20)]

        public string Email {  set; get; }

        [Required]
        public bool Activo { get; set; }

        public DateTime? FechaCreacion { get; set; }

        public string CreadoPor { get; set; }

        public DateTime? FechaModificacion { get; set; }

        public string ModificadoPor { get; set; }



    }
}
