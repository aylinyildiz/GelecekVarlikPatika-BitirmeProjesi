using Microsoft.EntityFrameworkCore.Migrations;

namespace SiteManagement.Dal.Migrations
{
    public partial class addressrelationadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "Apartments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Apartments_AddressId",
                table: "Apartments",
                column: "AddressId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Apartments_Address_AddressId",
                table: "Apartments",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Apartments_Address_AddressId",
                table: "Apartments");

            migrationBuilder.DropIndex(
                name: "IX_Apartments_AddressId",
                table: "Apartments");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Apartments");
        }
    }
}
