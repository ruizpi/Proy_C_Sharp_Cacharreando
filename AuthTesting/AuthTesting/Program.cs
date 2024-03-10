using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthTesting
{
    public class Program
    {
        static void Main(string[] args)
        {

        }

        public static string Something()
        {
            return "algo";
        }

        public static bool Login(string username, string password) =>
            (username == "mamon" && password=="tus muertos") ? true : false;


    }
}
