using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Auction.Core.Data.Migraciones
{
    /// <inheritdoc />
    public partial class saltedpasswordtest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Salt",
                table: "Usuario",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Salt",
                table: "Usuario");
        }
    }
}
