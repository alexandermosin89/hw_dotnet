using System;
namespace HW._02.Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            {    // Неявное преобразование типов
                sbyte a = 15;
                short b = a;
                int c = b;
                long d = c;
            }
            {   // Явное преобразовани типов       
                decimal a = 15;
                uint b = (uint)a;
                ushort c = (ushort)b;
                sbyte d = (sbyte)c;
            }
            {   // Упаковка и распаковка
                int a = 5;
                decimal b = 100;
                string text = "Распаковка и упаковка";
                object a1 = a; //упаковка
                object a2 = text; //упаковка
                object a3 = b; //упаковка
                int b1 = (int)a1;//распаковка
                string b2 = text;//распаковка
                decimal b3 = (decimal)a3;//распаковка
                System.Console.WriteLine(b1);
                System.Console.WriteLine(b2);
                System.Console.WriteLine(b3);
                Console.ReadKey();
                //сборка работает корректно, т.к. в результате образовался .exe и .dll 
            }
        }
    }
}
