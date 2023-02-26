using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversityStudyPlatform.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addStudentPerfomanceModelToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentPerfomances",
                columns: table => new
                {
                    StudentPerfomanceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountBookId = table.Column<int>(type: "int", nullable: false),
                    SubjectId = table.Column<int>(type: "int", nullable: false),
                    CurrentPoint = table.Column<float>(type: "real", nullable: false),
                    ExamPoint = table.Column<float>(type: "real", nullable: false),
                    TotalPoint = table.Column<float>(type: "real", nullable: false),
                    SemesterNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentPerfomances", x => x.StudentPerfomanceId);
                    table.ForeignKey(
                        name: "FK_StudentPerfomances_AccountBooks_AccountBookId",
                        column: x => x.AccountBookId,
                        principalTable: "AccountBooks",
                        principalColumn: "AccountBookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentPerfomances_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "SubjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentPerfomances_AccountBookId",
                table: "StudentPerfomances",
                column: "AccountBookId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentPerfomances_SubjectId",
                table: "StudentPerfomances",
                column: "SubjectId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentPerfomances");
        }
    }
}
