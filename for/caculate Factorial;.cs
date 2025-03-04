using System;
public class Caculate_Factorial
{
    static void Main(string[] args)
    {
        int num = Convert.ToInt32(Console.ReadLine());
        int Factorial = 1;
        for(int i = 2; i<=num; i++)
        {
            Factorial *= i;
        }
        Console.WriteLine(Factorial);
    }
}