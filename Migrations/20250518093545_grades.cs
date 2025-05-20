using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WF_job.Migrations
{
    /// <inheritdoc />
    public partial class grades : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Score",
                table: "Grades");

            migrationBuilder.AddColumn<string>(
                name: "Scores",
                table: "Grades",
                type: "TEXT",
                nullable: false,
                defaultValue: "[]");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Scores",
                table: "Grades");

            migrationBuilder.AddColumn<int>(
                name: "Score",
                table: "Grades",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
