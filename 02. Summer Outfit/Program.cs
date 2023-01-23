using System;

namespace _02._Summer_Outfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();
            string clothing = string.Empty;
            string shoes = string.Empty;

            if (timeOfDay == "Morning")
            {
                if (degrees <= 18)
                {
                    clothing = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (degrees <= 24)
                {
                    clothing = "Shirt";
                    shoes = "Moccasins";

                }
                else
                {
                    clothing = "T-Shirt";
                    shoes = "Sandals";

                }
            }
            else if (timeOfDay == "Afternoon")
            {
                if (degrees <= 18)
                {
                    clothing = "Shirt";
                    shoes = "Moccasins";

                }
                else if (degrees <= 24)
                {
                    clothing = "T-Shirt";
                    shoes = "Sandals";

                }
                else
                {
                    clothing = "Swim Suit";
                    shoes = "Barefoot";

                }
            }
            else 
            {
                clothing = "Shirt";
                shoes = "Moccasins";
            }

            Console.WriteLine($"It's {degrees} degrees, get your {clothing} and {shoes}.");


        }
    }
}
