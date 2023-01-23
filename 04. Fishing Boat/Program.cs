using System;

namespace _03._New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine(); 
            int fishermen = int.Parse(Console.ReadLine());

            double price = 0;
         
            if (season == "Spring")
            {
                price = 3000;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                price = 4200;
            }
            else
            {
                price = 2600;
            }

            if (fishermen <= 6)
            {
                price = price * 0.9;
            }
            else if (fishermen <= 11)
            {
                price = price * 0.85;
            }
            else if (fishermen > 12)
            {
                price = price * 0.75;
            }

            if (fishermen % 2 == 0 && season != "Autumn")
            {
                price = price * 0.95;
            }
            
            if (price <= budget)
            {
                double difference = budget - price;
                Console.WriteLine($"Yes! You have {difference:f2} leva left.");
            }
            else
            {
                double moneyneeded = price - budget;
                Console.WriteLine($"Not enough money! You need {moneyneeded:f2} leva.");
            }


        }
    }
}
