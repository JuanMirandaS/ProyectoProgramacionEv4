using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ProyectoProgramacionEv4.git.Models;

namespace ProyectoProgramacionEv4.git.DBContext
{
    public partial class infolutions_agenda_clienteContext : DbContext
    {
        public infolutions_agenda_clienteContext()
        {
        }

        public infolutions_agenda_clienteContext(DbContextOptions<infolutions_agenda_clienteContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AgendaCliente> AgendaClientes { get; set; } = null!;
        public virtual DbSet<Cliente> Clientes { get; set; } = null!;
        public virtual DbSet<Proyecto> Proyectos { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-P7V4D85\\SQLEXPRESS;Database=infolutions_agenda_cliente;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AgendaCliente>(entity =>
            {
                entity.ToTable("agenda_clientes");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Correo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.Empresa)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("empresa");

                entity.Property(e => e.FechaDeIngreso)
                    .HasColumnType("date")
                    .HasColumnName("fecha_de_ingreso");

                entity.Property(e => e.FechaHoraAtencionOficina)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_hora_atencion_oficina");

                entity.Property(e => e.HoraDeAgenda)
                    .HasColumnType("datetime")
                    .HasColumnName("hora_de_agenda");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Proyecto)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("proyecto");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("telefono");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.ToTable("clientes");

                entity.HasIndex(e => e.Correo, "UQ__clientes__2A586E0B77CE46DE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Correo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.Empresa)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("empresa");

                entity.Property(e => e.FechaHoraAtencionOficina)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_hora_atencion_oficina");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnType("date")
                    .HasColumnName("fecha_ingreso");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("telefono");
            });

            modelBuilder.Entity<Proyecto>(entity =>
            {
                entity.ToTable("proyectos");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClienteId).HasColumnName("cliente_id");

                entity.Property(e => e.Descripcion)
                    .HasColumnType("text")
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("('En Proceso')");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_creacion")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.Proyectos)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__proyectos__clien__46E78A0C");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("usuarios");

                entity.HasIndex(e => e.Correo, "UQ__usuarios__2A586E0B5FEAA5DE")
                    .IsUnique();

                entity.HasIndex(e => e.NombreUsuario, "UQ__usuarios__D4D22D74111BA0D0")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ContrasenaHash)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("contrasena_hash");

                entity.Property(e => e.Correo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.NombreUsuario)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre_usuario");

                entity.Property(e => e.Rol)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("rol");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
