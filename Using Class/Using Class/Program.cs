using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_Class
{
    class LearnHouse
    {
        static void Main(string[] args)
        {
            House house = new House();
            house.Area=1300;
            house.ShowData();
            Console.WriteLine(house.ToString());
            Door door = new Door();
            door.Color = "Red";
            door.ShowData();
            AnotherHouse anotherhouse = new AnotherHouse();
            anotherhouse.Area = 2000;
            anotherhouse.Color = "Green";
            anotherhouse.ShowData();
            Console.ReadLine();
            
        }
                
    }
}
