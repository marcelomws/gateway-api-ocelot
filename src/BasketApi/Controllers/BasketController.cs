using BasketApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BasketApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BasketController : ControllerBase
    {
        [HttpGet]
        [Route("{id}")]
        public BasketItem Get(int id)
        {
            return new BasketItem
            {
                Id = id,
                ProductId = 1,
                ProductName = "Casaco Adidas",
                Quantity = 1,
                UnitPrice = 109.00M
            };
        }
    }
}
