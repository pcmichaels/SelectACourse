using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SelectACourse.ThirdParty.Migrations
{
    public partial class AdditionalDemoData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Capacity",
                table: "CourseEntities",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "CourseEntities",
                keyColumn: "Id",
                keyValue: "1",
                column: "Capacity",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CourseEntities",
                keyColumn: "Id",
                keyValue: "2",
                column: "Capacity",
                value: 12);

            migrationBuilder.UpdateData(
                table: "CourseEntities",
                keyColumn: "Id",
                keyValue: "3",
                column: "Capacity",
                value: 25);

            migrationBuilder.UpdateData(
                table: "CourseEntities",
                keyColumn: "Id",
                keyValue: "4",
                column: "Capacity",
                value: 20);

            migrationBuilder.InsertData(
                table: "CourseEntities",
                columns: new[] { "Id", "Capacity", "Cost", "Date", "Title", "Tutor" },
                values: new object[] { "5", 12, 160m, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sound Engineering", "Dr. Alison Kilmister" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CourseEntities",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.DropColumn(
                name: "Capacity",
                table: "CourseEntities");
        }
    }
}
