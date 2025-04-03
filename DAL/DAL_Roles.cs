using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DAL_Roles
    {
       public static Roles Insert(Roles Entidad)
        {
            using (DBGestionCita bd = new DBGestionCita())
            {
                Entidad.Activo = true;
                Entidad.FechaCreacion = DateTime.Now;
                bd.Roles.Add(Entidad);
                bd.SaveChanges();
                return Entidad;
            }
          



        }


        public static Roles Update(Roles Entidad)
        {
            using (DBGestionCita bd = new DBGestionCita())
            {
                var Registro = bd.Roles.Find(Entidad.RolId);
                if (Registro == null)
                {
                    return new Roles();
                }

                // Actualizar los campos
                Registro.Nombre = Entidad.Nombre; // Asignar el nuevo nombre
                Registro.Activo = Entidad.Activo;  // Asignar el nuevo estado de 'Activo'
                Registro.FechaModificacion = DateTime.Now;
                bd.SaveChanges();
                return Registro;
            }


        }

        public static bool Delete(Roles Entidad)
        {
            using (DBGestionCita bd = new DBGestionCita())
            {
                var Registro = bd.Roles.Find(Entidad.RolId);
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

        public static Roles Registro(int IdRegistro)
        {
            using (DBGestionCita bd = new DBGestionCita())
            return bd.Roles.Find(IdRegistro);
        }


        public static List<Roles>Listar(bool Activo = true)
        {
            using (DBGestionCita bd = new DBGestionCita())
                return bd.Roles.Where(a=>a.Activo==Activo).ToList();


        }




    }
}
