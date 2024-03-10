using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingMsTestIntro
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public static class Calcs
        {
            public static int Sum(int a, int b)
            {
                return a + b;
            }

            public static int Substract(int a, int b)
            {
                return a - b;
            }

            public static int Multiply(int a, int b)
            {
                return (a * b);
            }
        }
    }


}
