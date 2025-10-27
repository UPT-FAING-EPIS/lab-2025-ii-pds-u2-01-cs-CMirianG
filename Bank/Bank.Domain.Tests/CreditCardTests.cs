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
        [Test]
        public void GivenCreditTypePlatinumChoosen_WhenRequestCreditCard_ThenNewValidCreditCard()
        {
            ICreditCard creditCard = new PlatinumFactoryMethod().CreateProduct();
            Assert.That(creditCard, Is.Not.Null);
            Assert.That(creditCard.GetCardType(), Is.Not.Empty);
            Assert.That(creditCard.GetCreditLimit(), Is.GreaterThanOrEqualTo(0));
            Assert.That(creditCard.GetAnnualCharge(), Is.GreaterThanOrEqualTo(0));
        }

        [Test]
        public void GivenCreditTypeTitaniumChoosen_WhenRequestCreditCard_ThenNewValidCreditCard()
        {
            ICreditCard creditCard = new TitaniumFactoryMethod().CreateProduct();
            Assert.That(creditCard, Is.Not.Null);
            Assert.That(creditCard.GetCardType(), Is.Not.Empty);
            Assert.That(creditCard.GetCardType(), Is.EqualTo("Titanium Edge"));
            Assert.That(creditCard.GetCreditLimit(), Is.GreaterThanOrEqualTo(0));
            Assert.That(creditCard.GetAnnualCharge(), Is.GreaterThanOrEqualTo(0));
        }
    }
}

