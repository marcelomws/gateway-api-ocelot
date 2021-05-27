using CatalogApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CatalogApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        [Route("{id}")]
        public Product Get(int id)
        {
            return new Product 
            { 
                Id = id,
                Description = "Tênis Nike" 
            };
        }
    }
}
