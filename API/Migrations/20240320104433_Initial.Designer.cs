﻿// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Migrations
{
    [DbContext(typeof(APIContext))]
    [Migration("20240320104433_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ClassLibrary.Models.Alkalmazott", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("Belepes")
                        .HasColumnType("datetime2");

                    b.Property<string>("Beosztas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Fizetes")
                        .HasColumnType("int");

                    b.Property<int>("FonokId")
                        .HasColumnType("int");

                    b.Property<int>("Jutalom")
                        .HasColumnType("int");

                    b.Property<string>("Nev")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<int>("OsztalyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Alkalmazott");
                });
#pragma warning restore 612, 618
        }
    }
}
