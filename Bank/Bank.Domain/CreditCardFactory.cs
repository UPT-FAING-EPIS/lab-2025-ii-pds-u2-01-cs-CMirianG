namespace Bank.Domain
{
    public class CreditCardFactory
    {
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

