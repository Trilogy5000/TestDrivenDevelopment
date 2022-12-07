namespace TestDrivenDevelopment.Models
{
    public class Money
    {
        internal int _amount;

        public override Boolean Equals(System.Object? _object)
        {

            Money? money = _object as Money; //newer way to cast

            return _amount == money?._amount && GetType().Equals(money.GetType());

            //return base.Equals(_object);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
