using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessCardLib;

namespace Wallet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aloha");

            BusinessCard bc = new BusinessCard();
            CreditCard creditCard = new CreditCard();            
            Money money = new Money();
            Console.WriteLine("Test");
        }
    }
}
