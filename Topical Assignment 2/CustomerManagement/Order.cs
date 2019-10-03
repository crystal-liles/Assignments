using System;
using System.Collections.Generic;

/*
 * Crystal Liles
 */

namespace CustomerManagement
{
    public class Order
    {
        #region Properies, variables, and fields.
        public Order()
        {

        }
        public Order(int orderId)
        {
            OrderId = orderId;
        }
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }
        #endregion

        ///<summary>
        /// Retrieve one order.
        /// </summary>
        public Order Retrieve(int orderId)
        {
            // Code theat retrieves the defined order

            return new Order();
        }

        ///<summary>
        ///Saves the current order.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // Code that saves the defined order

            return true;
        }

        ///<summary>
        ///Validates the order data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }
    }
}
  

