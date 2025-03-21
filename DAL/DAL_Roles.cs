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
            using (BDAgendamiento bd = new BDAgendamiento())
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
            using (BDAgendamiento bd = new BDAgendamiento())
            {
                var Registro = bd.Roles.Find(Entidad.RolId);
                if (Registro == null)
                {
                    return new Roles();

                }
                Registro.RolId = Entidad.RolId;
                Registro.FechaModificacion = DateTime.Now;
                bd.SaveChanges();
                return Registro;

            }


        }

        public static bool Delete(Roles Entidad)
        {
            using (BDAgendamiento bd = new BDAgendamiento())
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
            using (BDAgendamiento bd = new BDAgendamiento())
            return bd.Roles.Find(IdRegistro);
        }


        public static List<Roles>Listar(bool Activo = true)
        {
            using (BDAgendamiento bd = new BDAgendamiento())
                return bd.Roles.Where(a=>a.Activo==Activo).ToList();


        }




    }
}
