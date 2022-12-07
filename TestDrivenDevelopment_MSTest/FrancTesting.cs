
using TestDrivenDevelopment.Models;

namespace TestDrivenDevelopment_MSTest
{
    [TestClass]
    public class FrancTesting
    {
        [TestMethod]
        public void FranklySpeaking_product_TestingMultiplication()
        {
            //Arrange
            Franc five = new Franc(5);

            //Act

            //Assert
            Assert.AreEqual(new Franc(10), five.Times(2));
            //Assert            
            Assert.AreEqual(new Franc(15), five.Times(3));

        }

        [TestMethod]
        public void EqualityForAll_TestEquality()//This test was put in before Equality() was moved to base class Money
        {
            //Arrange

            //Act            

            //Assert

            Assert.IsTrue(new Dollar(5).Equals(new Dollar(5)));
            Assert.IsFalse(new Dollar(5).Equals(new Dollar(6)));

            Assert.IsTrue(new Franc(5).Equals(new Franc(5)));
            Assert.IsFalse(new Franc(5).Equals(new Franc(6)));

        }
    }
}
