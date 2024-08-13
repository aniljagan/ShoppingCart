using Dapper;
using Microsoft.Data.SqlClient;
using ShoppingCart.Models;
using System.Data;

namespace ShoppingCart.Repository
{
    /// <summary>
    /// OrderRepository
    /// </summary>
    public class OrderRepository : IOrderRepository
    {
        /// <summary>
        /// Db connection
        /// </summary>
        private IDbConnection _connection;

        /// <summary>
        /// OrderRepository ctor
        /// </summary>
        /// <param name="configuration"></param>
        public OrderRepository(IConfiguration configuration)
        {
            _connection = new SqlConnection(configuration.GetConnectionString("ShoppingCartDb"));
        }
        /// <summary>
        /// Get Customer Orders
        /// </summary>
        /// <returns></returns>
        public CustomerOrderResponse GetCustomerOrders(CustomerOrderRequest request)
        {
            try
            {
                CustomerOrderDto customerOrder;
                List<OrderItem> orderItems;
                CustomerOrderResponse response;

                var parameters = new DynamicParameters();
                parameters.Add("@Email", request.Email);
                parameters.Add("@CustomerId", request.CustomerId);

                using (var lists = _connection.QueryMultiple("usp_CustomerOrderDetailsByCustomerIdAndEmail", parameters, commandType: CommandType.StoredProcedure))
                {
                    customerOrder = lists.Read<CustomerOrderDto>().ToList().FirstOrDefault();
                    if (customerOrder == null)
                    {
                        response = new CustomerOrderResponse();
                    }
                    else
                    {
                        orderItems = lists.Read<OrderItem>().ToList();
                        response = new CustomerOrderResponse();
                        response.Customer = new Customer
                        {
                            FirstName = customerOrder?.FirstName,
                            LastName = customerOrder?.LastName,
                        };
                        response.Order = new Order
                        {
                            OrderNumber = customerOrder.OrderNumber,
                            OrderDate = customerOrder.OrderDate,
                            DeliveryAddress = customerOrder?.DeliveryAddress,
                            OrderItems = orderItems,
                        };
                    }
                }
                return response;
            }
            catch (Exception ex)
            {
                return new CustomerOrderResponse();
            }
        }
    }
}
