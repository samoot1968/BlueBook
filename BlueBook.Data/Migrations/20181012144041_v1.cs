using Microsoft.EntityFrameworkCore.Migrations;

namespace BlueBook.Web.Data.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_taskDescriptions_Tasks_TaskId",
                table: "taskDescriptions");

            migrationBuilder.AlterColumn<int>(
                name: "TaskId",
                table: "taskDescriptions",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_taskDescriptions_Tasks_TaskId",
                table: "taskDescriptions",
                column: "TaskId",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_taskDescriptions_Tasks_TaskId",
                table: "taskDescriptions");

            migrationBuilder.AlterColumn<int>(
                name: "TaskId",
                table: "taskDescriptions",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_taskDescriptions_Tasks_TaskId",
                table: "taskDescriptions",
                column: "TaskId",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
