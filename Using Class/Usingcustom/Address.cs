using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usingcustom
{
  public   class Address
    {
        public Address()
        {

        }
        private string mStreet;
        public string Street
        {
            get { return mStreet; }
            set { mStreet = value; }
        }
        private string mCity;
        public string City
        {
            get { return mCity; }
            set { mCity = value; }
        }
        private string mPincode;
        public string Pincode
        {
            get { return mPincode; }
            set { mPincode = value; }
        }
    }
}