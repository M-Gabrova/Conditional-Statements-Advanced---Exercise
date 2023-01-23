using System;

namespace _01._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeMovie = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int seats = rows* cols;
            double price = 0;

            if (typeMovie == "Premiere")
            {
                price = 12 ;
            }
            else if (typeMovie == "Normal")
            {
                price = 7.5;
            }
            else if (typeMovie == "Discount")
            {
                price = 5;
            }

            double income = seats * price;
            if (income > 0)
            {
                Console.WriteLine("{0:f2} leva", income);
            }
        }
    }
}
