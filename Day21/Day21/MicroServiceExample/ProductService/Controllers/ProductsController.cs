using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductService.Models;

namespace ProductService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private static readonly List<Product> Products = new()
        {
            new Product { Id = 1, Name = "Product A", Price = 100 },
            new Product { Id = 2, Name = "Product B", Price = 200 }
        };

        [HttpGet]
        public List<Product> GetAllProducts()
        {
            return (Products);
        }

        [HttpGet("{id}")]
        public Product GetProductById(int id)
        {
            var product = Products.Find(x => x.Id == id);
            if (product == null)
            {
                return new Product { Name = "Product not found ", Price = 0 };
            }
            return product;
        }
    }
}

