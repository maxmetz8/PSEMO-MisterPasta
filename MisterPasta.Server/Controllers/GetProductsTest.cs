using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MisterPasta.Server;



[ApiController]
[Route("[controller]")]
public class DataTestController : ControllerBase
{
    private readonly MyDbContext _context;

    public DataTestController(MyDbContext context)
    {
        _context = context;
    }

    [HttpGet("get-data")]
    public async Task<IActionResult> GetData()
    {
        var data = await _context.Products.ToListAsync();
        return Ok(data);
    }
}
