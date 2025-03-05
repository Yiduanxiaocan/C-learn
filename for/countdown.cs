using System;
namespace Countdown
{
    class Program
    {
        static void Main(string[]args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine(number);
                number--;
            }while(number >= 0);
        }
    }
}