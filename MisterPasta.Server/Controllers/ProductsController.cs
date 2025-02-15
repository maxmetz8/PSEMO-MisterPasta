﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MisterPasta.Server.DTO;
using MisterPasta.Server.Models;
using MisterPasta.Server.Services;

namespace MisterPasta.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ProductService _productService;
        private readonly FilterService  _filterService;

        public ProductsController(ProductService productService, FilterService filterService)
        {
            _productService = productService;
            _filterService = filterService;
        }

        // GET: api/Products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            var products = await _productService.GetProducts();
            return Ok(products);
        }

        // GET: api/Products/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            return await _productService.GetProductById(id);
        }


        [HttpPost("Filter")]
        public async Task<IEnumerable<Product>> Search(ProductRequestDTO? productRequest)
        {
            if (productRequest != null)
            {
                return await _filterService.Filter(productRequest);
            } else
            {
                // betere oplossing vinden
                return null;
            }
        }

        // GET: api/Products/images/id
        [HttpGet("{id}/images")]
        public async Task<IActionResult> GetProductImagesByProductId(int id)
        {
            var images = await _productService.GetImages(id);

            if (!images.Any())
            {
                return Ok(new { Message = "No images available for this product." });
            }

            return Ok(images.Select(img => img.ImageUrl).ToList());
        }
    }
}
