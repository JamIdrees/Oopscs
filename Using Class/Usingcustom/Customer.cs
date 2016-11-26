using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usingcustom
{
public class Customer
    {
        public Customer()
        {

        }
        private string mLastname;
        public string  Lastname{
           get { return mLastname; }
           set { mLastname = value; }
       }
        private string mFirstname;
        public string Firstname
        {
            get { return mFirstname; }
            set { mFirstname = value; }
        }
        private string mEmail;
        public string Email
        {
            get { return mEmail; }
            set { mEmail = value; }
        }
        private Address mHomeAddress;
        public Address HomeAddress
        {
            get { return mHomeAddress; }
            set { mHomeAddress = value; }

        }
        private Address mWorkaddress;
    public Address Workaddress
        {
            get { return mWorkaddress; }
            set { mWorkaddress = value; }
        }

      public  bool validate()
        {
            return true;    
        }

        public Customer Retrieve()
        {
            return new Customer();
        }
        public bool Save(Customer customer) 
        {
            return true;

        }

    }
}