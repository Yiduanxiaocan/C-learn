using System;
namespace Welcome_sololearner
{
    class Program
    {
        static void Main()
        {
            Welcome();
        }
        static void Welcome()
        {
            string? name = Console.ReadLine();
            if (name != null)
            {
                Console.WriteLine($"Welcome, {name}!");
            }
            else
            {
                Console.WriteLine("Welcome, guest!");
            }
        }
    }
}