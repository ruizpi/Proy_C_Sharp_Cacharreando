using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_LINQ_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
            {
                new Person("Sod", 180, 70, 20, Gender.Male),
                new Person("Aoda", 170, 88, 21, Gender.Male),
                new Person("Modi", 150, 48, 20, Gender.Female),
                new Person("Xod", 164, 77, 30, Gender.Male),
                new Person("Aod", 164, 77, 20, Gender.Male),
                new Person("Soda", 160, 55, 21, Gender.Male),
                new Person("Xodi", 160, 55, 25, Gender.Male)
            };

            //var genderGroup = from p in people
            //                  group p by p.Gender;

            //foreach (var person in genderGroup) { 
            //    Console.WriteLine($"{person.Key}");

            //    foreach(var p in person)
            //    {
            //        Console.WriteLine($" {p.Nombre} / {p.Gender}");
            //    }

            //}

            //var groupWithConditions = from p in people
            //                          where p.Edad > 19
            //                          group p by p.Edad;

            //foreach (var person in groupWithConditions)
            //{
            //    Console.WriteLine($"{person.Key}");

            //    foreach(var p in person)
            //    {
            //        Console.WriteLine($"{p.Nombre} / {p.Edad}");
            //    }
            //}


            var listaAlfabetica = from gente in people
                                  orderby gente.Nombre.Substring(0, 1)
                                  group gente by gente.Nombre.Substring(0, 1);
                                 

            foreach(var p in listaAlfabetica)
            {
                Console.WriteLine(p.Key);

                foreach(var individuo in p)
                {
                    Console.WriteLine($"{individuo.Nombre} / {individuo.Edad}");
                }
            }

        }



      
    }
    public class Person
    {
        string _name;
        int _altura;
        int _peso;
        int _edad;
        Gender _gender;

        public Person(string nombre, int altura, int peso, int edad, Gender gender)
        {
            Nombre = nombre;
            Altura = altura;
            Peso = peso;
            Edad = edad;
            Gender = gender;
        }

        public string Nombre { get => _name; set => _name = value; }
        public int Altura { get => _altura; set => _altura = value; }
        public int Peso { get => _peso; set => _peso = value; }

        public int Edad { get => _edad; set => _edad = value; }
        public Gender Gender { get => _gender; set => _gender = value; }
    }

    public enum Gender
    {
        Male,
        Female
    };
}
