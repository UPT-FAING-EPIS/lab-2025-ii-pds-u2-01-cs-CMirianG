namespace Bank.Domain
{
    /// <summary>
    /// Implementación concreta del Factory Method para crear tarjetas MoneyBack.
    /// Esta clase se encarga de la creación específica de tarjetas MoneyBack.
    /// </summary>
    public class MoneyBackFactoryMethod : CreditCardFactoryMethod
    {
        /// <summary>
        /// Crea una nueva instancia de tarjeta MoneyBack.
        /// </summary>
        /// <returns>Una nueva instancia de MoneyBack.</returns>
        protected override ICreditCard MakeProduct()
        {
            ICreditCard product = new MoneyBack();
            return product;
        }
    }
}