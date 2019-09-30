using System;

/*
 * Crystal Liles
 */

namespace CustomerManagement
{
    public class Customer
    {
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

    }
}