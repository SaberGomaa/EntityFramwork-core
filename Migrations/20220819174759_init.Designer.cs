﻿// <auto-generated />
using System;
using EntityFramwork.net5;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EntityFramwork.net5.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220819174759_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EntityFramwork.net5.Attendance", b =>
                {
                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmpolyeeID")
                        .HasColumnType("int");

                    b.HasKey("EmployeeID", "Date");

                    b.HasIndex("EmpolyeeID");

                    b.ToTable("Attendances");
                });

            modelBuilder.Entity("EntityFramwork.net5.Branch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Branchs");
                });

            modelBuilder.Entity("EntityFramwork.net5.Department", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("BranchID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("BranchID");

                    b.ToTable("Departments", (string)null);
                });

            modelBuilder.Entity("EntityFramwork.net5.Empolyee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<int>("DepartmentID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("FullName");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.HasIndex("DepartmentID");

                    b.ToTable("Empolyees");
                });

            modelBuilder.Entity("EntityFramwork.net5.Project", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("DepartmentID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("DepartmentID");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("EntityFramwork.net5.Attendance", b =>
                {
                    b.HasOne("EntityFramwork.net5.Empolyee", "Empolyee")
                        .WithMany("Attendances")
                        .HasForeignKey("EmpolyeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empolyee");
                });

            modelBuilder.Entity("EntityFramwork.net5.Department", b =>
                {
                    b.HasOne("EntityFramwork.net5.Branch", "Branchs")
                        .WithMany("Departments")
                        .HasForeignKey("BranchID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branchs");
                });

            modelBuilder.Entity("EntityFramwork.net5.Empolyee", b =>
                {
                    b.HasOne("EntityFramwork.net5.Department", "Department")
                        .WithMany("Empolyees")
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("EntityFramwork.net5.Project", b =>
                {
                    b.HasOne("EntityFramwork.net5.Department", "Department")
                        .WithMany("projects")
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("EntityFramwork.net5.Branch", b =>
                {
                    b.Navigation("Departments");
                });

            modelBuilder.Entity("EntityFramwork.net5.Department", b =>
                {
                    b.Navigation("Empolyees");

                    b.Navigation("projects");
                });

            modelBuilder.Entity("EntityFramwork.net5.Empolyee", b =>
                {
                    b.Navigation("Attendances");
                });
#pragma warning restore 612, 618
        }
    }
}
