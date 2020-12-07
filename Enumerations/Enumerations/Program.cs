using Enumerations.Entities;
using Enumerations.Entities.Enums;
using System;

namespace Enumerations
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
            Console.WriteLine(order);// OUTPUT: 1080, 07/12/2020 19:56:06, PendingPayment

            // Conversions 

            //string-enum:
            string txt = OrderStatus.PendingPayment.ToString();
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(os); //OUTPUT: Delivered
            Console.WriteLine(txt); //OUTPUT: PendingPayment

            /*For original type: use casting -->
            
            OrderStatus os1 = (OrderStatus)2;
            int n1 = (int)OrderStatus.Processing; 
            */
        }
    }
}
