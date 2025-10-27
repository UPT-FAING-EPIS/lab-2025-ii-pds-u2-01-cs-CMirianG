namespace Bank.Domain
{
    public class MoneyBackFactoryMethod : CreditCardFactoryMethod
    {
        protected override ICreditCard MakeProduct()
        {
            ICreditCard product = new MoneyBack();
            return product;
        }
    }
}