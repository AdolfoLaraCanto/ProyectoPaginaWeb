using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace InventarioPaginaWeb.Models
{
    public partial class inventarioContext : DbContext
    {
        string connectionString;

        public inventarioContext (String connectionString)
        {
            this.connectionString = connectionString;
        }

        public inventarioContext()
        {
        }

        public inventarioContext(DbContextOptions<inventarioContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Datos> Datos { get; set; }
        public virtual DbSet<DependenciaEntidad> DependenciaEntidad { get; set; }
        public virtual DbSet<Encargado> Encargado { get; set; }
        public virtual DbSet<Inventario> Inventario { get; set; }
        public virtual DbSet<Motivo> Motivo { get; set; }
        public virtual DbSet<Revision> Revision { get; set; }
        public virtual DbSet<TipoRegistro> TipoRegistro { get; set; }
        public virtual DbSet<Verificador> Verificador { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql(connectionString);
                //optionsBuilder.UseMySql("Server=localhost;Database=inventario;User=PaginaWeb;Password=cisco;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Datos>(entity =>
            {
                entity.HasKey(e => e.IdDatos)
                    .HasName("PRIMARY");

                entity.ToTable("datos");

                entity.HasIndex(e => e.RDependenciaEntidad)
                    .HasName("Datos_idx");

                entity.Property(e => e.IdDatos)
                    .HasColumnName("idDatos")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descripcion).HasColumnType("varchar(45)");

                entity.Property(e => e.Marca).HasColumnType("varchar(45)");

                entity.Property(e => e.Modelo).HasColumnType("varchar(45)");

                entity.Property(e => e.NoSerie)
                    .HasColumnName("No_Serie")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Observaciones).HasColumnType("varchar(45)");

                entity.Property(e => e.RDependenciaEntidad)
                    .HasColumnName("R_Dependencia_Entidad")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<DependenciaEntidad>(entity =>
            {
                entity.HasKey(e => e.IdDependenciaEntidad)
                    .HasName("PRIMARY");

                entity.ToTable("dependencia_entidad");

                entity.Property(e => e.IdDependenciaEntidad)
                    .HasColumnName("idDependencia_Entidad")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Departamento).HasColumnType("varchar(45)");

                entity.Property(e => e.UbicacionFisica)
                    .HasColumnName("Ubicacion_Fisica")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.UbicacionSistema)
                    .HasColumnName("Ubicacion_Sistema")
                    .HasColumnType("varchar(45)");
            });

            modelBuilder.Entity<Encargado>(entity =>
            {
                entity.HasKey(e => e.IdEncargado)
                    .HasName("PRIMARY");

                entity.ToTable("encargado");

                entity.Property(e => e.IdEncargado)
                    .HasColumnName("idEncargado")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Apellido).HasColumnType("varchar(45)");

                entity.Property(e => e.ClaveEncargado)
                    .HasColumnName("Clave_Encargado")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Nombre).HasColumnType("varchar(45)");
            });

            modelBuilder.Entity<Inventario>(entity =>
            {
                entity.HasKey(e => e.IdInventario)
                    .HasName("PRIMARY");

                entity.ToTable("inventario");

                entity.HasIndex(e => e.RCliente)
                    .HasName("Inventario_idx");

                entity.HasIndex(e => e.RRevision)
                    .HasName("Inventario_idx4");

                entity.HasIndex(e => e.RTipoRegistro)
                    .HasName("Inventario_idx3");

                entity.HasIndex(e => e.RVerificador)
                    .HasName("Inventario_idx1");

                entity.Property(e => e.IdInventario)
                    .HasColumnName("idInventario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.RCliente)
                    .HasColumnName("R_Cliente")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RRevision)
                    .HasColumnName("R_Revision")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RTipoRegistro)
                    .HasColumnName("R_Tipo_Registro")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RVerificador)
                    .HasColumnName("R_Verificador")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Status).HasColumnType("varchar(45)");
            });

            modelBuilder.Entity<Motivo>(entity =>
            {
                entity.HasKey(e => e.IdMotivo)
                    .HasName("PRIMARY");

                entity.ToTable("motivo");

                entity.Property(e => e.IdMotivo)
                    .HasColumnName("idMotivo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NombreMotivo)
                    .HasColumnName("Nombre_Motivo")
                    .HasColumnType("varchar(45)");
            });

            modelBuilder.Entity<Revision>(entity =>
            {
                entity.HasKey(e => e.IdRevision)
                    .HasName("PRIMARY");

                entity.ToTable("revision");

                entity.HasIndex(e => e.RMotivo)
                    .HasName("Revision_idx");

                entity.Property(e => e.IdRevision)
                    .HasColumnName("idRevision")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descripcion).HasColumnType("varchar(45)");

                entity.Property(e => e.NumReporte)
                    .HasColumnName("Num_Reporte")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RMotivo)
                    .HasColumnName("R_Motivo")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<TipoRegistro>(entity =>
            {
                entity.HasKey(e => e.IdRegistro)
                    .HasName("PRIMARY");

                entity.ToTable("tipo_registro");

                entity.HasIndex(e => e.RDatos)
                    .HasName("Tipo_Registro_idx");

                entity.Property(e => e.IdRegistro)
                    .HasColumnName("idRegistro")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RDatos)
                    .HasColumnName("R_Datos")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TipoRegistro1)
                    .HasColumnName("Tipo_Registro")
                    .HasColumnType("varchar(45)");
            });

            modelBuilder.Entity<Verificador>(entity =>
            {
                entity.HasKey(e => e.IdVerificador)
                    .HasName("PRIMARY");

                entity.ToTable("verificador");

                entity.Property(e => e.IdVerificador)
                    .HasColumnName("idVerificador")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Apellido).HasColumnType("varchar(45)");

                entity.Property(e => e.Nombre).HasColumnType("varchar(45)");
            });
        }
    }
}
