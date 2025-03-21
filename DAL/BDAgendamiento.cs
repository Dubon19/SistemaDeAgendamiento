using EL;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace DAL
{
    public class BDAgendamiento : DbContext

    {
        public BDAgendamiento() : base(Conexion.ConexionString(true)) {}



        public virtual DbSet<CatalogoHorarios> CatalogoHorarios { get; set; }
        public virtual DbSet<Citas> Citas { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<Empleados> Empleados { get; set; }
        public virtual DbSet<Permisos> Permisos { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Servicios> Servicios { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<Vacaciones> Vacaciones { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CatalogoHorarios>().Property(e => e.CatalogoHorarioId).HasColumnType("nvarchar");
            modelBuilder.Entity<Citas>().Property(e => e.CitaId).HasColumnType("nvarchar");
            modelBuilder.Entity<Clientes>().Property(e => e.ClienteId).HasColumnType("nvarchar");
            modelBuilder.Entity<Empleados>().Property(e => e.EmpleadoId).HasColumnType("nvarchar");
            modelBuilder.Entity<Permisos>().Property(e => e.PermisoId).HasColumnType("nvarchar");
            modelBuilder.Entity<Roles>().Property(e => e.RolId).HasColumnType("nvarchar");
            modelBuilder.Entity<Servicios>().Property(e => e.ServicioId).HasColumnType("nvarchar"); 
            modelBuilder.Entity<Usuarios>().Property(e => e.UsuarioId).HasColumnType("nvarchar");
            modelBuilder.Entity<Vacaciones>().Property(e => e.VacacionId).HasColumnType("nvarchar");





        }




    }
}
