using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyLib
{
    public class Money
    {
        public int ID { get; set; } = 1;
        public string Name { get; set; } = "USD";
        public override string ToString()
        {
            return $"ID: {ID}\n" + $"Name: {Name}";
        }
    }
}
