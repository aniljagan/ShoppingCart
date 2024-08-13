using ShoppingCart.Models;

namespace ShoppingCart.Repository
{
    public interface IOrderRepository
    {
        /// <summary>
        /// Retrieve Customer Orders
        /// </summary>
        /// <returns></returns>
        CustomerOrderResponse GetCustomerOrders(CustomerOrderRequest request);
    }
}
