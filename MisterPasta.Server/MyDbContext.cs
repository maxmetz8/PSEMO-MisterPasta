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
        public DbSet<Image> Images { get; set; }

        // Andere DbSets voor meer tabellen
        // public DbSet<OtherEntity> OtherEntities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>()
              .HasMany(p => p.Images)            // Een Product heeft meerdere Images
              .WithOne(i => i.Product)           // Elke Image heeft één Product
              .HasForeignKey(i => i.ProductId);  // De foreign key is ProductId

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
                    Quantity = 1
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
                    Quantity = 1
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
                    Quantity = 1
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
                    Quantity = 1
                },
                new Product
                {
                    ProductId = 5,
                    Name = "Fettuccine Alfredo",
                    Description = "Rijke en romige fettuccine, overgoten met een boterachtige Parmezaansaus die smelt in je mond. Het perfecte comfortfood voor een luxueuze traktatie.",
                    Price = 10.99,
                    LargeDescription = "",
                    IsVegetarian = true,
                    IsVegan = false,
                    IsHalal = true,
                    Quantity = 1
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
                    Quantity = 1
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
                    Quantity = 1
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
                    Quantity = 1
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
                    Quantity = 1
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
                    Quantity = 1
                }


            );
            modelBuilder.Entity<Image>().HasData(
               new Image
               {
                   ImageId = 1,
                   ProductId = 1,
                   ImageUrl = "https://images.unsplash.com/photo-1673442635965-34f1b36d8944?w=800&h=600&fit=crop"
               },
                new Image
                {
                    ImageId = 2,
                    ProductId = 1,
                    ImageUrl = "https://images.unsplash.com/photo-1571175534150-72cd2b5a6039?w=800&h=500&fit=crop"
                },
                 new Image
                 {
                     ImageId = 3,
                     ProductId = 1,
                     ImageUrl = "https://images.unsplash.com/photo-1633337474564-1d9478ca4e2e?w=800&h=500&fit=crop"
                 },
                  new Image
                  {
                      ImageId = 4,
                      ProductId = 1,
                      ImageUrl = "https://images.unsplash.com/photo-1733860532456-3e83dd0b1174?w=800&h=500&fit=crop"
                  },
                   new Image
                   {
                       ImageId = 5,
                       ProductId = 2,
                       ImageUrl = "https://plus.unsplash.com/premium_photo-1726718496691-250e6c3d1a30?w=800&h=500&fit=crop"
                   },
                    new Image
                    {
                        ImageId = 6,
                        ProductId = 2,
                        ImageUrl = "https://plus.unsplash.com/premium_photo-1668618296300-e301f8d2cef9?w=800&h=500&fit=crop"
                    },
                     new Image
                     {
                         ImageId = 7,
                         ProductId = 2,
                         ImageUrl = "https://plus.unsplash.com/premium_photo-1723770033472-0b0452d98225?w=800&h=500&fit=crop"
                     },
                      new Image
                      {
                          ImageId = 8,
                          ProductId = 2,
                          ImageUrl = "https://plus.unsplash.com/premium_photo-1723925079902-9f96f8d32f0d?w=800&h=500&fit=crop"
                      },
                       new Image
                       {
                           ImageId = 9,
                           ProductId = 3,
                           ImageUrl = "https://images.unsplash.com/photo-1612874742237-6526221588e3?w=800&h=500&fit=crop"
                       },
                        new Image
                        {
                            ImageId = 10,
                            ProductId = 3,
                            ImageUrl = "https://images.unsplash.com/photo-1574969903809-3f7a1668ceb0?w=800&h=500&fit=crop"
                        },
                        new Image
                        {
                            ImageId = 11,
                            ProductId = 3,
                            ImageUrl = "https://images.unsplash.com/photo-1574926053821-79c5e338a933?w=800&h=500&fit=crop"
                        },
                new Image
                {
                    ImageId = 12,
                    ProductId = 3,
                    ImageUrl = "https://images.unsplash.com/photo-1628079251261-624e723b7326?w=800&h=500&fit=crop"
                },
                 new Image
                 {
                     ImageId = 13,
                     ProductId = 4,
                     ImageUrl = "https://images.unsplash.com/photo-1630151317550-db97d275ce2d?w=800&h=500&fit=crop"
                 },
                  new Image
                  {
                      ImageId = 14,
                      ProductId = 4,
                      ImageUrl = "https://images.unsplash.com/photo-1685214743111-f0756f24144c?w=800&h=500&fit=crop"
                  },
                   new Image
                   {
                       ImageId = 15,
                       ProductId = 4,
                       ImageUrl = "https://images.unsplash.com/photo-1621996346565-e3dbc646d9a9?w=800&h=500&fit=crop"
                   },
                    new Image
                    {
                        ImageId = 16,
                        ProductId = 4,
                        ImageUrl = "https://images.unsplash.com/photo-1630151318557-1b2b20cc8cff?w=800&h=500&fit=crop"
                    },
                     new Image
                     {
                         ImageId = 17,
                         ProductId = 5,
                         ImageUrl = "https://www.allrecipes.com/thmb/LjXULjH7Yd_BeLLTLOlyaDx-xzE=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/19402-Quick-And-Easy-Alfredo-Sauce-mfs_002-df1c96e0f9514d2191d0d8ce4c8a9745.jpg"
                     },
                      new Image
                      {
                          ImageId = 18,
                          ProductId = 5,
                          ImageUrl = "https://www.southernliving.com/thmb/zKU_UjR400nWqANM5-0JeJMO2hY=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/Fettuccine_Alfredo_005-c5f3841f25084c818ff6f8e827154249.jpg"
                      },
                       new Image
                       {
                           ImageId = 19,
                           ProductId = 5,
                           ImageUrl = "https://lemarchebedandbreakfast.com/assets/components/phpthumbof/cache/fettuccine-alfredo.f6caab0d631b41cace65cc930f8dc277.jpg"
                       },
                        new Image
                        {
                            ImageId = 20,
                            ProductId = 5,
                            ImageUrl = "https://www.allrecipes.com/thmb/kegUHrkZqbRFom6G6miHnuqwQvA=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/Tuna-Alfredo-ca14288bb60b44c98ec50bbd809bd519.jpg"
                        },
                        new Image
                        {
                            ImageId = 21,
                            ProductId = 6,
                            ImageUrl = "https://imag.bonviveur.com/pasta-alla-norma.jpg"
                        },
                new Image
                {
                    ImageId = 22,
                    ProductId = 6,
                    ImageUrl = "https://cdn.dagelijksekost.tv/recipes/WaSRK14Q37OzBcZqVzgv/1728244535923_1080x1920?GoogleAccessId=firebase-adminsdk-2hybg%40dagelijkse-kost-prod.iam.gserviceaccount.com&Expires=16725225600&Signature=MCc44WxeBVgKEA6OvRHiNnq6kFJ6fKYmYrXyzlXkCBaDMy%2FVqd5lFDrv8ZessMQRl7xa1uTH8E67BQTV36Sf9fp24Z69fhUM45dpwV2YnJGIPalER3Z8zirCxwh%2F7qMe%2F7VNDfxkC8SVJ364ONMSAlFx8Z5a8yVO8s4IVqNHihXkQ%2F55W1a0gUtBLaxfj%2BPiCfHI6pRMcm6oF8G48CygzZiVFbU8mEYXniuS9tW7MBgy9UlxUupm2TAV5DusQdIp%2FVQ9PC%2BorXGLSGy9MPP4eHCWlEiI3Z9nOTj1DJ8jDulp5rnzQU3D%2FAcCmcfYtMeIAINm0vQqPAmFScOLlT879g%3D%3D"
                },
                 new Image
                 {
                     ImageId = 23,
                     ProductId = 6,
                     ImageUrl = "https://thehappyfoodie.co.uk/wp-content/uploads/2021/08/semplice_2_110_img-1372kucwzl_s900x0_c1095x640_l0x234.jpg"
                 },
                  new Image
                  {
                      ImageId = 24,
                      ProductId = 6,
                      ImageUrl = "https://images.dissapore.com/wp-content/uploads/2022/06/pasta-alla-norma-ricetta.jpg?width=1280&height=720&quality=75"
                  },
                   new Image
                   {
                       ImageId = 25,
                       ProductId = 7,
                       ImageUrl = "https://img.hellofresh.com/f_auto,fl_lossy,h_640,q_auto,w_1200/hellofresh_s3/image/tortellini-in-brodo-358b77fd.jpg"
                   },
                    new Image
                    {
                        ImageId = 26,
                        ProductId = 7,
                        ImageUrl = "https://www.collegeinn.com/sites/default/files/tortellini-en-brodo.jpg"
                    },
                     new Image
                     {
                         ImageId = 27,
                         ProductId = 7,
                         ImageUrl = "https://www.sidechef.com/recipe/51942260-129e-40e4-a66c-d6714b78eda2.jpg?d=1408x1120"
                     },
                      new Image
                      {
                          ImageId = 28,
                          ProductId = 7,
                          ImageUrl = "https://noseychef.com/wp-content/uploads/2022/11/IMG_9126123.jpg"
                      },
                       new Image
                       {
                           ImageId = 29,
                           ProductId = 8,
                           ImageUrl = "https://smaakmenutie.nl/wp-content/uploads/2018/03/Spaghetti-alla-puttanesca-2-1.jpg"
                       },
                        new Image
                        {
                            ImageId = 30,
                            ProductId = 8,
                            ImageUrl = "https://static01.nyt.com/images/2023/06/29/multimedia/SE-sardine-pasta-puttanesca-czkb/SE-sardine-pasta-puttanesca-czkb-superJumbo.jpg"
                        },
                        new Image
                        {
                            ImageId = 31,
                            ProductId = 8,
                            ImageUrl = "https://alleitaliaanse.nl/pasta/img/puttanesca-cover-16x9.jpg"
                        },
                new Image
                {
                    ImageId = 32,
                    ProductId = 8,
                    ImageUrl = "https://chickslovefood.com/resources/uploads/2013/07/Pasta-Puttanesca-van-Jamie_2-scaled.jpg"
                },
                 new Image
                 {
                     ImageId = 33,
                     ProductId = 9,
                     ImageUrl = "https://www.177milkstreet.com/assets/site/Recipes/_large/Updated-Cacio-e-Pepe.jpg"
                 },
                  new Image
                  {
                      ImageId = 34,
                      ProductId = 9,
                      ImageUrl = "https://assets.epicurious.com/photos/566853fd00de9d2a3815fc8e/master/pass/EP_12012015_dannymeyers_Maialino_pasta.jpg"
                  },
                   new Image
                   {
                       ImageId = 35,
                       ProductId = 9,
                       ImageUrl = "https://www.allesoverolijven.nl/wp-content/uploads/2024/05/Cacio-e-Pepe.jpeg"
                   },
                    new Image
                    {
                        ImageId = 36,
                        ProductId = 9,
                        ImageUrl = "https://sarahpuozzo.com/wp-content/uploads/2018/03/Spaghetti-cacio-e-pepe.jpg"
                    },
                     new Image
                     {
                         ImageId = 37,
                         ProductId = 10,
                         ImageUrl = "https://www.southernliving.com/thmb/qa17Gzd7GwxxgZDz-YZiU6OyiSM=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/27722_SUPTskillet_DIGI_43095-a75573c28e5148139e94721f11767a83.jpg"
                     },
                      new Image
                      {
                          ImageId = 38,
                          ProductId = 10,
                          ImageUrl = "https://www.thereciperebel.com/wp-content/uploads/2023/04/pasta-primavera-TRR-10-of-19.jpg"
                      },
                       new Image
                       {
                           ImageId = 39,
                           ProductId = 10,
                           ImageUrl = "https://images.themodernproper.com/billowy-turkey/production/posts/PastaPrimavera_6.jpg?w=1000&h=667&q=82&auto=format&fit=crop&dm=1719193370&s=2c9ffd3e851745fc84daeea036630a40"
                       },
                        new Image
                        {
                            ImageId = 40,
                            ProductId = 10,
                            ImageUrl = "https://talkingmeals.com/wp-content/uploads/2021/05/Pasta-Primavera-Recipe-POST-Plate-Fork-horiz-e1620927923520.jpg"
                        }
            );
        }
    }
}
