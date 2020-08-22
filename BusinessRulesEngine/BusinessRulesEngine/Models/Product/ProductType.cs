using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRulesEngine.Models.Product
{
    /// <summary>
    /// Product type model class.
    /// </summary>
    public class ProductType
    {
        /// <summary>
        /// Gets or sets Product type identifier.
        /// </summary>
        public long ProductTypeID { get; set; }

        /// <summary>
        /// Gets or sets Product type code.
        /// </summary>
        public string ProductTypeCode { get; set; }

        /// <summary>
        /// Gets or sets Product type code.
        /// </summary>
        public string ProductTypeName { get; set; }
    }
}
