using System;
using System.Diagnostics;

namespace _09._Ski_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int daysVacation  = int.Parse(Console.ReadLine())-1;
            string typeRoom = Console.ReadLine();       
            string evaluation = Console.ReadLine();
            double priceRoom = 18;
            double priceApartment = 25;
            double pricePresident = 35;
            double sum = 0;

            if (typeRoom == "room for one person")
            {
                sum = daysVacation * priceRoom;            }
            else if (typeRoom == "apartment")
            {
                if (daysVacation < 11)
                {
                    sum = daysVacation * priceApartment;
                    sum = sum*0.7;
                }
                else if (daysVacation < 16)
                {
                    sum = daysVacation * priceApartment;
                    sum = sum*0.65;
                }
                else
                {
                    sum = daysVacation * priceApartment;
                    sum = sum * 0.5;
                }
            }
            else if (typeRoom == "president apartment")
            {
                if (daysVacation < 11)
                {
                    sum = daysVacation * pricePresident;
                    sum = sum * 0.9;
                }
                else if (daysVacation < 16)
                {
                    sum = daysVacation * pricePresident;
                    sum = sum*0.85;
                }

                else
                {
                    sum = daysVacation * pricePresident;
                    sum = sum * 0.8;
                }
            }

            if (evaluation == "positive")
            {
                sum = sum + sum * 0.25;
            }
            else if (evaluation == "negative")
            {
                sum = sum * 0.9;
            }

            Console.WriteLine($"{sum:f2}");

        }
    }
}
