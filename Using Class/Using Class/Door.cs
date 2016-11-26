using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_Class
{
    class Door
    {
        public Door()
        {

        }
        private string mColor;

        public string Color
        {
            get { return mColor; }
            set { mColor = value; }
        }
        public Door(string color)
        {

        }
        public void ShowData()
        {
            Console.WriteLine("My Color Is: {0}" , mColor);
        }
    }
}
