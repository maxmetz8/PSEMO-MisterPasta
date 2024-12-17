namespace MisterPasta.Server.DTO
{
    public class PaymentRequest
    {
        public required long Amount { get; set; }
        public required string Currency { get; set; }
        public required string Description { get; set; }
    }
}
