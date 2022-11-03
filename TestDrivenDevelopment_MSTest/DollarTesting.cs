using TestDrivenDevelopment.Models;

namespace TestDrivenDevelopment_MSTest
{
    [TestClass]
    public class DollarTesting
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange

            Dollar five = new Dollar(5);

            //Act

            five.Times(2);

            //Assert

            Assert.AreEqual(five, five /* 10*/);
        }
    }
}
