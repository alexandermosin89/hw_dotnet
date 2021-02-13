using System;

namespace HW03.Calculator.Static
{
    class Program
    {
        static double Add()
        {
            Console.WriteLine("");
            Console.WriteLine("Суммирование");
            Console.WriteLine("Введите значение первого числа");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение второго числа");
            double b = Convert.ToDouble(Console.ReadLine());
            double result = a + b;
            return result;
        }
        static double Sub()
        {
            Console.WriteLine("");
            Console.WriteLine("Вычитание");
            Console.WriteLine("Введите значение первого числа");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение второго числа");
            double b = Convert.ToDouble(Console.ReadLine());
            double result = a - b;
            return result;
        }
        static double Mult()
        {
            Console.WriteLine("");
            Console.WriteLine("Умножение");
            Console.WriteLine("Введите значение первого числа");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение второго числа");
            double b = Convert.ToDouble(Console.ReadLine());
            double result = a * b;
            return result;
        }
        static double Div()
        {
            Console.WriteLine("");
            Console.WriteLine("Деление");
            Console.WriteLine("Введите значение числителя");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение знаменателя");
            double b = double.Parse(Console.ReadLine());
            double result = a / b;
            return result;
        }
        static double Exp()
        {
            Console.WriteLine("");
            Console.WriteLine("Возведение в степень");
            Console.WriteLine("Введите значение числа");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение степени");
            double b = double.Parse(Console.ReadLine());
            double result = Math.Pow(a, b);
            return result;
        }
        static double Sq()
        {
            Console.WriteLine("");
            Console.WriteLine("Площадь окружности");
            Console.WriteLine("Введите значение радиуса окружности");
            double a = double.Parse(Console.ReadLine());
            double result = 3.14 * a * a;
            return result;
        }

        static void Main(string[] args)
        {
            Add();
            Console.WriteLine("результат суммирования = " + Add());
            Sub();
            Console.WriteLine("результат вычитания = " + Sub());
            Mult();
            Console.WriteLine("результат умножения = " + Mult());
            Div();
            Console.WriteLine("результат деления = " + Div());
            Exp();
            Console.WriteLine("результат возведения в степень = " + Exp());
            Sq();
            Console.WriteLine("площадь круга = " + Sq());
            Console.ReadKey();

        }
    }
}
