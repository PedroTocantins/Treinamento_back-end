﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmartSchool_WebApi.Data;

namespace SmartSchool_WebApi.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20211115231710_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.12");

            modelBuilder.Entity("SmartSchool_WebApi.Models.Aluno", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("sobrenome")
                        .HasColumnType("TEXT");

                    b.Property<string>("telefone")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Alunos");

                    b.HasData(
                        new
                        {
                            id = 1,
                            nome = "Marta",
                            sobrenome = "Kent",
                            telefone = "33225555"
                        },
                        new
                        {
                            id = 2,
                            nome = "Paula",
                            sobrenome = "Isabela",
                            telefone = "3354288"
                        },
                        new
                        {
                            id = 3,
                            nome = "Laura",
                            sobrenome = "Antonia",
                            telefone = "55668899"
                        },
                        new
                        {
                            id = 4,
                            nome = "Luiza",
                            sobrenome = "Maria",
                            telefone = "6565659"
                        },
                        new
                        {
                            id = 5,
                            nome = "Lucas",
                            sobrenome = "Machado",
                            telefone = "565685415"
                        },
                        new
                        {
                            id = 6,
                            nome = "Pedro",
                            sobrenome = "Alvares",
                            telefone = "456454545"
                        },
                        new
                        {
                            id = 7,
                            nome = "Paulo",
                            sobrenome = "José",
                            telefone = "9874512"
                        });
                });

            modelBuilder.Entity("SmartSchool_WebApi.Models.AlunoDisciplina", b =>
                {
                    b.Property<int>("AlunoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DisciplinaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("AlunoId", "DisciplinaId");

                    b.HasIndex("DisciplinaId");

                    b.ToTable("AlunosDisciplinas");

                    b.HasData(
                        new
                        {
                            AlunoId = 1,
                            DisciplinaId = 2
                        },
                        new
                        {
                            AlunoId = 1,
                            DisciplinaId = 4
                        },
                        new
                        {
                            AlunoId = 1,
                            DisciplinaId = 5
                        },
                        new
                        {
                            AlunoId = 2,
                            DisciplinaId = 1
                        },
                        new
                        {
                            AlunoId = 2,
                            DisciplinaId = 2
                        },
                        new
                        {
                            AlunoId = 2,
                            DisciplinaId = 5
                        },
                        new
                        {
                            AlunoId = 3,
                            DisciplinaId = 1
                        },
                        new
                        {
                            AlunoId = 3,
                            DisciplinaId = 2
                        },
                        new
                        {
                            AlunoId = 3,
                            DisciplinaId = 3
                        },
                        new
                        {
                            AlunoId = 4,
                            DisciplinaId = 1
                        },
                        new
                        {
                            AlunoId = 4,
                            DisciplinaId = 4
                        },
                        new
                        {
                            AlunoId = 4,
                            DisciplinaId = 5
                        },
                        new
                        {
                            AlunoId = 5,
                            DisciplinaId = 4
                        },
                        new
                        {
                            AlunoId = 5,
                            DisciplinaId = 5
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 1
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 2
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 3
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 4
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 1
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 2
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 3
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 4
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 5
                        });
                });

            modelBuilder.Entity("SmartSchool_WebApi.Models.Disciplina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProfessorId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Disciplinas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Matemática",
                            ProfessorId = 1
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Física",
                            ProfessorId = 2
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Português",
                            ProfessorId = 3
                        },
                        new
                        {
                            Id = 4,
                            Nome = "Inglês",
                            ProfessorId = 4
                        },
                        new
                        {
                            Id = 5,
                            Nome = "Programação",
                            ProfessorId = 5
                        });
                });

            modelBuilder.Entity("SmartSchool_WebApi.Models.Professor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Professores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Lauro"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Roberto"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Ronaldo"
                        },
                        new
                        {
                            Id = 4,
                            Nome = "Rodrigo"
                        },
                        new
                        {
                            Id = 5,
                            Nome = "Alexandre"
                        });
                });

            modelBuilder.Entity("SmartSchool_WebApi.Models.AlunoDisciplina", b =>
                {
                    b.HasOne("SmartSchool_WebApi.Models.Aluno", "Aluno")
                        .WithMany()
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartSchool_WebApi.Models.Disciplina", "Disciplina")
                        .WithMany()
                        .HasForeignKey("DisciplinaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aluno");

                    b.Navigation("Disciplina");
                });

            modelBuilder.Entity("SmartSchool_WebApi.Models.Disciplina", b =>
                {
                    b.HasOne("SmartSchool_WebApi.Models.Professor", "Professor")
                        .WithMany("Disciplina")
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Professor");
                });

            modelBuilder.Entity("SmartSchool_WebApi.Models.Professor", b =>
                {
                    b.Navigation("Disciplina");
                });
#pragma warning restore 612, 618
        }
    }
}
