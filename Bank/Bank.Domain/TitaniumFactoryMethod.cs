namespace Bank.Domain
{
    /// <summary>
    /// Implementación concreta del Factory Method para crear tarjetas Titanium Edge.
    /// Esta clase se encarga de la creación específica de tarjetas Titanium Edge.
    /// </summary>
    public class TitaniumFactoryMethod : CreditCardFactoryMethod
    {
        /// <summary>
        /// Crea una nueva instancia de tarjeta Titanium Edge.
        /// </summary>
        /// <returns>Una nueva instancia de Titanium.</returns>
        protected override ICreditCard MakeProduct()
        {
            ICreditCard product = new Titanium();
            return product;
        }
    }
}