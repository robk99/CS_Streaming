using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CS.Session.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SessionIdAutGenerated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 21, 3, 44, 957, DateTimeKind.Local).AddTicks(1692), 2, new DateTime(2024, 9, 18, 19, 20, 44, 957, DateTimeKind.Local).AddTicks(1692), 8 });

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
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 23, 10, 44, 957, DateTimeKind.Local).AddTicks(1735), 3, new DateTime(2024, 9, 18, 20, 7, 44, 957, DateTimeKind.Local).AddTicks(1735), 8 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndTime", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 20, 15, 44, 957, DateTimeKind.Local).AddTicks(1751), new DateTime(2024, 9, 18, 19, 38, 44, 957, DateTimeKind.Local).AddTicks(1751), 1 });

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
                columns: new[] { "EndTime", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 21, 27, 44, 957, DateTimeKind.Local).AddTicks(1777), new DateTime(2024, 9, 18, 18, 55, 44, 957, DateTimeKind.Local).AddTicks(1777), 10 });

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
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 21, 40, 44, 957, DateTimeKind.Local).AddTicks(1818), 3, new DateTime(2024, 9, 18, 19, 40, 44, 957, DateTimeKind.Local).AddTicks(1818), 7 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "EndTime", "MediaId", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 18, 23, 3, 44, 957, DateTimeKind.Local).AddTicks(1832), 1, new DateTime(2024, 9, 18, 20, 4, 44, 957, DateTimeKind.Local).AddTicks(1832) });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 20, 50, 44, 957, DateTimeKind.Local).AddTicks(1846), 1, new DateTime(2024, 9, 18, 19, 45, 44, 957, DateTimeKind.Local).AddTicks(1846), 1 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "EndTime", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 20, 40, 44, 957, DateTimeKind.Local).AddTicks(1861), new DateTime(2024, 9, 18, 19, 54, 44, 957, DateTimeKind.Local).AddTicks(1861), 3 });

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
                columns: new[] { "EndTime", "MediaId", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 18, 21, 34, 44, 957, DateTimeKind.Local).AddTicks(1901), 3, new DateTime(2024, 9, 18, 18, 48, 44, 957, DateTimeKind.Local).AddTicks(1901) });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "EndTime", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 21, 31, 44, 957, DateTimeKind.Local).AddTicks(1916), new DateTime(2024, 9, 18, 18, 59, 44, 957, DateTimeKind.Local).AddTicks(1916), 3 });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 18, 6, 56, 822, DateTimeKind.Local).AddTicks(4490), 1, new DateTime(2024, 9, 18, 16, 43, 56, 822, DateTimeKind.Local).AddTicks(4490), 1 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 20, 5, 56, 822, DateTimeKind.Local).AddTicks(4595), 3, new DateTime(2024, 9, 18, 17, 47, 56, 822, DateTimeKind.Local).AddTicks(4595), 1 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 18, 5, 56, 822, DateTimeKind.Local).AddTicks(4611), 3, new DateTime(2024, 9, 18, 16, 52, 56, 822, DateTimeKind.Local).AddTicks(4611), 8 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 19, 32, 56, 822, DateTimeKind.Local).AddTicks(4624), 2, new DateTime(2024, 9, 18, 17, 30, 56, 822, DateTimeKind.Local).AddTicks(4624), 10 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 20, 51, 56, 822, DateTimeKind.Local).AddTicks(4638), 1, new DateTime(2024, 9, 18, 18, 7, 56, 822, DateTimeKind.Local).AddTicks(4638), 10 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndTime", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 18, 54, 56, 822, DateTimeKind.Local).AddTicks(4655), new DateTime(2024, 9, 18, 17, 8, 56, 822, DateTimeKind.Local).AddTicks(4655), 8 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 19, 12, 56, 822, DateTimeKind.Local).AddTicks(4668), 1, new DateTime(2024, 9, 18, 16, 53, 56, 822, DateTimeKind.Local).AddTicks(4668), 10 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndTime", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 19, 20, 56, 822, DateTimeKind.Local).AddTicks(4681), new DateTime(2024, 9, 18, 16, 42, 56, 822, DateTimeKind.Local).AddTicks(4681), 2 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 19, 9, 56, 822, DateTimeKind.Local).AddTicks(4693), 2, new DateTime(2024, 9, 18, 18, 7, 56, 822, DateTimeKind.Local).AddTicks(4693), 2 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 19, 42, 56, 822, DateTimeKind.Local).AddTicks(4707), 2, new DateTime(2024, 9, 18, 18, 9, 56, 822, DateTimeKind.Local).AddTicks(4707), 2 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 20, 26, 56, 822, DateTimeKind.Local).AddTicks(4720), 2, new DateTime(2024, 9, 18, 17, 30, 56, 822, DateTimeKind.Local).AddTicks(4720), 9 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "EndTime", "MediaId", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 18, 19, 11, 56, 822, DateTimeKind.Local).AddTicks(4735), 3, new DateTime(2024, 9, 18, 17, 56, 56, 822, DateTimeKind.Local).AddTicks(4735) });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 20, 32, 56, 822, DateTimeKind.Local).AddTicks(4749), 3, new DateTime(2024, 9, 18, 17, 20, 56, 822, DateTimeKind.Local).AddTicks(4749), 3 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "EndTime", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 18, 6, 56, 822, DateTimeKind.Local).AddTicks(4765), new DateTime(2024, 9, 18, 17, 2, 56, 822, DateTimeKind.Local).AddTicks(4765), 4 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 20, 8, 56, 822, DateTimeKind.Local).AddTicks(4827), 3, new DateTime(2024, 9, 18, 17, 12, 56, 822, DateTimeKind.Local).AddTicks(4827), 5 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 19, 17, 56, 822, DateTimeKind.Local).AddTicks(4841), 1, new DateTime(2024, 9, 18, 17, 22, 56, 822, DateTimeKind.Local).AddTicks(4841), 4 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "EndTime", "MediaId", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 18, 18, 0, 56, 822, DateTimeKind.Local).AddTicks(4855), 1, new DateTime(2024, 9, 18, 17, 52, 56, 822, DateTimeKind.Local).AddTicks(4855) });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "EndTime", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 20, 15, 56, 822, DateTimeKind.Local).AddTicks(4869), new DateTime(2024, 9, 18, 17, 45, 56, 822, DateTimeKind.Local).AddTicks(4869), 9 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 18, 21, 56, 822, DateTimeKind.Local).AddTicks(4882), 1, new DateTime(2024, 9, 18, 17, 25, 56, 822, DateTimeKind.Local).AddTicks(4882), 6 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 19, 34, 56, 822, DateTimeKind.Local).AddTicks(4895), 2, new DateTime(2024, 9, 18, 17, 54, 56, 822, DateTimeKind.Local).AddTicks(4895), 5 });
        }
    }
}
