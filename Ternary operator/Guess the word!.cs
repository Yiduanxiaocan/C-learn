using System;
    public class guess_//猜单词游戏
{
    public static void Main(string[]args)
    {
        string answer = Console.ReadLine();
        string attempt = Console.ReadLine();
        string result = answer == attempt ? "You win" : "You lose";
        Console.WriteLine(result);
    }
}