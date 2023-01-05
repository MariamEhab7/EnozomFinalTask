using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class editedCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CountryHoliday_Holidays_itemsetag",
                table: "CountryHoliday");

            migrationBuilder.DropTable(
                name: "Populations");

            migrationBuilder.RenameColumn(
                name: "itemsetag",
                table: "CountryHoliday",
                newName: "holidaysetag");

            migrationBuilder.RenameIndex(
                name: "IX_CountryHoliday_itemsetag",
                table: "CountryHoliday",
                newName: "IX_CountryHoliday_holidaysetag");

            migrationBuilder.AddForeignKey(
                name: "FK_CountryHoliday_Holidays_holidaysetag",
                table: "CountryHoliday",
                column: "holidaysetag",
                principalTable: "Holidays",
                principalColumn: "etag",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CountryHoliday_Holidays_holidaysetag",
                table: "CountryHoliday");

            migrationBuilder.RenameColumn(
                name: "holidaysetag",
                table: "CountryHoliday",
                newName: "itemsetag");

            migrationBuilder.RenameIndex(
                name: "IX_CountryHoliday_holidaysetag",
                table: "CountryHoliday",
                newName: "IX_CountryHoliday_itemsetag");

            migrationBuilder.CreateTable(
                name: "Populations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CountryCode = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<ulong>(type: "bigint unsigned", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Populations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Populations_Countries_CountryCode",
                        column: x => x.CountryCode,
                        principalTable: "Countries",
                        principalColumn: "Code");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Populations_CountryCode",
                table: "Populations",
                column: "CountryCode");

            migrationBuilder.AddForeignKey(
                name: "FK_CountryHoliday_Holidays_itemsetag",
                table: "CountryHoliday",
                column: "itemsetag",
                principalTable: "Holidays",
                principalColumn: "etag",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
