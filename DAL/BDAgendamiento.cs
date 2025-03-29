using EL;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace DAL
{
    public class DBGestionCita : DbContext

    {
        public DBGestionCita() : base(Conexion.ConexionString(true)) {}



        public virtual DbSet<CatalogoHorarios> CatalogoHorarios { get; set; }
        public virtual DbSet<Citas> Citas { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<Empleados> Empleados { get; set; }
        public virtual DbSet<Permisos> Permisos { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Servicios> Servicios { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<Vacaciones> Vacaciones { get; set; }

        public virtual DbSet<RolesPermisos> RolesPermisos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CatalogoHorarios>().Property(e => e.CatalogoHorarioId).HasColumnType("INT");
            modelBuilder.Entity<Citas>().Property(e => e.CitaId).HasColumnType("INT");
            modelBuilder.Entity<Clientes>().Property(e => e.ClienteId).HasColumnType("INT");
            modelBuilder.Entity<Empleados>().Property(e => e.EmpleadoId).HasColumnType("INT");
            modelBuilder.Entity<Permisos>().Property(e => e.PermisoId).HasColumnType("INT");
            modelBuilder.Entity<Roles>().Property(e => e.RolId).HasColumnType("INT");
            modelBuilder.Entity<Servicios>().Property(e => e.ServicioId).HasColumnType("INT"); 
            modelBuilder.Entity<Usuarios>().Property(e => e.UsuarioId).HasColumnType("INT");
            modelBuilder.Entity<Vacaciones>().Property(e => e.VacacionId).HasColumnType("INT");





        }




    }
}
