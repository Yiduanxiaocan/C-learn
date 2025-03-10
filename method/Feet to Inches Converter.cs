using System;
namespace Convert_Inches
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double foot = Convert.ToDouble(Console.ReadLine());
            Converts(foot);
        }
        static void Converts(double foot)
        {
            double inches = foot * 12;
            Console.WriteLine(inches);
        }
    }
}