using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Auction.Core.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedRelationFactura : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdProducto",
                table: "Facturas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_IdProducto",
                table: "Facturas",
                column: "IdProducto");

            migrationBuilder.AddForeignKey(
                name: "FK_Facturas_Productos_IdProducto",
                table: "Facturas",
                column: "IdProducto",
                principalTable: "Productos",
                principalColumn: "IdProducto");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Facturas_Productos_IdProducto",
                table: "Facturas");

            migrationBuilder.DropIndex(
                name: "IX_Facturas_IdProducto",
                table: "Facturas");

            migrationBuilder.DropColumn(
                name: "IdProducto",
                table: "Facturas");
        }
    }
}
