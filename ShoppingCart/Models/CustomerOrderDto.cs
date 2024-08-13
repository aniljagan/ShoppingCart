using System.Runtime.ExceptionServices;

namespace ShoppingCart.Models
{
    /// <summary>
    /// CustomerOrderDto
    /// </summary>
    public class CustomerOrderDto
    {
        /// <summary>
        /// Get or Set First Name
        /// </summary>
       public string FirstName { get; set; }

        /// <summary>
        /// Get or Set Last Name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Get or Set Delivery Address
        /// </summary>
        public string DeliveryAddress { get; set; }

        /// <summary>
        /// Get or Set Order Number
        /// </summary>
        public int OrderNumber { get; set; }

        /// <summary>
        /// Get or Set Order Date
        /// </summary>
        public DateTime OrderDate { get; set; }

        /// <summary>
        /// Get or Set DeliveryExpectedDate
        /// </summary>
        public DateTime DeliveryExpectedDate { get; set; }



    }

}
