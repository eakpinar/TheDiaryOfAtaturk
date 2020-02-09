﻿// <auto-generated />
using System;
using DoAtaApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DoAtaApi.Migrations
{
    [DbContext(typeof(DoAtaContext))]
    partial class DoAtaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("DoAtaApi.Models.DoAtaItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Day");

                    b.Property<string>("Description");

                    b.Property<int>("Month");

                    b.Property<string>("Name");

                    b.Property<int?>("TypeId");

                    b.Property<int>("Year");

                    b.HasKey("Id");

                    b.HasIndex("TypeId");

                    b.ToTable("DoAtaItems");
                });

            modelBuilder.Entity("DoAtaApi.Models.Type", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Types");
                });

            modelBuilder.Entity("DoAtaApi.Models.DoAtaItem", b =>
                {
                    b.HasOne("DoAtaApi.Models.Type", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId");
                });
#pragma warning restore 612, 618
        }
    }
}
