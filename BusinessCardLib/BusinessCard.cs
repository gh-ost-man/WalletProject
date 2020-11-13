using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessCardLib
{
    public class BusinessCard
    {
        public int Id { get; set; } = 1;

        public string Name { get; set; } = "Ghost Hunter";

        public override string ToString()
        {
            return $"\n\nId: {Id}\nName: {Name}\n\n";
        }
    }
}
