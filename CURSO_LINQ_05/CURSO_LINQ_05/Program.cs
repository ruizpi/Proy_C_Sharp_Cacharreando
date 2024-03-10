using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURSO_LINQ_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Buyers> buyers = new List<Buyers>() {  
                new Buyers("Johny","Fantasy District", 22),
                new Buyers("Peter","Scientist District", 40),
                new Buyers("Paul","Fantasy District", 30),
                new Buyers("Maria","Scientist District", 35),
                new Buyers("Joshua","EarthIsFlat District", 40),
                new Buyers("Silvia","Developers District", 22),
                new Buyers("Rebecca","Scientist District", 30),
                new Buyers("Jaime","Developers District", 35),
                new Buyers("Pierce","Fantasy District", 40)
            };

            List<Suppliers> suppliers = new List<Suppliers>() { 
                new Suppliers("Harrison", "Fantasy District", 22),
                new Suppliers("Charles", "Developers District", 40),
                new Suppliers("Hailee", "Scientist District", 35),
                new Suppliers("Taylor", "EarthIsFlat District", 56)
            };

            var innerjoin = from s in suppliers
                            join b in buyers on s.Zona equals b.Zona
                            orderby b.Zona
                            select new
                            {
                                SuppplierName = s.NomVendedor,
                                BuyerName = b.NomComprador,
                                b.Zona
                            };

            foreach (var item in innerjoin)
            {
                Console.WriteLine($"Zona: {item.Zona} - Vendedor: {item.SuppplierName} - Comprador {item.BuyerName}");
            }





            //var innerjoin = suppliers.Join(buyers, s => s.Zona, b => b.Zona,
            //    (s, b) => new
            //    {
            //        Vendedor = s.NomVendedor,
            //        Comprador = b.NomComprador,
            //        Zona = s.Zona
            //    });

            //foreach (var item in innerjoin)
            //{
            //    Console.WriteLine($"Zona: {item.Zona}, Vendedor: {item.Vendedor}, Comprador: {item.Comprador}");

            //}

            //var compositeJoin = suppliers.Join(buyers,
            //    s => new { s.Zona, s.Edad },
            //    b => new { b.Zona, b.Edad },
            //    (s, b) => new
            //    {
            //        Vendedor = s.NomVendedor,
            //        Edad = s.Edad,
            //        Comprador = b.NomComprador,
            //        Zona = b.Zona
            //    }) ;

            //foreach (var item in compositeJoin)
            //{
            //    Console.WriteLine($"Zona: {item.Zona}, Edad: {item.Edad}, Vendedor: {item.Vendedor}, Comprador: {item.Comprador}");
            //}
        }
    }

    internal class Buyers
    {
        private string _nomComprador;
        private string _zona;
        private int _edad;

        public Buyers(string nomComprador, string zona, int edad)
        {
            NomComprador = nomComprador;
            Zona = zona;
            Edad = edad;
        }

        public string NomComprador { get => _nomComprador; set => _nomComprador = value; }
        public string Zona { get => _zona; set => _zona = value; }
        public int Edad { get => _edad; set => _edad = value; }
    }

    internal class Suppliers
    {
        private string _nomVendedor;
        private string _zona;
        private int _edad;

        public Suppliers(string nomVendedor, string zona, int edad)
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
