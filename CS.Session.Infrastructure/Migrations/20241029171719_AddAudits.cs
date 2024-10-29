using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CS.Session.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddAudits : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOnUtc",
                table: "Sessions",
                type: "datetime2",
                nullable: false,
                defaultValue: DateTime.UtcNow);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOnUtc",
                table: "Sessions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndTime", "MediaId", "ModifiedOnUtc", "StartTime", "UserId" },
                values: new object[] {  new DateTime(2024, 10, 29, 17, 13, 18, 915, DateTimeKind.Local).AddTicks(4920), 2, null, new DateTime(2024, 10, 29, 14, 37, 18, 915, DateTimeKind.Local).AddTicks(4920), 8 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndTime", "MediaId", "ModifiedOnUtc", "StartTime" },
                values: new object[] {  new DateTime(2024, 10, 29, 15, 55, 18, 915, DateTimeKind.Local).AddTicks(5024), 3, null, new DateTime(2024, 10, 29, 14, 32, 18, 915, DateTimeKind.Local).AddTicks(5024) });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndTime", "MediaId", "ModifiedOnUtc", "StartTime", "UserId" },
                values: new object[] {  new DateTime(2024, 10, 29, 14, 30, 18, 915, DateTimeKind.Local).AddTicks(5042), 2, null, new DateTime(2024, 10, 29, 13, 45, 18, 915, DateTimeKind.Local).AddTicks(5042), 9 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndTime", "MediaId", "ModifiedOnUtc", "StartTime", "UserId" },
                values: new object[] {  new DateTime(2024, 10, 29, 17, 8, 18, 915, DateTimeKind.Local).AddTicks(5056), 2, null, new DateTime(2024, 10, 29, 14, 28, 18, 915, DateTimeKind.Local).AddTicks(5056), 10 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndTime", "ModifiedOnUtc", "StartTime", "UserId" },
                values: new object[] {  new DateTime(2024, 10, 29, 15, 29, 18, 915, DateTimeKind.Local).AddTicks(5071), null, new DateTime(2024, 10, 29, 14, 34, 18, 915, DateTimeKind.Local).AddTicks(5071), 7 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndTime", "MediaId", "ModifiedOnUtc", "StartTime" },
                values: new object[] {  new DateTime(2024, 10, 29, 16, 44, 18, 915, DateTimeKind.Local).AddTicks(5086), 1, null, new DateTime(2024, 10, 29, 13, 38, 18, 915, DateTimeKind.Local).AddTicks(5086) });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndTime", "ModifiedOnUtc", "StartTime", "UserId" },
                values: new object[] {  new DateTime(2024, 10, 29, 14, 57, 18, 915, DateTimeKind.Local).AddTicks(5100), null, new DateTime(2024, 10, 29, 14, 30, 18, 915, DateTimeKind.Local).AddTicks(5100), 7 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndTime", "MediaId", "ModifiedOnUtc", "StartTime", "UserId" },
                values: new object[] {  new DateTime(2024, 10, 29, 14, 52, 18, 915, DateTimeKind.Local).AddTicks(5114), 3, null, new DateTime(2024, 10, 29, 13, 25, 18, 915, DateTimeKind.Local).AddTicks(5114), 1 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndTime", "MediaId", "ModifiedOnUtc", "StartTime", "UserId" },
                values: new object[] {  new DateTime(2024, 10, 29, 18, 3, 18, 915, DateTimeKind.Local).AddTicks(5127), 1, null, new DateTime(2024, 10, 29, 14, 51, 18, 915, DateTimeKind.Local).AddTicks(5127), 5 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndTime", "MediaId", "ModifiedOnUtc", "StartTime" },
                values: new object[] {  new DateTime(2024, 10, 29, 15, 34, 18, 915, DateTimeKind.Local).AddTicks(5143), 3, null, new DateTime(2024, 10, 29, 13, 27, 18, 915, DateTimeKind.Local).AddTicks(5143) });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "EndTime", "MediaId", "ModifiedOnUtc", "StartTime", "UserId" },
                values: new object[] {  new DateTime(2024, 10, 29, 14, 58, 18, 915, DateTimeKind.Local).AddTicks(5158), 2, null, new DateTime(2024, 10, 29, 13, 24, 18, 915, DateTimeKind.Local).AddTicks(5158), 3 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "EndTime", "ModifiedOnUtc", "StartTime" },
                values: new object[] {  new DateTime(2024, 10, 29, 16, 19, 18, 915, DateTimeKind.Local).AddTicks(5173), null, new DateTime(2024, 10, 29, 13, 41, 18, 915, DateTimeKind.Local).AddTicks(5173) });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "EndTime", "MediaId", "ModifiedOnUtc", "StartTime", "UserId" },
                values: new object[] {  new DateTime(2024, 10, 29, 17, 19, 18, 915, DateTimeKind.Local).AddTicks(5191), 1, null, new DateTime(2024, 10, 29, 14, 36, 18, 915, DateTimeKind.Local).AddTicks(5191), 9 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "EndTime", "ModifiedOnUtc", "StartTime", "UserId" },
                values: new object[] {  new DateTime(2024, 10, 29, 16, 55, 18, 915, DateTimeKind.Local).AddTicks(5252), null, new DateTime(2024, 10, 29, 14, 30, 18, 915, DateTimeKind.Local).AddTicks(5252), 7 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "EndTime", "MediaId", "ModifiedOnUtc", "StartTime" },
                values: new object[] {  new DateTime(2024, 10, 29, 15, 24, 18, 915, DateTimeKind.Local).AddTicks(5272), 2, null, new DateTime(2024, 10, 29, 13, 45, 18, 915, DateTimeKind.Local).AddTicks(5272) });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "EndTime", "ModifiedOnUtc", "StartTime", "UserId" },
                values: new object[] {  new DateTime(2024, 10, 29, 16, 56, 18, 915, DateTimeKind.Local).AddTicks(5288), null, new DateTime(2024, 10, 29, 14, 6, 18, 915, DateTimeKind.Local).AddTicks(5288), 4 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "EndTime", "ModifiedOnUtc", "StartTime", "UserId" },
                values: new object[] {  new DateTime(2024, 10, 29, 17, 26, 18, 915, DateTimeKind.Local).AddTicks(5301), null, new DateTime(2024, 10, 29, 14, 18, 18, 915, DateTimeKind.Local).AddTicks(5301), 4 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "EndTime", "ModifiedOnUtc", "StartTime", "UserId" },
                values: new object[] {  new DateTime(2024, 10, 29, 15, 33, 18, 915, DateTimeKind.Local).AddTicks(5317), null, new DateTime(2024, 10, 29, 14, 40, 18, 915, DateTimeKind.Local).AddTicks(5317), 3 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "EndTime", "MediaId", "ModifiedOnUtc", "StartTime", "UserId" },
                values: new object[] {  new DateTime(2024, 10, 29, 16, 59, 18, 915, DateTimeKind.Local).AddTicks(5330), 1, null, new DateTime(2024, 10, 29, 14, 15, 18, 915, DateTimeKind.Local).AddTicks(5330), 4 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "EndTime", "MediaId", "ModifiedOnUtc", "StartTime", "UserId" },
                values: new object[] {  new DateTime(2024, 10, 29, 15, 17, 18, 915, DateTimeKind.Local).AddTicks(5345), 1, null, new DateTime(2024, 10, 29, 14, 40, 18, 915, DateTimeKind.Local).AddTicks(5345), 2 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedOnUtc",
                table: "Sessions");

            migrationBuilder.DropColumn(
                name: "ModifiedOnUtc",
                table: "Sessions");

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 10, 28, 14, 59, 17, 705, DateTimeKind.Local).AddTicks(215), 3, new DateTime(2024, 10, 28, 14, 17, 17, 705, DateTimeKind.Local).AddTicks(215), 3 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndTime", "MediaId", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 28, 15, 26, 17, 705, DateTimeKind.Local).AddTicks(343), 1, new DateTime(2024, 10, 28, 15, 22, 17, 705, DateTimeKind.Local).AddTicks(343) });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 10, 28, 17, 29, 17, 705, DateTimeKind.Local).AddTicks(364), 3, new DateTime(2024, 10, 28, 14, 28, 17, 705, DateTimeKind.Local).AddTicks(364), 10 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 10, 28, 16, 59, 17, 705, DateTimeKind.Local).AddTicks(384), 1, new DateTime(2024, 10, 28, 14, 52, 17, 705, DateTimeKind.Local).AddTicks(384), 6 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndTime", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 10, 28, 16, 26, 17, 705, DateTimeKind.Local).AddTicks(403), new DateTime(2024, 10, 28, 15, 29, 17, 705, DateTimeKind.Local).AddTicks(403), 3 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndTime", "MediaId", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 28, 17, 10, 17, 705, DateTimeKind.Local).AddTicks(499), 2, new DateTime(2024, 10, 28, 15, 54, 17, 705, DateTimeKind.Local).AddTicks(499) });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndTime", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 10, 28, 17, 15, 17, 705, DateTimeKind.Local).AddTicks(522), new DateTime(2024, 10, 28, 15, 52, 17, 705, DateTimeKind.Local).AddTicks(522), 10 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 10, 28, 15, 14, 17, 705, DateTimeKind.Local).AddTicks(542), 2, new DateTime(2024, 10, 28, 14, 17, 17, 705, DateTimeKind.Local).AddTicks(542), 5 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 10, 28, 18, 51, 17, 705, DateTimeKind.Local).AddTicks(563), 3, new DateTime(2024, 10, 28, 15, 54, 17, 705, DateTimeKind.Local).AddTicks(563), 9 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndTime", "MediaId", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 28, 16, 44, 17, 705, DateTimeKind.Local).AddTicks(587), 1, new DateTime(2024, 10, 28, 14, 31, 17, 705, DateTimeKind.Local).AddTicks(587) });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 10, 28, 16, 43, 17, 705, DateTimeKind.Local).AddTicks(609), 3, new DateTime(2024, 10, 28, 15, 10, 17, 705, DateTimeKind.Local).AddTicks(609), 6 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 28, 15, 21, 17, 705, DateTimeKind.Local).AddTicks(631), new DateTime(2024, 10, 28, 15, 17, 17, 705, DateTimeKind.Local).AddTicks(631) });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 10, 28, 17, 52, 17, 705, DateTimeKind.Local).AddTicks(651), 3, new DateTime(2024, 10, 28, 15, 3, 17, 705, DateTimeKind.Local).AddTicks(651), 3 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "EndTime", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 10, 28, 16, 13, 17, 705, DateTimeKind.Local).AddTicks(674), new DateTime(2024, 10, 28, 15, 5, 17, 705, DateTimeKind.Local).AddTicks(674), 5 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "EndTime", "MediaId", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 28, 17, 50, 17, 705, DateTimeKind.Local).AddTicks(696), 3, new DateTime(2024, 10, 28, 15, 8, 17, 705, DateTimeKind.Local).AddTicks(696) });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "EndTime", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 10, 28, 15, 28, 17, 705, DateTimeKind.Local).AddTicks(718), new DateTime(2024, 10, 28, 14, 33, 17, 705, DateTimeKind.Local).AddTicks(718), 2 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "EndTime", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 10, 28, 17, 11, 17, 705, DateTimeKind.Local).AddTicks(740), new DateTime(2024, 10, 28, 15, 48, 17, 705, DateTimeKind.Local).AddTicks(740), 2 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "EndTime", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 10, 28, 16, 39, 17, 705, DateTimeKind.Local).AddTicks(763), new DateTime(2024, 10, 28, 15, 4, 17, 705, DateTimeKind.Local).AddTicks(763), 2 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 10, 28, 16, 22, 17, 705, DateTimeKind.Local).AddTicks(784), 3, new DateTime(2024, 10, 28, 14, 55, 17, 705, DateTimeKind.Local).AddTicks(784), 1 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 10, 28, 16, 2, 17, 705, DateTimeKind.Local).AddTicks(806), 3, new DateTime(2024, 10, 28, 15, 18, 17, 705, DateTimeKind.Local).AddTicks(806), 1 });
        }
    }
}
