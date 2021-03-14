using System;
using System.Text;

namespace HW_08.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "1a!2.3!!.. 4.!.?6 7! ..?";
            StringBuilder result = new StringBuilder();
            bool hz = false;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != '!' && str[i] != '.' && hz == false)
                {
                    result = result.Append(str[i]);
                }
                if (hz == true)
                {
                    if (str[i] == ' ')
                    {
                        result = result.Append("_");
                    }
                    else
                    {
                        result = result.Append(str[i]);
                    }
                }
                if (hz == false)
                {
                    hz = (str[i] == '?');
                }
            }
            Console.WriteLine(result);
        }
    }
}
