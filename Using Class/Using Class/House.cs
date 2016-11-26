using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_Class
{
    public class House
    {
       public House()
       {

       }

       private float mArea;
       public float Area {
           get { return mArea; }
           set { mArea = value; }
       }

       public void ShowData()
       {
           Console.WriteLine("My Area is {0}",mArea);
           //Console.WriteLine($ "My Area is {Area}" );
       }

       public override string ToString()
       {
           return "My Areas is : " + mArea;
       }
       
    }
}
