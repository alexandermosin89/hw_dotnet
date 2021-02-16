using System;

namespace HW03.Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текущий год");
            int cr_year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите текущий месяц в виде числа");
            int cr_month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите год рождения");
            int u_year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите месяц рождения в виде числа");
            int u_months = Convert.ToInt32(Console.ReadLine());
            if (u_months == cr_month)
            { 
             int years = cr_year - u_year+1;
                Console.WriteLine("возраст = " + years);
            }
            else
            {
                int years = cr_year - u_year;
                Console.WriteLine("возраст = " + years);
            }
            Console.ReadKey();   
        }
    }
}
