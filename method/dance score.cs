using System;
namespace Dance_score
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double score1 = Convert.ToDouble(Console.ReadLine());
            double score2 = Convert.ToDouble(Console.ReadLine());
            double score3 = Convert.ToDouble(Console.ReadLine());
            double result = Average(score1, score2, score3);
            Console.WriteLine(result);
            Average(score1, score2, score3);
        }
        public static double Average(double score1, double score2, double score3)
        {
            double average = (score1 + score2 + score3) / 3;
            return average;
        }
    }
}