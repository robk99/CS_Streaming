using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CS.Session.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SessionEndTimeNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                table: "Sessions",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 19, 7, 24, 39, 762, DateTimeKind.Local).AddTicks(8022), 3, new DateTime(2024, 9, 19, 4, 6, 39, 762, DateTimeKind.Local).AddTicks(8022), 1 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndTime", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 19, 7, 15, 39, 762, DateTimeKind.Local).AddTicks(8127), new DateTime(2024, 9, 19, 4, 57, 39, 762, DateTimeKind.Local).AddTicks(8127), 10 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 19, 7, 40, 39, 762, DateTimeKind.Local).AddTicks(8143), 3, new DateTime(2024, 9, 19, 4, 50, 39, 762, DateTimeKind.Local).AddTicks(8143), 9 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 19, 8, 37, 39, 762, DateTimeKind.Local).AddTicks(8159), 1, new DateTime(2024, 9, 19, 5, 21, 39, 762, DateTimeKind.Local).AddTicks(8159), 8 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndTime", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 19, 6, 21, 39, 762, DateTimeKind.Local).AddTicks(8173), new DateTime(2024, 9, 19, 5, 27, 39, 762, DateTimeKind.Local).AddTicks(8173), 3 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 19, 6, 15, 39, 762, DateTimeKind.Local).AddTicks(8189), 1, new DateTime(2024, 9, 19, 4, 42, 39, 762, DateTimeKind.Local).AddTicks(8189), 5 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 19, 5, 54, 39, 762, DateTimeKind.Local).AddTicks(8202), 1, new DateTime(2024, 9, 19, 5, 8, 39, 762, DateTimeKind.Local).AddTicks(8202), 6 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 19, 6, 56, 39, 762, DateTimeKind.Local).AddTicks(8215), 2, new DateTime(2024, 9, 19, 5, 10, 39, 762, DateTimeKind.Local).AddTicks(8215), 3 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 19, 4, 19, 39, 762, DateTimeKind.Local).AddTicks(8229), 3, new DateTime(2024, 9, 19, 4, 7, 39, 762, DateTimeKind.Local).AddTicks(8229), 10 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 19, 3, 56, 39, 762, DateTimeKind.Local).AddTicks(8245), 2, new DateTime(2024, 9, 19, 3, 52, 39, 762, DateTimeKind.Local).AddTicks(8245), 9 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "EndTime", "MediaId", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 19, 5, 27, 39, 762, DateTimeKind.Local).AddTicks(8259), 2, new DateTime(2024, 9, 19, 4, 2, 39, 762, DateTimeKind.Local).AddTicks(8259) });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 19, 8, 26, 39, 762, DateTimeKind.Local).AddTicks(8273), 3, new DateTime(2024, 9, 19, 5, 8, 39, 762, DateTimeKind.Local).AddTicks(8273), 3 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "EndTime", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 19, 6, 25, 39, 762, DateTimeKind.Local).AddTicks(8318), new DateTime(2024, 9, 19, 5, 21, 39, 762, DateTimeKind.Local).AddTicks(8318), 7 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 19, 6, 59, 39, 762, DateTimeKind.Local).AddTicks(8334), 2, new DateTime(2024, 9, 19, 4, 14, 39, 762, DateTimeKind.Local).AddTicks(8334), 5 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 19, 7, 10, 39, 762, DateTimeKind.Local).AddTicks(8348), 3, new DateTime(2024, 9, 19, 4, 7, 39, 762, DateTimeKind.Local).AddTicks(8348), 9 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 19, 8, 35, 39, 762, DateTimeKind.Local).AddTicks(8362), 2, new DateTime(2024, 9, 19, 5, 29, 39, 762, DateTimeKind.Local).AddTicks(8362), 9 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 19, 5, 22, 39, 762, DateTimeKind.Local).AddTicks(8375), 2, new DateTime(2024, 9, 19, 5, 19, 39, 762, DateTimeKind.Local).AddTicks(8375), 9 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 19, 6, 58, 39, 762, DateTimeKind.Local).AddTicks(8391), 1, new DateTime(2024, 9, 19, 4, 3, 39, 762, DateTimeKind.Local).AddTicks(8391), 1 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 19, 6, 46, 39, 762, DateTimeKind.Local).AddTicks(8404), 3, new DateTime(2024, 9, 19, 4, 34, 39, 762, DateTimeKind.Local).AddTicks(8404), 1 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 19, 6, 50, 39, 762, DateTimeKind.Local).AddTicks(8418), 2, new DateTime(2024, 9, 19, 4, 42, 39, 762, DateTimeKind.Local).AddTicks(8418), 8 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                table: "Sessions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 21, 45, 44, 957, DateTimeKind.Local).AddTicks(1591), 2, new DateTime(2024, 9, 18, 19, 29, 44, 957, DateTimeKind.Local).AddTicks(1591), 8 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndTime", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 21, 3, 44, 957, DateTimeKind.Local).AddTicks(1692), new DateTime(2024, 9, 18, 19, 20, 44, 957, DateTimeKind.Local).AddTicks(1692), 8 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 22, 54, 44, 957, DateTimeKind.Local).AddTicks(1707), 1, new DateTime(2024, 9, 18, 19, 46, 44, 957, DateTimeKind.Local).AddTicks(1707), 10 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 21, 57, 44, 957, DateTimeKind.Local).AddTicks(1722), 3, new DateTime(2024, 9, 18, 20, 0, 44, 957, DateTimeKind.Local).AddTicks(1722), 3 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndTime", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 23, 10, 44, 957, DateTimeKind.Local).AddTicks(1735), new DateTime(2024, 9, 18, 20, 7, 44, 957, DateTimeKind.Local).AddTicks(1735), 8 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 20, 15, 44, 957, DateTimeKind.Local).AddTicks(1751), 2, new DateTime(2024, 9, 18, 19, 38, 44, 957, DateTimeKind.Local).AddTicks(1751), 1 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 21, 16, 44, 957, DateTimeKind.Local).AddTicks(1764), 2, new DateTime(2024, 9, 18, 18, 45, 44, 957, DateTimeKind.Local).AddTicks(1764), 1 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 21, 27, 44, 957, DateTimeKind.Local).AddTicks(1777), 1, new DateTime(2024, 9, 18, 18, 55, 44, 957, DateTimeKind.Local).AddTicks(1777), 10 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 21, 10, 44, 957, DateTimeKind.Local).AddTicks(1790), 1, new DateTime(2024, 9, 18, 18, 47, 44, 957, DateTimeKind.Local).AddTicks(1790), 9 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 21, 12, 44, 957, DateTimeKind.Local).AddTicks(1804), 3, new DateTime(2024, 9, 18, 19, 5, 44, 957, DateTimeKind.Local).AddTicks(1804), 3 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "EndTime", "MediaId", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 18, 21, 40, 44, 957, DateTimeKind.Local).AddTicks(1818), 3, new DateTime(2024, 9, 18, 19, 40, 44, 957, DateTimeKind.Local).AddTicks(1818) });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 23, 3, 44, 957, DateTimeKind.Local).AddTicks(1832), 1, new DateTime(2024, 9, 18, 20, 4, 44, 957, DateTimeKind.Local).AddTicks(1832), 7 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "EndTime", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 20, 50, 44, 957, DateTimeKind.Local).AddTicks(1846), new DateTime(2024, 9, 18, 19, 45, 44, 957, DateTimeKind.Local).AddTicks(1846), 1 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 20, 40, 44, 957, DateTimeKind.Local).AddTicks(1861), 1, new DateTime(2024, 9, 18, 19, 54, 44, 957, DateTimeKind.Local).AddTicks(1861), 3 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 19, 2, 44, 957, DateTimeKind.Local).AddTicks(1874), 1, new DateTime(2024, 9, 18, 18, 58, 44, 957, DateTimeKind.Local).AddTicks(1874), 8 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 21, 21, 44, 957, DateTimeKind.Local).AddTicks(1887), 3, new DateTime(2024, 9, 18, 19, 7, 44, 957, DateTimeKind.Local).AddTicks(1887), 10 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 21, 34, 44, 957, DateTimeKind.Local).AddTicks(1901), 3, new DateTime(2024, 9, 18, 18, 48, 44, 957, DateTimeKind.Local).AddTicks(1901), 6 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 21, 31, 44, 957, DateTimeKind.Local).AddTicks(1916), 3, new DateTime(2024, 9, 18, 18, 59, 44, 957, DateTimeKind.Local).AddTicks(1916), 3 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 21, 30, 44, 957, DateTimeKind.Local).AddTicks(1929), 2, new DateTime(2024, 9, 18, 19, 57, 44, 957, DateTimeKind.Local).AddTicks(1929), 8 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 21, 9, 44, 957, DateTimeKind.Local).AddTicks(1942), 1, new DateTime(2024, 9, 18, 19, 46, 44, 957, DateTimeKind.Local).AddTicks(1942), 7 });
        }
    }
}
