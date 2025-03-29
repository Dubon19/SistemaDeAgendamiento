using EL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public static class DAL_Vacaciones
    {
        public static Vacaciones Insert(Vacaciones Entidad)
        {
            using (DBGestionCita bd = new DBGestionCita())
            {
                Entidad.FechaCreacion = DateTime.Now;
                bd.Vacaciones.Add(Entidad);
                bd.SaveChanges();
                return Entidad;
            }
        }

        public static Vacaciones Update(Vacaciones Entidad)
        {
            using (DBGestionCita bd = new DBGestionCita())
            {
                var Registro = bd.Vacaciones
                                 .FirstOrDefault(v => v.VacacionId == Entidad.VacacionId); 
                if (Registro == null)
                {
                    return new Vacaciones();  
                }

                
                Registro.FechaModificacion = DateTime.Now;
                Registro.ModificadoPor = Entidad.ModificadoPor; 

                bd.SaveChanges();
                return Registro;
            }
        }

        public static bool Delete(Vacaciones Entidad)
        {
            using (DBGestionCita bd = new DBGestionCita())
            {
                var Registro = bd.Vacaciones
                                 .FirstOrDefault(v => v.VacacionId == Entidad.VacacionId);
                if (Registro == null)
                {
                    return false;
                }

                bd.Vacaciones.Remove(Registro);
                bd.SaveChanges();
                return true;
            }
        }

        public static Vacaciones Registro(int VacacionesId)
        {
            using (DBGestionCita bd = new DBGestionCita())
            {
                return bd.Vacaciones
                         .FirstOrDefault(v => v.VacacionId == VacacionesId);
            }
        }

        public static List<Vacaciones> Listar()
        {
            using (DBGestionCita bd = new DBGestionCita())
            {
                return bd.Vacaciones.ToList();
            }
        }
    }
}

