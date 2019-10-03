using System;
using System.Collections.Generic;

/*
 * Crystal Liles
 */

namespace CustomerManagement
{
    public class OrderItem
    {
        #region Properies, variables, and fields.
        public OrderItem()
        { 
        
        }
        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }
        public int OrderItemId { get; private set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }
        #endregion

        /// <summary>
        /// Retrieve one order item.
        /// </summary>
        public OrderItem Retrieve(int orderItemId)
        {
            // Code that retrieves the defined order item

            return new OrderItem();
        }

        ///<summary>
        ///Saves the current order item.
        /// </summary>
        /// <return></return>
        public bool Save()
        {
            // Code that saves the defines order item

            return true;
        }

        ///<summary>
        ///Validate the order item data.
        /// </summary>
        /// <return></return>
        public bool Validate()
        {
            var isValid = true;

            if (Quantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;

            return isValid;
        }
    }
}
