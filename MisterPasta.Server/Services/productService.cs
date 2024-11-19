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

        public async Task<IEnumerable<ProductDTO>> GetProducts()
        {
            IEnumerable<Product> products = await _context.Products.ToListAsync();

            return products.Select(product => ProductDTO.ProductMapper(product));
        }

        public async Task<ProductDTO> GetProductById(int id)
        {
            var product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return null;
            }

            return ProductDTO.ProductMapper(product);
        }
    }
}
