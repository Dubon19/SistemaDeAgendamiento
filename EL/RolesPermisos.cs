using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EL
{
    [Table("RolesPermisos")]
    public class RolesPermisos
    {
        [Key, Column(Order = 0)]
        [ForeignKey("Roles")]
        public int RolId { get; set; }
        public virtual Roles Roles { get; set; }

        [Key, Column(Order = 1)]
        [ForeignKey("Permiso")]
        public int PermisoId { get; set; }
        public virtual Permisos Permiso { get; set; }

        [Required]
        public bool Activo { get; set; }

        public DateTime? FechaCreacion { get; set; }

        public string CreadoPor { get; set; }

        public DateTime? FechaModificacion { get; set; }

        public string ModificadoPor { get; set; }


    }
}
