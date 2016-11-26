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
            Address homeAddress = new Address();
            homeAddress.Street = "Queens Road";
            homeAddress.City = "Bangalore";
            homeAddress.Pincode = "560001";
            cust.HomeAddress = homeAddress;
            cust.Retrieve();
            Console.ReadLine();
        }
    }
}