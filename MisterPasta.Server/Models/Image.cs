namespace MisterPasta.Server.Models
{
    public class Image
    {
        public int ImageId { get; set; }
        public int ProductId { get; set; } // Foreign Key naar Product
        public required string ImageUrl { get; set; }
        public Product? Product { get; set; }
    }
}
