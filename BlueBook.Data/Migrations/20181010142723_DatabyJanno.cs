using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlueBook.Web.Data.Migrations
{
    public partial class DatabyJanno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReleaseNotes",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReleaseNotes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Task",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    taskNumber = table.Column<string>(nullable: true),
                    taskName = table.Column<string>(nullable: true),
                    TargetTaskType = table.Column<int>(nullable: false),
                    Application = table.Column<int>(nullable: false),
                    ReleaseNoteid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Task", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Task_ReleaseNotes_ReleaseNoteid",
                        column: x => x.ReleaseNoteid,
                        principalTable: "ReleaseNotes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TaskDescription",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    TaskId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskDescription", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskDescription_Task_TaskId",
                        column: x => x.TaskId,
                        principalTable: "Task",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Task_ReleaseNoteid",
                table: "Task",
                column: "ReleaseNoteid");

            migrationBuilder.CreateIndex(
                name: "IX_TaskDescription_TaskId",
                table: "TaskDescription",
                column: "TaskId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TaskDescription");

            migrationBuilder.DropTable(
                name: "Task");

            migrationBuilder.DropTable(
                name: "ReleaseNotes");
        }
    }
}
