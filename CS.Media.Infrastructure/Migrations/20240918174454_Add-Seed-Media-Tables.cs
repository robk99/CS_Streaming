using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CS.Media.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedMediaTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MediaTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LongName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MediaTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Medias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MediaTypeId = table.Column<int>(type: "int", nullable: false),
                    LengthInSeconds = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Medias_MediaTypes_MediaTypeId",
                        column: x => x.MediaTypeId,
                        principalTable: "MediaTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "MediaTypes",
                columns: new[] { "Id", "LongName", "Name" },
                values: new object[,]
                {
                    { 1, "Video on Demand", "VOD" },
                    { 2, "Audio on Demand", "AOD" },
                    { 3, "Electronic Program Guide", "EPG-1" }
                });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "LengthInSeconds", "MediaTypeId", "Name" },
                values: new object[,]
                {
                    { 1, null, 3, "EPG" },
                    { 2, 9219, 1, "VOD-2" },
                    { 3, 13918, 1, "VOD-3" },
                    { 4, 5999, 1, "VOD-4" },
                    { 5, 1825, 1, "VOD-5" },
                    { 6, 9976, 1, "VOD-6" },
                    { 7, 14020, 1, "VOD-7" },
                    { 8, 746, 1, "VOD-8" },
                    { 9, 7687, 1, "VOD-9" },
                    { 10, 12280, 1, "VOD-10" },
                    { 11, 11209, 1, "VOD-11" },
                    { 12, 927, 2, "AOD-12" },
                    { 13, 268, 2, "AOD-13" },
                    { 14, 88, 2, "AOD-14" },
                    { 15, 3396, 2, "AOD-15" },
                    { 16, 1960, 2, "AOD-16" },
                    { 17, 2847, 2, "AOD-17" },
                    { 18, 3456, 2, "AOD-18" },
                    { 19, 1726, 2, "AOD-19" },
                    { 20, 1854, 2, "AOD-20" },
                    { 21, 2353, 2, "AOD-21" },
                    { 22, 249, 2, "AOD-22" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Medias_MediaTypeId",
                table: "Medias",
                column: "MediaTypeId");

            migrationBuilder.Sql(@"CREATE PROCEDURE Medias_Create
                @Name NVARCHAR(100),
                @MediaTypeId INT,
                @LengthInSeconds INT = NULL,
                @NewMediaId INT OUTPUT
            AS
            BEGIN
                INSERT INTO Medias (Name, MediaTypeId, LengthInSeconds)
                VALUES (@Name, @MediaTypeId, @LengthInSeconds);
                SET @NewMediaId = SCOPE_IDENTITY();
            END;
            GO");

            migrationBuilder.Sql(@"CREATE PROCEDURE Medias_GetById
                @Id INT
            AS
            BEGIN
                SELECT * FROM Medias WHERE Id = @Id;
            END;
            GO");

            migrationBuilder.Sql(@"CREATE PROCEDURE MediaTypes_GetById
                @Id INT
            AS
            BEGIN
                SELECT * FROM MediaTypes WHERE Id = @Id;
            END;
            GO");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Medias");

            migrationBuilder.DropTable(
                name: "MediaTypes");

            migrationBuilder.Sql("DROP PROCEDURE IF EXISTS Medias_Create;");
            migrationBuilder.Sql("DROP PROCEDURE IF EXISTS Medias_Create;");
            migrationBuilder.Sql("DROP PROCEDURE IF EXISTS MediaTypes_GetById;");

        }
    }
}
