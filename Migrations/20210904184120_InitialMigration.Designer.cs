﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ProjectsApi.Data;

namespace ProjectsApi.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210904184120_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("ProjectsApi.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("DevID")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime>("finishDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("isFinished")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("startDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("Projects");
                });
#pragma warning restore 612, 618
        }
    }
}
