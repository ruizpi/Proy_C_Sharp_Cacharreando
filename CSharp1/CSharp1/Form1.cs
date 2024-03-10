using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {

            string textobox = EdComida.Text;

            switch (textobox)
            {
                case "papas": MessageBox.Show("Magnificas papas");
                break;
                case "filetes": MessageBox.Show("Carne deliciosa");
                break;
                default:
                    MessageBox.Show("No está");
                break;

            }
           
                

         //   LabSaludo.Text = textobox2.ToString();

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
           Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LabSaludo_Click(object sender, EventArgs e)
        {

        }
    }
}
