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

        public Task<IEnumerable<ProductDTO>> Filter(ProductRequestDTO productRequest)
        {
            IEnumerable<Product> query = _context.Products.AsQueryable();

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

            IEnumerable<ProductDTO> products = query.Select(product => ProductDTO.ProductMapper(product));

            return Task.FromResult(products);
        }
    }
}
