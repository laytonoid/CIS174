﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Multi_PageWebAppLayton.Models;

#nullable disable

namespace Multi_PageWebAppLayton.Migrations
{
    [DbContext(typeof(ContactContext))]
    [Migration("20230124142513_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Multi_PageWebAppLayton.Models.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContactId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactId");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            ContactId = 1,
                            Name = "Mark Ruffalo",
                            Phone = "673-392-1992"
                        },
                        new
                        {
                            ContactId = 2,
                            Name = "John Cena",
                            Phone = "551-523-5493"
                        },
                        new
                        {
                            ContactId = 3,
                            Name = "Biscuit Johnson",
                            Phone = "641-841-0218"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
