using System;
namespace Area_rectangle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int width = Convert.ToInt32(Console.ReadLine());
            int length = Convert.ToInt32(Console.ReadLine());
            //int result = Area(width,length);
            int result = width * length;
            Console.WriteLine(result);
        }
       /* public static int Area(int width,int length)
        {
            int Result = width * length;
            return Result;
        }*/
    }
}