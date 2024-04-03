﻿// <auto-generated />
using System;
using Kmakai.WardrobeInventory.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Kmakai.WardrobeInventory.Migrations
{
    [DbContext(typeof(WardrobeContext))]
    [Migration("20240403223227_ReInit2")]
    partial class ReInit2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Shared.Models.Wardrobe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("BottomId")
                        .HasColumnType("int");

                    b.Property<int?>("FootwearId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TopId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BottomId");

                    b.HasIndex("FootwearId");

                    b.HasIndex("TopId");

                    b.ToTable("wardrobes");
                });

            modelBuilder.Entity("Shared.Models.WardrobeImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("wardrobeImages");
                });

            modelBuilder.Entity("Shared.Models.WardrobeItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ImageId")
                        .HasColumnType("int");

                    b.Property<int?>("ItemType")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.ToTable("WardrobeItems");
                });

            modelBuilder.Entity("Shared.Models.Wardrobe", b =>
                {
                    b.HasOne("Shared.Models.WardrobeItem", "Bottom")
                        .WithMany()
                        .HasForeignKey("BottomId");

                    b.HasOne("Shared.Models.WardrobeItem", "Footwear")
                        .WithMany()
                        .HasForeignKey("FootwearId");

                    b.HasOne("Shared.Models.WardrobeItem", "Top")
                        .WithMany()
                        .HasForeignKey("TopId");

                    b.Navigation("Bottom");

                    b.Navigation("Footwear");

                    b.Navigation("Top");
                });

            modelBuilder.Entity("Shared.Models.WardrobeItem", b =>
                {
                    b.HasOne("Shared.Models.WardrobeImage", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId");

                    b.Navigation("Image");
                });
#pragma warning restore 612, 618
        }
    }
}
