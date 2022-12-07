namespace TestDrivenDevelopment.Models
{
    public class Dollar : Money
    {
        //private int _amount;//This started out as public. It changed when test: Privacy_InlineTemporaryVariable_product()
                            //was established since this class is now the only class using _amount.

        public Dollar(int amount)
        {
            _amount = amount;
        }

        public Dollar Times(int multiplier)
        {
            //_amount *= multiplier; Was return null to get it to compile; then became new Dollar();
            return new Dollar(_amount * multiplier);
        }
    }
}
