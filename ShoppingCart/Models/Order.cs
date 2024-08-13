namespace ShoppingCart.Models
{
    /// <summary>
    /// Order
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Get or Set Order Number
        /// </summary>
        public int OrderNumber { get; set; }
        /// <summary>
        /// Get or Set Delivery Address
        /// </summary>
        public string DeliveryAddress { get; set; }

        /// <summary>
        /// Get or Set Order Date
        /// </summary>
        public DateTime OrderDate { get; set; }

        /// <summary>
        /// Get or Set DeliveryExpectedDate
        /// </summary>
        public DateTime DeliveryExpectedDate { get; set; }

        /// <summary>
        ///  Order Items contains Product Name, Quantity and Price
        /// </summary>
        public List<OrderItem> OrderItems { get; set; }

    }
}
