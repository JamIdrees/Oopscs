using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_Class
{
    class AnotherHouse
    {
        public AnotherHouse()
        {

        }
        private float mArea;
        public float Area
        {
            get { return mArea; }
            set { mArea = value; }
        }

        private string mColor;

        public string Color
        {
            get { return mColor; }
            set { mColor = value; }
        }

        public void ShowData()
        {
            Console.WriteLine("My Area is {0}", mArea);
            Console.WriteLine("My Color Is: {0}", mColor);
        }

    }
}
