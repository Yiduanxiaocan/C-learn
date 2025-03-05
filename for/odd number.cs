using System;
public class Odd
{
    public static void Main(string[]args)
    {
        int number = Convert.ToInt32(Console.ReadLine());
        for(int i = 1; i<=number; i+=2)
        {
            Console.Write(i+" ");
        }
    }
}