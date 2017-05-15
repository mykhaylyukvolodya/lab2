using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Money;
using CreditCard;
using BusinessCard;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = new Money.Money(100);
            Console.WriteLine(money.GetMoney());
            var credit = new CreditCard.CreditCard(500);
            Console.WriteLine(credit.GetSumCreditCard());
            var bcard = new BusinessCard.BusinessCard("Ar1k");
            Console.WriteLine(bcard.FindOutWhose());
            Console.WriteLine("This App is work!");
        }
    }
}
