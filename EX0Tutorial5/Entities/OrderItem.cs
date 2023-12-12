using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX0Tutorial5.Entities
{
    internal class OrderItem
    {
        private Product produto;
        private int quantity;
        private double price;

        public OrderItem(Product produto, int quantity, double price)
        {
            this.produto = produto;
            this.quantity = quantity;
            this.price = price;
        }
        public override string ToString()
        {
                return $"Dados do item encomendado:" +
                $"\n\tProduto:{produto.ToString()}" +
                $"\n\tQuantidade:{quantity}," +
                $"\n\tPreço:{price:f2}";
        }
    }
}
