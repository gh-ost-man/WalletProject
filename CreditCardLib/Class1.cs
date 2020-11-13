using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardLib
{
    public class CreditCard
    {
        public int ID { get; set; } = 7;
        public string Name { get; set; } = "Albert";

        public override string ToString()
        {
            return $"ID: {ID}\n" +
                $"Name: {Name}";
        }
    }
}
