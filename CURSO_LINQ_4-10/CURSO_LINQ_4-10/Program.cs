using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURSO_LINQ_4_10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Person> people = new List<Person>()
            {
                new Person("Sod", 180, 70, 25, Gender.Male),
                new Person("Aoda", 170, 88, 21, Gender.Male),
                new Person("Modi", 150, 48, 20, Gender.Female),
                new Person("Xod", 164, 77, 30, Gender.Male),
                new Person("Aod", 164, 77, 20, Gender.Male),
                new Person("Soda", 160, 55, 21, Gender.Female),
                new Person("Xodi", 160, 55, 25, Gender.Male)
            };

            var simpleGrouping = people.Where(p => p.Edad>20).GroupBy(p => p.Gender);

            foreach (var item in simpleGrouping) {

                Console.WriteLine($"Gender: {item.Key}");

                foreach(var person in item)
                {
                    Console.WriteLine($"{person.Nombre} / {person.Edad}");
                }

            }

            var alphabeticalGroup = people.OrderBy(p => p.Nombre).GroupBy(p => p.Gender);


            foreach (var item in alphabeticalGroup)
            {

                Console.WriteLine($"Gender: {item.Key}");

                foreach (var person in item)
                {
                    Console.WriteLine($"{person.Nombre} / {person.Edad}");
                }

            }


            var multiKey = people.GroupBy(p => new { p.Gender, p.Edad }).OrderBy(p => p.Count());

            foreach (var item in multiKey)
            {

                Console.WriteLine($"Gender: {item.Key}");

                foreach (var person in item)
                {
                    Console.WriteLine($"{person.Nombre} / {person.Edad}");
                }

            }


        }

        public class Person
        {
            private string _nombre;
            private int _estatura;
            private int _peso;
            private int _edad;
            private Gender _gender;

            public Person(string nombre, int estatura, int peso, int edad, Gender gender)
            {
                Nombre = nombre;
                Estatura = estatura;
                Peso = peso;
                Edad = edad;
                Gender = gender;
            }

            public string Nombre { get => _nombre; set => _nombre = value; }
            public int Estatura { get => _estatura; set => _estatura = value; }
            public int Peso { get => _peso; set => _peso = value; }
            public int Edad { get => _edad; set => _edad = value; }
            internal Gender Gender { get => _gender; set => _gender = value; }
        }

        public enum Gender
        {
            Male,
            Female
        }
    }
}
