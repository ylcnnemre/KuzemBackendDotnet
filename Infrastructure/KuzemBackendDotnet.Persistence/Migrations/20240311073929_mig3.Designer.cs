﻿// <auto-generated />
using System;
using KuzemBackendDotnet.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace KuzemBackendDotnet.Persistence.Migrations
{
    [DbContext(typeof(KuzemDbContext))]
    [Migration("20240311073929_mig3")]
    partial class mig3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("KuzemBackendDotnet.Domain.Entities.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("SemesterId")
                        .HasColumnType("uuid");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("SemesterId");

                    b.ToTable("course");
                });

            modelBuilder.Entity("KuzemBackendDotnet.Domain.Entities.Semester", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Period")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("active")
                        .HasColumnType("boolean");

                    b.Property<int>("year")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Semester");
                });

            modelBuilder.Entity("KuzemBackendDotnet.Domain.Entities.Course", b =>
                {
                    b.HasOne("KuzemBackendDotnet.Domain.Entities.Semester", "semester")
                        .WithMany("courses")
                        .HasForeignKey("SemesterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("semester");
                });

            modelBuilder.Entity("KuzemBackendDotnet.Domain.Entities.Semester", b =>
                {
                    b.Navigation("courses");
                });
#pragma warning restore 612, 618
        }
    }
}