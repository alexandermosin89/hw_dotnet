using System;

namespace GoodDay
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan td1 = DateTime.Now.TimeOfDay;
            int td2 = td1.Hours;
            switch (td2)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                    Console.WriteLine("Good morning,guys");
                    break;
                case 13:
                case 14:
                case 15:
                    Console.WriteLine("Good day,guys");
                    break;
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                case 21:
                case 22:
                    Console.WriteLine("Good evening,guys");
                    break;
                default:
                    Console.WriteLine("none");
                    break;
            }
        }
    }
}