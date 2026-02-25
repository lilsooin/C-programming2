using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public static class RestaurantBillCalculator
    {
        public static double CalculateTotalCost(StreamReader input)
        {
            Console.WriteLine("first food price: ");
            double price = double.Parse(input.ReadLine());

            Console.WriteLine("second food price: ");
            price += double.Parse(input.ReadLine());

            Console.WriteLine("third food price: ");
            price += double.Parse(input.ReadLine());

            Console.WriteLine("fourth food price: ");
            price += double.Parse(input.ReadLine());

            Console.WriteLine("fifth food price: ");
            price += double.Parse(input.ReadLine());

            Console.WriteLine("tip percent: ");
            int tipRate = int.Parse(input.ReadLine());

            double taxRate = 5;
            double tax = price * taxRate / 100;
            double tip = (price + tax) * tipRate / 100;
            double totalPrice = (int)((price + tax + tip) * 100 + 0.5) / 100.0;

            Console.WriteLine($"total = {price}");
            Console.WriteLine($"tax = ({price}) x {taxRate / 100} = {tax}");
            Console.WriteLine($"tip = ({price} + {tip}) x {tipRate} / 100 = {tip}");
            Console.WriteLine($"total price = {price} + {tax} + {tip} = {totalPrice}");

            return totalPrice;
        }

        public static double CalculateIndividualCost(StreamReader input, double totalCost)
        {
            int count = int.Parse(input.ReadLine());
            double result = (int)(totalCost / count * 100 + 0.5) / 100.0;

            return result;
        }

        public static uint CalculatePayerCount(StreamReader input, double totalCost)
        {
            double amount = double.Parse(input.ReadLine());
            uint count = (uint)Math.Ceiling(totalCost / amount);
            

            Console.WriteLine("count: " + count);

            return count;
        }
    }
}
