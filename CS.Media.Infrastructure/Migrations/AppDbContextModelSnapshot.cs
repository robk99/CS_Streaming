﻿// <auto-generated />
using System;
using CS.Media.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CS.Media.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CS.Media.Domain.Medias.Media", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("LengthInSeconds")
                        .HasColumnType("int");

                    b.Property<int>("MediaTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MediaTypeId");

                    b.ToTable("Medias");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MediaTypeId = 3,
                            Name = "EPG"
                        },
                        new
                        {
                            Id = 2,
                            LengthInSeconds = 9219,
                            MediaTypeId = 1,
                            Name = "VOD-2"
                        },
                        new
                        {
                            Id = 3,
                            LengthInSeconds = 13918,
                            MediaTypeId = 1,
                            Name = "VOD-3"
                        },
                        new
                        {
                            Id = 4,
                            LengthInSeconds = 5999,
                            MediaTypeId = 1,
                            Name = "VOD-4"
                        },
                        new
                        {
                            Id = 5,
                            LengthInSeconds = 1825,
                            MediaTypeId = 1,
                            Name = "VOD-5"
                        },
                        new
                        {
                            Id = 6,
                            LengthInSeconds = 9976,
                            MediaTypeId = 1,
                            Name = "VOD-6"
                        },
                        new
                        {
                            Id = 7,
                            LengthInSeconds = 14020,
                            MediaTypeId = 1,
                            Name = "VOD-7"
                        },
                        new
                        {
                            Id = 8,
                            LengthInSeconds = 746,
                            MediaTypeId = 1,
                            Name = "VOD-8"
                        },
                        new
                        {
                            Id = 9,
                            LengthInSeconds = 7687,
                            MediaTypeId = 1,
                            Name = "VOD-9"
                        },
                        new
                        {
                            Id = 10,
                            LengthInSeconds = 12280,
                            MediaTypeId = 1,
                            Name = "VOD-10"
                        },
                        new
                        {
                            Id = 11,
                            LengthInSeconds = 11209,
                            MediaTypeId = 1,
                            Name = "VOD-11"
                        },
                        new
                        {
                            Id = 12,
                            LengthInSeconds = 927,
                            MediaTypeId = 2,
                            Name = "AOD-12"
                        },
                        new
                        {
                            Id = 13,
                            LengthInSeconds = 268,
                            MediaTypeId = 2,
                            Name = "AOD-13"
                        },
                        new
                        {
                            Id = 14,
                            LengthInSeconds = 88,
                            MediaTypeId = 2,
                            Name = "AOD-14"
                        },
                        new
                        {
                            Id = 15,
                            LengthInSeconds = 3396,
                            MediaTypeId = 2,
                            Name = "AOD-15"
                        },
                        new
                        {
                            Id = 16,
                            LengthInSeconds = 1960,
                            MediaTypeId = 2,
                            Name = "AOD-16"
                        },
                        new
                        {
                            Id = 17,
                            LengthInSeconds = 2847,
                            MediaTypeId = 2,
                            Name = "AOD-17"
                        },
                        new
                        {
                            Id = 18,
                            LengthInSeconds = 3456,
                            MediaTypeId = 2,
                            Name = "AOD-18"
                        },
                        new
                        {
                            Id = 19,
                            LengthInSeconds = 1726,
                            MediaTypeId = 2,
                            Name = "AOD-19"
                        },
                        new
                        {
                            Id = 20,
                            LengthInSeconds = 1854,
                            MediaTypeId = 2,
                            Name = "AOD-20"
                        },
                        new
                        {
                            Id = 21,
                            LengthInSeconds = 2353,
                            MediaTypeId = 2,
                            Name = "AOD-21"
                        },
                        new
                        {
                            Id = 22,
                            LengthInSeconds = 249,
                            MediaTypeId = 2,
                            Name = "AOD-22"
                        });
                });

            modelBuilder.Entity("CS.Media.Domain.Medias.MediaType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("LongName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MediaTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            LongName = "Video on Demand",
                            Name = "VOD"
                        },
                        new
                        {
                            Id = 2,
                            LongName = "Audio on Demand",
                            Name = "AOD"
                        },
                        new
                        {
                            Id = 3,
                            LongName = "Electronic Program Guide",
                            Name = "EPG-1"
                        });
                });

            modelBuilder.Entity("CS.Media.Domain.Medias.Media", b =>
                {
                    b.HasOne("CS.Media.Domain.Medias.MediaType", "MediaType")
                        .WithMany()
                        .HasForeignKey("MediaTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MediaType");
                });
#pragma warning restore 612, 618
        }
    }
}
