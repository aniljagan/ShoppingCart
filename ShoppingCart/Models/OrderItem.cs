namespace ShoppingCart.Models
{
    /// <summary>
    /// Order Items 
    /// </summary>
    public class OrderItem
    {
        /// <summary>
        /// Get or Set ProductName
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// Get or Set Quantity
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Get or Set Price
        /// </summary>
        public decimal Price { get; set; }
    }
}
