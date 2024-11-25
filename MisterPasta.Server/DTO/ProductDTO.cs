using MisterPasta.Server.Models;

namespace MisterPasta.Server.DTO
{
    public class ProductDTO
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required double Price { get; set; }
        public required string LargeDescription { get; set; }

        public static ProductDTO ProductMapper(Product product)
        {
            return new ProductDTO 
            { 
                Name = product.Name, 
                Description = product.Description, 
                Price = product.Price,
                LargeDescription = product.LargeDescription,
            };    
        }
    }
}

