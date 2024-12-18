using Microsoft.EntityFrameworkCore;
using MisterPasta.Server.DTO;
using MisterPasta.Server.Models;

namespace MisterPasta.Server.Services
{
    public class ProductService
    {
        private readonly MyDbContext _context;
        public ProductService(MyDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            IEnumerable<Product> products = await _context.Products.ToListAsync();

            return products;
        }

        public async Task<IEnumerable<Image>> GetImages(int id)
        {
            return await _context.Images
                .Where(i => i.ProductId == id) 
                .ToListAsync(); 
        }



        public async Task<Product> GetProductById(int id)
        {
            var product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return null;
            }

            return product;
        }
    }
}
