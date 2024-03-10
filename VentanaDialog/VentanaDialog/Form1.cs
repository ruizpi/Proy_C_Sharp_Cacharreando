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

namespace VentanaDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BOTABRIR_Click(object sender, EventArgs e)
        {
            try { 

                openFileDialog1.Title = "Busca tu archivo";
                openFileDialog1.ShowDialog();

                if (File.Exists(openFileDialog1.FileName)){
                
                    string texto = openFileDialog1.FileName;    

                    TextReader Leer = new StreamReader(texto);

                    RichTextBox.Text = Leer.ReadToEnd();
                    Leer.Close(); 

                    EDDireccion.Text = texto;



                }
            }
            catch (Exception){

                MessageBox.Show("error al abrir");
            }

        }

        private void BOTGUARDAR_Click(object sender, EventArgs e)
        {
  

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(saveFileDialog1.FileName)) {
                        string txt = saveFileDialog1.FileName;

                        StreamWriter textoaguardar = new StreamWriter(txt);
                        textoaguardar.Write(RichTextBox.Text);
                        textoaguardar.Flush();
                        textoaguardar.Close();

                        EDDireccion.Text= txt;


                    }
                    else
                    {

                        string txt = saveFileDialog1.FileName;

                        StreamWriter textoaguardar = new StreamWriter(txt);
                        textoaguardar.Write(RichTextBox.Text);
                        textoaguardar.Flush();
                        textoaguardar.Close();

                        EDDireccion.Text = txt;



                    }


            }
                


        }
    }
}
