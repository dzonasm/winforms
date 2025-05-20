using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WF_job.Migrations
{
    /// <inheritdoc />
    public partial class removeRelationsInGrade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grades_LearningModules_LearningModuleId",
                table: "Grades");

            migrationBuilder.DropIndex(
                name: "IX_Grades_LearningModuleId",
                table: "Grades");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Grades_LearningModuleId",
                table: "Grades",
                column: "LearningModuleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_LearningModules_LearningModuleId",
                table: "Grades",
                column: "LearningModuleId",
                principalTable: "LearningModules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
