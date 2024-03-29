﻿// <auto-generated />
using System;
using BookProviders.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookProviders.Data.Migrations
{
    [DbContext(typeof(BookProvidersContext))]
    [Migration("20191002182832_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BookProviders.Business.Models.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CatererId");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("varchar(400)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("varchar(8)");

                    b.HasKey("Id");

                    b.HasIndex("CatererId")
                        .IsUnique();

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("BookProviders.Business.Models.Caterer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<int>("CatererType");

                    b.Property<string>("Document")
                        .IsRequired()
                        .HasColumnType("varchar(14)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Caterers");
                });

            modelBuilder.Entity("BookProviders.Business.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<Guid>("CatererId");

                    b.Property<DateTime>("Created");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(1000)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<decimal>("Price");

                    b.HasKey("Id");

                    b.HasIndex("CatererId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("BookProviders.Business.Models.Address", b =>
                {
                    b.HasOne("BookProviders.Business.Models.Caterer", "Caterer")
                        .WithOne("Adress")
                        .HasForeignKey("BookProviders.Business.Models.Address", "CatererId");
                });

            modelBuilder.Entity("BookProviders.Business.Models.Product", b =>
                {
                    b.HasOne("BookProviders.Business.Models.Caterer", "Caterer")
                        .WithMany("Products")
                        .HasForeignKey("CatererId");
                });
#pragma warning restore 612, 618
        }
    }
}
