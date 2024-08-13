using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Models;
using ShoppingCart.Repository;

namespace ShoppingCart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerOrderController : ControllerBase
    {
        /// <summary>
        /// OrderRepository
        /// </summary>
        private IOrderRepository _orderRepository;

        /// <summary>
        /// Get Customer Order by CustomerId and Email
        /// </summary>
        public CustomerOrderController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        [HttpPost("getcustomerorderslatest")]
        public CustomerOrderResponse GetCustomerOrder(CustomerOrderRequest customerOrderRequest)
        {
            try
            {
                var result = _orderRepository.GetCustomerOrders(customerOrderRequest);
                return result;
            }
            catch (Exception ex) {
                return null;
            }
        }

    }
}
