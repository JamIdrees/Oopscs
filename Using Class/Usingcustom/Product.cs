using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usingcustom
{
   public  class Product
    {
        public Product()
        {

        }
        private string mProductname;
        public string Productname
        {
            get { return mProductname; }
            set { mProductname = value; }
        }
        private string mDescription;
        public string Description
        {
            get { return mDescription; }
            set { mDescription = value; }
        }
        private float mCurrentprice;
        public float Currentprice
        {
            get { return mCurrentprice; }
            set { mCurrentprice = value; }
        }

        public bool validate()
        {

            return true;
        }

        public Product Retrieve()
        {
            return new Product();

        }
        public bool save(Product product)
        {
            return true;
        }

       
    }
}