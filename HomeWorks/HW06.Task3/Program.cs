using System;

namespace HW06.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int[] array1 = new int[a];
            Random rand = new Random();
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = rand.Next(0, 10);
                Console.Write(array1[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i<=a/2; i++)
            {
                int m = array1[i];
                array1[i] = array1[a-1-i];
                array1[a - 1-i] = m;
            }
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write(array1[i] + " ");
            }
        }
    }
}
