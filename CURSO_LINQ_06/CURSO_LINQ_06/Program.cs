using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace CURSO_LINQ_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] catNames = { "Lucky", "Bella", "Luna", "Oreo", "Simba", "Toby", "Loki", "Oscar" };
            List<int> numbers = new List<int>() { 5, 6, 3, 2, 1, 5, 6, 7, 8, 4, 234, 54, 14, 653, 3, 4, 5, 6, 7 };
            object[] mix = { 1, "string", 'd', new List<int>() { 1, 2, 3, 4 }, new List<int>() { 5, 2, 3, 4 }, "dd", 's', "Hello Kity", 1,2,3,4 };

//            List<Warriors> warriors = new List<Warriors>();

            List<int> oddNumbers = numbers.Where(n => n%2==1).ToList();

            Console.WriteLine(string.Join(", ", oddNumbers));

            var allIntegers = mix.OfType<int>();
            Console.WriteLine(string.Join(" ", allIntegers));


            List<Person> people = new List<Person>()
            {
                new Buyers(){Age=20},
                new Buyers(){Age=25},
                new Buyers(){Age=20},
                new Supplier(){Age=22},
                new Supplier(){Age=20}

            };

            //var suppliers = from p in people
            //                where p is Buyers
            //                let b = p as Buyers
            //                where b.Age > 19 && b.Age < 22
            //                select p;

            var suppliers = people.OfType<Buyers>().Where(a => a.Age==20);  

           

            foreach ( var supplier in suppliers)
            {
                Console.WriteLine(supplier.GetType().ToString());
            }
            
           




        }

        internal class Person
        {
            private int _age;

            public int Age { get => _age; set => _age = value; }
        }

        internal class Buyers: Person
        {
            public Buyers()
            {
            }

        }

        internal class Supplier : Person
        {
            public Supplier()
            {
            }

        }
    }
}
