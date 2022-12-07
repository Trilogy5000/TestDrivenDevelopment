using TestDrivenDevelopment.Models;

namespace TestDrivenDevelopment_MSTest
{
    [TestClass]
    public class DollarTesting
    {
        //[TestMethod]
        //public void AddingAmountFieldToDollar_RemovingDependencyAndDuplicationFromDollar() //$5 * 2(multiplier) = 10 ...
        //{
        //    //Arrange

        //    Dollar five = new Dollar(5);

        //    //Act
        //    five.Times(2);

        //    //Assert

        //    Assert.AreEqual(10, five._amount /* 10*/); //This became untestable when "amount" went private.
        //}

        //[TestMethod]
        //public void DegenerateObjects_GettingRidOfSideEffects_2()
        //{
        //    ////Arrange
        //    //Dollar five = new Dollar(5);
        //    ////Act
        //    //five.Times(2);
        //    //Assert.AreEqual(10, five._amount);//changed to private
        //    //five.Times(3);
        //    ////Assert            
        //    //Assert.AreEqual(15, five._amount);//changed to private

        //    //The below was commented out when _amount went private instead of public

        //    ////Arrange
        //    //Dollar five = new Dollar(5);
        //    //Dollar product = five.Times(2);
        //    ////Act            
        //    //Assert.AreEqual(10, product._amount);
        //    //product = five.Times(3);
        //    ////Assert            
        //    //Assert.AreEqual(15, product._amount);

        //}

        [TestMethod]
        public void EqualityForAll_TestEquality()
        {            
            //Arrange
            
            //Act            
                        
            //Assert

            Assert.IsTrue(new Dollar(5).Equals(new Dollar(5)));

            Assert.IsFalse(new Dollar(5).Equals(new Dollar(6)));

        }

        [TestMethod]
        public void Privacy_ComparingObjectsToOneAnother()
        {
            ////Arrange
            //Dollar five = new Dollar(5);
            ////Act
            //five.Times(2);
            //Assert.AreEqual(10, five._amount);
            //five.Times(3);
            ////Assert            
            //Assert.AreEqual(15, five._amount);



            //Assert.AreEqual(expected, actual);

            //Arrange
            Dollar five = new Dollar(5);
            Dollar product = five.Times(2);
            //Act            
            Assert.AreEqual(new Dollar(10), product);

            product = five.Times(3);
            //Assert            
            Assert.AreEqual(new Dollar(15), product);

        }

        [TestMethod]
        public void Privacy_InlineTemporaryVariable_product_TestingMultiplication()
        {            
            //Arrange
            Dollar five = new Dollar(5);

            //Act            


            //Assert.AreEqual(expected, actual);

            //Assert
            Assert.AreEqual(new Dollar(10), five.Times(2));                        
            //Assert            
            Assert.AreEqual(new Dollar(15), five.Times(3));
        }



        //Need to find out where the last test above came from!!


        [TestMethod]
        public void ApplesAndOranges_TestingDollarsAndFrancs_orTestEquality()
        {
            //Arrange
            Dollar five = new Dollar(5);

            //Act            


            //Assert.AreEqual(expected, actual);

            //Assert
            Assert.IsTrue(new Dollar(5).Equals(new Dollar(5)));
            //Assert            
            Assert.IsFalse(new Dollar(5).Equals(new Dollar(6)));
            //Assert
            Assert.IsTrue(new Franc(5).Equals(new Franc(5)));
            //Assert            
            Assert.IsFalse(new Franc(5).Equals(new Franc(6)));
            //Assert            
            Assert.IsFalse(new Franc(5).Equals(new Dollar(5)));
        }

    }
}
