using System;
using System.Linq;
using Basket.API.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Basket.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{customerId:int}")]
        public CustomerBasket Get([FromRoute]int customerId)
        {
            var random = new Random();
            return new CustomerBasket(customerId, "demo", Summaries.Select(x =>
            {
                var price = random.Next(10, 20);
                return new BasketItem(x, $"{x}-{x}", 1, price, price * .9m);
            }).ToList());
        }
    }
}
