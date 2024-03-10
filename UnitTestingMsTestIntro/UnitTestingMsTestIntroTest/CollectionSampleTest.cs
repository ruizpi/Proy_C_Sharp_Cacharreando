using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingMsTestIntro;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace UnitTestingMsTestIntroTest
{
    [TestClass]
    public class CollectionSampleTest
    {
        [DataRow("Remigio")]
        [TestMethod]
        public void FirstNameTest(string firstname)
        {
            // ARRANGE
            Customer customer = new Customer();

            // ACT
            customer.FirstName = firstname;


            // ASSERT
            Assert.IsTrue(customer.FirstName == firstname);
            
        }
    }
}
