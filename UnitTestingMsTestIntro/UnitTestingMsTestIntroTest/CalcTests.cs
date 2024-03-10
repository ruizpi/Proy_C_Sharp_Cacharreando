using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingMsTestIntro;


namespace UnitTestingMsTestIntroTest
{
    [TestClass]
    public class CalcTests
    {

        [DataRow(3,4,7)]
        [TestMethod]
        public void SumTestReturnSameValueEs3(int a, int b, int expected)
        {
            // ARRANGE

            // ACT
            int resultado = UnitTestingMsTestIntro.Program.Calcs.Sum(a, b);

            // ASSERT
            NUnit.Framework.Assert.AreEqual(expected, resultado);
           
        }


        [TestMethod]
        public void GetCustomer_ShouldBeTheSame()
        {
            // ARRANGE
            Customer[] clientes = new Customer[2] {
                                        new Customer{ FirstName="Emilio", LastName="minio" },
                                        new Customer{ FirstName="Fulgencio",LastName="Tuis"}
            };

            int index = 1;
            Customer expected = clientes[1];

            // ACT
            Customer actual = CollectionsSample.GetCustomer(clientes, index);

            // ASSERT
            
            NUnit.Framework.Assert.IsInstanceOf<Customer>(actual);
            NUnit.Framework.Assert.AreEqual(expected, actual);


          
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void GetCustomer_ShouldThrowIndexOutOfRangeException()
        {
            // ARRANGE

            Customer[] clientes = new Customer[2] {
                                        new Customer{ FirstName="Emilio", LastName="minio" },
                                        new Customer{ FirstName="Fulgencio",LastName="Tuis"}
            };

            int index = 3;



            // ACT

            CollectionsSample.GetCustomer(clientes, index);

            Customer cliente = clientes[index];



            // ASSERT



        }
    }
}
