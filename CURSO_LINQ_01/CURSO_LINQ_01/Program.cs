using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURSO_LINQ_01
{
    internal class Program
    {

        class Person
        {
            private string _nombre;
            private int _estatura;
            private int _peso;
            private Gender _sexo;

            public string Nombre { get => _nombre; set => _nombre = value; }
            public int Estatura { get => _estatura; set => _estatura = value; }
            public int Peso { get => _peso; set => _peso = value; }
            private Gender Sexo { get => _sexo; set => _sexo = value; }

            public Person(Gender sexo)
            {
                Sexo = sexo;
            }

            public Person(string nombre, int estatura, int peso, Gender sexo)
            {
                Nombre = nombre;
                Estatura = estatura;
                Peso = peso;
                Sexo = sexo;
            }
        }


        internal enum Gender
        {
            Male,
            Female
        }

        public Gender genero { get; set; }

        static void Main(string[] args)
        {

            List<Person> people = new List<Person>()
            {
                new Person("Sod", 180, 70, Gender.Male),
                new Person("Aoda", 170, 88, Gender.Male),
                new Person("Modi", 150, 48, Gender.Female),
                new Person("Xod", 164, 77, Gender.Male),
                new Person("Aod", 164, 77, Gender.Male),
                new Person("Soda", 160, 55, Gender.Male),
                new Person("Xodi", 160, 55, Gender.Male)
            };


            var fourCharPeople = from p in people
                                 orderby p.Nombre, p.Peso descending
                                 select p;


                
            foreach (var item in fourCharPeople)
            {
                Console.WriteLine($"{item.Nombre} / {item.Peso}");
            }


           




            //string sentence = "I love cats";
            //string[] catNames = { "Lucky", "Desgraciao", "Inutil", "Oreo", "Simba", "Toby", "Oscar", "Sieso" };
            //int[] numbers = { 5, 6, 3, 2, 1, 5, 6, 7, 8, 4, 234, 54, 14, 653, 3, 4, 6, 7 };




            //var lstNombreGatos = from nomGatos in catNames
            //                     where nomGatos.Contains("e") && nomGatos.Length < 5
            //                     select nomGatos;
                                 
            //Console.WriteLine(String.Join(", ", lstNombreGatos));


            //var lstNumeros = from num in numbers
            //                 where (num > 5)
            //                 where (num < 10)
            //                 orderby num ascending
            //                 select num;

            //Console.WriteLine(String.Join(", ", lstNumeros));






            //var getTheNumbers = from number in numbers
            //                    where number < 5
            //                    select number;

            //foreach (var numero in getTheNumbers)
            //{
            //    Console.WriteLine(numero);
            //}

            //var simpleLinq from s in sentence
            //               select s;

            //IEnumerable

            //Console.WriteLine(string.Join(", ",simpleLinq);


        //    simpleLinq[0]

            //Console.WriteLine(string.Join(", ", getTheNumbers));



        }
    }
}
