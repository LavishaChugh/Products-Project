using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Products.Migrations
{
    /// <inheritdoc />
    public partial class Stocks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "stocks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ItemsId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PurchaseId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_stocks_Items_ItemsId",
                        column: x => x.ItemsId,
                        principalTable: "Items",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_stocks_Puchases_PurchaseId",
                        column: x => x.PurchaseId,
                        principalTable: "Puchases",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_stocks_ItemsId",
                table: "stocks",
                column: "ItemsId");

            migrationBuilder.CreateIndex(
                name: "IX_stocks_PurchaseId",
                table: "stocks",
                column: "PurchaseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "stocks");
        }
    }
}
