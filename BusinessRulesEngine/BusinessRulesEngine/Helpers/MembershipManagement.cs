using BusinessRulesEngine.Models.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRulesEngine.Helpers
{
    /// <summary>
    /// This class will be used to create Helper methods related to Membership management
    /// </summary>
    public static class MembershipManagement
    {
        /// <summary>
        /// Method to Activate or upgrade membership and send email.
        /// </summary>
        /// <param name="CustomerID">Customer ID.</param>
        /// <param name="orderDetails">Order details.</param>
        public static void ActivateOrUpgradeMembership(long CustomerID, OrderDetails orderDetails)
        {
            //// Code for activating membership and send Email.
            Console.WriteLine("Activate / Upgrade Membership.");
        }
    }
}
