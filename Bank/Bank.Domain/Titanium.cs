namespace Bank.Domain
{
    /// <summary>
    /// Implementación de tarjeta de crédito Titanium Edge.
    /// Esta tarjeta ofrece un límite de crédito intermedio con beneficios premium.
    /// Diseñada para usuarios con buen historial crediticio que buscan más beneficios.
    /// </summary>
    public class Titanium : ICreditCard
    {
        /// <summary>
        /// Obtiene el tipo de tarjeta Titanium Edge.
        /// </summary>
        /// <returns>El nombre "Titanium Edge" como tipo de tarjeta.</returns>
        public string GetCardType()
        {
            return "Titanium Edge";
        }
        
        /// <summary>
        /// Obtiene el límite de crédito para la tarjeta Titanium Edge.
        /// </summary>
        /// <returns>El límite de crédito de $25,000.</returns>
        public int GetCreditLimit()
        {
            return 25000;
        }
        
        /// <summary>
        /// Obtiene el cargo anual para la tarjeta Titanium Edge.
        /// </summary>
        /// <returns>El cargo anual de $1,500.</returns>
        public int GetAnnualCharge()
        {
            return 1500;
        }
    }
}

