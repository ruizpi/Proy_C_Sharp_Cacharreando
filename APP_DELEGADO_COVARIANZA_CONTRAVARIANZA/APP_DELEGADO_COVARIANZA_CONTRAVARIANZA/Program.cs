using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace APP_DELEGADO_COVARIANZA_CONTRAVARIANZA
{

    public delegate Vehiculo covariance();
    public delegate void contravariance(RollsRoyce rr);

    class Program
    {
        static void Main(string[] args)
        {


            // CONTRAVARIANZA
            // NOS PERMITE QUE UN DELEGADO DE CIERTO TIPO PUEDA HACER REFERENCIA A UN METODO CON UN TIPO MENOS DERIVADO QUE EL QUE ESTÁ DEFINIDO EN EL DELEGADO
            Console.WriteLine("1");
            RollsRoyce r = new RollsRoyce();
            contravariance d2 = DContraRR;
            d2(r);


            // COVARIANZA


        }
    
        static void DContraRR(Vehiculo v)
        {
            Console.WriteLine(v.ToString());
        }

    }



}
