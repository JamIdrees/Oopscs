using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usingcustom
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer cust = new Customer();
            cust.Firstname = "Mohammed";
            cust.Lastname = "Idrees";
            cust.Email = "mdidrees134@gmail.com";
            cust.Address = "Bangalore";
            cust.Retrieve();
            Console.ReadLine();
        }
    }
}