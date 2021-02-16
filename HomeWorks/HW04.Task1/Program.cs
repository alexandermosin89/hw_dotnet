using System;

namespace HW04.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Summ();
            Console.WriteLine("Сумма чисел равна " + result);
        }
        static int Summ()
        {
            int a, b;
            Console.WriteLine("Введите целое число a");
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Ошибка! Введите целое число a");
            }
            Console.WriteLine("Введите целое число b");
            while (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Ошибка! Введите целое число b");
            }
            return a + b;
        }

    }
}
