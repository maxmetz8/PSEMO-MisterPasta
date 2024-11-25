using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MisterPasta.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddedFilterOptionsToProductModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsHalal",
                table: "Products",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsVegan",
                table: "Products",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsVegetarian",
                table: "Products",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "IsHalal", "IsVegan", "IsVegetarian" },
                values: new object[] { true, false, false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "IsHalal", "IsVegan", "IsVegetarian" },
                values: new object[] { true, false, false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "IsHalal", "IsVegan", "IsVegetarian" },
                values: new object[] { false, false, false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "IsHalal", "IsVegan", "IsVegetarian" },
                values: new object[] { true, true, true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "IsHalal", "IsVegan", "IsVegetarian" },
                values: new object[] { true, false, true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "IsHalal", "IsVegan", "IsVegetarian" },
                values: new object[] { true, false, true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "IsHalal", "IsVegan", "IsVegetarian" },
                values: new object[] { true, false, false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "IsHalal", "IsVegan", "IsVegetarian" },
                values: new object[] { true, false, false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "IsHalal", "IsVegan", "IsVegetarian" },
                values: new object[] { true, false, true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "IsHalal", "IsVegan", "IsVegetarian" },
                values: new object[] { true, true, true });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsHalal",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsVegan",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsVegetarian",
                table: "Products");
        }
    }
}
