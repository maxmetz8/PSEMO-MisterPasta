using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MisterPasta.Server.Migrations
{
    /// <inheritdoc />
    public partial class ChangedCartID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CartId",
                table: "Carts",
                newName: "CartItemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CartItemId",
                table: "Carts",
                newName: "CartId");
        }
    }
}
