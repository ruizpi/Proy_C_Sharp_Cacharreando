using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace APP_DELEGADO03
{
    public class Notas
    {
        public static void addAlumno(List<Alumnos> lst)
        {
            string respuesta = "si";
            while (respuesta == "si")
            {
                Console.WriteLine("Nombre del Alumno: ");
                string name = Console.ReadLine();
                double nota = Double.Parse(Console.ReadLine());
                lst.Add(new Alumnos { Name = name, Nota = nota });
                Console.WriteLine("Deseas agregar otro alumno? [si] [no]");
                respuesta = Console.ReadLine();
                Console.Clear();
            }
        }
        public static void Media(List<Alumnos> list)
        {
            double suma = 0;
            foreach(Alumnos alumnos in list)
            {
                suma += alumnos.Nota;
                Console.WriteLine($"El Alumno {alumnos.Name} tiene {alumnos.Nota} de calificación");
            }

            Console.WriteLine($"La media es {suma / list.Count}");

        }
    }
}
