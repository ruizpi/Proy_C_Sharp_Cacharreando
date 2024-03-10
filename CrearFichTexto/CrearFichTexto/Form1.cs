using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CrearFichTexto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BOTESCRIBIR_Click(object sender, EventArgs e)
        {
            TextWriter Escribe = new StreamWriter("Test.txt");
            Escribe.WriteLine("Hola Mundo!");
            Escribe.Close();

            TextWriter Agregar = File.AppendText("Test.txt");
            Agregar.WriteLine("Nueva linea agregada");
            Agregar.Close();




            MessageBox.Show("Hecho");
        }

        private void BOTLEER_Click(object sender, EventArgs e)
        {
            TextReader Leer = new StreamReader("Test.txt");

            
            //MessageBox.Show(Leer.ReadLine());
            MessageBox.Show(Leer.ReadToEnd());

            Leer.Close();
        }
    }
}
