using System;
public class Noon_Or_Midnight//利用三元运算符来确定时间段是早晨还是下午
{
    public static void Main(string[]args)
    {
        int hour = Convert.ToInt32(Console.ReadLine());
        string result = hour <= 12 ? "AM" : "PM";
        Console.WriteLine(result);
    }
}
