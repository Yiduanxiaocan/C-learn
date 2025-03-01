using System;

public class switch_study
{
    public static void Main(string[]args)
    {
        int choice = Convert.ToInt32(Console.ReadLine());
        switch(choice)
        {
            case 1:
                Console.WriteLine("Sports");
                break;
            case 2:
                Console.WriteLine("Business");
                break;
            case 3:
                Console.WriteLine("Technology");
                break;
            default:
                Console.WriteLine("Unknown");
                break;
        }
    }
}