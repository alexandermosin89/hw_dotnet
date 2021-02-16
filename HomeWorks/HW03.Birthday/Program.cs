using System;

namespace HW03.Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текущий год");
            int crYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите текущий месяц в виде числа");
            int crMonth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите год рождения");
            int uYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите месяц рождения в виде числа");
            int uMonths = Convert.ToInt32(Console.ReadLine());
            if (uMonths == crMonth)
            {
                int years = crYear - uYear + 1;
                Console.WriteLine("возраст = " + years);
            }
            else
            {
                int years = crYear - uYear;
                Console.WriteLine("возраст = " + years);
            }
            Console.ReadKey();
        }
    }
}
