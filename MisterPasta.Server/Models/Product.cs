using Microsoft.Build.Evaluation;

namespace MisterPasta.Server.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required double Price { get; set; }
        public required string LargeDescription { get; set; }
        public required bool IsVegetarian { get; set; }
        public required bool IsVegan { get; set; }
        public required bool IsHalal { get; set; }
    }

}