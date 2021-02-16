using System;

namespace HW04.Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Summ();
        }
        static void Summ()
        {
            int result, a, b;
            char op;
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
            Console.WriteLine("Введите символ арифметической операции ");
            op = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введите ваш ответ");
            switch (op)
            {
                case '+':
                    result = a + b;
                    break;
                case '-':
                    result = a - b;
                    break;
                default:
                    result = 0;
                    break;
            }
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
