﻿// <auto-generated />
using System;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EntityLayer.Concrete.Brand", b =>
                {
                    b.Property<int>("brandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("brandId"), 1L, 1);

                    b.Property<string>("brandName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("brandId");

                    b.ToTable("brands");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Car", b =>
                {
                    b.Property<int>("carId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("carId"), 1L, 1);

                    b.Property<int>("brandId")
                        .HasColumnType("int");

                    b.Property<float>("carDailyPrice")
                        .HasColumnType("real");

                    b.Property<string>("carDescription")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("carModelYear")
                        .HasColumnType("int");

                    b.Property<string>("carName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("colorId")
                        .HasColumnType("int");

                    b.HasKey("carId");

                    b.HasIndex("brandId");

                    b.HasIndex("colorId");

                    b.ToTable("cars");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Color", b =>
                {
                    b.Property<int>("colorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("colorId"), 1L, 1);

                    b.Property<string>("colorName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("colorId");

                    b.ToTable("colors");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Customer", b =>
                {
                    b.Property<int>("customerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("customerId"), 1L, 1);

                    b.Property<string>("adress")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("birthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("eMail")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("userName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("customerId");

                    b.ToTable("customers");
                });

            modelBuilder.Entity("EntityLayer.Concrete.PaymentMethod", b =>
                {
                    b.Property<int>("paymentMethodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("paymentMethodId"), 1L, 1);

                    b.Property<string>("paymentMethodName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("paymentMethodId");

                    b.ToTable("paymentMethods");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Rental", b =>
                {
                    b.Property<int>("rentalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("rentalId"), 1L, 1);

                    b.Property<int>("carId")
                        .HasColumnType("int");

                    b.Property<int>("customerId")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("paymentMethodId")
                        .HasColumnType("int");

                    b.Property<DateTime>("rentalDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("rentalReturnDate")
                        .HasColumnType("datetime2");

                    b.HasKey("rentalId");

                    b.HasIndex("carId");

                    b.HasIndex("customerId");

                    b.HasIndex("paymentMethodId");

                    b.ToTable("rentals");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Car", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Brand", "brand")
                        .WithMany("cars")
                        .HasForeignKey("brandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.Color", "color")
                        .WithMany("cars")
                        .HasForeignKey("colorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("brand");

                    b.Navigation("color");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Rental", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Car", "car")
                        .WithMany("rentals")
                        .HasForeignKey("carId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.Customer", "customer")
                        .WithMany("rentals")
                        .HasForeignKey("customerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.PaymentMethod", "paymentMethod")
                        .WithMany("rentals")
                        .HasForeignKey("paymentMethodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("car");

                    b.Navigation("customer");

                    b.Navigation("paymentMethod");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Brand", b =>
                {
                    b.Navigation("cars");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Car", b =>
                {
                    b.Navigation("rentals");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Color", b =>
                {
                    b.Navigation("cars");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Customer", b =>
                {
                    b.Navigation("rentals");
                });

            modelBuilder.Entity("EntityLayer.Concrete.PaymentMethod", b =>
                {
                    b.Navigation("rentals");
                });
#pragma warning restore 612, 618
        }
    }
}
