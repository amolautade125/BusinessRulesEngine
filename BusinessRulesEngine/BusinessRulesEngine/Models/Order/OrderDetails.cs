using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRulesEngine.Models.Order
{
    /// <summary>
    /// Order details model class.
    /// </summary>
    public class OrderDetails
    {
        /// <summary>
        /// Gets or sets Product Ientifier.
        /// </summary>
        public long ProductID { get; set; }

        /// <summary>
        /// Gets or sets Quantity.
        /// </summary>
        public int Quantity { get; set; }
    }
}
