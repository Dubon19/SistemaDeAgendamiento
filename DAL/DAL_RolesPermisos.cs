using EL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public static class DAL_RolesPermisos
    {
        public static RolesPermisos Insert(RolesPermisos Entidad)
        {
            using (DBGestionCita bd = new DBGestionCita())
            {
                Entidad.FechaCreacion = DateTime.Now;
                bd.RolesPermisos.Add(Entidad);
                bd.SaveChanges();
                return Entidad;
            }
        }

        public static RolesPermisos Update(RolesPermisos Entidad)
        {
            using (DBGestionCita bd = new DBGestionCita())
            {
                var Registro = bd.RolesPermisos
                                 .FirstOrDefault(rp => rp.RolId == Entidad.RolId && rp.PermisoId == Entidad.PermisoId);
                if (Registro == null)
                {
                    return new RolesPermisos();  
                }

                
                Registro.FechaModificacion = DateTime.Now;
                Registro.ModificadoPor = Entidad.ModificadoPor; 

                bd.SaveChanges();
                return Registro;
            }
        }

        public static bool Delete(RolesPermisos Entidad)
        {
            using (DBGestionCita bd = new DBGestionCita())
            {
                var Registro = bd.RolesPermisos
                                 .FirstOrDefault(rp => rp.RolId == Entidad.RolId && rp.PermisoId == Entidad.PermisoId);
                if (Registro == null)
                {
                    return false;
                }

                bd.RolesPermisos.Remove(Registro);
                bd.SaveChanges();
                return true;
            }
        }

        public static RolesPermisos Registro(int RolId, int PermisoId)
        {
            using (DBGestionCita bd = new DBGestionCita())
            {
                return bd.RolesPermisos
                         .FirstOrDefault(rp => rp.RolId == RolId && rp.PermisoId == PermisoId);
            }
        }

        public static List<RolesPermisos> Listar()
        {
            using (DBGestionCita bd = new DBGestionCita())
            {
                return bd.RolesPermisos.ToList();
            }
        }
    }
}

