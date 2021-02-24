using System;

namespace LettersCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово");
            string str = Console.ReadLine();
            int num = 0;
            for (int i = 0; i < str.Length; i++)
            {
                switch (str[i])
                {
                    case 'A':
                    case 'a':
                    case 'А':
                    case 'а':
                        num = num + 1;
                        break;
                }
            }
            Console.WriteLine("Количество букв равно {0}", num);
            Console.ReadKey();
        }
    }
}