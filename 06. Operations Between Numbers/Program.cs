using System;

namespace _06._Operations_Between_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());

            if (symbol == '+' || symbol == '-' || symbol == '*')
            {
                int result;
                if (symbol == '+')
                {
                    result = N1 + N2;
                }
                else if (symbol == '-')
                {
                    result = N1 - N2;
                }
                else
                { 
                      result = N1 * N2; 
                }

                string evenOrOdd = "odd";
                if (result % 2 == 0)
                {
                    evenOrOdd = "even";
                }

                Console.WriteLine($"{N1} {symbol} {N2} = {result} - {evenOrOdd}");
            }
            else
            {
                if (N2 == 0)
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                }
                else if (symbol == '/')
                {
                    Console.WriteLine($"{N1} / {N2} = {(double)N1 / N2:f2}");
                }
                else
                {
                    Console.WriteLine($"{N1} % {N2} = {N1%N2}");
                }
            }
        }
    }
}
