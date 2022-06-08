﻿// <auto-generated />
using System;
using HomeStayManagement.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HomeStayManagement.Migrations
{
    [DbContext(typeof(HomeStayContext))]
    [Migration("20220608062451_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HomeStayManagement.Model.Bill", b =>
                {
                    b.Property<int?>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("ID"), 1L, 1);

                    b.Property<string>("Customer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PhoneNumber")
                        .HasColumnType("int");

                    b.Property<int?>("TotalCost")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Bill");
                });

            modelBuilder.Entity("HomeStayManagement.Model.Homestay", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int?>("BillID")
                        .HasColumnType("int");

                    b.Property<string>("IMG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Summary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("checkout")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("entry")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("BillID");

                    b.ToTable("Homestay");
                });

            modelBuilder.Entity("HomeStayManagement.Model.Homestay", b =>
                {
                    b.HasOne("HomeStayManagement.Model.Bill", null)
                        .WithMany("reserved")
                        .HasForeignKey("BillID");
                });

            modelBuilder.Entity("HomeStayManagement.Model.Bill", b =>
                {
                    b.Navigation("reserved");
                });
#pragma warning restore 612, 618
        }
    }
}
