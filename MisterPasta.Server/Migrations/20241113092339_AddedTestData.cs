using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MisterPasta.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddedTestData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "Description",
                value: "Lange slierten spaghetti in een rijke saus van gehakt, tomaten, en kruiden. Een hartverwarmende klassieker die perfect is voor elke pasta-liefhebber.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "Name",
                value: "Lasagne");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 3, "Romige spaghetti zonder room, maar met een saus van eieren, Parmezaanse kaas en knapperige guanciale. De volle, romige smaak smelt op de tong.", "Carbonara", 10.99 },
                    { 4, "Pittige tomatensaus met knoflook en rode peper geeft deze penne een vurige kick. Ideaal voor wie van een beetje spice houdt!", "Penne all’Arrabbiata", 12.99 },
                    { 5, "Rijke en romige fettuccine, overgoten met een boterachtige Parmezaansaus die smelt in je mond. Het perfecte comfortfood voor een luxueuze traktatie.", "Fettuccine Alfredo", 10.99 },
                    { 6, "Traditionele Siciliaanse pasta met zachte aubergine, tomatensaus en gezouten ricotta. Een verfijnde mix van zoete en hartige smaken.", "Pasta alla Norma", 12.99 },
                    { 7, "Kleine ringvormige pasta gevuld met vlees of kaas, geserveerd in een delicate bouillon. Comfort in een kom, ideaal voor koude dagen.", "Tortellini in Brodo", 10.99 },
                    { 8, "Een smaakvolle mix van tomaten, olijven, kappertjes en ansjovis, die deze pasta een zoute, hartige kick geeft. Perfect voor wie houdt van intense Mediterrane smaken.", "Pasta Putanesca", 12.99 },
                    { 9, "Simpele maar smaakvolle spaghetti met alleen Pecorino Romano en versgemalen zwarte peper. Dit gerecht is de ultieme Italiaanse comfortfood met een zijdezachte, romige saus.", "Cacio e Pepe", 10.99 },
                    { 10, "Lenteachtige pasta met kleurrijke, knapperige groenten zoals paprika, courgette en cherrytomaatjes in een lichte olijfolie-saus. Fris, levendig en vol van smaak!", "Pasta Primavera", 12.99 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "Description",
                value: "Heerlijke spaghetti met een rijke bolognesesaus.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "Name",
                value: "Penne Arrabiata");
        }
    }
}
