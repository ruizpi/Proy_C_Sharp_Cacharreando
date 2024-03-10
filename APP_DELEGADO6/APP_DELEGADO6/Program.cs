using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace APP_DELEGADO6
{

    public delegate void Accion();
    public delegate int Funcion(int n1, int n2);
    public delegate bool Predicado(Funcion f);

    public class Program
    {
        static void Main(string[] args)
        {

            // DELEGADOS PROPIOS

            Accion d1 = Mensaje;
            d1();
            Funcion d2 = Suma;
            Console.WriteLine(d2(7, 30));
            Predicado d3 = Callback;
            Console.WriteLine(d3(Suma));




            // DELEGADOS ACTION FUNC PREDICATE

            Console.WriteLine("\nFUNC --- ACTION --- PREDICATE\n");

            // EL DELEGADO ACTION ES DE TIPO VOID Y LOS PARAMETROS SON LOS QUE UNO QUIERA
            Action dAct = Mensaje;
            dAct();
            //Devuelve cualquier tipo de valor y parametros de 0 a 16 parametros
            //El último parámetro es el valor que devuelve
            // Devuelve cualquier tipo
            Func<int, int, int> dFunc = Suma;
            Console.WriteLine(dFunc(77, 100));


            // PREDICATE
            // DEVUELVE SIEMBRE TRUE OR FALSE
            // CUENTA CON 1 PARAMETRO
            // DEVUELVE BOOL
            // SIRVE PARA HACER FILTRADOS O BUSQUEDAS EN LAS LISTAS
            Predicate<Func<int, int, int>> dPredicate = Callback;
            Console.WriteLine(dPredicate(Suma));



        }

        static void Mensaje() => Console.WriteLine("Comparte este video a tus amigos");
        static int Suma(int n1, int n2) => n1 + n2;

        static bool Callback(Funcion f)
        {
            return f(7,30) == 37 ? true : false;
        }

        static bool Callback(Func<int, int, int> f) {
            return f(77, 100) == 177 ? true : false;
        }
    }


}
