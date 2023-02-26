using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversityStudyPlatform.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addSubjectModelToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccountBook_Students_AccountBookId",
                table: "AccountBook");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AccountBook",
                table: "AccountBook");

            migrationBuilder.RenameTable(
                name: "AccountBook",
                newName: "AccountBooks");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AccountBooks",
                table: "AccountBooks",
                column: "AccountBookId");

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    SubjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.SubjectId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_AccountBooks_Students_AccountBookId",
                table: "AccountBooks",
                column: "AccountBookId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccountBooks_Students_AccountBookId",
                table: "AccountBooks");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AccountBooks",
                table: "AccountBooks");

            migrationBuilder.RenameTable(
                name: "AccountBooks",
                newName: "AccountBook");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AccountBook",
                table: "AccountBook",
                column: "AccountBookId");

            migrationBuilder.AddForeignKey(
                name: "FK_AccountBook_Students_AccountBookId",
                table: "AccountBook",
                column: "AccountBookId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
