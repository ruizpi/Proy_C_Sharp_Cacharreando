using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DELEGADO02
{
    class Program
    {

        public delegate void DelSaludo(String str);
        static void Main(string[] args)
        {


            DelSaludo d1 = Saludo.Like;
            D1Parametro(d1);

        }

        static void D1Parametro(DelSaludo d1)
        {
            d1("Metodo argumento de otro");
        }

 
    }
    public class Saludo
    {
        public static void Like(String str)
        {
            Console.WriteLine(str);
        }
    }
}
