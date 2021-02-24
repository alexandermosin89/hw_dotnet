using System;

namespace HW05.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vvod");
            int a = Convert.ToInt32(Console.ReadLine());
            string emp = null;
            for (int i = 1; i <= a; i++)
            {
                emp = emp + " ";
                string str = null;
                for (int j = i; j <= a; j++)
                {
                    str = str + " " + Convert.ToString(i);
                }
                Console.WriteLine(emp + str);
            }
        }
    }
}