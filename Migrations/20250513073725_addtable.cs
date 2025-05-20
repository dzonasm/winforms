using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WF_job.Migrations
{
    /// <inheritdoc />
    public partial class addtable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Grades",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "LearningModules",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Grades");

            migrationBuilder.RenameColumn(
                name: "ModuleName",
                table: "LearningModules",
                newName: "Name");

            migrationBuilder.CreateTable(
                name: "StudentLearningModule",
                columns: table => new
                {
                    LearningModulesId = table.Column<int>(type: "INTEGER", nullable: false),
                    StudentsId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentLearningModule", x => new { x.LearningModulesId, x.StudentsId });
                    table.ForeignKey(
                        name: "FK_StudentLearningModule_LearningModules_LearningModulesId",
                        column: x => x.LearningModulesId,
                        principalTable: "LearningModules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentLearningModule_Students_StudentsId",
                        column: x => x.StudentsId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Grades_LearningModuleId",
                table: "Grades",
                column: "LearningModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_StudentId",
                table: "Grades",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentLearningModule_StudentsId",
                table: "StudentLearningModule",
                column: "StudentsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_LearningModules_LearningModuleId",
                table: "Grades",
                column: "LearningModuleId",
                principalTable: "LearningModules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_Students_StudentId",
                table: "Grades",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grades_LearningModules_LearningModuleId",
                table: "Grades");

            migrationBuilder.DropForeignKey(
                name: "FK_Grades_Students_StudentId",
                table: "Grades");

            migrationBuilder.DropTable(
                name: "StudentLearningModule");

            migrationBuilder.DropIndex(
                name: "IX_Grades_LearningModuleId",
                table: "Grades");

            migrationBuilder.DropIndex(
                name: "IX_Grades_StudentId",
                table: "Grades");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "LearningModules",
                newName: "ModuleName");

            migrationBuilder.AddColumn<string>(
                name: "Grades",
                table: "Students",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LearningModules",
                table: "Students",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Grades",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
