﻿// <auto-generated />
using MicrodadosEnemSergipe.WebApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MicrodadosEnemSergipe.WebApp.Migrations
{
    [DbContext(typeof(ContextConnection))]
    [Migration("20240321101724_AdicionarTabelaUsuario")]
    partial class AdicionarTabelaUsuario
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Participante", b =>
                {
                    b.Property<string>("NumeroInscricao")
                        .HasColumnType("text")
                        .HasColumnName("numero_inscricao");

                    b.Property<int>("AnoEnem")
                        .HasColumnType("integer")
                        .HasColumnName("ano_enem");

                    b.Property<string>("EstadoCivil")
                        .HasColumnType("text")
                        .HasColumnName("estado_civil");

                    b.Property<string>("FaixaEtaria")
                        .HasColumnType("text")
                        .HasColumnName("faixa_etaria");

                    b.Property<string>("Nacionalidade")
                        .HasColumnType("text")
                        .HasColumnName("nacionalidade");

                    b.Property<string>("Raca")
                        .HasColumnType("text")
                        .HasColumnName("raca");

                    b.Property<string>("Sexo")
                        .HasColumnType("text")
                        .HasColumnName("sexo");

                    b.Property<int>("Treineiro")
                        .HasColumnType("integer")
                        .HasColumnName("treineiro");

                    b.HasKey("NumeroInscricao");

                    b.ToTable("participante");
                });

            modelBuilder.Entity("Usuario", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<string>("Email")
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<bool>("IsAdministrador")
                        .HasColumnType("boolean")
                        .HasColumnName("isadministrador");

                    b.Property<string>("Nome")
                        .HasColumnType("text")
                        .HasColumnName("nome");

                    b.Property<string>("Senha")
                        .HasColumnType("text")
                        .HasColumnName("senha");

                    b.HasKey("ID");

                    b.ToTable("usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
