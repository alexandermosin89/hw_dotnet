using System;

namespace HW07.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("write the your text using \" \" as separator");
            string txt = Console.ReadLine();
            //delmaxlengthw(txt);
            //changewords(txt);
            //howmuch(txt);
            workwitharray(txt);
        }
        static void delmaxlengthw(string txt)
        {
            string[] str = txt.Split(" ");
            string maxword = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Length > maxword.Length)
                {
                    maxword = str[i];
                    if (i == str.Length - 1)
                        maxword = " " + maxword;
                    else
                        maxword = maxword + " ";
                }
            }
            Console.WriteLine(maxword);
            txt = txt.Replace(maxword, string.Empty);
            Console.WriteLine(txt);
        }
        static void changewords(string txt)
        {
            int max, min;
            max = 0;
            min = 0;
            string[] str = txt.Split(" ");
            string maxword = str[0];
            string minword = str[0];
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i].Length > maxword.Length)
                {
                    maxword = str[i];
                    max = i;
                }
                if (str[i].Length < minword.Length)
                {
                    minword = str[i];
                    min = i;
                }
            }
            str[max] = minword;
            str[min] = maxword;
            //Console.WriteLine(maxword + " " + minword);
            for (int i = 0; i<str.Length; i++)
            Console.Write(str[i] + " ");
        }
        static void howmuch(string txt)
        {
            int letters = 0;
            int chars = 0;
            for (int i = 0; i<txt.Length; i++)
            {
                if (char.IsLetter(txt[i]))
                    letters++;
                if (char.IsPunctuation(txt[i]))
                    chars++;
            }
            Console.Write(letters + " " + chars);
        }
        static void workwitharray(string txt)
        {
            string[] str = txt.Split(" ");
            for (int i = 0; i < str.Length; i++)
            {
               
            }
        }
    }
}
