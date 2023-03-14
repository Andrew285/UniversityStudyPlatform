﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using UniversityStudyPlatform.DataAccess.Data;

#nullable disable

namespace UniversityStudyPlatform.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("UniversityStudyPlatform.Models.AccountBook", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("GroupId")
                        .HasColumnType("integer");

                    b.Property<int>("StudentId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("StudentId")
                        .IsUnique();

                    b.ToTable("AccountBooks");
                });

            modelBuilder.Entity("UniversityStudyPlatform.Models.Assignment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CourseId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Assignments");
                });

            modelBuilder.Entity("UniversityStudyPlatform.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("SubjectId")
                        .HasColumnType("integer");

                    b.Property<int>("TeacherId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("SubjectId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("UniversityStudyPlatform.Models.CourseGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CourseId")
                        .HasColumnType("integer");

                    b.Property<int>("GroupId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("GroupId");

                    b.ToTable("CourseGroups");
                });

            modelBuilder.Entity("UniversityStudyPlatform.Models.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("StudentAmount")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("UniversityStudyPlatform.Models.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("CourseId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("UniversityStudyPlatform.Models.Shedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Faculty")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("GroupId")
                        .HasColumnType("integer");

                    b.Property<int>("SubjectId")
                        .HasColumnType("integer");

                    b.Property<int>("TeacherId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("SubjectId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Shedule");
                });

            modelBuilder.Entity("UniversityStudyPlatform.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("UniversityStudyPlatform.Models.StudentPerfomance", b =>
                {
                    b.Property<int>("StudentPerfomanceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("StudentPerfomanceId"));

                    b.Property<int>("AccountBookId")
                        .HasColumnType("integer");

                    b.Property<float>("CurrentPoint")
                        .HasColumnType("real");

                    b.Property<float>("ExamPoint")
                        .HasColumnType("real");

                    b.Property<int>("SemesterNumber")
                        .HasColumnType("integer");

                    b.Property<int>("SubjectId")
                        .HasColumnType("integer");

                    b.Property<float>("TotalPoint")
                        .HasColumnType("real");

                    b.HasKey("StudentPerfomanceId");

                    b.HasIndex("AccountBookId");

                    b.HasIndex("SubjectId");

                    b.ToTable("StudentPerfomances");
                });

            modelBuilder.Entity("UniversityStudyPlatform.Models.Subject", b =>
                {
                    b.Property<int>("SubjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("SubjectId"));

                    b.Property<string>("SubjectName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("SubjectId");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("UniversityStudyPlatform.Models.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Teacher");
                });

            modelBuilder.Entity("UniversityStudyPlatform.Models.AccountBook", b =>
                {
                    b.HasOne("UniversityStudyPlatform.Models.Group", "Group")
                        .WithMany("AccountBooks")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniversityStudyPlatform.Models.Student", "Student")
                        .WithOne("AccountBook")
                        .HasForeignKey("UniversityStudyPlatform.Models.AccountBook", "StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("UniversityStudyPlatform.Models.Assignment", b =>
                {
                    b.HasOne("UniversityStudyPlatform.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("UniversityStudyPlatform.Models.Course", b =>
                {
                    b.HasOne("UniversityStudyPlatform.Models.Subject", "Subject")
                        .WithMany("Courses")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniversityStudyPlatform.Models.Teacher", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subject");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("UniversityStudyPlatform.Models.CourseGroup", b =>
                {
                    b.HasOne("UniversityStudyPlatform.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniversityStudyPlatform.Models.Group", "Group")
                        .WithMany("CourseGroups")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Group");
                });

            modelBuilder.Entity("UniversityStudyPlatform.Models.Message", b =>
                {
                    b.HasOne("UniversityStudyPlatform.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("UniversityStudyPlatform.Models.Shedule", b =>
                {
                    b.HasOne("UniversityStudyPlatform.Models.Group", "Group")
                        .WithMany("Shedule")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniversityStudyPlatform.Models.Subject", "Subject")
                        .WithMany("Shedule")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniversityStudyPlatform.Models.Teacher", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");

                    b.Navigation("Subject");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("UniversityStudyPlatform.Models.StudentPerfomance", b =>
                {
                    b.HasOne("UniversityStudyPlatform.Models.AccountBook", "AccountBook")
                        .WithMany("StudentPerfomances")
                        .HasForeignKey("AccountBookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniversityStudyPlatform.Models.Subject", "Subject")
                        .WithMany("StudentPerfomances")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AccountBook");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("UniversityStudyPlatform.Models.AccountBook", b =>
                {
                    b.Navigation("StudentPerfomances");
                });

            modelBuilder.Entity("UniversityStudyPlatform.Models.Group", b =>
                {
                    b.Navigation("AccountBooks");

                    b.Navigation("CourseGroups");

                    b.Navigation("Shedule");
                });

            modelBuilder.Entity("UniversityStudyPlatform.Models.Student", b =>
                {
                    b.Navigation("AccountBook")
                        .IsRequired();
                });

            modelBuilder.Entity("UniversityStudyPlatform.Models.Subject", b =>
                {
                    b.Navigation("Courses");

                    b.Navigation("Shedule");

                    b.Navigation("StudentPerfomances");
                });
#pragma warning restore 612, 618
        }
    }
}
