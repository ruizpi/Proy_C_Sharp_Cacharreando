using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Productos;

namespace POOPractica1
{



    public partial class Form1 : Form
    {
       

        Telefono MiTelefono = new Telefono();
        Telefono MiTelefono2 = new Telefono("Samsung","Verde","4G");
        Telefono MiTelefono3 = new Telefono("Teclast");




        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BTNOK_Click(object sender, EventArgs e)
        {
            // Movistar.Llamar();
            MessageBox.Show(MiTelefono.Color);
            MiTelefono.Color = "Gris";
            MessageBox.Show(MiTelefono.Color);

            MessageBox.Show(MiTelefono2.Marca);

            MessageBox.Show(MiTelefono3.Marca);


            MessageBox.Show(Operaciones.Suma(100, 250).ToString());

           

        }
    }
}
