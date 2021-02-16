using System;

namespace HW04.Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = Convert.ToInt32('Z'); i >= Convert.ToInt32('A'); i--)
            {
                Console.WriteLine(Convert.ToChar(i));
            }
            Console.ReadLine();
        }
    }
}
