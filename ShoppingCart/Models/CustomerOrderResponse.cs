namespace ShoppingCart.Models
{
    /// <summary>
    /// Final Response for displaying customer Orders
    /// </summary>
    public class CustomerOrderResponse
    {
        /// <summary>
        /// Customer First Name and Last Name Details
        /// </summary>
        public Customer Customer { get; set; }

        /// <summary>
        /// Order details
        /// </summary>
        public Order Order { get; set; }

    }
}
