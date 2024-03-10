using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productos
{


    class Telefono
    {
        private string marca;
        private string color;
        private string tipo;

        public Telefono()
        {
            this.marca = "Apple";
            this.color = "Blanco";
            this.tipo = "S3";
        }

        public Telefono(string marca, string color = "", string tipo = "")
        {
            this.marca = marca;
            this.color = color;
            this.tipo = tipo;
        }


        public void Llamar()
        {
            System.Windows.Forms.MessageBox.Show("Hola a todos");

        }

        public void MandarMensaje()
        {

        }


        public string Marca{
            get { return this.marca; }
            set {  this.marca = value; }
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public string Tipo
        {
            get { return this.tipo; }  
            set { this.tipo = value; }  
        }

    }
}
