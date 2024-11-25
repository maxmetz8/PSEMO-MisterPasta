using Microsoft.AspNetCore.Mvc;
using MisterPasta.Server;

[Route("[controller]")]
[ApiController]
public class DatabaseTestController : ControllerBase
{
	private readonly MyDbContext _context;

	public DatabaseTestController(MyDbContext context)
	{
		_context = context;
	}

	[HttpGet("test-connection")]
	public IActionResult TestConnection()
	{
		try
		{
			// Voer een eenvoudige query uit om de verbinding te testen
			var canConnect = _context.Database.CanConnect();
			if (canConnect)
			{
				return Ok("Succesvol verbonden met de database!");
			}
			else
			{
				return StatusCode(500, "Kan geen verbinding maken met de database.");
			}
		}
		catch (Exception ex)
		{
			return StatusCode(500, $"Er is een fout opgetreden: {ex.Message}");
		}
	}
}
