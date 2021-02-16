using System;

namespace HW03.Calculator.Static
{
   static class Calculator
    {
        public static double Add()
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

        public static double Sub()
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

        public static double Mult()
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

        public static double Div()
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

        public static double Exp()
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

        public static double Sq()
        {
            Console.WriteLine("");
            Console.WriteLine("Площадь окружности");
            Console.WriteLine("Введите значение радиуса окружности");
            double a = double.Parse(Console.ReadLine());
            double result = 3.14 * a * a;
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {          
            Console.WriteLine("результат суммирования = " + Calculator.Add());
            Console.WriteLine("результат вычитания = " + Calculator.Sub());
            Console.WriteLine("результат умножения = " + Calculator.Mult());
            Console.WriteLine("результат деления = " + Calculator.Div());
            Console.WriteLine("результат возведения в степень = " + Calculator.Exp());
            Console.WriteLine("площадь круга = " + Calculator.Sq());
            Console.ReadKey();
        }

    }
}

