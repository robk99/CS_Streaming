﻿// <auto-generated />
using System;
using CS.Media.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CS.Media.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240918213825_MediaId-AutGenerated")]
    partial class MediaIdAutGenerated
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            LengthInSeconds = 13344,
                            MediaTypeId = 1,
                            Name = "VOD-2"
                        },
                        new
                        {
                            Id = 3,
                            LengthInSeconds = 1730,
                            MediaTypeId = 1,
                            Name = "VOD-3"
                        },
                        new
                        {
                            Id = 4,
                            LengthInSeconds = 2278,
                            MediaTypeId = 1,
                            Name = "VOD-4"
                        },
                        new
                        {
                            Id = 5,
                            LengthInSeconds = 6352,
                            MediaTypeId = 1,
                            Name = "VOD-5"
                        },
                        new
                        {
                            Id = 6,
                            LengthInSeconds = 7452,
                            MediaTypeId = 1,
                            Name = "VOD-6"
                        },
                        new
                        {
                            Id = 7,
                            LengthInSeconds = 11410,
                            MediaTypeId = 1,
                            Name = "VOD-7"
                        },
                        new
                        {
                            Id = 8,
                            LengthInSeconds = 3350,
                            MediaTypeId = 1,
                            Name = "VOD-8"
                        },
                        new
                        {
                            Id = 9,
                            LengthInSeconds = 5321,
                            MediaTypeId = 1,
                            Name = "VOD-9"
                        },
                        new
                        {
                            Id = 10,
                            LengthInSeconds = 10345,
                            MediaTypeId = 1,
                            Name = "VOD-10"
                        },
                        new
                        {
                            Id = 11,
                            LengthInSeconds = 3887,
                            MediaTypeId = 1,
                            Name = "VOD-11"
                        },
                        new
                        {
                            Id = 12,
                            LengthInSeconds = 1121,
                            MediaTypeId = 2,
                            Name = "AOD-12"
                        },
                        new
                        {
                            Id = 13,
                            LengthInSeconds = 193,
                            MediaTypeId = 2,
                            Name = "AOD-13"
                        },
                        new
                        {
                            Id = 14,
                            LengthInSeconds = 339,
                            MediaTypeId = 2,
                            Name = "AOD-14"
                        },
                        new
                        {
                            Id = 15,
                            LengthInSeconds = 1169,
                            MediaTypeId = 2,
                            Name = "AOD-15"
                        },
                        new
                        {
                            Id = 16,
                            LengthInSeconds = 3208,
                            MediaTypeId = 2,
                            Name = "AOD-16"
                        },
                        new
                        {
                            Id = 17,
                            LengthInSeconds = 2137,
                            MediaTypeId = 2,
                            Name = "AOD-17"
                        },
                        new
                        {
                            Id = 18,
                            LengthInSeconds = 1808,
                            MediaTypeId = 2,
                            Name = "AOD-18"
                        },
                        new
                        {
                            Id = 19,
                            LengthInSeconds = 3189,
                            MediaTypeId = 2,
                            Name = "AOD-19"
                        },
                        new
                        {
                            Id = 20,
                            LengthInSeconds = 1797,
                            MediaTypeId = 2,
                            Name = "AOD-20"
                        },
                        new
                        {
                            Id = 21,
                            LengthInSeconds = 424,
                            MediaTypeId = 2,
                            Name = "AOD-21"
                        },
                        new
                        {
                            Id = 22,
                            LengthInSeconds = 1676,
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
                            Name = "EPG"
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
