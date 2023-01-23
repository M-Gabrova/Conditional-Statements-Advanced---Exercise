using System;

namespace _03._New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int flowersCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double sumRoses = flowersCount*5 ;
            double sumDahlias = flowersCount * 3.8;
            double sumTulips = flowersCount * 2.8;
            double sumNarcissus = flowersCount * 3;
            double sumGladiolus = flowersCount * 2.5;
            double sum = 0;

            if (flower == "Roses")
            {
                if (flowersCount > 80)
                {
                    sum = sumRoses * 0.9;
                }
                else
                {
                    sum = sumRoses;
                }
            }
            else if (flower == "Dahlias")
            {
                if (flowersCount > 90)
                {
                    sum = sumDahlias * 0.85;
                }
                else
                {
                    sum = sumDahlias;
                }
            }
            else if (flower == "Tulips")
            {
                if (flowersCount > 80)
                {
                    sum = sumTulips * 0.85;
                }
                else
                {
                    sum = sumTulips;
                }
            }
            else if (flower == "Narcissus")
            {
                if (flowersCount < 120)
                {
                    sum = sumNarcissus + (sumNarcissus * 0.15);
                }
                else
                {
                    sum = sumNarcissus;
                }
            }
            else if (flower == "Gladiolus")
            {
                if (flowersCount < 80)
                {
                    sum = sumGladiolus + (sumGladiolus * 0.20);
                }
                else
                {
                    sum = sumGladiolus;
                }
            }

            
            
                if (sum > budget)
                {
                    double moneyneeded = sum - budget;
                    Console.WriteLine($"Not enough money, you need {moneyneeded:f2} leva more.");
                }
                else
                { 
                    double difference = budget - sum;
                    Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flower} and {difference:f2} leva left.");
                }
            

        }
    }
}
