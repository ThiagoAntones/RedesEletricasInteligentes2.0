using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ApiMysqlRedesEletricasInteligentes.Models;

public partial class DbRedesinteContext : DbContext
{
    public DbRedesinteContext()
    {
    }

    public DbRedesinteContext(DbContextOptions<DbRedesinteContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Nivel1> Nivel1s { get; set; }

    public virtual DbSet<Nivel2> Nivel2s { get; set; }

    public virtual DbSet<Projeto> Projetos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_general_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Nivel1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("nivel1")
                .HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            entity.HasIndex(e => e.Projeto, "Projeto");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("ID");
            entity.Property(e => e.Descricao)
                .HasMaxLength(100)
                .HasColumnName("descricao")
                .UseCollation("utf8mb4_general_ci")
                .HasCharSet("utf8mb4");
            entity.Property(e => e.Projeto)
                .HasColumnType("int(11)")
                .HasColumnName("projeto");

            entity.HasOne(d => d.ProjetoNavigation).WithMany(p => p.Nivel1s)
                .HasForeignKey(d => d.Projeto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("nivel1_ibfk_1");
        });

        modelBuilder.Entity<Nivel2>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("nivel2");

            entity.HasIndex(e => e.Nivel1, "nivel1");

            entity.HasIndex(e => e.Projeto, "projeto");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("ID");
            entity.Property(e => e.Descricao)
                .HasMaxLength(100)
                .HasColumnName("descricao");
            entity.Property(e => e.Nivel1)
                .HasColumnType("int(11)")
                .HasColumnName("nivel1");
            entity.Property(e => e.Projeto)
                .HasColumnType("int(11)")
                .HasColumnName("projeto");

            entity.HasOne(d => d.Nivel1Navigation).WithMany(p => p.Nivel2s)
                .HasForeignKey(d => d.Nivel1)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("nivel2_ibfk_1");

            entity.HasOne(d => d.ProjetoNavigation).WithMany(p => p.Nivel2s)
                .HasForeignKey(d => d.Projeto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("nivel2_ibfk_2");
        });

        modelBuilder.Entity<Projeto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("projetos");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("ID");
            entity.Property(e => e.Custo)
                .HasColumnType("double(10,2)")
                .HasColumnName("custo");
            entity.Property(e => e.Descricao)
                .HasMaxLength(100)
                .HasColumnName("descricao");
            entity.Property(e => e.Inicio).HasColumnName("inicio");
            entity.Property(e => e.Termino).HasColumnName("termino");
            entity.Property(e => e.Titulo)
                .HasMaxLength(20)
                .HasColumnName("titulo");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
