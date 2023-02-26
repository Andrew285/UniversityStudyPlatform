﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
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
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("UniversityStudyPlatform.Models.AccountBook", b =>
                {
                    b.Property<int>("AccountBookId")
                        .HasColumnType("int");

                    b.HasKey("AccountBookId");

                    b.ToTable("AccountBooks");
                });

            modelBuilder.Entity("UniversityStudyPlatform.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("UniversityStudyPlatform.Models.StudentPerfomance", b =>
                {
                    b.Property<int>("StudentPerfomanceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentPerfomanceId"));

                    b.Property<int>("AccountBookId")
                        .HasColumnType("int");

                    b.Property<float>("CurrentPoint")
                        .HasColumnType("real");

                    b.Property<float>("ExamPoint")
                        .HasColumnType("real");

                    b.Property<int>("SemesterNumber")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

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
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubjectId"));

                    b.Property<string>("SubjectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubjectId");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("UniversityStudyPlatform.Models.AccountBook", b =>
                {
                    b.HasOne("UniversityStudyPlatform.Models.Student", "Student")
                        .WithOne("AccountBook")
                        .HasForeignKey("UniversityStudyPlatform.Models.AccountBook", "AccountBookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
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

            modelBuilder.Entity("UniversityStudyPlatform.Models.Student", b =>
                {
                    b.Navigation("AccountBook")
                        .IsRequired();
                });

            modelBuilder.Entity("UniversityStudyPlatform.Models.Subject", b =>
                {
                    b.Navigation("StudentPerfomances");
                });
#pragma warning restore 612, 618
        }
    }
}
