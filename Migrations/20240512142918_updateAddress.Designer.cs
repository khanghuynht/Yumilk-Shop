﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SWP391_DEMO.Data;

#nullable disable

namespace SWP391_DEMO.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240512142918_updateAddress")]
    partial class updateAddress
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SWP391_DEMO.Entities.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("deleted_at");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(2000)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("is_active");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("brands", (string)null);
                });

            modelBuilder.Entity("SWP391_DEMO.Entities.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<Guid?>("CustomerId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("customer_id");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("deleted_at");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("is_active");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("carts", (string)null);
                });

            modelBuilder.Entity("SWP391_DEMO.Entities.CartDetail", b =>
                {
                    b.Property<int>("CartId")
                        .HasColumnType("int")
                        .HasColumnName("cart_id");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("product_id");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("is_active");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("CartId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("cart_details", (string)null);
                });

            modelBuilder.Entity("SWP391_DEMO.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("deleted_at");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(2000)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("is_active");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("categories", (string)null);
                });

            modelBuilder.Entity("SWP391_DEMO.Entities.Customer", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("user_id");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("GoogleId")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("google_id");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("phone_number");

                    b.Property<int?>("Points")
                        .HasColumnType("int");

                    b.Property<string>("ProfilePictureUrl")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("profile_picture_url");

                    b.HasKey("UserId");

                    b.ToTable("customers", (string)null);
                });

            modelBuilder.Entity("SWP391_DEMO.Entities.CustomerAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("deleted_at");

                    b.Property<int>("DistrictId")
                        .HasColumnType("int")
                        .HasColumnName("district_id");

                    b.Property<string>("DistrictName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("district_name");

                    b.Property<bool>("IsDefault")
                        .HasColumnType("bit")
                        .HasColumnName("is_default");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("phone_number");

                    b.Property<int>("ProvinceId")
                        .HasColumnType("int")
                        .HasColumnName("province_id");

                    b.Property<string>("ProvinceName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("province_name");

                    b.Property<string>("ReceiverName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("receiver_name");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("user_id");

                    b.Property<int>("WardCode")
                        .HasColumnType("int")
                        .HasColumnName("ward_code");

                    b.Property<string>("WardName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("ward_name");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("customer_addresses", (string)null);
                });

            modelBuilder.Entity("SWP391_DEMO.Entities.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<Guid?>("CustomerId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("customer_id");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("deleted_at");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("phone_number");

                    b.Property<decimal?>("ShippingFee")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("shipping_fee");

                    b.Property<int?>("StatusId")
                        .HasColumnType("int")
                        .HasColumnName("status_id");

                    b.Property<decimal?>("TotalAmount")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("total_amount");

                    b.Property<decimal?>("TotalPrice")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("total_price");

                    b.Property<int?>("VoucherId")
                        .HasColumnType("int")
                        .HasColumnName("voucher_id");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("StatusId");

                    b.HasIndex("VoucherId");

                    b.ToTable("orders", (string)null);
                });

            modelBuilder.Entity("SWP391_DEMO.Entities.OrderDetail", b =>
                {
                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("order_id");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("product_id");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("deleted_at");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("is_active");

                    b.Property<decimal?>("ItemPrice")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("item_price");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("product_name");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal?>("UnitPrice")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("unit_price");

                    b.HasKey("OrderId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("order_details", (string)null);
                });

            modelBuilder.Entity("SWP391_DEMO.Entities.OrderStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("deleted_at");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(2000)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("is_active");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("order_statuses", (string)null);
                });

            modelBuilder.Entity("SWP391_DEMO.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("BrandId")
                        .HasColumnType("int")
                        .HasColumnName("brand_id");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("category_id");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("deleted_at");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(2000)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("is_active");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(255)");

                    b.Property<decimal?>("OriginalPrice")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("original_price");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal?>("SalePrice")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("sale_price");

                    b.Property<int?>("UnitId")
                        .HasColumnType("int")
                        .HasColumnName("unit_id");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UnitId");

                    b.ToTable("products", (string)null);
                });

            modelBuilder.Entity("SWP391_DEMO.Entities.ProductAnalytic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("deleted_at");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("is_active");

                    b.Property<Guid?>("ProductId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("product_id");

                    b.Property<int?>("PurchaseCount")
                        .HasColumnType("int")
                        .HasColumnName("purchase_count");

                    b.Property<int?>("ViewCount")
                        .HasColumnType("int")
                        .HasColumnName("view_count");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("product_analytics", (string)null);
                });

            modelBuilder.Entity("SWP391_DEMO.Entities.ProductAttribute", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("deleted_at");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(2000)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("is_active");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("product_attributes", (string)null);
                });

            modelBuilder.Entity("SWP391_DEMO.Entities.ProductAttributeValue", b =>
                {
                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("product_id");

                    b.Property<int>("AttributeId")
                        .HasColumnType("int")
                        .HasColumnName("attribute_id");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(2000)");

                    b.HasKey("ProductId", "AttributeId");

                    b.HasIndex("AttributeId");

                    b.ToTable("product_attribute_values", (string)null);
                });

            modelBuilder.Entity("SWP391_DEMO.Entities.ProductImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("deleted_at");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("image_url");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("is_active");

                    b.Property<Guid?>("ProductId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("product_id");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("product_images", (string)null);
                });

            modelBuilder.Entity("SWP391_DEMO.Entities.RefreshToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("deleted_at");

                    b.Property<DateTime?>("Expires")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("is_active");

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(255)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("refresh_tokens", (string)null);
                });

            modelBuilder.Entity("SWP391_DEMO.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("deleted_at");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(2000)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("is_active");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("roles", (string)null);
                });

            modelBuilder.Entity("SWP391_DEMO.Entities.Unit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("deleted_at");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(2000)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("is_active");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("units", (string)null);
                });

            modelBuilder.Entity("SWP391_DEMO.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AccessToken")
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("access_token");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("deleted_at");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("first_name");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("is_active");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("last_name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("RoleId")
                        .HasColumnType("int")
                        .HasColumnName("role_id");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("VerificationToken")
                        .HasColumnType("nvarchar(6)")
                        .HasColumnName("verification_token");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("users", (string)null);
                });

            modelBuilder.Entity("SWP391_DEMO.Entities.UserVoucher", b =>
                {
                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("customer_id");

                    b.Property<int>("VoucherId")
                        .HasColumnType("int")
                        .HasColumnName("voucher_id");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("deleted_at");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("is_active");

                    b.HasKey("CustomerId", "VoucherId");

                    b.HasIndex("VoucherId");

                    b.ToTable("user_vouchers", (string)null);
                });

            modelBuilder.Entity("SWP391_DEMO.Entities.Voucher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("deleted_at");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(2000)");

                    b.Property<decimal?>("DiscountPercent")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("discount_percent");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("end_date");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("is_active");

                    b.Property<decimal?>("MaxDiscountAmount")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("max_discount_amount");

                    b.Property<decimal?>("MinOrderValue")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("min_order_value");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("start_date");

                    b.HasKey("Id");

                    b.ToTable("vouchers", (string)null);
                });

            modelBuilder.Entity("SWP391_DEMO.Entities.Cart", b =>
                {
                    b.HasOne("SWP391_DEMO.Entities.Customer", "Customer")
                        .WithMany("Carts")
                        .HasForeignKey("CustomerId");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("SWP391_DEMO.Entities.CartDetail", b =>
                {
                    b.HasOne("SWP391_DEMO.Entities.Cart", "Cart")
                        .WithMany("CartDetails")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SWP391_DEMO.Entities.Product", "Product")
                        .WithMany("CartDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("SWP391_DEMO.Entities.Customer", b =>
                {
                    b.HasOne("SWP391_DEMO.Entities.User", "User")
                        .WithOne("Customer")
                        .HasForeignKey("SWP391_DEMO.Entities.Customer", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("SWP391_DEMO.Entities.CustomerAddress", b =>
                {
                    b.HasOne("SWP391_DEMO.Entities.Customer", "User")
                        .WithMany("CustomerAddresses")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SWP391_DEMO.Entities.Order", b =>
                {
                    b.HasOne("SWP391_DEMO.Entities.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId");

                    b.HasOne("SWP391_DEMO.Entities.OrderStatus", "Status")
                        .WithMany("Orders")
                        .HasForeignKey("StatusId");

                    b.HasOne("SWP391_DEMO.Entities.Voucher", "Voucher")
                        .WithMany("Orders")
                        .HasForeignKey("VoucherId");

                    b.Navigation("Customer");

                    b.Navigation("Status");

                    b.Navigation("Voucher");
                });

            modelBuilder.Entity("SWP391_DEMO.Entities.OrderDetail", b =>
                {
                    b.HasOne("SWP391_DEMO.Entities.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SWP391_DEMO.Entities.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("SWP391_DEMO.Entities.Product", b =>
                {
                    b.HasOne("SWP391_DEMO.Entities.Brand", "Brand")
                        .WithMany("Products")
                        .HasForeignKey("BrandId");

                    b.HasOne("SWP391_DEMO.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId");

                    b.HasOne("SWP391_DEMO.Entities.Unit", "Unit")
                        .WithMany("Products")
                        .HasForeignKey("UnitId");

                    b.Navigation("Brand");

                    b.Navigation("Category");

                    b.Navigation("Unit");
                });

            modelBuilder.Entity("SWP391_DEMO.Entities.ProductAnalytic", b =>
                {
                    b.HasOne("SWP391_DEMO.Entities.Product", "Product")
                        .WithMany("ProductAnalytics")
                        .HasForeignKey("ProductId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("SWP391_DEMO.Entities.ProductAttributeValue", b =>
                {
                    b.HasOne("SWP391_DEMO.Entities.ProductAttribute", "Attribute")
                        .WithMany("ProductAttributeValues")
                        .HasForeignKey("AttributeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SWP391_DEMO.Entities.Product", "Product")
                        .WithMany("ProductAttributeValues")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Attribute");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("SWP391_DEMO.Entities.ProductImage", b =>
                {
                    b.HasOne("SWP391_DEMO.Entities.Product", "Product")
                        .WithMany("ProductImages")
                        .HasForeignKey("ProductId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("SWP391_DEMO.Entities.RefreshToken", b =>
                {
                    b.HasOne("SWP391_DEMO.Entities.User", "User")
                        .WithMany("RefreshTokens")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SWP391_DEMO.Entities.User", b =>
                {
                    b.HasOne("SWP391_DEMO.Entities.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("SWP391_DEMO.Entities.UserVoucher", b =>
                {
                    b.HasOne("SWP391_DEMO.Entities.Customer", "Customer")
                        .WithMany("UserVouchers")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SWP391_DEMO.Entities.Voucher", "Voucher")
                        .WithMany("UserVouchers")
                        .HasForeignKey("VoucherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Voucher");
                });

            modelBuilder.Entity("SWP391_DEMO.Entities.Brand", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("SWP391_DEMO.Entities.Cart", b =>
                {
                    b.Navigation("CartDetails");
                });

            modelBuilder.Entity("SWP391_DEMO.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("SWP391_DEMO.Entities.Customer", b =>
                {
                    b.Navigation("Carts");

                    b.Navigation("CustomerAddresses");

                    b.Navigation("Orders");

                    b.Navigation("UserVouchers");
                });

            modelBuilder.Entity("SWP391_DEMO.Entities.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("SWP391_DEMO.Entities.OrderStatus", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("SWP391_DEMO.Entities.Product", b =>
                {
                    b.Navigation("CartDetails");

                    b.Navigation("OrderDetails");

                    b.Navigation("ProductAnalytics");

                    b.Navigation("ProductAttributeValues");

                    b.Navigation("ProductImages");
                });

            modelBuilder.Entity("SWP391_DEMO.Entities.ProductAttribute", b =>
                {
                    b.Navigation("ProductAttributeValues");
                });

            modelBuilder.Entity("SWP391_DEMO.Entities.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("SWP391_DEMO.Entities.Unit", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("SWP391_DEMO.Entities.User", b =>
                {
                    b.Navigation("Customer");

                    b.Navigation("RefreshTokens");
                });

            modelBuilder.Entity("SWP391_DEMO.Entities.Voucher", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("UserVouchers");
                });
#pragma warning restore 612, 618
        }
    }
}
