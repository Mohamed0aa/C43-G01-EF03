using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment.Data.Migrations
{
    /// <inheritdoc />
    public partial class Relations2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "topicId",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Courses_topicId",
                table: "Courses",
                column: "topicId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Topics_topicId",
                table: "Courses",
                column: "topicId",
                principalTable: "Topics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Topics_topicId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_topicId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "topicId",
                table: "Courses");
        }
    }
}
