﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dbBackend.Models;

namespace dbBackend.Migrations
{
    [DbContext(typeof(masterContext))]
    [Migration("20201109071149_Migrations")]
    partial class Migrations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("dbBackend.Models.Designation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("varchar(400)")
                        .HasMaxLength(400)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("designation");
                });

            modelBuilder.Entity("dbBackend.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("serial")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Designation")
                        .HasColumnName("designation")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("varchar(40)")
                        .HasMaxLength(40)
                        .IsUnicode(false);

                    b.Property<int?>("HotelID")
                        .HasColumnType("int");

                    b.Property<DateTime>("JoiningDate")
                        .HasColumnName("joining_date")
                        .HasColumnType("date");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(40)")
                        .HasMaxLength(40)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.HasIndex("Designation");

                    b.HasIndex("HotelID");

                    b.ToTable("employee");
                });

            modelBuilder.Entity("dbBackend.Models.Employee", b =>
                {
                    b.HasOne("dbBackend.Models.Designation", "DesignationNavigation")
                        .WithMany("Employee")
                        .HasForeignKey("Designation")
                        .HasConstraintName("FK__employee__design__1D114BD1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("dbBackend.Models.Designation", "desg")
                        .WithMany()
                        .HasForeignKey("HotelID");
                });
#pragma warning restore 612, 618
        }
    }
}