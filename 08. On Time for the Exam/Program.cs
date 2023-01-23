using System;

namespace _08._On_Time_for_the_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minutesExam = int.Parse(Console.ReadLine());
            int hourArrival = int.Parse(Console.ReadLine());
            int minutesArrival = int.Parse(Console.ReadLine());

            minutesExam = hourExam * 60 + minutesExam;
            minutesArrival = hourArrival* 60 + minutesArrival;

            int difference = minutesExam - minutesArrival;

            if (difference <0)
            {
                Console.WriteLine("Late");
                if (difference > -60)
                {
                    Console.WriteLine($"{Math.Abs(difference)} minutes after the start");
                }
                else
                { 
                    Console.WriteLine($"{Math.Abs(difference/60)}:{Math.Abs(difference%60):d2} hours after the start");

                }

            }
            else if (difference >= 0 && difference <= 30)
            {
                Console.WriteLine("On time");
                if (difference>0)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
            }
            else
            {
                Console.WriteLine("Early");
                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
                else
                { 
                    Console.WriteLine($"{difference/60}:{difference%60:d2} hours before the start");

                }
            }            
        }
    }
}
