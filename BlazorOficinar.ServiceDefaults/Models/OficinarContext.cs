﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BlazorOficinar.ServiceDefaults.Models;

public partial class OficinarContext : DbContext
{
    public OficinarContext(DbContextOptions<OficinarContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Agendamento> Agendamentos { get; set; }

    public virtual DbSet<AgendamentoServico> AgendamentoServicos { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<PecasCarro> PecasCarros { get; set; }

    public virtual DbSet<Servico> Servicos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Agendamento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("agendamentos_pkey");

            entity.ToTable("agendamentos");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DataCriacao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data_criacao");
            entity.Property(e => e.DataHoraAgendamento)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data_hora_agendamento");
            entity.Property(e => e.DataModificacao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data_modificacao");
            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Agendamentos)
                .HasForeignKey(d => d.IdCliente)
                .HasConstraintName("agendamentos_id_cliente_fkey");
        });

        modelBuilder.Entity<AgendamentoServico>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("agendamento_servicos_pkey");

            entity.ToTable("agendamento_servicos");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DataCriacao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data_criacao");
            entity.Property(e => e.DataModificacao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data_modificacao");
            entity.Property(e => e.IdAgendamento).HasColumnName("id_agendamento");
            entity.Property(e => e.IdServico).HasColumnName("id_servico");

            entity.HasOne(d => d.IdAgendamentoNavigation).WithMany(p => p.AgendamentoServicos)
                .HasForeignKey(d => d.IdAgendamento)
                .HasConstraintName("agendamento_servicos_id_agendamento_fkey");

            entity.HasOne(d => d.IdServicoNavigation).WithMany(p => p.AgendamentoServicos)
                .HasForeignKey(d => d.IdServico)
                .HasConstraintName("agendamento_servicos_id_servico_fkey");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("clientes_pkey");

            entity.ToTable("clientes");

            entity.HasIndex(e => e.Cpf, "clientes_cpf_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Aniversario).HasColumnName("aniversario");
            entity.Property(e => e.Cpf)
                .IsRequired()
                .HasMaxLength(14)
                .HasColumnName("cpf");
            entity.Property(e => e.DataCriacao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data_criacao");
            entity.Property(e => e.DataModificacao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data_modificacao");
            entity.Property(e => e.Endereco)
                .HasMaxLength(255)
                .HasColumnName("endereco");
            entity.Property(e => e.Nome)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<PecasCarro>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pecas_carro_pkey");

            entity.ToTable("pecas_carro");

            entity.HasIndex(e => e.PartNumber, "pecas_carro_part_number_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DataCriacao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data_criacao");
            entity.Property(e => e.DataModificacao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data_modificacao");
            entity.Property(e => e.Descricao).HasColumnName("descricao");
            entity.Property(e => e.PartNumber)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("part_number");
            entity.Property(e => e.Quantidade).HasColumnName("quantidade");
        });

        modelBuilder.Entity<Servico>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("servicos_pkey");

            entity.ToTable("servicos");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.NomeServico)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("nome_servico");
            entity.Property(e => e.PrecoHora)
                .HasPrecision(10, 2)
                .HasColumnName("preco_hora");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}