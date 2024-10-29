using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CS.Media.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddAudits : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOnUtc",
                table: "Medias",
                type: "datetime2",
                nullable: false,
                defaultValue: DateTime.UtcNow
                );

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOnUtc",
                table: "Medias",
                type: "datetime2",
                nullable: true,
                defaultValue: null
                );

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ModifiedOnUtc" },
                values: new object[] { null });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "LengthInSeconds", "ModifiedOnUtc" },
                values: new object[] { 1343, null });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "LengthInSeconds", "ModifiedOnUtc" },
                values: new object[] { 1599, null });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "LengthInSeconds", "ModifiedOnUtc" },
                values: new object[] { 1905, null });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "LengthInSeconds", "ModifiedOnUtc" },
                values: new object[] { 8598, null });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "LengthInSeconds", "ModifiedOnUtc" },
                values: new object[] { 8010, null });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "LengthInSeconds", "ModifiedOnUtc" },
                values: new object[] { 3358, null });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "LengthInSeconds", "ModifiedOnUtc" },
                values: new object[] { 1975, null });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "LengthInSeconds", "ModifiedOnUtc" },
                values: new object[] { 9577, null });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "LengthInSeconds", "ModifiedOnUtc" },
                values: new object[] { 7425, null });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "LengthInSeconds", "ModifiedOnUtc" },
                values: new object[] { 3789, null });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "LengthInSeconds", "ModifiedOnUtc" },
                values: new object[] { 3270, null });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "LengthInSeconds", "ModifiedOnUtc" },
                values: new object[] { 563, null });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "LengthInSeconds", "ModifiedOnUtc" },
                values: new object[] { 1381, null });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "LengthInSeconds", "ModifiedOnUtc" },
                values: new object[] { 2412, null });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "LengthInSeconds", "ModifiedOnUtc" },
                values: new object[] { 2279, null });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "LengthInSeconds", "ModifiedOnUtc" },
                values: new object[] { 3340, null });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "LengthInSeconds", "ModifiedOnUtc" },
                values: new object[] { 794, null });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "LengthInSeconds", "ModifiedOnUtc" },
                values: new object[] { 289, null });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "LengthInSeconds", "ModifiedOnUtc" },
                values: new object[] { 678, null });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "LengthInSeconds", "ModifiedOnUtc" },
                values: new object[] { 231, null });

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "LengthInSeconds", "ModifiedOnUtc" },
                values: new object[] { 1911, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedOnUtc",
                table: "Medias");

            migrationBuilder.DropColumn(
                name: "ModifiedOnUtc",
                table: "Medias");

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 2,
                column: "LengthInSeconds",
                value: 3986);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 3,
                column: "LengthInSeconds",
                value: 8817);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 4,
                column: "LengthInSeconds",
                value: 639);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 5,
                column: "LengthInSeconds",
                value: 1106);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 6,
                column: "LengthInSeconds",
                value: 4830);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 7,
                column: "LengthInSeconds",
                value: 12959);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 8,
                column: "LengthInSeconds",
                value: 9618);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 9,
                column: "LengthInSeconds",
                value: 11711);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 10,
                column: "LengthInSeconds",
                value: 12331);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 11,
                column: "LengthInSeconds",
                value: 555);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 12,
                column: "LengthInSeconds",
                value: 2742);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 13,
                column: "LengthInSeconds",
                value: 2284);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 14,
                column: "LengthInSeconds",
                value: 2834);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 15,
                column: "LengthInSeconds",
                value: 2351);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 16,
                column: "LengthInSeconds",
                value: 806);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 17,
                column: "LengthInSeconds",
                value: 2428);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 18,
                column: "LengthInSeconds",
                value: 3202);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 19,
                column: "LengthInSeconds",
                value: 294);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 20,
                column: "LengthInSeconds",
                value: 2791);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 21,
                column: "LengthInSeconds",
                value: 65);

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 22,
                column: "LengthInSeconds",
                value: 1712);
        }
    }
}
