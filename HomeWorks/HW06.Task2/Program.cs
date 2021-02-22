using System;

namespace HW06.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов массива");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] array1 = new int[a];
            for (int i = 0; i < array1.Length-1; i++)
            {
                Console.WriteLine("Введите элемент массива");
                array1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < array1.Length-1; i++)
            {
                Console.Write(array1[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Введите номер элемента массива");
            int n = Convert.ToInt32(Console.ReadLine())-1;
            for (int i = a - 1; i>n; i--)
            {
                array1[i] = array1[i - 1];
            }
            Console.WriteLine("Введите значение элемента");
            array1[n] = int.Parse(Console.ReadLine());
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write(" " + array1[i]);
            }
        }
    }
}
