using System;
using System.Globalization;

namespace Softuni_Coffee_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            decimal totalPrice = 0.0m;

            for (int i = 0; i < count; i++)
            {
                var pricePerCapsule = decimal.Parse(Console.ReadLine());
                var orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                var capsulesCount = int.Parse(Console.ReadLine());
                var price = 0.0m;

                var daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);

                price = daysInMonth * pricePerCapsule * capsulesCount;

                Console.WriteLine($"The price for the coffee is: ${price:f2}");

                totalPrice += price;
            }

            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
