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
    }
}
