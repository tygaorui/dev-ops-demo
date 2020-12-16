using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Ordering.API.Queries;

namespace Ordering.API.Controllers
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

        [HttpGet("{message}")]
        public IEnumerable<Order> Get([FromRoute] string message)
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Order
            {
                OrderNumber = index,
                Date = DateTime.Now.AddDays(index),
                Items = Summaries.Select(a => new OrderItem
                {
                    ProductName = a,
                    Quantity = 1,
                    PictureUrl = $"/home/{a}",
                    UnitPrice = Convert.ToDecimal(rng.Next(10, 20))
                }).ToList(),
                Remark = message
            })
            .ToArray();
        }
    }
}
