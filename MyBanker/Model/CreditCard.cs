using System;
using MyBanker.Utils;

namespace MyBanker.Model
{
    internal abstract class CreditCard : ICard
    {
        protected string cardHolderName { get; set; }
        protected string cardNumber { get; set; }
        protected string accountNumber { get; set; }
        protected DateTime expiryDate { get; set; }

        public CreditCard(string cardHolderName)
        {
            this.cardHolderName = cardHolderName;
            accountNumber = GenerateAccountNumber();
        }
        protected string GenerateAccountNumber()
        {
            Random random = new Random();
            return "3520" + random.Next(100000000, 999999999).ToString();
        }

        public abstract void GenerateCardNumber();
    }
}
