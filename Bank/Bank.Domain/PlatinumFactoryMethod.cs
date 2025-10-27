namespace Bank.Domain
{
    /// <summary>
    /// Implementación concreta del Factory Method para crear tarjetas Platinum Plus.
    /// Esta clase se encarga de la creación específica de tarjetas Platinum Plus.
    /// </summary>
    public class PlatinumFactoryMethod: CreditCardFactoryMethod
    {
        /// <summary>
        /// Crea una nueva instancia de tarjeta Platinum Plus.
        /// </summary>
        /// <returns>Una nueva instancia de Platinum.</returns>
        protected override ICreditCard MakeProduct()
        {
            ICreditCard product = new Platinum();
            return product;
        }
    }
}