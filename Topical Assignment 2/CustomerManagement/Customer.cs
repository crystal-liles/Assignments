using System;
using System.Collections.Generic;

/*
 * Crystal Liles
 */

namespace CustomerManagement
{
    public class Customer
    {
        #region Properies, variables, and fields.
        public int CustomerID { get; private set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }

        public string FullName
        {

            get
            {
                if (!string.IsNullOrWhiteSpace(FirstName) &&
                    !string.IsNullOrWhiteSpace(LastName))
                {
                    return $"{LastName}, {FirstName}";
                }
                return LastName + FirstName;
            }
        }
        public static int InstanceCount { get; set; }
        private string _lastName;
        #endregion


        public string LastName
        {
            get
            {
                return _lastName;
            }

            set
            {
                _lastName = value;
            }
        }
        ///<summary>
        /// Validates the customer data.
        /// </summary>
        ///<returns></returns>
        public bool Validate()
        {
            //var isValid = true;
            //if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            //if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            //return isValid;

            return !string.IsNullOrWhiteSpace(LastName) &&
                   !string.IsNullOrWhiteSpace(EmailAddress);

            
        }

        ///<summary>
        /// Retrieve one customer.
        /// </summary>
        ///<returns></returns>
        public Customer Retreive(int customerID)
        {
            // Code that retrieves the defined customer

            return new Customer();
        }

        ///<summary>
        /// Retrieve all customers.
        /// </summary>
        ///<returns></returns>
        public List<Customer> Retreive()
        {
            // Code that retrieves all of the customers

            return new List<Customer>();
        }

        ///<summary>
        /// Saves the current customer.
        /// </summary>
        ///<returns></returns>
        public bool Save()
        {
            //Code that saves the defined customer

            return true;

        }
    }
}