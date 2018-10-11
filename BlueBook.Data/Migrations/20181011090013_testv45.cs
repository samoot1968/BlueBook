using Microsoft.EntityFrameworkCore.Migrations;

namespace BlueBook.Web.Data.Migrations
{
    public partial class testv45 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskDescription_Tasks_TaskId",
                table: "TaskDescription");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TaskDescription",
                table: "TaskDescription");

            migrationBuilder.RenameTable(
                name: "TaskDescription",
                newName: "taskDescriptions");

            migrationBuilder.RenameIndex(
                name: "IX_TaskDescription_TaskId",
                table: "taskDescriptions",
                newName: "IX_taskDescriptions_TaskId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_taskDescriptions",
                table: "taskDescriptions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_taskDescriptions_Tasks_TaskId",
                table: "taskDescriptions",
                column: "TaskId",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_taskDescriptions_Tasks_TaskId",
                table: "taskDescriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_taskDescriptions",
                table: "taskDescriptions");

            migrationBuilder.RenameTable(
                name: "taskDescriptions",
                newName: "TaskDescription");

            migrationBuilder.RenameIndex(
                name: "IX_taskDescriptions_TaskId",
                table: "TaskDescription",
                newName: "IX_TaskDescription_TaskId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TaskDescription",
                table: "TaskDescription",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskDescription_Tasks_TaskId",
                table: "TaskDescription",
                column: "TaskId",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
