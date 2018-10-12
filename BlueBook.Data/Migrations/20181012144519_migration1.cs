using Microsoft.EntityFrameworkCore.Migrations;

namespace BlueBook.Web.Data.Migrations
{
    public partial class migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_ReleaseNotes_ReleaseNoteid",
                table: "Tasks");

            migrationBuilder.AlterColumn<int>(
                name: "ReleaseNoteid",
                table: "Tasks",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_ReleaseNotes_ReleaseNoteid",
                table: "Tasks",
                column: "ReleaseNoteid",
                principalTable: "ReleaseNotes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
