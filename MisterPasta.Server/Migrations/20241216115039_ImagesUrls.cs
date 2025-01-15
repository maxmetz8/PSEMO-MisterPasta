using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MisterPasta.Server.Migrations
{
    /// <inheritdoc />
    public partial class ImagesUrls : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    ImagesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.ImagesId);
                    table.ForeignKey(
                        name: "FK_Images_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ImagesId", "ImageUrl", "ProductId" },
                values: new object[,]
                {
                    { 1, "https://images.unsplash.com/photo-1673442635965-34f1b36d8944?w=800&h=600&fit=crop", 1 },
                    { 2, "https://images.unsplash.com/photo-1571175534150-72cd2b5a6039?w=800&h=500&fit=crop", 1 },
                    { 3, "https://images.unsplash.com/photo-1633337474564-1d9478ca4e2e?w=800&h=500&fit=crop", 1 },
                    { 4, "https://images.unsplash.com/photo-1733860532456-3e83dd0b1174?w=800&h=500&fit=crop", 1 },
                    { 5, "https://plus.unsplash.com/premium_photo-1726718496691-250e6c3d1a30?w=800&h=500&fit=crop", 2 },
                    { 6, "https://plus.unsplash.com/premium_photo-1668618296300-e301f8d2cef9?w=800&h=500&fit=crop", 2 },
                    { 7, "https://plus.unsplash.com/premium_photo-1723770033472-0b0452d98225?w=800&h=500&fit=crop", 2 },
                    { 8, "https://plus.unsplash.com/premium_photo-1723925079902-9f96f8d32f0d?w=800&h=500&fit=crop", 2 },
                    { 9, "https://images.unsplash.com/photo-1612874742237-6526221588e3?w=800&h=500&fit=crop", 3 },
                    { 10, "https://images.unsplash.com/photo-1574969903809-3f7a1668ceb0?w=800&h=500&fit=crop", 3 },
                    { 11, "https://images.unsplash.com/photo-1574926053821-79c5e338a933?w=800&h=500&fit=crop", 3 },
                    { 12, "https://images.unsplash.com/photo-1628079251261-624e723b7326?w=800&h=500&fit=crop", 3 },
                    { 13, "https://images.unsplash.com/photo-1630151317550-db97d275ce2d?w=800&h=500&fit=crop", 4 },
                    { 14, "https://images.unsplash.com/photo-1685214743111-f0756f24144c?w=800&h=500&fit=crop", 4 },
                    { 15, "https://images.unsplash.com/photo-1621996346565-e3dbc646d9a9?w=800&h=500&fit=crop", 4 },
                    { 16, "https://images.unsplash.com/photo-1630151318557-1b2b20cc8cff?w=800&h=500&fit=crop", 4 },
                    { 17, "https://www.allrecipes.com/thmb/LjXULjH7Yd_BeLLTLOlyaDx-xzE=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/19402-Quick-And-Easy-Alfredo-Sauce-mfs_002-df1c96e0f9514d2191d0d8ce4c8a9745.jpg", 5 },
                    { 18, "https://www.southernliving.com/thmb/zKU_UjR400nWqANM5-0JeJMO2hY=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/Fettuccine_Alfredo_005-c5f3841f25084c818ff6f8e827154249.jpg", 5 },
                    { 19, "https://lemarchebedandbreakfast.com/assets/components/phpthumbof/cache/fettuccine-alfredo.f6caab0d631b41cace65cc930f8dc277.jpg", 5 },
                    { 20, "https://www.allrecipes.com/thmb/kegUHrkZqbRFom6G6miHnuqwQvA=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/Tuna-Alfredo-ca14288bb60b44c98ec50bbd809bd519.jpg", 5 },
                    { 21, "https://imag.bonviveur.com/pasta-alla-norma.jpg", 6 },
                    { 22, "https://cdn.dagelijksekost.tv/recipes/WaSRK14Q37OzBcZqVzgv/1728244535923_1080x1920?GoogleAccessId=firebase-adminsdk-2hybg%40dagelijkse-kost-prod.iam.gserviceaccount.com&Expires=16725225600&Signature=MCc44WxeBVgKEA6OvRHiNnq6kFJ6fKYmYrXyzlXkCBaDMy%2FVqd5lFDrv8ZessMQRl7xa1uTH8E67BQTV36Sf9fp24Z69fhUM45dpwV2YnJGIPalER3Z8zirCxwh%2F7qMe%2F7VNDfxkC8SVJ364ONMSAlFx8Z5a8yVO8s4IVqNHihXkQ%2F55W1a0gUtBLaxfj%2BPiCfHI6pRMcm6oF8G48CygzZiVFbU8mEYXniuS9tW7MBgy9UlxUupm2TAV5DusQdIp%2FVQ9PC%2BorXGLSGy9MPP4eHCWlEiI3Z9nOTj1DJ8jDulp5rnzQU3D%2FAcCmcfYtMeIAINm0vQqPAmFScOLlT879g%3D%3D", 6 },
                    { 23, "https://thehappyfoodie.co.uk/wp-content/uploads/2021/08/semplice_2_110_img-1372kucwzl_s900x0_c1095x640_l0x234.jpg", 6 },
                    { 24, "https://images.dissapore.com/wp-content/uploads/2022/06/pasta-alla-norma-ricetta.jpg?width=1280&height=720&quality=75", 6 },
                    { 25, "https://img.hellofresh.com/f_auto,fl_lossy,h_640,q_auto,w_1200/hellofresh_s3/image/tortellini-in-brodo-358b77fd.jpg", 7 },
                    { 26, "https://www.collegeinn.com/sites/default/files/tortellini-en-brodo.jpg", 7 },
                    { 27, "https://www.sidechef.com/recipe/51942260-129e-40e4-a66c-d6714b78eda2.jpg?d=1408x1120", 7 },
                    { 28, "https://noseychef.com/wp-content/uploads/2022/11/IMG_9126123.jpg", 7 },
                    { 29, "https://smaakmenutie.nl/wp-content/uploads/2018/03/Spaghetti-alla-puttanesca-2-1.jpg", 8 },
                    { 30, "https://static01.nyt.com/images/2023/06/29/multimedia/SE-sardine-pasta-puttanesca-czkb/SE-sardine-pasta-puttanesca-czkb-superJumbo.jpg", 8 },
                    { 31, "https://alleitaliaanse.nl/pasta/img/puttanesca-cover-16x9.jpg", 8 },
                    { 32, "https://chickslovefood.com/resources/uploads/2013/07/Pasta-Puttanesca-van-Jamie_2-scaled.jpg", 8 },
                    { 33, "https://www.177milkstreet.com/assets/site/Recipes/_large/Updated-Cacio-e-Pepe.jpg", 9 },
                    { 34, "https://assets.epicurious.com/photos/566853fd00de9d2a3815fc8e/master/pass/EP_12012015_dannymeyers_Maialino_pasta.jpg", 9 },
                    { 35, "https://www.allesoverolijven.nl/wp-content/uploads/2024/05/Cacio-e-Pepe.jpeg", 9 },
                    { 36, "https://sarahpuozzo.com/wp-content/uploads/2018/03/Spaghetti-cacio-e-pepe.jpg", 9 },
                    { 37, "https://www.southernliving.com/thmb/qa17Gzd7GwxxgZDz-YZiU6OyiSM=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/27722_SUPTskillet_DIGI_43095-a75573c28e5148139e94721f11767a83.jpg", 10 },
                    { 38, "https://www.thereciperebel.com/wp-content/uploads/2023/04/pasta-primavera-TRR-10-of-19.jpg", 10 },
                    { 39, "https://images.themodernproper.com/billowy-turkey/production/posts/PastaPrimavera_6.jpg?w=1000&h=667&q=82&auto=format&fit=crop&dm=1719193370&s=2c9ffd3e851745fc84daeea036630a40", 10 },
                    { 40, "https://talkingmeals.com/wp-content/uploads/2021/05/Pasta-Primavera-Recipe-POST-Plate-Fork-horiz-e1620927923520.jpg", 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Images_ProductId",
                table: "Images",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");
        }
    }
}
