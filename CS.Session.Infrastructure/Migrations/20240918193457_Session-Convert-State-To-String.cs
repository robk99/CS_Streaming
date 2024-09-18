using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CS.Session.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SessionConvertStateToString : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Sessions",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "State", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 18, 6, 56, 822, DateTimeKind.Local).AddTicks(4490), 1, new DateTime(2024, 9, 18, 16, 43, 56, 822, DateTimeKind.Local).AddTicks(4490), "CLOSED", 1 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "State", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 20, 5, 56, 822, DateTimeKind.Local).AddTicks(4595), 3, new DateTime(2024, 9, 18, 17, 47, 56, 822, DateTimeKind.Local).AddTicks(4595), "CLOSED", 1 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndTime", "StartTime", "State", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 18, 5, 56, 822, DateTimeKind.Local).AddTicks(4611), new DateTime(2024, 9, 18, 16, 52, 56, 822, DateTimeKind.Local).AddTicks(4611), "CLOSED", 8 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "State" },
                values: new object[] { new DateTime(2024, 9, 18, 19, 32, 56, 822, DateTimeKind.Local).AddTicks(4624), 2, new DateTime(2024, 9, 18, 17, 30, 56, 822, DateTimeKind.Local).AddTicks(4624), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "State" },
                values: new object[] { new DateTime(2024, 9, 18, 20, 51, 56, 822, DateTimeKind.Local).AddTicks(4638), 1, new DateTime(2024, 9, 18, 18, 7, 56, 822, DateTimeKind.Local).AddTicks(4638), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndTime", "StartTime", "State", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 18, 54, 56, 822, DateTimeKind.Local).AddTicks(4655), new DateTime(2024, 9, 18, 17, 8, 56, 822, DateTimeKind.Local).AddTicks(4655), "CLOSED", 8 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "State", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 19, 12, 56, 822, DateTimeKind.Local).AddTicks(4668), 1, new DateTime(2024, 9, 18, 16, 53, 56, 822, DateTimeKind.Local).AddTicks(4668), "CLOSED", 10 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "State", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 19, 20, 56, 822, DateTimeKind.Local).AddTicks(4681), 1, new DateTime(2024, 9, 18, 16, 42, 56, 822, DateTimeKind.Local).AddTicks(4681), "CLOSED", 2 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "State", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 19, 9, 56, 822, DateTimeKind.Local).AddTicks(4693), 2, new DateTime(2024, 9, 18, 18, 7, 56, 822, DateTimeKind.Local).AddTicks(4693), "CLOSED", 2 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndTime", "StartTime", "State", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 19, 42, 56, 822, DateTimeKind.Local).AddTicks(4707), new DateTime(2024, 9, 18, 18, 9, 56, 822, DateTimeKind.Local).AddTicks(4707), "CLOSED", 2 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "State", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 20, 26, 56, 822, DateTimeKind.Local).AddTicks(4720), 2, new DateTime(2024, 9, 18, 17, 30, 56, 822, DateTimeKind.Local).AddTicks(4720), "CLOSED", 9 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "State", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 19, 11, 56, 822, DateTimeKind.Local).AddTicks(4735), 3, new DateTime(2024, 9, 18, 17, 56, 56, 822, DateTimeKind.Local).AddTicks(4735), "CLOSED", 7 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "EndTime", "StartTime", "State", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 20, 32, 56, 822, DateTimeKind.Local).AddTicks(4749), new DateTime(2024, 9, 18, 17, 20, 56, 822, DateTimeKind.Local).AddTicks(4749), "CLOSED", 3 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "State", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 18, 6, 56, 822, DateTimeKind.Local).AddTicks(4765), 1, new DateTime(2024, 9, 18, 17, 2, 56, 822, DateTimeKind.Local).AddTicks(4765), "CLOSED", 4 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "State", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 20, 8, 56, 822, DateTimeKind.Local).AddTicks(4827), 3, new DateTime(2024, 9, 18, 17, 12, 56, 822, DateTimeKind.Local).AddTicks(4827), "CLOSED", 5 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "State", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 19, 17, 56, 822, DateTimeKind.Local).AddTicks(4841), 1, new DateTime(2024, 9, 18, 17, 22, 56, 822, DateTimeKind.Local).AddTicks(4841), "CLOSED", 4 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "State" },
                values: new object[] { new DateTime(2024, 9, 18, 18, 0, 56, 822, DateTimeKind.Local).AddTicks(4855), 1, new DateTime(2024, 9, 18, 17, 52, 56, 822, DateTimeKind.Local).AddTicks(4855), "CLOSED" });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "State", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 20, 15, 56, 822, DateTimeKind.Local).AddTicks(4869), 3, new DateTime(2024, 9, 18, 17, 45, 56, 822, DateTimeKind.Local).AddTicks(4869), "CLOSED", 9 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "State", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 18, 21, 56, 822, DateTimeKind.Local).AddTicks(4882), 1, new DateTime(2024, 9, 18, 17, 25, 56, 822, DateTimeKind.Local).AddTicks(4882), "CLOSED", 6 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "State", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 19, 34, 56, 822, DateTimeKind.Local).AddTicks(4895), 2, new DateTime(2024, 9, 18, 17, 54, 56, 822, DateTimeKind.Local).AddTicks(4895), "CLOSED", 5 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "State",
                table: "Sessions",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "State", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 8, 55, 11, 517, DateTimeKind.Local).AddTicks(3813), 2, new DateTime(2024, 9, 18, 7, 33, 11, 517, DateTimeKind.Local).AddTicks(3813), 5, 8 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "State", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 8, 22, 11, 517, DateTimeKind.Local).AddTicks(3947), 1, new DateTime(2024, 9, 18, 7, 52, 11, 517, DateTimeKind.Local).AddTicks(3947), 5, 4 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "EndTime", "StartTime", "State", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 8, 14, 11, 517, DateTimeKind.Local).AddTicks(3964), new DateTime(2024, 9, 18, 7, 49, 11, 517, DateTimeKind.Local).AddTicks(3964), 5, 6 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "State" },
                values: new object[] { new DateTime(2024, 9, 18, 11, 42, 11, 517, DateTimeKind.Local).AddTicks(3977), 3, new DateTime(2024, 9, 18, 8, 24, 11, 517, DateTimeKind.Local).AddTicks(3977), 5 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "State" },
                values: new object[] { new DateTime(2024, 9, 18, 9, 41, 11, 517, DateTimeKind.Local).AddTicks(3992), 3, new DateTime(2024, 9, 18, 8, 0, 11, 517, DateTimeKind.Local).AddTicks(3992), 5 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "EndTime", "StartTime", "State", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 9, 49, 11, 517, DateTimeKind.Local).AddTicks(4008), new DateTime(2024, 9, 18, 7, 47, 11, 517, DateTimeKind.Local).AddTicks(4008), 5, 2 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "State", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 8, 21, 11, 517, DateTimeKind.Local).AddTicks(4022), 2, new DateTime(2024, 9, 18, 7, 25, 11, 517, DateTimeKind.Local).AddTicks(4022), 5, 8 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "State", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 9, 19, 11, 517, DateTimeKind.Local).AddTicks(4034), 3, new DateTime(2024, 9, 18, 8, 32, 11, 517, DateTimeKind.Local).AddTicks(4034), 5, 7 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "State", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 8, 38, 11, 517, DateTimeKind.Local).AddTicks(4047), 1, new DateTime(2024, 9, 18, 8, 7, 11, 517, DateTimeKind.Local).AddTicks(4047), 5, 9 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "EndTime", "StartTime", "State", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 9, 5, 11, 517, DateTimeKind.Local).AddTicks(4060), new DateTime(2024, 9, 18, 7, 43, 11, 517, DateTimeKind.Local).AddTicks(4060), 5, 4 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "State", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 11, 50, 11, 517, DateTimeKind.Local).AddTicks(4073), 1, new DateTime(2024, 9, 18, 8, 36, 11, 517, DateTimeKind.Local).AddTicks(4073), 5, 5 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "State", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 8, 43, 11, 517, DateTimeKind.Local).AddTicks(4086), 1, new DateTime(2024, 9, 18, 7, 59, 11, 517, DateTimeKind.Local).AddTicks(4086), 5, 2 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "EndTime", "StartTime", "State", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 10, 40, 11, 517, DateTimeKind.Local).AddTicks(4100), new DateTime(2024, 9, 18, 8, 6, 11, 517, DateTimeKind.Local).AddTicks(4100), 5, 4 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "State", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 9, 38, 11, 517, DateTimeKind.Local).AddTicks(4115), 3, new DateTime(2024, 9, 18, 8, 23, 11, 517, DateTimeKind.Local).AddTicks(4115), 5, 9 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "State", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 8, 5, 11, 517, DateTimeKind.Local).AddTicks(4190), 2, new DateTime(2024, 9, 18, 7, 46, 11, 517, DateTimeKind.Local).AddTicks(4190), 5, 8 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "State", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 11, 29, 11, 517, DateTimeKind.Local).AddTicks(4205), 3, new DateTime(2024, 9, 18, 8, 20, 11, 517, DateTimeKind.Local).AddTicks(4205), 5, 9 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "State" },
                values: new object[] { new DateTime(2024, 9, 18, 10, 36, 11, 517, DateTimeKind.Local).AddTicks(4218), 3, new DateTime(2024, 9, 18, 7, 42, 11, 517, DateTimeKind.Local).AddTicks(4218), 5 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "State", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 9, 20, 11, 517, DateTimeKind.Local).AddTicks(4232), 1, new DateTime(2024, 9, 18, 8, 25, 11, 517, DateTimeKind.Local).AddTicks(4232), 5, 5 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "State", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 8, 35, 11, 517, DateTimeKind.Local).AddTicks(4245), 2, new DateTime(2024, 9, 18, 8, 10, 11, 517, DateTimeKind.Local).AddTicks(4245), 5, 8 });

            migrationBuilder.UpdateData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "EndTime", "MediaId", "StartTime", "State", "UserId" },
                values: new object[] { new DateTime(2024, 9, 18, 10, 16, 11, 517, DateTimeKind.Local).AddTicks(4258), 3, new DateTime(2024, 9, 18, 7, 39, 11, 517, DateTimeKind.Local).AddTicks(4258), 5, 6 });
        }
    }
}
