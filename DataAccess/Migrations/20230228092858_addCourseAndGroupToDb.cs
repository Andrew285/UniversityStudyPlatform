using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversityStudyPlatform.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addCourseAndGroupToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccountBooks_Students_AccountBookId",
                table: "AccountBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentPerfomances_AccountBooks_AccountBookId",
                table: "StudentPerfomances");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AccountBooks",
                table: "AccountBooks");

            migrationBuilder.RenameColumn(
                name: "AccountBookId",
                table: "AccountBooks",
                newName: "StudentId");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "AccountBooks",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "AccountBooks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AccountBooks",
                table: "AccountBooks",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubjectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Course_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "SubjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Group",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CourseGroup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseGroup_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseGroup_Group_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Group",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccountBooks_GroupId",
                table: "AccountBooks",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountBooks_StudentId",
                table: "AccountBooks",
                column: "StudentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Course_SubjectId",
                table: "Course",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseGroup_CourseId",
                table: "CourseGroup",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseGroup_GroupId",
                table: "CourseGroup",
                column: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_AccountBooks_Group_GroupId",
                table: "AccountBooks",
                column: "GroupId",
                principalTable: "Group",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AccountBooks_Students_StudentId",
                table: "AccountBooks",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentPerfomances_AccountBooks_AccountBookId",
                table: "StudentPerfomances",
                column: "AccountBookId",
                principalTable: "AccountBooks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccountBooks_Group_GroupId",
                table: "AccountBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_AccountBooks_Students_StudentId",
                table: "AccountBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentPerfomances_AccountBooks_AccountBookId",
                table: "StudentPerfomances");

            migrationBuilder.DropTable(
                name: "CourseGroup");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "Group");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AccountBooks",
                table: "AccountBooks");

            migrationBuilder.DropIndex(
                name: "IX_AccountBooks_GroupId",
                table: "AccountBooks");

            migrationBuilder.DropIndex(
                name: "IX_AccountBooks_StudentId",
                table: "AccountBooks");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "AccountBooks");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "AccountBooks");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "AccountBooks",
                newName: "AccountBookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AccountBooks",
                table: "AccountBooks",
                column: "AccountBookId");

            migrationBuilder.AddForeignKey(
                name: "FK_AccountBooks_Students_AccountBookId",
                table: "AccountBooks",
                column: "AccountBookId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentPerfomances_AccountBooks_AccountBookId",
                table: "StudentPerfomances",
                column: "AccountBookId",
                principalTable: "AccountBooks",
                principalColumn: "AccountBookId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
