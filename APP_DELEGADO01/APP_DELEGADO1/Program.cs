using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace APP_DELEGADO1
{
    class Program
    {

        public delegate void DelSaludo(string str);

        static void Main(string[] args)
        {

            DelSaludo d0  = new DelSaludo(Saludo.Like);
            d0("DELEGADO FORMA 1");

            // DELEGADO FORMA 1
            DelSaludo d1 = Saludo.Like;
            d1("DELEGADO FORMA 2");

            // DELEGADO FORMA 3
            DelSaludo anonimoD1 = delegate (string str)
            {
                Console.WriteLine(str);
            };
            anonimoD1("DELEGADO FORMA 3");

            // DELEGADO FORMA 4
            DelSaludo lamda = str => { Console.WriteLine(str); };

            lamda("DELEGADO FORMA 4");

        }

    }

    public class Saludo
    {
        public static void Like(string str)
        {
            Console.WriteLine(str);
        }
    }
}
