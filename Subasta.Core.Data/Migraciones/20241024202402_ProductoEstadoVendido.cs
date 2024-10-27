using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Auction.Core.Data.Migraciones
{
    /// <inheritdoc />
    public partial class ProductoEstadoVendido : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Vendido",
                table: "Productos",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Vendido",
                table: "Productos");
        }
    }
}
