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
            Id = 1,
            Name = "Spaghetti Bolognese",
            Description = "Heerlijke spaghetti met een rijke bolognesesaus."
        },
        new Product
        {
            Id = 2,
            Name = "Penne Arrabiata",
            Description = "Pittige penne met een kruidige tomatensaus."
        }
            );
        }
    }
}
