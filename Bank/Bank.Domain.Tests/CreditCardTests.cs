using Bank.Domain;
using NUnit.Framework;

namespace Bank.Domain.Tests
{
    public class CreditCardTests
    {
        [Test]
        public void GivenCreditTypeSelected_WhenRequestCreditCard_ThenNewValidCreditCard()
        {
            string cardType = "MoneyBack";
            ICreditCard? cardDetails = CreditCardFactory.GetCreditCard(cardType);
            Assert.That(cardDetails, Is.Not.Null);
            Assert.That(cardDetails!.GetCardType(), Is.Not.Empty);
            Assert.That(cardDetails.GetCreditLimit(), Is.GreaterThanOrEqualTo(0));
            Assert.That(cardDetails.GetAnnualCharge(), Is.GreaterThanOrEqualTo(0));
        }
    }
}

