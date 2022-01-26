using Microsoft.EntityFrameworkCore.Migrations;

namespace DioSeriesWebMvc.Migrations
{
    public partial class GymDepartmentForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gymming_GymDepartment_GymDepartmentId",
                table: "Gymming");

            migrationBuilder.AlterColumn<int>(
                name: "GymDepartmentId",
                table: "Gymming",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Gymming_GymDepartment_GymDepartmentId",
                table: "Gymming",
                column: "GymDepartmentId",
                principalTable: "GymDepartment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gymming_GymDepartment_GymDepartmentId",
                table: "Gymming");

            migrationBuilder.AlterColumn<int>(
                name: "GymDepartmentId",
                table: "Gymming",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Gymming_GymDepartment_GymDepartmentId",
                table: "Gymming",
                column: "GymDepartmentId",
                principalTable: "GymDepartment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
