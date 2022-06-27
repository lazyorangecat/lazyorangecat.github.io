﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _0624_ReBuild_CoreMvc5_Razor.Data;

namespace _0624_ReBuild_CoreMvc5_Razor.Migrations
{
    [DbContext(typeof(StudentContext))]
    partial class StudentContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("_0624_ReBuild_CoreMvc5_Razor.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("Chinese")
                        .HasColumnType("int");

                    b.Property<int>("English")
                        .HasColumnType("int");

                    b.Property<int>("Math")
                        .HasColumnType("int")
                        .HasColumnName("Mathematics");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("StudentTable");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Chinese = 88,
                            English = 95,
                            Math = 71,
                            Name = "Joe"
                        },
                        new
                        {
                            Id = 12,
                            Chinese = 88,
                            English = 95,
                            Math = 71,
                            Name = "Aoe"
                        },
                        new
                        {
                            Id = 11,
                            Chinese = 88,
                            English = 95,
                            Math = 71,
                            Name = "Eoe"
                        },
                        new
                        {
                            Id = 14,
                            Chinese = 88,
                            English = 95,
                            Math = 71,
                            Name = "Voe"
                        },
                        new
                        {
                            Id = 16,
                            Chinese = 88,
                            English = 95,
                            Math = 71,
                            Name = "Doe"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
