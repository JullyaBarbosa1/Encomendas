using EX0Tutorial5.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX0Tutorial5.Entities
{
    internal class Order
    {

        private List<OrderItem> listaItems = new List<OrderItem>();
        private DateTime moment;
        private OrderStatus orderStatus;
        private Client client;

        public Order(DateTime moment, OrderStatus orderStatus, Client client)
        {
            this.moment = moment;
            this.orderStatus = orderStatus;
            this.client = client;
        }
        public void AddItem(OrderItem orderItem) 
        {
        
        listaItems .Add(orderItem);

        }

        public void RemoverItem(OrderItem orderItem) 
        {
        
            listaItems.Remove(orderItem);

        }
        public override string ToString()
        {
            string res = "2";

            return $"\n\nDADOS DA ENCOMENDA:" +
                $"\n{client.ToString()}" +
                $"\n Data/hora:{moment.ToLongDateString()}/{moment.ToShortTimeString()}" +
                $"\nEstado da encomenda: {(OrderStatus)orderStatus}" +
                $"\n{res}";
        }
    }
}
