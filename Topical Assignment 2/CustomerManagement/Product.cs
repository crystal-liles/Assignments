using System;
using System.Collections.Generic;

/*
 * Crystal Liles
 */

namespace CustomerManagement
{
    public class Product
    {
        #region Properies, variables, and fields.
        public Product()
        {

        }
        public Product(int productId)
        {
            ProductId = productId;
        }
        public decimal? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }
        public int ProductId { get; private set; }
        public string ProductName { get; set; }
        #endregion

        ///<summary>
        ///Retrieve one product.
        /// </summary>
        public Product Retrieve(int productId)
        {
            // Code that retrieved the defined product
            return new Product();
        }

        ///<summary>
        ///Saves the current product.
        /// </summary>
        /// <return></return>
        
        public bool Save()
        {
            // Code that saves the defines product

            return true;
        }

        ///<summary>
        ///Validates the product data.
        /// </summary>
        /// <return></return>
        
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }
    }
}