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
            using (BDAgendamiento bd = new BDAgendamiento())
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
            using (BDAgendamiento bd = new BDAgendamiento())
            {
                var Registro = bd.Clientes.Find(Entidad.ClienteId);
                if (Registro == null)
                {
                    return new Clientes();
                }

                Registro.Name = Entidad.Name;
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
            using (BDAgendamiento bd = new BDAgendamiento())
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
            using (BDAgendamiento bd = new BDAgendamiento())
            {
                return bd.Clientes.Find(IdRegistro);
            }
        }

        public static List<Clientes> Listar(bool Activo = true)
        {
            using (BDAgendamiento bd = new BDAgendamiento())
            {
                return bd.Clientes.Where(a => a.Activo == Activo).ToList();
            }
        }
    }
}

