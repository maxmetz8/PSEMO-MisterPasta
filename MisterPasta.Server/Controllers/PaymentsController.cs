using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MisterPasta.Server.DTO;
using Stripe;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MisterPasta.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentsController : ControllerBase
    {
        private readonly StripeSettings _stripeSettings;

        public PaymentsController(IOptions<StripeSettings> stripeSettings)
        {
            _stripeSettings = stripeSettings.Value;
        }

        [HttpPost("create-payment-intent")]
        public IActionResult CreatePaymentIntent([FromBody] PaymentRequest request)
        {
            try
            {
                // Define PaymentIntent options
                var options = new PaymentIntentCreateOptions
                {
                    Amount = request.Amount,
                    Currency = request.Currency,
                    PaymentMethodTypes = new List<string> { "card", "ideal" },
                    Description = request.Description,
                };

                // Create the PaymentIntent
                var service = new PaymentIntentService();
                var paymentIntent = service.Create(options);

                return Ok(new { clientSecret = paymentIntent.ClientSecret });
            }
            catch (StripeException ex)
            {
                return BadRequest(new { error = ex.StripeError.Message });
            }
        }

        [HttpPost("webhook")]
        public async Task<IActionResult> HandleWebhook()
        {
            var json = await new StreamReader(HttpContext.Request.Body).ReadToEndAsync();

            try
            {
                var stripeEvent = EventUtility.ConstructEvent(
                    json,
                    Request.Headers["Stripe-Signature"],
                    "whsec_v0oMVTdg63RYUclzaA26yKFrCx28y2JG" // Replace with your webhook signing secret
                );
                
                // Handle specific event types
                if (stripeEvent.Type == "payment_intent.succeeded")
                {
                    var paymentIntent = stripeEvent.Data.Object as PaymentIntent;
                    Console.WriteLine($"Payment succeeded for ID: {paymentIntent.Id}");
                    // Add logic to handle successful payment, like updating the database
                }

                return Ok();
            }
            catch (StripeException e)
            {
                return BadRequest(new { error = e.Message });
            }
        }
    }
}
