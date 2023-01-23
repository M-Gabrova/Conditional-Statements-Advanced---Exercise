using System;

namespace _07.HotelRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();

            int nightsCount = int.Parse(Console.ReadLine());

            double studioSum = 0;

            double apartmentSum = 0;

            if ((season == "May") || (season == "October"))
            {
                double studioPrice = 50;
                studioSum = studioPrice * nightsCount;

                double apartmentPrice = 65;
                apartmentSum = apartmentPrice * nightsCount;

                if (nightsCount > 14)
                {
                    studioSum *= 0.7;

                    apartmentSum *= 0.9;
                }

                else if (nightsCount > 7)
                {
                    studioSum *= 0.95;
                }
            }

            else if ((season == "June") || (season == "September"))
            {
                double studioPrice = 75.2;
                studioSum = studioPrice * nightsCount;

                double apartmentPrice = 68.7;
                apartmentSum = apartmentPrice * nightsCount;

                if (nightsCount > 14)
                {
                    studioSum *= 0.8;

                    apartmentSum *= 0.9;
                }
            }

            else if ((season == "July") || (season == "August"))
            {
                double studioPrice = 76;
                studioSum = studioPrice * nightsCount;

                double apartmentPrice = 77;
                apartmentSum = apartmentPrice * nightsCount;

                if (nightsCount > 14)
                {
                    apartmentSum *= 0.9;
                }
            }

            Console.WriteLine($"Apartment: {apartmentSum:f2} lv.");
            Console.WriteLine($"Studio: {studioSum:f2} lv.");
        }
    }
}

