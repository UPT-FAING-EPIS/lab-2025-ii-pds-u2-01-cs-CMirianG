namespace Bank.Domain
{
    /// <summary>
    /// Factory estático que implementa el patrón Factory para crear tarjetas de crédito.
    /// Permite crear diferentes tipos de tarjetas basándose en el tipo especificado.
    /// </summary>
    public class CreditCardFactory
    {
        /// <summary>
        /// Crea una nueva tarjeta de crédito basándose en el tipo especificado.
        /// </summary>
        /// <param name="cardType">El tipo de tarjeta a crear. Valores válidos: "MoneyBack", "Titanium", "Platinum".</param>
        /// <returns>Una instancia de ICreditCard del tipo especificado, o null si el tipo no es válido.</returns>
        /// <example>
        /// <code>
        /// ICreditCard card = CreditCardFactory.GetCreditCard("MoneyBack");
        /// if (card != null)
        /// {
        ///     Console.WriteLine($"Tipo: {card.GetCardType()}");
        ///     Console.WriteLine($"Límite: {card.GetCreditLimit()}");
        /// }
        /// </code>
        /// </example>
        public static ICreditCard? GetCreditCard(string cardType)
        {
            ICreditCard? cardDetails = null;
            if (cardType == "MoneyBack")
            {
                cardDetails = new MoneyBack();
            }
            else if (cardType == "Titanium")
            {
                cardDetails = new Titanium();
            }
            else if (cardType == "Platinum")
            {
                cardDetails = new Platinum();
            }
            return cardDetails; 
        }
    }
}

