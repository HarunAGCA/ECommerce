﻿// <auto-generated />
using System;
using Agca.ECommerce.DataAccess.Concrete.EntityFramework.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Agca.ECommerce.DataAccess.Migrations
{
    [DbContext(typeof(ECommerceContext))]
    partial class ECommerceContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Agca.ECommerce.Entities.Concrete.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Agca.ECommerce.Entities.Concrete.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EMail");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("TurkishIdNo");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Agca.ECommerce.Entities.Concrete.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId");

                    b.Property<decimal>("TotalPrice");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Agca.ECommerce.Entities.Concrete.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("AmountOfPayment");

                    b.Property<string>("CreditCardCVC");

                    b.Property<string>("CreditCardExpiryDate");

                    b.Property<string>("CreditCardNo");

                    b.Property<string>("CreditCardOwnerName");

                    b.Property<DateTime>("DateOfPayment");

                    b.Property<int>("OrderId");

                    b.HasKey("Id");

                    b.HasIndex("OrderId")
                        .IsUnique();

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("Agca.ECommerce.Entities.Concrete.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsMain");

                    b.Property<int>("ProductId");

                    b.Property<int?>("ProductId1");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("ProductId1");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("Agca.ECommerce.Entities.Concrete.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<string>("Name");

                    b.Property<decimal>("UnitPrice");

                    b.Property<int>("UnitsInStock");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Agca.ECommerce.Entities.Concrete.Shipment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderId");

                    b.Property<string>("ReceiverAddress");

                    b.Property<string>("ReceiverEMail");

                    b.Property<string>("ReceiverFirstName");

                    b.Property<string>("ReceiverLastName");

                    b.Property<string>("ReceiverPhoneNumber");

                    b.Property<string>("ReceiverTurkishIdNo");

                    b.Property<DateTime>("TimeOfDelivery");

                    b.Property<DateTime>("TimeOfShipping");

                    b.HasKey("Id");

                    b.HasIndex("OrderId")
                        .IsUnique();

                    b.ToTable("Shipments");
                });

            modelBuilder.Entity("Agca.ECommerce.Entities.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderId");

                    b.Property<int>("ProductId");

                    b.Property<int>("Quantity");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("Agca.ECommerce.Entities.Concrete.Order", b =>
                {
                    b.HasOne("Agca.ECommerce.Entities.Concrete.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Agca.ECommerce.Entities.Concrete.Payment", b =>
                {
                    b.HasOne("Agca.ECommerce.Entities.Concrete.Order", "Order")
                        .WithOne("Payment")
                        .HasForeignKey("Agca.ECommerce.Entities.Concrete.Payment", "OrderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Agca.ECommerce.Entities.Concrete.Photo", b =>
                {
                    b.HasOne("Agca.ECommerce.Entities.Concrete.Product")
                        .WithMany("Photos")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Agca.ECommerce.Entities.Concrete.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId1");
                });

            modelBuilder.Entity("Agca.ECommerce.Entities.Concrete.Product", b =>
                {
                    b.HasOne("Agca.ECommerce.Entities.Concrete.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Agca.ECommerce.Entities.Concrete.Shipment", b =>
                {
                    b.HasOne("Agca.ECommerce.Entities.Concrete.Order", "Order")
                        .WithOne("Shipment")
                        .HasForeignKey("Agca.ECommerce.Entities.Concrete.Shipment", "OrderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Agca.ECommerce.Entities.OrderItem", b =>
                {
                    b.HasOne("Agca.ECommerce.Entities.Concrete.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Agca.ECommerce.Entities.Concrete.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
