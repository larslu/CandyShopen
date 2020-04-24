using Microsoft.EntityFrameworkCore.Migrations;

namespace CandyShopen.Migrations
{
    public partial class AddingShoppingCartItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShoppingCartItem",
                columns: table => new
                {
                    ShoppingCartItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShoppingCartId = table.Column<string>(nullable: true),
                    CandyId = table.Column<int>(nullable: true),
                    Amount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItem", x => x.ShoppingCartItemId);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItem_Candies_CandyId",
                        column: x => x.CandyId,
                        principalTable: "Candies",
                        principalColumn: "CandyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\thumbnails\\chocolateCandy-small.jpg", "\\Images\\chocolateCandy.jpg" });

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItem_CandyId",
                table: "ShoppingCartItem",
                column: "CandyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoppingCartItem");

            migrationBuilder.UpdateData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "~\\Images	humbnails\\chocolateCandy-small.jpg", "~\\Images\\chocolateCandy.jpg" });
        }
    }
}
