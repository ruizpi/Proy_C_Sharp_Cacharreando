using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borrar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Compradores> compradores = new List<Compradores>() {
                new Compradores("Remigio","05", 20),
                new Compradores("Fulgencio","02", 30),
                new Compradores("Gervasio","01", 25),
                new Compradores("Brutecio","03", 26),
                new Compradores("Indalecio","04", 27),
                new Compradores("Evaristo","04", 30),
                new Compradores("Anastasio","04", 45),
                new Compradores("Anacleto","02", 32)
            };

            List<Vendedores> vendedores = new List<Vendedores>() {
                new Vendedores("Manolo", "02", 45),
                new Vendedores("Irene", "02", 30),
                new Vendedores("Romina", "01", 24),
                new Vendedores("Silvia", "01", 56),
                new Vendedores("Felipe", "03", 60),
                new Vendedores("Yolanda", "04", 42),
                new Vendedores("Sofia", "05", 34)
            };


            //var enlaceSimple = compradores.Join(vendedores, c => c.Zona, v => v.ZonaVendedor,
            //    (c, v) => new
            //    {
            //        Vendedor = v.NomVendedor,
            //        Comprador = c.NomComprador,
            //        v.Edad,
            //        Zona = c.Zona
            //    });

            //foreach(var item in enlaceSimple)
            //{
            //    Console.WriteLine($"Zona: {item.Zona}, Vendedor: {item.Vendedor}, Edad: {item.Edad}");
            //    Console.WriteLine($"Comprador: {item.Comprador}");
            //}

            Console.WriteLine("-------------------------------------------------------------------------------------------");




            var enlaceDoble = vendedores.Join(compradores,
                                v => new { v.Zona, v.Edad },
                                c => new { c.Zona, c.Edad },
                                (v, c) => new
                                {
                                    Vendedor =v.NomVendedor,
                                    Comprador = c.NomComprador,
                                    Edad = v.Edad,
                                    ZonaVendedor = v.Zona

                                });





            foreach (var item in enlaceDoble)
            {
                Console.WriteLine($"Zona: {item.ZonaVendedor}, Vendedor: {item.Vendedor}, Edad: {item.Edad}");
                Console.WriteLine($"Comprador: {item.Comprador}");
            }


        }

        internal class Compradores
        {
            private string _nomComprador;
            private string _zona;
            private int _edad;

            public Compradores(string nomComprador, string zona, int edad)
            {
                NomComprador = nomComprador;
                Zona = zona;
                Edad = edad; 
            }

            public string NomComprador { get => _nomComprador; set => _nomComprador = value; }
            public string Zona { get => _zona; set => _zona = value; }
            public int Edad { get => _edad; set => _edad = value; }
        }

        internal class Vendedores
        {
            private string _nomVendedor;
            private string _zona;
            private int _edad;
           

            public Vendedores(string nomVendedor, string zona, int edad)
            {
                NomVendedor = nomVendedor;
                Zona = zona;
                Edad = edad;
            }

            public string NomVendedor { get => _nomVendedor; set => _nomVendedor = value; }
            public string Zona { get => _zona; set => _zona = value; }
            public int Edad { get => _edad; set => _edad = value; }
        }

    }
}
