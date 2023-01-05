using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class secondCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "timeZone",
                table: "Holidays",
                newName: "visibility");

            migrationBuilder.RenameColumn(
                name: "nextSyncToken",
                table: "Holidays",
                newName: "transparency");

            migrationBuilder.RenameColumn(
                name: "defaultReminders",
                table: "Holidays",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "accessRole",
                table: "Holidays",
                newName: "start");

            migrationBuilder.AddColumn<string>(
                name: "created",
                table: "Holidays",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "creatoremail",
                table: "Holidays",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "Holidays",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "end",
                table: "Holidays",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "eventType",
                table: "Holidays",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "htmlLink",
                table: "Holidays",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "iCalUID",
                table: "Holidays",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "id",
                table: "Holidays",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "organizeremail",
                table: "Holidays",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "sequence",
                table: "Holidays",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "creator",
                columns: table => new
                {
                    email = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    displayName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    self = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_creator", x => x.email);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "organizer",
                columns: table => new
                {
                    email = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    displayName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    self = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_organizer", x => x.email);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Holidays_creatoremail",
                table: "Holidays",
                column: "creatoremail");

            migrationBuilder.CreateIndex(
                name: "IX_Holidays_organizeremail",
                table: "Holidays",
                column: "organizeremail");

            migrationBuilder.AddForeignKey(
                name: "FK_Holidays_creator_creatoremail",
                table: "Holidays",
                column: "creatoremail",
                principalTable: "creator",
                principalColumn: "email",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Holidays_organizer_organizeremail",
                table: "Holidays",
                column: "organizeremail",
                principalTable: "organizer",
                principalColumn: "email",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Holidays_creator_creatoremail",
                table: "Holidays");

            migrationBuilder.DropForeignKey(
                name: "FK_Holidays_organizer_organizeremail",
                table: "Holidays");

            migrationBuilder.DropTable(
                name: "creator");

            migrationBuilder.DropTable(
                name: "organizer");

            migrationBuilder.DropIndex(
                name: "IX_Holidays_creatoremail",
                table: "Holidays");

            migrationBuilder.DropIndex(
                name: "IX_Holidays_organizeremail",
                table: "Holidays");

            migrationBuilder.DropColumn(
                name: "created",
                table: "Holidays");

            migrationBuilder.DropColumn(
                name: "creatoremail",
                table: "Holidays");

            migrationBuilder.DropColumn(
                name: "description",
                table: "Holidays");

            migrationBuilder.DropColumn(
                name: "end",
                table: "Holidays");

            migrationBuilder.DropColumn(
                name: "eventType",
                table: "Holidays");

            migrationBuilder.DropColumn(
                name: "htmlLink",
                table: "Holidays");

            migrationBuilder.DropColumn(
                name: "iCalUID",
                table: "Holidays");

            migrationBuilder.DropColumn(
                name: "id",
                table: "Holidays");

            migrationBuilder.DropColumn(
                name: "organizeremail",
                table: "Holidays");

            migrationBuilder.DropColumn(
                name: "sequence",
                table: "Holidays");

            migrationBuilder.RenameColumn(
                name: "visibility",
                table: "Holidays",
                newName: "timeZone");

            migrationBuilder.RenameColumn(
                name: "transparency",
                table: "Holidays",
                newName: "nextSyncToken");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "Holidays",
                newName: "defaultReminders");

            migrationBuilder.RenameColumn(
                name: "start",
                table: "Holidays",
                newName: "accessRole");
        }
    }
}
