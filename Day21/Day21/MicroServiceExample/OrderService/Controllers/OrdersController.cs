using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderService.Models;

namespace OrderService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {


        private static readonly List<Order> Orders = new()
        {
            new Order { Id = 1, ProductName = "Product A", Quantity = 2 },
            new Order { Id = 2, ProductName = "Product B", Quantity = 1 }
        };

        [HttpGet]
        public List<Order> GetAllOrders()
        {
            return Orders;
        }

        [HttpGet("{id}")]
        public Order GetOrderById(int id)
        {
            var order = Orders.Find(x => x.Id == id);
            if (order == null)
            {
                return new Order { ProductName = "order not found ", Quantity = 0 };
            }
            return order;
        }
    }
}
