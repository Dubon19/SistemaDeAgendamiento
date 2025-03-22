﻿using EL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public static class DAL_Empleados
    {
        public static Empleados Insert(Empleados Entidad)
        {
            using (BDAgendamiento bd = new BDAgendamiento())
            {
                Entidad.Activo = true;
                Entidad.FechaCreacion = DateTime.Now;
                bd.Empleados.Add(Entidad);
                bd.SaveChanges();
                return Entidad;
            }
        }

        public static Empleados Update(Empleados Entidad)
        {
            using (BDAgendamiento bd = new BDAgendamiento())
            {
                var Registro = bd.Empleados.Find(Entidad.EmpleadoId);
                if (Registro == null)
                {
                    return new Empleados();
                }

                Registro.Nombre = Entidad.Nombre;
                Registro.Telefono = Entidad.Telefono;
                Registro.Email = Entidad.Email;
                Registro.CatalogoHorarioId = Entidad.CatalogoHorarioId;
                Registro.FechaModificacion = DateTime.Now;

                bd.SaveChanges();
                return Registro;
            }
        }

        public static bool Delete(Empleados Entidad)
        {
            using (BDAgendamiento bd = new BDAgendamiento())
            {
                var Registro = bd.Empleados.Find(Entidad.EmpleadoId);
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

        public static Empleados Registro(int IdRegistro)
        {
            using (BDAgendamiento bd = new BDAgendamiento())
            {
                return bd.Empleados.Find(IdRegistro);
            }
        }

        public static List<Empleados> Listar(bool Activo = true)
        {
            using (BDAgendamiento bd = new BDAgendamiento())
            {
                return bd.Empleados.Where(a => a.Activo == Activo).ToList();
            }
        }
    }
}
