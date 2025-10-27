namespace Bank.Domain
{
    /// <summary>
    /// Implementación de tarjeta de crédito Platinum Plus.
    /// Esta tarjeta ofrece el límite de crédito más alto con beneficios exclusivos.
    /// Diseñada para usuarios premium con excelente historial crediticio.
    /// </summary>
    public class Platinum : ICreditCard
    {
        /// <summary>
        /// Obtiene el tipo de tarjeta Platinum Plus.
        /// </summary>
        /// <returns>El nombre "Platinum Plus" como tipo de tarjeta.</returns>
        public string GetCardType()
        {
            return "Platinum Plus";
        }
        
        /// <summary>
        /// Obtiene el límite de crédito para la tarjeta Platinum Plus.
        /// </summary>
        /// <returns>El límite de crédito de $35,000.</returns>
        public int GetCreditLimit()
        {
            return 35000;
        }
        
        /// <summary>
        /// Obtiene el cargo anual para la tarjeta Platinum Plus.
        /// </summary>
        /// <returns>El cargo anual de $2,000.</returns>
        public int GetAnnualCharge()
        {
            return 2000;
        }
    }
}

