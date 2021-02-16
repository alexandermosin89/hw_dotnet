using System;

namespace HW04.Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            string action;
            Console.WriteLine("Enter symbol");
            action = Console.ReadLine();
            switch (action)
            {
                case "w":
                    Console.WriteLine("Go up");
                    break;
                case "s":
                    Console.WriteLine("Go down");
                    break;
                case "a":
                    Console.WriteLine("Go left");
                    break;
                case "d":
                    Console.WriteLine("Go rigth");
                    break;
                default:
                    Console.WriteLine("Impossible movement");
                    break;
            }

        }
    }
}
