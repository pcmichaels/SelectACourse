﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SelectACourse.ThirdParty.DataAccess;

namespace SelectACourse.ThirdParty.Migrations
{
    [DbContext(typeof(CourseSelectDbContext))]
    partial class CourseSelectDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SelectACourse.ThirdParty.DataAccess.Entities.CourseEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("Cost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tutor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CourseEntities");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            Cost = 20m,
                            Date = new DateTime(2021, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Geology for Beginers",
                            Tutor = "David Price"
                        },
                        new
                        {
                            Id = "2",
                            Cost = 120m,
                            Date = new DateTime(2021, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Advanced Mathematics",
                            Tutor = "Dr. Graham Sutherland"
                        },
                        new
                        {
                            Id = "3",
                            Cost = 75.20m,
                            Date = new DateTime(2020, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "An Introduction to InfoSec",
                            Tutor = "Ronald Jones"
                        },
                        new
                        {
                            Id = "4",
                            Cost = 95m,
                            Date = new DateTime(2021, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Advanced Material Physics",
                            Tutor = "Dr. Stephanie Browne"
                        });
                });

            modelBuilder.Entity("SelectACourse.ThirdParty.DataAccess.Entities.EnrolmentEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CourseId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EnrolmentEntities");
                });
#pragma warning restore 612, 618
        }
    }
}
