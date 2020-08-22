using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRulesEngine.Models.Order
{
    /// <summary>
    /// Order model class.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Gets or sets Customer Identifier.
        /// </summary>
        public long CustomerID { get; set; }

        /// <summary>
        /// Gets or sets list of ordered products and quantity.
        /// </summary>
        public List<OrderDetails> OrderDetails { get; set; }
    }
}
