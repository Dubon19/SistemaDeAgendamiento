﻿using EL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public static class DAL_Servicios
    {
        public static Servicios Insert(Servicios Entidad)
        {
            using (BDAgendamiento bd = new BDAgendamiento())
            {
                Entidad.Activo = true;
                Entidad.FechaCreacion = DateTime.Now;
                bd.Servicios.Add(Entidad);
                bd.SaveChanges();
                return Entidad;
            }
        }

        public static Servicios Update(Servicios Entidad)
        {
            using (BDAgendamiento bd = new BDAgendamiento())
            {
                var Registro = bd.Servicios.Find(Entidad.ServicioId);
                if (Registro == null)
                {
                    return new Servicios();
                }

                Registro.Nombre = Entidad.Nombre;
                Registro.Duracion = Entidad.Duracion;
                Registro.FechaModificacion = DateTime.Now;

                bd.SaveChanges();
                return Registro;
            }
        }

        public static bool Delete(Servicios Entidad)
        {
            using (BDAgendamiento bd = new BDAgendamiento())
            {
                var Registro = bd.Servicios.Find(Entidad.ServicioId);
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

        public static Servicios Registro(int IdRegistro)
        {
            using (BDAgendamiento bd = new BDAgendamiento())
            {
                return bd.Servicios.Find(IdRegistro);
            }
        }

        public static List<Servicios> Listar(bool Activo = true)
        {
            using (BDAgendamiento bd = new BDAgendamiento())
            {
                return bd.Servicios.Where(a => a.Activo == Activo).ToList();
            }
        }
    }
}

