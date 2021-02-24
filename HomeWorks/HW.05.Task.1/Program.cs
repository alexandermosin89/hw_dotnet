using System;

namespace HW05.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int num = Convert.ToInt32(Console.ReadLine());
            int summ = 0;
            for (int i = 1; i<=num; i++) 
            {
                summ = summ + i;
            }
            Console.WriteLine("сумма чисел равна = {0}" ,summ);
        }
    }
}
