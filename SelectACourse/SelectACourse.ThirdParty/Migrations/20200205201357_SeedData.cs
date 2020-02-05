using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SelectACourse.ThirdParty.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CourseEntities",
                columns: new[] { "Id", "Cost", "Date", "Title", "Tutor" },
                values: new object[,]
                {
                    { "1", 20m, new DateTime(2021, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Geology for Beginers", "David Price" },
                    { "2", 120m, new DateTime(2021, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Advanced Mathematics", "Dr. Graham Sutherland" },
                    { "3", 75.20m, new DateTime(2020, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "An Introduction to InfoSec", "Ronald Jones" },
                    { "4", 95m, new DateTime(2021, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Advanced Material Physics", "Dr. Stephanie Browne" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CourseEntities",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "CourseEntities",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "CourseEntities",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "CourseEntities",
                keyColumn: "Id",
                keyValue: "4");
        }
    }
}
