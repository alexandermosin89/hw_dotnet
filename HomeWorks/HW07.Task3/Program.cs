using System;

namespace HW07.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string strdigit = string.Empty;
            Console.WriteLine("Enter your text");
            string txt = Console.ReadLine();
            char symb = ' ';
            int result = 0;
            char[] array = txt.ToCharArray();
            foreach (char i in array)
            {
                switch (i)
                {
                    case '+':
                    case '-':
                    case '/':
                    case '*':
                        symb = i;
                        break;
                    default:
                        break;
                }

                if (char.IsDigit(i) == true)
                {
                    strdigit += i;
                }
                if (i == symb)
                {
                    strdigit += symb;
                }
            }
            Console.WriteLine("Math operation symbol is" + symb);
            Console.WriteLine("Expression to evaluate is" + strdigit);
            string[] splarray = strdigit.Split(symb);
            int number1 = Convert.ToInt32(splarray[0]);
            int number2 = Convert.ToInt32(splarray[1]);
            switch (symb)
            {
                case '+':
                    result = number1 + number2;
                    Console.WriteLine("Calculation result = " + result);
                    break;
                case '-':
                    result = number1 - number2;
                    Console.WriteLine("Calculation result = " + result);
                    break;
                case '/':
                    result = number1 / number2;
                    Console.WriteLine("Calculation result = " + result);
                    break;
                case '*':
                    result = number1 * number2;
                    Console.WriteLine("Calculation result = " + result);
                    break;
                default:
                    break;
            }
        }
    }
}
