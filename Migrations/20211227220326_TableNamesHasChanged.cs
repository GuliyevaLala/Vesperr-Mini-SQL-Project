using Microsoft.EntityFrameworkCore.Migrations;

namespace VesperrMiniProject.Migrations
{
    public partial class TableNamesHasChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SiteName",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "Text",
                table: "Contacts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SiteName",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Text",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
