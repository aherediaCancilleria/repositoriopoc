using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// <summary>
// Contexto de Base de Datos
// </summary>
// <param></param>
// <returns></returns>
namespace mremh_netcore_data.Models
{
    public partial class poc_ahdContext : DbContext
    {
        public poc_ahdContext()
        {
        }

        public poc_ahdContext(DbContextOptions<poc_ahdContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Arquitectura> Arquitectura { get; set; }
        public virtual DbSet<BaseDatos> BaseDatos { get; set; }
        public virtual DbSet<CodigoFuente> CodigoFuente { get; set; }
        public virtual DbSet<Estado> Estado { get; set; }
        public virtual DbSet<Sistema> Sistema { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("User ID=mremh_sgpj;Password=sgpjwww;Server=10.10.8.9;Port=5432;Database=poc_ahd;Integrated Security=true;Pooling=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Arquitectura>(entity =>
            {
                entity.ToTable("arquitectura", "poc");

                entity.Property(e => e.ArquitecturaId)
                    .HasColumnName("arquitectura_id")
                    .HasDefaultValueSql("nextval('poc.arquitectura_arquitectura_id_seq'::regclass)");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BaseDatos>(entity =>
            {
                entity.ToTable("base_datos", "poc");

                entity.Property(e => e.BaseDatosId)
                    .HasColumnName("base_datos_id")
                    .HasDefaultValueSql("nextval('poc.base_datos_base_datos_id_seq'::regclass)");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CodigoFuente>(entity =>
            {
                entity.ToTable("codigo_fuente", "poc");

                entity.Property(e => e.CodigoFuenteId)
                    .HasColumnName("codigo_fuente_id")
                    .HasDefaultValueSql("nextval('poc.codigo_fuente_codigo_fuente_id_seq'::regclass)");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Estado>(entity =>
            {
                entity.ToTable("estado", "poc");

                entity.Property(e => e.EstadoId)
                    .HasColumnName("estado_id")
                    .HasDefaultValueSql("nextval('poc.estado_estado_id_seq'::regclass)");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Sistema>(entity =>
            {
                entity.HasKey(e => e.IdSistema);

                entity.ToTable("sistema", "poc");

                entity.Property(e => e.IdSistema)
                    .HasColumnName("id_sistema")
                    .HasDefaultValueSql("nextval('poc.sistema_id_sistema_seq'::regclass)");

                entity.Property(e => e.AnioProduccion).HasColumnName("anio_produccion");

                entity.Property(e => e.Arquitectura).HasColumnName("arquitectura");

                entity.Property(e => e.BaseDatos).HasColumnName("base_datos");

                entity.Property(e => e.CodigoFuente).HasColumnName("codigo_fuente");

                entity.Property(e => e.DependenciaSistemas).HasColumnName("dependencia_sistemas");

                entity.Property(e => e.Descripcion).HasColumnName("descripcion");

                entity.Property(e => e.Documento).HasColumnName("documento");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaCreacion).HasColumnName("fecha_creacion");

                entity.Property(e => e.FechaModificacion).HasColumnName("fecha_modificacion");

                entity.Property(e => e.Isactivo).HasColumnName("isactivo");

                entity.Property(e => e.LinkAcceso).HasColumnName("link_acceso");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre");

                entity.Property(e => e.Observaciones).HasColumnName("observaciones");

                entity.Property(e => e.Siglas).HasColumnName("siglas");

                entity.Property(e => e.UsuarioCreacion).HasColumnName("usuario_creacion");

                entity.Property(e => e.UsuarioModificacion).HasColumnName("usuario_modificacion");
            });

            modelBuilder.HasSequence("arquitectura_arquitectura_id_seq");

            modelBuilder.HasSequence("base_datos_base_datos_id_seq");

            modelBuilder.HasSequence("codigo_fuente_codigo_fuente_id_seq");

            modelBuilder.HasSequence("estado_estado_id_seq");

            modelBuilder.HasSequence("sistema_id_sistema_seq");
        }
    }
}
