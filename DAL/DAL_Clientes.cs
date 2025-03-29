using EL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public static class DAL_Clientes
    {
        public static Clientes Insert(Clientes Entidad)
        {
            using (DBGestionCita bd = new DBGestionCita())
            {
                Entidad.Activo = true;
                Entidad.FechaCreacion = DateTime.Now;
                bd.Clientes.Add(Entidad);
                bd.SaveChanges();
                return Entidad;
            }
        }

        public static Clientes Update(Clientes Entidad)
        {
            using (DBGestionCita bd = new DBGestionCita())
            {
                var Registro = bd.Clientes.Find(Entidad.ClienteId);
                if (Registro == null)
                {
                    return new Clientes();
                }

                Registro.Nombre = Entidad.Nombre;
                Registro.Apellido = Entidad.Apellido;
                Registro.Email = Entidad.Email;
                Registro.Telefono = Entidad.Telefono;
                Registro.FechaModificacion = DateTime.Now;
                bd.SaveChanges();
                return Registro;
            }
        }

        public static bool Delete(Clientes Entidad)
        {
            using (DBGestionCita bd = new DBGestionCita())
            {
                var Registro = bd.Clientes.Find(Entidad.ClienteId);
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

        public static Clientes Registro(int IdRegistro)
        {
            using (DBGestionCita bd = new DBGestionCita())
            {
                return bd.Clientes.Find(IdRegistro);
            }
        }

        public static List<Clientes> Listar(bool Activo = true)
        {
            using (DBGestionCita bd = new DBGestionCita())
            {
                return bd.Clientes.Where(a => a.Activo == Activo).ToList();
            }
        }
    }
}

