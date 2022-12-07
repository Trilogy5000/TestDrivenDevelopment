namespace TestDrivenDevelopment.Models
{
    public class Franc : Money
    {
        //private int _amount;//This started out as public. It changed when test: Privacy_InlineTemporaryVariable_product_TestMultiplication()
                            //was established since this class is now the only class using _amount.

        public Franc(int amount)
        {
            _amount = amount;
        }

        public Franc Times(int multiplier)
        {
            //_amount *= multiplier; Was return null to get it to compile; then became new Franc();
            return new Franc(_amount * multiplier);
        }
    }
}
