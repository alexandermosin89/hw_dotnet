using System;

namespace HW06.Task1
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
            int[] array2 = new int[a];
            for (int i = 0; i < array2.Length; i++)
            { 
                array2[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            int[] array3 = new int[a];
            for (int i = 0; i < array3.Length;i++)
            {
                array3[i] = array1[i] + array2[i];
                Console.Write(array3[i] + " ");
            }
        }
    }
}
