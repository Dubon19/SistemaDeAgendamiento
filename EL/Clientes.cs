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

        public string Name {  get; set; }
        [Required][MaxLength(50)]

        public string Apellido { get; set; }
        [Required]

        public int Telefono { get; set; }
        [Required][MaxLength(50)]

        public string Email {  set; get; }

        public DateTime? FechaCreacion { get; set; }

        public string CreadoPor { get; set; }

        public DateTime? FechaModificacion { get; set; }

        public string ModificadoPor { get; set; }



    }
}
