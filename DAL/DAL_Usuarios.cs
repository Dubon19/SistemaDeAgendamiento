using EL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public static class DAL_Usuarios
    {
        public static Usuarios Insert(Usuarios Entidad)
        {
            using (DBGestionCita bd = new DBGestionCita())
            {
                Entidad.Activo = true;
                Entidad.FechaCreacion = DateTime.Now;
                bd.Usuarios.Add(Entidad);
                bd.SaveChanges();
                return Entidad;
            }
        }

        public static Usuarios Update(Usuarios Entidad)
        {
            using (DBGestionCita bd = new DBGestionCita())
            {
                var Registro = bd.Usuarios.Find(Entidad.UsuarioId);
                if (Registro == null)
                {
                    return new Usuarios();
                }

                Registro.Nombre = Entidad.Nombre;
                Registro.Usuario = Entidad.Usuario;
                Registro.RolId = Entidad.RolId;
                Registro.FechaModificacion = DateTime.Now;

                bd.SaveChanges();
                return Registro;
            }
        }

        public static bool Delete(Usuarios Entidad)
        {
            using (DBGestionCita bd = new DBGestionCita())
            {
                var Registro = bd.Usuarios.Find(Entidad.UsuarioId);
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

        public static Usuarios Registro(int IdRegistro)
        {
            using (DBGestionCita bd = new DBGestionCita())
            {
                return bd.Usuarios.Find(IdRegistro);
            }
        }

        public static List<Usuarios> Listar(bool Activo = true)
        {
            using (DBGestionCita bd = new DBGestionCita())
            {
                return bd.Usuarios.Where(a => a.Activo == Activo).ToList();
            }
        }
    }
}
