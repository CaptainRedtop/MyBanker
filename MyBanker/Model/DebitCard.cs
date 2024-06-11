using System;
using MyBanker.Utils;

namespace MyBanker.Model
{
    internal class DebitCard : CreditCard
    {
        public DebitCard(string cardHolderName) : base(cardHolderName)
        {
            ExpiryDate = DateTime.MaxValue; // No expiry date
            GenerateCardNumber();
        }

        public override void GenerateCardNumber()
        {
            Random random = new Random();
            CardNumber = "2400" + random.Next(1000000000000, 9999999999999).ToString();
        }

    }
}
