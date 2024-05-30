using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Products.Migrations
{
    /// <inheritdoc />
    public partial class purchases : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateTable(
                name: "Puchases",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Qunatity = table.Column<int>(type: "int", nullable: false),
                    TotalCost = table.Column<float>(type: "real", nullable: false),
                    ItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Puchases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Puchases_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Puchases_ItemId",
                table: "Puchases",
                column: "ItemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Puchases");

            migrationBuilder.CreateTable(
                name: "Purchase",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchase", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Purchase_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_ItemId",
                table: "Purchase",
                column: "ItemId");
        }
    }
}
