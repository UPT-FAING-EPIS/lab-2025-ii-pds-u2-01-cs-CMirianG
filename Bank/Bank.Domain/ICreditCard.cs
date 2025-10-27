namespace Bank.Domain
{
    /// <summary>
    /// Interfaz que define el contrato para las tarjetas de crédito del banco.
    /// Implementa el patrón Factory Method para la creación de diferentes tipos de tarjetas.
    /// </summary>
    public interface ICreditCard
    {
        /// <summary>
        /// Obtiene el tipo de tarjeta de crédito.
        /// </summary>
        /// <returns>El nombre del tipo de tarjeta de crédito.</returns>
        string GetCardType();
        
        /// <summary>
        /// Obtiene el límite de crédito de la tarjeta.
        /// </summary>
        /// <returns>El límite de crédito en unidades monetarias.</returns>
        int GetCreditLimit();
        
        /// <summary>
        /// Obtiene el cargo anual de la tarjeta de crédito.
        /// </summary>
        /// <returns>El cargo anual en unidades monetarias.</returns>
        int GetAnnualCharge();
    }
}

