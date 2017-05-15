using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCard
{
    public class CreditCard
    {
        public decimal amount = 0;
        private string msg = "Credit Card balanse: ";

        public string GetSumCreditCard()
        {
            return msg + amount.ToString();
        }

        public CreditCard(decimal amount)
        {
            this.amount = amount;
        }
    }
}
