using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usingcustom
{
    public class Order
    {
        public Order()
        {

        }

        private Customer mCustomer;

        public Customer MyCustomer
        {
            get { return mCustomer; }
            set { mCustomer = value; }
        }

        private Product mProduct;

        public Product MyProduct
        {
            get { return mProduct; }
            set { mProduct = value; }
        }
        
        
        private DateTime mOrderdate;
        public DateTime Orderdate
        {
            get { return mOrderdate; }
            set { mOrderdate = value; }
        }
        private string mShipaddress;
        public string Shipaddress
        {
            get { return mShipaddress; }
            set { mShipaddress = value; }
        }
        bool validate()
        {
            return true;
        }
        public Order Retrieve(int id)
        {
            return new Order();
        }
    }
}
