using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DELEGADO03
{

    public delegate void D1(List<Alumnos> lst);
    public class Program
    {


        static void Main(string[] args)
        {
            D1 allMethods;
            allMethods = Notas.addAlumno;
            allMethods += Notas.Media;
            CallBack(allMethods);

        }

        static void CallBack(D1 delegado)
        {
            Console.WriteLine("Este es el callback función\n");
            List<Alumnos> lst = new List<Alumnos>();
            delegado(lst);
        }


    }
}
