using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessCardLib;
using CreditCardLib;
using MoneyLib;

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

            Console.WriteLine(new string('-',50));
            Console.WriteLine(bc);
            Console.WriteLine(new string('-', 50));

<<<<<<< HEAD
=======
            Console.WriteLine(new string('-', 50));
            Console.WriteLine(creditCard);
            Console.WriteLine(new string('-', 50));

>>>>>>> b3ff8232539bcef7bc342fde4cc2276934875857
            Console.WriteLine(new string('-', 50));
            Console.WriteLine(money);
            Console.WriteLine(new string('-', 50));

            Console.WriteLine(new string('-', 50));
            Console.WriteLine(money);
            Console.WriteLine(new string('-', 50));
        }
    }
}
