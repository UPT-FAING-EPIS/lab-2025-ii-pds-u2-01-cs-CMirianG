namespace Bank.Domain
{
    /// <summary>
    /// Clase abstracta que implementa el patrón Factory Method para crear tarjetas de crédito.
    /// Define el esqueleto del algoritmo de creación, delegando la creación específica a las subclases.
    /// </summary>
    public abstract class CreditCardFactoryMethod
    {
        /// <summary>
        /// Método abstracto que debe ser implementado por las subclases para crear el producto específico.
        /// </summary>
        /// <returns>Una instancia de ICreditCard del tipo específico.</returns>
        protected abstract ICreditCard MakeProduct();
        
        /// <summary>
        /// Método template que define el algoritmo de creación de tarjetas de crédito.
        /// También contiene lógica de negocio que depende de los objetos Product devueltos por el factory method.
        /// </summary>
        /// <returns>Una instancia de ICreditCard creada por la subclase específica.</returns>
        /// <remarks>
        /// La responsabilidad principal del Creator no es crear productos.
        /// Usualmente contiene lógica de negocio central que depende de los objetos Product devueltos por el factory method.
        /// </remarks>
        public ICreditCard CreateProduct()
        {
            // Llama al MakeProduct que creará y retornará el objeto apropiado
            ICreditCard creditCard = this.MakeProduct();
            // Retorna el objeto al cliente
            return creditCard;
        }
    }
}
