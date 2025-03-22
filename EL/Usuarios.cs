using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EL
{
    [Table("Usuarios")]
    public class Usuarios
    {
        [Key]
        public int UsuarioId { get; set; }
        [Required][StringLength(50)]

        public string Nombre { get; set; }
        [Required][StringLength(50)]

        public string Apellido { get; set; }
        [Required][StringLength(50)]

        public string Usuario { get; set; }
        [Required]

        public byte[] Contrasena { get; set; }

        [ForeignKey("Rol")]
        public int RolId { get; set; }
        public virtual Roles Rol { get; set; }

        [Required]
        public bool Activo { get; set; }

        public DateTime? FechaCreacion { get; set; }

        public string CreadoPor { get; set; }

        public DateTime? FechaModificacion { get; set; }

        public string ModificadoPor { get; set; }


    }
}
