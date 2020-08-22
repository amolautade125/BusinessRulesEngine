using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRulesEngine.Models.Product
{
    /// <summary>
    /// Product model class.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Gets or sets Product Identifier.
        /// </summary>
        public long ProductID { get; set; }

        /// <summary>
        /// Gets or sets SKU.
        /// </summary>
        public char SKU { get; set; }

        /// <summary>
        /// Gets or sets Product Type details.
        /// </summary>
        public ProductType ProductType { get; set; }

        /// <summary>
        /// Gets or sets Unit Price for the product.
        /// </summary>
        public double Price { get; set; }
    }
}
