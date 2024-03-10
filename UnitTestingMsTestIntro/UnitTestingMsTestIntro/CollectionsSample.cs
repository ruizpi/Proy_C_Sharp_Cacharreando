using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingMsTestIntro
{

    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class CollectionsSample
    {


        public static Customer GetCustomer(Customer[] customers, int index)
        {
            return customers[index];
        }
    }
}
