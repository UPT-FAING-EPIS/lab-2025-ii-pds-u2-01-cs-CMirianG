namespace Bank.Domain
{
    public class TitaniumFactoryMethod : CreditCardFactoryMethod
    {
        protected override ICreditCard MakeProduct()
        {
            ICreditCard product = new Titanium();
            return product;
        }
    }
}