using Microsoft.EntityFrameworkCore.Migrations;

namespace BlueBook.Web.Data.Migrations
{
    public partial class testv44 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Task_ReleaseNotes_ReleaseNoteid",
                table: "Task");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskDescription_Task_TaskId",
                table: "TaskDescription");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Task",
                table: "Task");

            migrationBuilder.RenameTable(
                name: "Task",
                newName: "Tasks");

            migrationBuilder.RenameIndex(
                name: "IX_Task_ReleaseNoteid",
                table: "Tasks",
                newName: "IX_Tasks_ReleaseNoteid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tasks",
                table: "Tasks",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskDescription_Tasks_TaskId",
                table: "TaskDescription",
                column: "TaskId",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_ReleaseNotes_ReleaseNoteid",
                table: "Tasks",
                column: "ReleaseNoteid",
                principalTable: "ReleaseNotes",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskDescription_Tasks_TaskId",
                table: "TaskDescription");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_ReleaseNotes_ReleaseNoteid",
                table: "Tasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tasks",
                table: "Tasks");

            migrationBuilder.RenameTable(
                name: "Tasks",
                newName: "Task");

            migrationBuilder.RenameIndex(
                name: "IX_Tasks_ReleaseNoteid",
                table: "Task",
                newName: "IX_Task_ReleaseNoteid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Task",
                table: "Task",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Task_ReleaseNotes_ReleaseNoteid",
                table: "Task",
                column: "ReleaseNoteid",
                principalTable: "ReleaseNotes",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskDescription_Task_TaskId",
                table: "TaskDescription",
                column: "TaskId",
                principalTable: "Task",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
