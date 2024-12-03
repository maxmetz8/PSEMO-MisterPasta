using Microsoft.EntityFrameworkCore;
using MisterPasta.Server.DTO;
using MisterPasta.Server.Models;

namespace MisterPasta.Server.Services
{
    public class FilterService
    {
        private readonly MyDbContext _context;

        public FilterService(MyDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> Filter(ProductRequestDTO productRequest)
        {
            // Validate the input
            if (productRequest == null)
            {
                throw new ArgumentNullException(nameof(productRequest), "Product request cannot be null.");
            }

            if (productRequest.MaxPrice.HasValue && productRequest.MaxPrice.Value < 0)
            {
                throw new ArgumentException("MaxPrice cannot be negative.", nameof(productRequest.MaxPrice));
            }

            // Start with the base query
            var query = _context.Products.AsQueryable();

            // Apply filters
            if (productRequest.IsVegetarian.HasValue)
            {
                query = query.Where(p => p.IsVegetarian == productRequest.IsVegetarian.Value);
            }

            if (productRequest.IsVegan.HasValue)
            {
                query = query.Where(p => p.IsVegan == productRequest.IsVegan.Value);
            }

            if (productRequest.IsHalal.HasValue)
            {
                query = query.Where(p => p.IsHalal == productRequest.IsHalal.Value);
            }

            if (productRequest.MaxPrice.HasValue)
            {
                query = query.Where(p => p.Price <= productRequest.MaxPrice.Value);
            }

            // Execute query and return results
            return await query.ToListAsync();
        }
    }
}
