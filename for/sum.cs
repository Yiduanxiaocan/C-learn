using System;
namespace Sum
{
    class Caculate
    {
        static void Main(string[]args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            /*while(num>=0)
            {
                sum += num;
                num--;
            }
            Console.WriteLine(sum);*/
            do
            {
                sum += num;
                num--;
            } while (num > 0);
            Console.WriteLine(sum);
        }
    }
}