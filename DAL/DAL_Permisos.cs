using EL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public static class DAL_Permisos
    {
        public static Permisos Insert(Permisos Entidad)
        {
            using (DBGestionCita bd = new DBGestionCita())
            {
                Entidad.Activo = true;
                Entidad.FechaCreacion = DateTime.Now;
                bd.Permisos.Add(Entidad);
                bd.SaveChanges();
                return Entidad;
            }
        }

        public static Permisos Update(Permisos Entidad)
        {
            using (DBGestionCita bd = new DBGestionCita())
            {
                var Registro = bd.Permisos.Find(Entidad.PermisoId);
                if (Registro == null)
                {
                    return new Permisos();
                }

                Registro.NombrePermiso = Entidad.NombrePermiso;
                Registro.FechaModificacion = DateTime.Now;
                bd.SaveChanges();
                return Registro;
            }
        }

        public static bool Delete(Permisos Entidad)
        {
            using (DBGestionCita bd = new DBGestionCita())
            {
                var Registro = bd.Permisos.Find(Entidad.PermisoId);
                if (Registro == null)
                {
                    return false;
                }

                Registro.Activo = false;
                Registro.FechaModificacion = DateTime.Now;
                bd.SaveChanges();
                return true;
            }
        }

        public static Permisos Registro(int IdRegistro)
        {
            using (DBGestionCita bd = new DBGestionCita())
            {
                return bd.Permisos.Find(IdRegistro);
            }
        }

        public static List<Permisos> Listar(bool Activo = true)
        {
            using (DBGestionCita bd = new DBGestionCita())
            {
                return bd.Permisos.Where(a => a.Activo == Activo).ToList();
            }
        }
    }
}

