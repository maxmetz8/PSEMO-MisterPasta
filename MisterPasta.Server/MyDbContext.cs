namespace MisterPasta.Server
{
    using Microsoft.EntityFrameworkCore;
    using MisterPasta.Server.Models;

    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        // Voeg hier DbSet eigenschappen toe voor elke entiteit die je in je database wilt hebben.
        public DbSet<Product> Products { get; set; }

        // Andere DbSets voor meer tabellen
        // public DbSet<OtherEntity> OtherEntities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 1,
                    Name = "Spaghetti Bolognese",
                    Description = "Lange slierten spaghetti in een rijke saus van gehakt, tomaten, en kruiden. Een hartverwarmende klassieker die perfect is voor elke pasta-liefhebber.",
                    Price = 10.99,
                    LargeDescription = "",
                    IsVegetarian = false,
                    IsVegan = false,
                    IsHalal = true,
                },
                new Product
                {
                    ProductId = 2,
                    Name = "Lasagne",
                    Description = "Pittige penne met een kruidige tomatensaus.",
                    Price = 12.99,
                    LargeDescription = "",
                    IsVegetarian = false,
                    IsVegan = false,
                    IsHalal = true,
                },
                new Product
                {
                    ProductId = 3,
                    Name = "Carbonara",
                    Description = "Romige spaghetti zonder room, maar met een saus van eieren, Parmezaanse kaas en knapperige guanciale. De volle, romige smaak smelt op de tong.",
                    Price = 10.99,
                    LargeDescription = "",
                    IsVegetarian = false,
                    IsVegan = false,
                    IsHalal = false,
                },
                new Product
                {
                    ProductId = 4,
                    Name = "Penne all’Arrabbiata",
                    Description = "Pittige tomatensaus met knoflook en rode peper geeft deze penne een vurige kick. Ideaal voor wie van een beetje spice houdt!",
                    Price = 12.99,
                    LargeDescription = "",
                    IsVegetarian = true,
                    IsVegan = true,
                    IsHalal = true,
                },
                new Product
                {
                    ProductId = 5,
                    Name = "Fettuccine Alfredo",
                    Description = "Rijke en romige fettuccine, overgoten met een boterachtige Parmezaansaus die smelt in je mond. Het perfecte comfortfood voor een luxueuze traktatie.",
                    Price = 10.99,
                    LargeDescription = "",
                    IsVegetarian= true,
                    IsVegan= false,
                    IsHalal = true,
                },
                new Product
                {
                    ProductId = 6,
                    Name = "Pasta alla Norma",
                    Description = "Traditionele Siciliaanse pasta met zachte aubergine, tomatensaus en gezouten ricotta. Een verfijnde mix van zoete en hartige smaken.",
                    Price = 12.99,
                    LargeDescription = "",
                    IsVegetarian = true,
                    IsVegan = false,
                    IsHalal = true,
                },
                new Product
                {
                    ProductId = 7,
                    Name = "Tortellini in Brodo",
                    Description = "Kleine ringvormige pasta gevuld met vlees of kaas, geserveerd in een delicate bouillon. Comfort in een kom, ideaal voor koude dagen.",
                    Price = 10.99,
                    LargeDescription = "",
                    IsVegetarian = false,
                    IsVegan = false,
                    IsHalal = true,
                },
                new Product
                {
                    ProductId = 8,
                    Name = "Pasta Putanesca",
                    Description = "Een smaakvolle mix van tomaten, olijven, kappertjes en ansjovis, die deze pasta een zoute, hartige kick geeft. Perfect voor wie houdt van intense Mediterrane smaken.",
                    Price = 12.99,
                    LargeDescription = "",
                    IsVegetarian = false,
                    IsVegan = false,
                    IsHalal = true,
                },
                new Product
                {
                    ProductId = 9,
                    Name = "Cacio e Pepe",
                    Description = "Simpele maar smaakvolle spaghetti met alleen Pecorino Romano en versgemalen zwarte peper. Dit gerecht is de ultieme Italiaanse comfortfood met een zijdezachte, romige saus.",
                    Price = 10.99,
                    LargeDescription = "",
                    IsVegetarian = true,
                    IsVegan = false,
                    IsHalal = true,
                },
                new Product
                {
                    ProductId = 10,
                    Name = "Pasta Primavera",
                    Description = "Lenteachtige pasta met kleurrijke, knapperige groenten zoals paprika, courgette en cherrytomaatjes in een lichte olijfolie-saus. Fris, levendig en vol van smaak!",
                    Price = 12.99,
                    LargeDescription = "",
                    IsVegetarian = true,
                    IsVegan = true,
                    IsHalal = true,
                }

            );
        }
    }
}
