﻿// <auto-generated />
using System;
using EstudiantePrueba.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EstudiantePrueba.Migrations
{
    [DbContext(typeof(ContextDB))]
    [Migration("20240502011647_ini4")]
    partial class ini4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EstudiantePrueba.Entidades.Asistencia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("EstudianteId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EstudianteId1")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("Date");

                    b.HasKey("Id");

                    b.HasIndex("EstudianteId1");

                    b.ToTable("Asistencia");
                });

            modelBuilder.Entity("EstudiantePrueba.Entidades.Calificacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EstudianteId")
                        .HasColumnType("int");

                    b.Property<int>("MaestroId")
                        .HasColumnType("int");

                    b.Property<int>("MateriaId")
                        .HasColumnType("int");

                    b.Property<decimal>("Nota")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("PeriodoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EstudianteId");

                    b.HasIndex("MaestroId");

                    b.HasIndex("MateriaId");

                    b.HasIndex("PeriodoId");

                    b.ToTable("Calificaciones");
                });

            modelBuilder.Entity("EstudiantePrueba.Entidades.Estudiante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Curso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("Sexo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Estudiantes");
                });

            modelBuilder.Entity("EstudiantePrueba.Entidades.Maestro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<string>("GradoObtenido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("Sexo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Maestro");
                });

            modelBuilder.Entity("EstudiantePrueba.Entidades.Materia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Asignatura")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Materia");
                });

            modelBuilder.Entity("EstudiantePrueba.Entidades.Periodo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("PeriodoEvaluacion")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Periodo");
                });

            modelBuilder.Entity("EstudiantePrueba.Entidades.Asistencia", b =>
                {
                    b.HasOne("EstudiantePrueba.Entidades.Estudiante", "Estudiante")
                        .WithMany()
                        .HasForeignKey("EstudianteId1");

                    b.Navigation("Estudiante");
                });

            modelBuilder.Entity("EstudiantePrueba.Entidades.Calificacion", b =>
                {
                    b.HasOne("EstudiantePrueba.Entidades.Estudiante", "Estudiante")
                        .WithMany()
                        .HasForeignKey("EstudianteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EstudiantePrueba.Entidades.Maestro", "Maestro")
                        .WithMany()
                        .HasForeignKey("MaestroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EstudiantePrueba.Entidades.Materia", "Materia")
                        .WithMany()
                        .HasForeignKey("MateriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EstudiantePrueba.Entidades.Periodo", "Periodo")
                        .WithMany()
                        .HasForeignKey("PeriodoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estudiante");

                    b.Navigation("Maestro");

                    b.Navigation("Materia");

                    b.Navigation("Periodo");
                });
#pragma warning restore 612, 618
        }
    }
}
