using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX0Tutorial5.Entities
{
    internal class Product
    {
        public string Name { get; private set; }
        private double price;

        public Product(string name, double price)
        {
            this.Name = name;
            this.price = price;
        }
        public override string ToString()
        {
            return $"\nDados do Produto:" +
                $"\n\tNome:{Name}, Preço (PVP): {price:f2}";
        }
    }
}
