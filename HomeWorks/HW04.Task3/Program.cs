using System;

namespace HW04.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Summ();
        }
        static void Summ()
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
            int result = a + b;
            Console.WriteLine("Введите ваш ответ");
            int c = Convert.ToInt32(Console.ReadLine());
            if (c == result)
            {
                Console.WriteLine("Ответ верный");
            }
            if (c <= result)
            {
                Console.WriteLine("Ответ неверный, ожидается больше");
            }
            if (c >= result)
            {
                Console.WriteLine("Ответ неверный, ожидается меньше");
            }
        }

    }
}
