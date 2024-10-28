using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CS.Session.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddAuditMetadata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndTime", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 10, 28, 14, 59, 17, 705, DateTimeKind.Local).AddTicks(215), new DateTime(2024, 10, 28, 14, 17, 17, 705, DateTimeKind.Local).AddTicks(215), 3 });

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
                columns: new[] { "EndTime", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 10, 28, 17, 29, 17, 705, DateTimeKind.Local).AddTicks(364), new DateTime(2024, 10, 28, 14, 28, 17, 705, DateTimeKind.Local).AddTicks(364), 10 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndTime", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 10, 28, 16, 59, 17, 705, DateTimeKind.Local).AddTicks(384), new DateTime(2024, 10, 28, 14, 52, 17, 705, DateTimeKind.Local).AddTicks(384), 6 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndTime", "MediaId", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 28, 16, 26, 17, 705, DateTimeKind.Local).AddTicks(403), 2, new DateTime(2024, 10, 28, 15, 29, 17, 705, DateTimeKind.Local).AddTicks(403) });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 10, 28, 17, 10, 17, 705, DateTimeKind.Local).AddTicks(499), 2, new DateTime(2024, 10, 28, 15, 54, 17, 705, DateTimeKind.Local).AddTicks(499), 9 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 10, 28, 17, 15, 17, 705, DateTimeKind.Local).AddTicks(522), 2, new DateTime(2024, 10, 28, 15, 52, 17, 705, DateTimeKind.Local).AddTicks(522), 10 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndTime", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 10, 28, 15, 14, 17, 705, DateTimeKind.Local).AddTicks(542), new DateTime(2024, 10, 28, 14, 17, 17, 705, DateTimeKind.Local).AddTicks(542), 5 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndTime", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 10, 28, 18, 51, 17, 705, DateTimeKind.Local).AddTicks(563), new DateTime(2024, 10, 28, 15, 54, 17, 705, DateTimeKind.Local).AddTicks(563), 9 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 10, 28, 16, 44, 17, 705, DateTimeKind.Local).AddTicks(587), 1, new DateTime(2024, 10, 28, 14, 31, 17, 705, DateTimeKind.Local).AddTicks(587), 4 });

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
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 10, 28, 15, 21, 17, 705, DateTimeKind.Local).AddTicks(631), 1, new DateTime(2024, 10, 28, 15, 17, 17, 705, DateTimeKind.Local).AddTicks(631), 5 });

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
                columns: new[] { "EndTime", "MediaId", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 28, 16, 13, 17, 705, DateTimeKind.Local).AddTicks(674), 1, new DateTime(2024, 10, 28, 15, 5, 17, 705, DateTimeKind.Local).AddTicks(674) });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "EndTime", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 10, 28, 17, 50, 17, 705, DateTimeKind.Local).AddTicks(696), new DateTime(2024, 10, 28, 15, 8, 17, 705, DateTimeKind.Local).AddTicks(696), 6 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 10, 28, 15, 28, 17, 705, DateTimeKind.Local).AddTicks(718), 3, new DateTime(2024, 10, 28, 14, 33, 17, 705, DateTimeKind.Local).AddTicks(718), 2 });

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
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 28, 16, 22, 17, 705, DateTimeKind.Local).AddTicks(784), new DateTime(2024, 10, 28, 14, 55, 17, 705, DateTimeKind.Local).AddTicks(784) });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 10, 28, 16, 2, 17, 705, DateTimeKind.Local).AddTicks(806), 3, new DateTime(2024, 10, 28, 15, 18, 17, 705, DateTimeKind.Local).AddTicks(806), 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndTime", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 19, 7, 24, 39, 762, DateTimeKind.Local).AddTicks(8022), new DateTime(2024, 9, 19, 4, 6, 39, 762, DateTimeKind.Local).AddTicks(8022), 1 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndTime", "MediaId", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 19, 7, 15, 39, 762, DateTimeKind.Local).AddTicks(8127), 2, new DateTime(2024, 9, 19, 4, 57, 39, 762, DateTimeKind.Local).AddTicks(8127) });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndTime", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 19, 7, 40, 39, 762, DateTimeKind.Local).AddTicks(8143), new DateTime(2024, 9, 19, 4, 50, 39, 762, DateTimeKind.Local).AddTicks(8143), 9 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndTime", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 19, 8, 37, 39, 762, DateTimeKind.Local).AddTicks(8159), new DateTime(2024, 9, 19, 5, 21, 39, 762, DateTimeKind.Local).AddTicks(8159), 8 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndTime", "MediaId", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 19, 6, 21, 39, 762, DateTimeKind.Local).AddTicks(8173), 3, new DateTime(2024, 9, 19, 5, 27, 39, 762, DateTimeKind.Local).AddTicks(8173) });

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
                columns: new[] { "EndTime", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 19, 6, 56, 39, 762, DateTimeKind.Local).AddTicks(8215), new DateTime(2024, 9, 19, 5, 10, 39, 762, DateTimeKind.Local).AddTicks(8215), 3 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndTime", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 19, 4, 19, 39, 762, DateTimeKind.Local).AddTicks(8229), new DateTime(2024, 9, 19, 4, 7, 39, 762, DateTimeKind.Local).AddTicks(8229), 10 });

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
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 19, 5, 27, 39, 762, DateTimeKind.Local).AddTicks(8259), 2, new DateTime(2024, 9, 19, 4, 2, 39, 762, DateTimeKind.Local).AddTicks(8259), 7 });

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
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 19, 6, 25, 39, 762, DateTimeKind.Local).AddTicks(8318), 1, new DateTime(2024, 9, 19, 5, 21, 39, 762, DateTimeKind.Local).AddTicks(8318), 7 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "EndTime", "MediaId", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 19, 6, 59, 39, 762, DateTimeKind.Local).AddTicks(8334), 2, new DateTime(2024, 9, 19, 4, 14, 39, 762, DateTimeKind.Local).AddTicks(8334) });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "EndTime", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 19, 7, 10, 39, 762, DateTimeKind.Local).AddTicks(8348), new DateTime(2024, 9, 19, 4, 7, 39, 762, DateTimeKind.Local).AddTicks(8348), 9 });

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
                columns: new[] { "EndTime", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 19, 5, 22, 39, 762, DateTimeKind.Local).AddTicks(8375), new DateTime(2024, 9, 19, 5, 19, 39, 762, DateTimeKind.Local).AddTicks(8375), 9 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "EndTime", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 19, 6, 58, 39, 762, DateTimeKind.Local).AddTicks(8391), new DateTime(2024, 9, 19, 4, 3, 39, 762, DateTimeKind.Local).AddTicks(8391), 1 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 19, 6, 46, 39, 762, DateTimeKind.Local).AddTicks(8404), new DateTime(2024, 9, 19, 4, 34, 39, 762, DateTimeKind.Local).AddTicks(8404) });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 19, 6, 50, 39, 762, DateTimeKind.Local).AddTicks(8418), 2, new DateTime(2024, 9, 19, 4, 42, 39, 762, DateTimeKind.Local).AddTicks(8418), 8 });
        }
    }
}
