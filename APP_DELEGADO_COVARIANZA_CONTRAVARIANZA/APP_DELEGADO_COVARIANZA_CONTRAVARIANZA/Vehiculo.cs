using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_DELEGADO_COVARIANZA_CONTRAVARIANZA
{
    public class Vehiculo
    {

        public Vehiculo()
        {
            Console.WriteLine("Se crea el primer vehiculo");
        }

        public string ToString()
        {
            return "Contravarianza del Vehiculo";
        }
    }

    public class Auto : Vehiculo { 
        
        public Auto()
        {
            Console.WriteLine("Soy un automovil con 4 ruedas");
        }
    }


    public class RollsRoyce : Auto
    {
        public RollsRoyce()
        {
            Console.WriteLine("Soy un RollsRoyce muy elegante");
        }

    }
}
