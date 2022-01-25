using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DioSeriesWebMvc.Migrations
{
    public partial class OtherEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gymming",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    Categorie = table.Column<int>(nullable: false),
                    GymDepartmentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gymming", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gymming_GymDepartment_GymDepartmentId",
                        column: x => x.GymDepartmentId,
                        principalTable: "GymDepartment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GymmingRecord",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(nullable: false),
                    Amount = table.Column<double>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    GymmingId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GymmingRecord", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GymmingRecord_Gymming_GymmingId",
                        column: x => x.GymmingId,
                        principalTable: "Gymming",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Gymming_GymDepartmentId",
                table: "Gymming",
                column: "GymDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_GymmingRecord_GymmingId",
                table: "GymmingRecord",
                column: "GymmingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GymmingRecord");

            migrationBuilder.DropTable(
                name: "Gymming");
        }
    }
}
