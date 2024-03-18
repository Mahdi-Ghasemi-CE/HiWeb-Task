using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HiWeb_Task.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddTermInCourse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Terms_TermId",
                table: "Courses");

            migrationBuilder.AlterColumn<int>(
                name: "TermId",
                table: "Courses",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Terms_TermId",
                table: "Courses",
                column: "TermId",
                principalTable: "Terms",
                principalColumn: "TermId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Terms_TermId",
                table: "Courses");

            migrationBuilder.AlterColumn<int>(
                name: "TermId",
                table: "Courses",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Terms_TermId",
                table: "Courses",
                column: "TermId",
                principalTable: "Terms",
                principalColumn: "TermId");
        }
    }
}
