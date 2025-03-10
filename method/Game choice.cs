using System;
namespace Game_choice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            run(number);
        }
        static void run(int number)
        {
            if (number == 1)
            {
                Console.WriteLine("Shooter");
            }
            else if (number == 2)
            {
                Console.WriteLine("Puzzle");
            }
            else if (number == 3)
            {
                Console.WriteLine("Snake");
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }
        }

    }
}
