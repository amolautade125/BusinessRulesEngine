using BusinessRulesEngine.Models.Order;
using System;

namespace BusinessRulesEngine.Helpers
{
    /// <summary>
    /// This class will provide helper methods related to Packing slip generation.
    /// </summary>
    public static class PackingSlipManagement
    {
        /// <summary>
        /// Method for generating Packing slip.
        /// </summary>
        /// <param name="CustomerID"></param>
        /// <param name="orderDetails"></param>
        /// <param name="isDuplicateCopy">Check if we want rto create a duplicate copy.</param>
        public static void GeneratePackingSlip(long CustomerID, OrderDetails orderDetails, bool isDuplicateCopy = false)
        {
            //// Code for generating Packaging Slip.
            //// Check if we want to mark the copy as "DUPLICATE".
            string packingSlipString = isDuplicateCopy == true ? "Duplicate Packing slip." : "Packing slip.";
            Console.WriteLine(packingSlipString);
        }
    }
}
