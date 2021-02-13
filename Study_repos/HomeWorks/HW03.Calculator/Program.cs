using System;

namespace HW03.Calculator
{
    public class Calculator
    {
        public double Add()
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
        public double Sub()
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
        public double Mult()
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
        public double Div()
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
        public double Exp()
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
        public double Sq()
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
        public static void Main(string[] args)
        {
            Calculator cl1 = new Calculator();
            Console.WriteLine("результат суммирования = " + cl1.Add());
            Calculator cl2 = new Calculator();
            Console.WriteLine("результат вычитания = " + cl2.Sub());
            Calculator cl3 = new Calculator();
            Console.WriteLine("результат умножения = " + cl3.Mult());
            Calculator cl4 = new Calculator();
            Console.WriteLine("результат деления = " + cl4.Div());
            Calculator cl5 = new Calculator();
            Console.WriteLine("результат возведения в степень = " + cl5.Exp());
            Calculator cl6 = new Calculator();
            Console.WriteLine("площадь круга = " + cl6.Sq());
            Console.ReadKey();
        }
    }
}


