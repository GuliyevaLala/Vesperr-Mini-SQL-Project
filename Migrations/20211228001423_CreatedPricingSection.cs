using Microsoft.EntityFrameworkCore.Migrations;

namespace VesperrMiniProject.Migrations
{
    public partial class CreatedPricingSection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PricingCards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PricingCards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PricingOffers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    First = table.Column<string>(nullable: true),
                    Second = table.Column<string>(nullable: true),
                    Third = table.Column<string>(nullable: true),
                    Fourth = table.Column<string>(nullable: true),
                    Fifth = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PricingOffers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PricingCardOffers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PricingCardId = table.Column<int>(nullable: false),
                    PricingOfferId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PricingCardOffers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PricingCardOffers_PricingCards_PricingCardId",
                        column: x => x.PricingCardId,
                        principalTable: "PricingCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PricingCardOffers_PricingOffers_PricingOfferId",
                        column: x => x.PricingOfferId,
                        principalTable: "PricingOffers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PricingCardOffers_PricingCardId",
                table: "PricingCardOffers",
                column: "PricingCardId");

            migrationBuilder.CreateIndex(
                name: "IX_PricingCardOffers_PricingOfferId",
                table: "PricingCardOffers",
                column: "PricingOfferId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PricingCardOffers");

            migrationBuilder.DropTable(
                name: "PricingCards");

            migrationBuilder.DropTable(
                name: "PricingOffers");
        }
    }
}
