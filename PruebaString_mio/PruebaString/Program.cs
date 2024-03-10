using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PruebaQueStringHolaTieneLongitud4();
            PruebaQueStringHolaContieneCaracterA();
            Console.WriteLine("Prueba Existosa");
        }

        static void PruebaQueStringHolaContieneCaracterA()
        {
            //Arrange
            var stringHola = "Hola";

            //Action
            var contieneletraa = stringHola.Contains("a");

            //Assert
            Assert.Que(contieneletraa);

        }

        static void PruebaQueStringHolaTieneLongitud4()
        {
            //Arrange
            var stringHola = "Hola";

            //Action
            var cantidadLetras = stringHola.Length;

            //Assert
            Assert.Que(cantidadLetras==1);



        }
    }
}
