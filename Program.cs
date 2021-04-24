using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            int time = int.Parse(Console.ReadLine());
            int bs = 5;
            int ws = 2;
            int cf = 3;
            while (true)
            {
                string menu = Console.ReadLine();
                if (menu == "Breakfast Set")
                {
                    if (time >= 11)
                    {
                        Console.WriteLine("Sorry your order is not available");
                    }
                    else if (bs <= 0)
                    {
                        Console.WriteLine("Sorry your order is out of stock");
                    }
                    else
                    {
                        bs = bs - 1;
                    }
                }
                else if (menu == "Weekend Set")
                {
                    if (day >=1 && day <=5)
                    {
                        Console.WriteLine("Sorry your order is not available");
                    }
                    else if (ws <= 0)
                    {
                        Console.WriteLine("Sorry your order is out of stock");
                    }
                    else
                    {
                        ws = ws - 1;
                    }
                }
                else if (menu == "Coffee")
                {
                    if (cf <= 0)
                    {
                        Console.WriteLine("Sorry your order is out of stock");
                    }
                    else
                    {
                        cf = cf - 1;
                    }
                }
                else if (menu == "End")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid menu");
                }
            }
        }
    }
}
