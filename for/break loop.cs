using System;
class break_loop
{
    public static void Main(string[] args)
    {
        int num = 1;
        for(int i = 1; i<=100; i++)
        {
            if(num>=10000)
            {
                break;
             }
             num *= i;
         }
         Console.WriteLine(num);
     }
}