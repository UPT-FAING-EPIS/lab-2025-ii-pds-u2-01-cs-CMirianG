namespace Bank.Domain
{
    /// <summary>
    /// Implementación de tarjeta de crédito MoneyBack.
    /// Esta tarjeta ofrece un límite de crédito moderado con un cargo anual bajo.
    /// Ideal para usuarios que buscan una tarjeta básica con beneficios de cashback.
    /// </summary>
    public class MoneyBack : ICreditCard
    {
        /// <summary>
        /// Obtiene el tipo de tarjeta MoneyBack.
        /// </summary>
        /// <returns>El nombre "MoneyBack" como tipo de tarjeta.</returns>
        public string GetCardType()
        {
            return "MoneyBack";
        }
        
        /// <summary>
        /// Obtiene el límite de crédito para la tarjeta MoneyBack.
        /// </summary>
        /// <returns>El límite de crédito de $15,000.</returns>
        public int GetCreditLimit()
        {
            return 15000;
        }
        
        /// <summary>
        /// Obtiene el cargo anual para la tarjeta MoneyBack.
        /// </summary>
        /// <returns>El cargo anual de $500.</returns>
        public int GetAnnualCharge()
        {
            return 500;
        }
    }
}

