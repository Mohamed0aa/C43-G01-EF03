using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment.Data.Migrations
{
    /// <inheritdoc />
    public partial class Relations5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "workforId",
                table: "Instructors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_workforId",
                table: "Instructors",
                column: "workforId");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_workforId",
                table: "Instructors",
                column: "workforId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_workforId",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_workforId",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "workforId",
                table: "Instructors");
        }
    }
}
