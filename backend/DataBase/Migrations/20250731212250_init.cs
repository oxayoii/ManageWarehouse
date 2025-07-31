using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DataBase.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DocumentEntrances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Number = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentEntrances", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Resourses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resourses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnitMeansures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitMeansures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ResourseEntrances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DocumentEntranceId = table.Column<int>(type: "integer", nullable: false),
                    ResourseId = table.Column<int>(type: "integer", nullable: false),
                    UnitMeansureId = table.Column<int>(type: "integer", nullable: false),
                    Count = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResourseEntrances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResourseEntrances_DocumentEntrances_DocumentEntranceId",
                        column: x => x.DocumentEntranceId,
                        principalTable: "DocumentEntrances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ResourseEntrances_Resourses_ResourseId",
                        column: x => x.ResourseId,
                        principalTable: "Resourses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ResourseEntrances_UnitMeansures_UnitMeansureId",
                        column: x => x.UnitMeansureId,
                        principalTable: "UnitMeansures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ResourseEntrances_DocumentEntranceId",
                table: "ResourseEntrances",
                column: "DocumentEntranceId");

            migrationBuilder.CreateIndex(
                name: "IX_ResourseEntrances_ResourseId",
                table: "ResourseEntrances",
                column: "ResourseId");

            migrationBuilder.CreateIndex(
                name: "IX_ResourseEntrances_UnitMeansureId",
                table: "ResourseEntrances",
                column: "UnitMeansureId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ResourseEntrances");

            migrationBuilder.DropTable(
                name: "DocumentEntrances");

            migrationBuilder.DropTable(
                name: "Resourses");

            migrationBuilder.DropTable(
                name: "UnitMeansures");
        }
    }
}
