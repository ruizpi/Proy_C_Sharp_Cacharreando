using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Curso_LINQ_03
{

    // PROGRAMA CORRESPONDE A LA LECCION 3 DE LAMBDAS
    internal class Program
    {

        private static int[] StringToIntArray(string array)
        {

            int[] arrayFromString = array.Split(' ').Select(element => int.Parse(element)).ToArray();

            return arrayFromString;

        }
        class Warrior
        {
            int _height;

            public int Height { get => _height; set => _height = value; }
        }





        static void Main(string[] args)
        {
            List<Warrior> warriors = new List<Warrior>()
            {
                new Warrior() {Height = 100},
                new Warrior() {Height = 80},
                new Warrior() {Height = 100},
                new Warrior() {Height = 70},

            };

            //var shorWarriors = warriors.Where(wh => wh.Height == 100).Select(wh => wh.Height).ToList();

            //foreach (var word in shorWarriors) {

            //    Console.WriteLine(word.ToString());
            //}
            
            List<int> shortWarriors  = warriors.Where(wh => wh.Height == 100).Select(wh => wh.Height).ToList();

            Console.WriteLine(string.Join(", ",shortWarriors));

            shortWarriors.ForEach(sh => Console.WriteLine($"valor {sh}"));








            //List<int> numbers = new List<int>() { 5, 6, 3, 2, 1, 5, 6, 7, 8, 4, 234, 54, 14, 653, 3, 4, 5, 6, 7 };


            //var oddnumbers = numbers.Where(num => num % 2 == 1);

            //Console.WriteLine(String.Join(", ", oddnumbers));

            //var num = from n in numbers
            //              where n%2 == 1
            //              select n; 

            //Console.WriteLine(String.Join(", ", num));



        }
    }
}
