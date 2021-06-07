using ExemploEnum.Entities;
using ExemploEnum.Entities.Enums;
using System;

namespace ExemploEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();// Conversão de enum para string

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");// Conversão string para enum, o texto "Delivered" precisa estar escrito exatamento como no enum
            Console.WriteLine(txt);

            Console.WriteLine(os);
        }
    }
}
