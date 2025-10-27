namespace Bank.Domain
{
    public class PlatinumFactoryMethod: CreditCardFactoryMethod
    {
        protected override ICreditCard MakeProduct()
        {
            ICreditCard product = new Platinum();
            return product;
        }
    }
}