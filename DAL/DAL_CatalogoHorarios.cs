using EL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public static class DAL_CatalogoHorarios
    {
        public static CatalogoHorarios Insert(CatalogoHorarios Entidad)
        {
            using (BDAgendamiento bd = new BDAgendamiento())
            {
                Entidad.Activo = true;
                Entidad.FechaCreacion = DateTime.Now;
                bd.CatalogoHorarios.Add(Entidad);
                bd.SaveChanges();
                return Entidad;
            }
        }

        public static CatalogoHorarios Update(CatalogoHorarios Entidad)
        {
            using (BDAgendamiento bd = new BDAgendamiento())
            {
                var Registro = bd.CatalogoHorarios.Find(Entidad.CatalogoHorarioId);
                if (Registro == null)
                {
                    return new CatalogoHorarios();
                }

                Registro.DiaSemanaInicio = Entidad.DiaSemanaInicio;
                Registro.DiaSemanaFin = Entidad.DiaSemanaFin;
                Registro.HoraInicio = Entidad.HoraInicio;
                Registro.HoraFin = Entidad.HoraFin;
                Registro.DiaLibre = Entidad.DiaLibre;
                Registro.FechaModificacion = DateTime.Now;
                bd.SaveChanges();
                return Registro;
            }
        }

        public static bool Delete(CatalogoHorarios Entidad)
        {
            using (BDAgendamiento bd = new BDAgendamiento())
            {
                var Registro = bd.CatalogoHorarios.Find(Entidad.CatalogoHorarioId);
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

        public static CatalogoHorarios Registro(int IdRegistro)
        {
            using (BDAgendamiento bd = new BDAgendamiento())
            {
                return bd.CatalogoHorarios.Find(IdRegistro);
            }
        }

        public static List<CatalogoHorarios> Listar(bool Activo = true)
        {
            using (BDAgendamiento bd = new BDAgendamiento())
            {
                return bd.CatalogoHorarios.Where(a => a.Activo == Activo).ToList();
            }
        }
    }
}

