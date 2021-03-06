﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RecordingMicroService.DbAccess;

namespace RecordingMicroService.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("RecordingMicroService.Models.Recording", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecordingPath")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Recordings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "hard guitar",
                            RecordingPath = "/recordings/hard_guitar.wav"
                        },
                        new
                        {
                            Id = 2,
                            Name = "riif guitar",
                            RecordingPath = "/recordings/riff_guitar.wav"
                        },
                        new
                        {
                            Id = 3,
                            Name = "soft guitar",
                            RecordingPath = "/recordings/soft_guitar.mp3"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
