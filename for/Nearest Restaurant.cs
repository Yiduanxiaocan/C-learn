using System;
namespace Nearest_restaurant
{
    public class Select_restaurant
    {
        public static void Main(string[] args)
        {
            int floors = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= floors; i++)
            {
                if (0 != i % 5)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}