using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace administacion.Models;

public partial class AdministacionEmpleadosContext : DbContext
{
    public AdministacionEmpleadosContext()
    {
    }

    public AdministacionEmpleadosContext(DbContextOptions<AdministacionEmpleadosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<InsertedBk> InsertedBks { get; set; }

    public virtual DbSet<Tbldepartamento> Tbldepartamentos { get; set; }

    public virtual DbSet<Tblempleado> Tblempleados { get; set; }

    public virtual DbSet<TblestadoCivil> TblestadoCivils { get; set; }

    public virtual DbSet<Tblprueba> Tblpruebas { get; set; }

    public virtual DbSet<Tblpuesto> Tblpuestos { get; set; }

    public virtual DbSet<Tblunidad> Tblunidads { get; set; }

    public virtual DbSet<UsuariosRegistrado> UsuariosRegistrados { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
            //        => optionsBuilder.UseSqlServer("server=DESKTOP-VL3CL3G\\MSSQLSERVER01; Database=AdministacionEmpleados; Trusted_Connection=true; TrustServerCertificate=true;");
        } 
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<InsertedBk>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("insertedBK");

            entity.Property(e => e.ClaveDepartamento).HasColumnName("claveDepartamento");
            entity.Property(e => e.ClavePuesto)
                .ValueGeneratedOnAdd()
                .HasColumnName("clavePuesto");
            entity.Property(e => e.ClaveUnidad).HasColumnName("claveUnidad");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("datetime")
                .HasColumnName("fechaAlta");
            entity.Property(e => e.NombrePuesto)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("nombrePuesto");
        });

        modelBuilder.Entity<Tbldepartamento>(entity =>
        {
            entity.HasKey(e => e.ClaveDepartamento).HasName("PK__Tbldepar__44F0BA604F7A4F63");

            entity.ToTable("Tbldepartamento");

            entity.Property(e => e.ClaveDepartamento).HasColumnName("claveDepartamento");
            entity.Property(e => e.ClaveUnidad).HasColumnName("claveUnidad");
            entity.Property(e => e.FechaAlta)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaAlta");
            entity.Property(e => e.NombreDepartamento)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("nombreDepartamento");
        });

        modelBuilder.Entity<Tblempleado>(entity =>
        {
            entity.HasKey(e => e.ClaveEmpleado).HasName("PK__Tblemple__454BB1E02E11721F");

            entity.Property(e => e.ClaveEmpleado).HasColumnName("claveEmpleado");
            entity.Property(e => e.ApellidoMaterno)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("apellidoMaterno");
            entity.Property(e => e.ApellidoPaterno)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("apellidoPaterno");
            entity.Property(e => e.EstadoCivil).HasColumnName("estadoCivil");
            entity.Property(e => e.FechaInicio)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaInicio");
            entity.Property(e => e.IdDepartamento).HasColumnName("idDepartamento");
            entity.Property(e => e.IdPuesto).HasColumnName("idPuesto");
            entity.Property(e => e.IdUnidad).HasColumnName("idUnidad");
            entity.Property(e => e.NivelEstudios).HasColumnName("nivelEstudios");
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Rfc)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("rfc");
            entity.Property(e => e.Sueldo)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("sueldo");
        });

        modelBuilder.Entity<TblestadoCivil>(entity =>
        {
            entity.HasKey(e => e.ClaveEstadoCivil).HasName("PK__Tblestad__AC09204AB77ECFCD");

            entity.ToTable("TblestadoCivil");

            entity.Property(e => e.ClaveEstadoCivil).HasColumnName("claveEstadoCivil");
            entity.Property(e => e.NombreEstadoCivil)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("nombreEstadoCivil");
        });

        modelBuilder.Entity<Tblprueba>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblpruebas");

            entity.Property(e => e.IdPrueba).HasColumnName("idPrueba");
            entity.Property(e => e.Opcion1)
                .IsUnicode(false)
                .HasColumnName("opcion1");
            entity.Property(e => e.Opcion2)
                .IsUnicode(false)
                .HasColumnName("opcion2");
            entity.Property(e => e.Opcion3)
                .IsUnicode(false)
                .HasColumnName("opcion3");
            entity.Property(e => e.Opcion4)
                .IsUnicode(false)
                .HasColumnName("opcion4");
        });

        modelBuilder.Entity<Tblpuesto>(entity =>
        {
            entity.HasKey(e => e.ClavePuesto).HasName("PK__Tblpuest__1B8DE47C743653B0");

            entity.ToTable(tb => tb.HasTrigger("creaPuestos"));

            entity.Property(e => e.ClavePuesto).HasColumnName("clavePuesto");
            entity.Property(e => e.ClaveDepartamento).HasColumnName("claveDepartamento");
            entity.Property(e => e.ClaveUnidad).HasColumnName("claveUnidad");
            entity.Property(e => e.FechaAlta)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaAlta");
            entity.Property(e => e.NombrePuesto)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("nombrePuesto");
        });

        modelBuilder.Entity<Tblunidad>(entity =>
        {
            entity.HasKey(e => e.ClaveUnidad).HasName("PK__Tblunida__96CB4819D30EBD09");

            entity.ToTable("Tblunidad");

            entity.Property(e => e.ClaveUnidad).HasColumnName("claveUnidad");
            entity.Property(e => e.FechaAlta)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaAlta");
            entity.Property(e => e.NombreUnidad)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("nombreUnidad");
        });

        modelBuilder.Entity<UsuariosRegistrado>(entity =>
        {
            entity.HasKey(e => e.NumeroRegistro).HasName("PK__usuarios__58DC1A5328B7D8CF");

            entity.ToTable("usuariosRegistrados");

            entity.Property(e => e.NumeroRegistro)
                .ValueGeneratedNever()
                .HasColumnName("numeroRegistro");
            entity.Property(e => e.Alias)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("alias");
            entity.Property(e => e.Contrasena)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("contrasena");
            entity.Property(e => e.Correo)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("correo");
            entity.Property(e => e.IdUsuario)
                .ValueGeneratedOnAdd()
                .HasColumnName("idUsuario");
            entity.Property(e => e.NombreCompleto)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("nombreCompleto");
            entity.Property(e => e.TipoUsuario).HasColumnName("tipoUsuario");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
