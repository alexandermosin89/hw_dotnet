using System;

namespace HW07.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("write the your text using \";\" as separator");
            string txt = Console.ReadLine();
            txt = txt.Replace('a', 'o');
            string[] str = txt.Split(';');
            for (int i = 0; i < str.Length; i++)
                Console.WriteLine(str[i]);
        }
    }
}
