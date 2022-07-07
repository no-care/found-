using Microsoft.EntityFrameworkCore.Migrations;

namespace found.Migrations
{
    public partial class dialog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_dialogs_users_Usersid",
                table: "dialogs");

            migrationBuilder.DropIndex(
                name: "IX_dialogs_Usersid",
                table: "dialogs");

            migrationBuilder.DropColumn(
                name: "Usersid",
                table: "dialogs");

            migrationBuilder.DropColumn(
                name: "user1_id",
                table: "dialogs");

            migrationBuilder.DropColumn(
                name: "user2_id",
                table: "dialogs");

            migrationBuilder.CreateTable(
                name: "DialogsUsers",
                columns: table => new
                {
                    Dialogsid = table.Column<int>(type: "int", nullable: false),
                    Usersid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DialogsUsers", x => new { x.Dialogsid, x.Usersid });
                    table.ForeignKey(
                        name: "FK_DialogsUsers_dialogs_Dialogsid",
                        column: x => x.Dialogsid,
                        principalTable: "dialogs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DialogsUsers_users_Usersid",
                        column: x => x.Usersid,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DialogsUsers_Usersid",
                table: "DialogsUsers",
                column: "Usersid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DialogsUsers");

            migrationBuilder.AddColumn<int>(
                name: "Usersid",
                table: "dialogs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "user1_id",
                table: "dialogs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "user2_id",
                table: "dialogs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_dialogs_Usersid",
                table: "dialogs",
                column: "Usersid");

            migrationBuilder.AddForeignKey(
                name: "FK_dialogs_users_Usersid",
                table: "dialogs",
                column: "Usersid",
                principalTable: "users",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
