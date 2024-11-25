namespace MisterPasta.Server.DTO
{
    public class ProductRequestDTO
    {
        public bool? IsVegetarian { get; set; }
        public bool? IsVegan { get; set; }
        public bool? IsHalal { get; set; }
        public double? MaxPrice { get; set; }
    }
}
