using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vectores
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {

            int numx = 0;

            int[] numeros = new int[5];

            int[,] vector = new int[3,3];

            numeros[0] = 1;
            numeros[1] = 2;
            numeros[2] = 3;
            numeros[3] = 4;
            numeros[4] = 5;

            string cadena = "";

            foreach(int i in numeros)
            {
                cadena = cadena + " " + i.ToString();

                MessageBox.Show(cadena);

            }

            string resultado;

            int[,] matriz = new int[3,3];

            matriz[0,0] = 1; matriz[0,1] = 2; matriz[0,2] = 3; 
            matriz[1,0] = 4; matriz[1,1] = 5; matriz[1,2] = 6;
            matriz[2,0] = 7; matriz[2,1] = 8; matriz[2,2] = 9;

          //  matriz.GetLength(0)
            for (int fila = 0; fila < matriz.GetLength(0); fila++)
            {
                for (int col = 0; col < matriz.GetLength(1); col++)
                {
                    Console.WriteLine(" En (" + fila.ToString() + "," + col.ToString() + ") es " + matriz[fila, col].ToString());
                    
                }
            }


            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FMain());
        }
    }
}
