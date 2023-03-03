﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoContatos.Application.API.Context;

#nullable disable

namespace ProjetoContatos.Application.API.Migrations
{
    [DbContext(typeof(SQLServerContext))]
    partial class SQLServerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProjetoContatos.Application.API.Entities.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Rua Hermann Tribess",
                            Name = "Pedro Godri",
                            Phone = "47999998888"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Rua Alberto Einstein",
                            Name = "Ramon Lisboa",
                            Phone = "47999997777"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Rua Julio Michel",
                            Name = "Luiz Godri",
                            Phone = "47999996666"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
