using Microsoft.VisualStudio.TestPlatform.TestHost;


namespace MsTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {

            //Assert.Pass();
            string result = AuthTesting.Program.Something();

            // ASSERT
            Assert.AreEqual("algo", result);
        
        }

        [Test]
        public void LoginTestTrue()
        {
            bool result = AuthTesting.Program.Login("mamon", "tus muertos");

            Assert.IsTrue(result);

        }

        [Test]
        public void LoginTestFalse()
        {
            bool result = AuthTesting.Program.Login("mamon2", "tus muertos");

            Assert.IsFalse(result);

        }

    }
}