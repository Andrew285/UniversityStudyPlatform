using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversityStudyPlatform.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addAccountBookModelToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountBook",
                columns: table => new
                {
                    AccountBookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountBook", x => x.AccountBookId);
                    table.ForeignKey(
                        name: "FK_AccountBook_Students_AccountBookId",
                        column: x => x.AccountBookId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountBook");
        }
    }
}
