using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonaCalendar.Migrations
{
    /// <inheritdoc />
    public partial class index : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Users_UsersUserId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Notes_Users_UsersUserId",
                table: "Notes");

            migrationBuilder.DropForeignKey(
                name: "FK_Reminders_Users_UsersUserId",
                table: "Reminders");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Users_UsersUserId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_UsersUserId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Reminders_UsersUserId",
                table: "Reminders");

            migrationBuilder.DropIndex(
                name: "IX_Notes_UsersUserId",
                table: "Notes");

            migrationBuilder.DropIndex(
                name: "IX_Events_UsersUserId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "UsersUserId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "UsersUserId",
                table: "Reminders");

            migrationBuilder.DropColumn(
                name: "UsersUserId",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "UsersUserId",
                table: "Events");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_UserId",
                table: "Tasks",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reminders_UserId",
                table: "Reminders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Notes_UserId",
                table: "Notes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_UserId",
                table: "Events",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Users_UserId",
                table: "Events",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_Users_UserId",
                table: "Notes",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reminders_Users_UserId",
                table: "Reminders",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Users_UserId",
                table: "Tasks",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Users_UserId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Notes_Users_UserId",
                table: "Notes");

            migrationBuilder.DropForeignKey(
                name: "FK_Reminders_Users_UserId",
                table: "Reminders");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Users_UserId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_UserId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Reminders_UserId",
                table: "Reminders");

            migrationBuilder.DropIndex(
                name: "IX_Notes_UserId",
                table: "Notes");

            migrationBuilder.DropIndex(
                name: "IX_Events_UserId",
                table: "Events");

            migrationBuilder.AddColumn<int>(
                name: "UsersUserId",
                table: "Tasks",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsersUserId",
                table: "Reminders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsersUserId",
                table: "Notes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsersUserId",
                table: "Events",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_UsersUserId",
                table: "Tasks",
                column: "UsersUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reminders_UsersUserId",
                table: "Reminders",
                column: "UsersUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Notes_UsersUserId",
                table: "Notes",
                column: "UsersUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_UsersUserId",
                table: "Events",
                column: "UsersUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Users_UsersUserId",
                table: "Events",
                column: "UsersUserId",
                principalTable: "Users",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_Users_UsersUserId",
                table: "Notes",
                column: "UsersUserId",
                principalTable: "Users",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reminders_Users_UsersUserId",
                table: "Reminders",
                column: "UsersUserId",
                principalTable: "Users",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Users_UsersUserId",
                table: "Tasks",
                column: "UsersUserId",
                principalTable: "Users",
                principalColumn: "UserId");
        }
    }
}
