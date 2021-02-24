using System;

namespace HW._02.Types
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a1 = true;
            Boolean a2 = true;
            byte b1 = 1;
            Byte b2 = 2;
            char c1 = '%';
            Char c2 = '&';
            decimal d1 = 10;
            Decimal d2 = 10;
            sbyte sb1 = 1;
            SByte sb2 = -15;
            float fl1 = 4.5f;
            Single fl2 = 4.6f;
            double db1 = 55.55;
            Double db2 = 55.66;
            short sh1 = 1;
            Int16 sh2 = 1;
            ushort ush1 = 10;
            UInt16 ush2 = 10;
            int i1 = 5;
            Int32 i2 = 5;
            uint ui1 = 5000;
            UInt32 ui2 = 5000;
            long l1 = 155;
            Int64 l2 = 156;
            ulong ul1 = 500;
            UInt64 ul2 = 501;
            object ob1 = 500;
            Object ob2 = 500;
            string str1 = "stroka";
            String str2 = "stroka2";
            Console.WriteLine("Variable type: " + a1.GetType());
            Console.WriteLine("Variable type: " + a2.GetType());
            Console.WriteLine("Variable type: " + b1.GetType());
            Console.WriteLine("Variable type: " + b2.GetType());
            Console.WriteLine("Variable type: " + c1.GetType());
            Console.WriteLine("Variable type: " + c2.GetType());
            Console.WriteLine("Variable type: " + d1.GetType());
            Console.WriteLine("Variable type: " + d2.GetType());
            Console.WriteLine("Variable type: " + sb1.GetType());
            Console.WriteLine("Variable type: " + sb2.GetType());
            Console.WriteLine("Variable type: " + fl1.GetType());
            Console.WriteLine("Variable type: " + fl2.GetType());
            Console.WriteLine("Variable type: " + db1.GetType());
            Console.WriteLine("Variable type: " + db2.GetType());
            Console.WriteLine("Variable type: " + sh1.GetType());
            Console.WriteLine("Variable type: " + sh2.GetType());
            Console.WriteLine("Variable type: " + ush1.GetType());
            Console.WriteLine("Variable type: " + ush2.GetType());
            Console.WriteLine("Variable type: " + i1.GetType());
            Console.WriteLine("Variable type: " + i2.GetType());
            Console.WriteLine("Variable type: " + ui1.GetType());
            Console.WriteLine("Variable type: " + ui2.GetType());
            Console.WriteLine("Variable type: " + l1.GetType());
            Console.WriteLine("Variable type: " + l2.GetType());
            Console.WriteLine("Variable type: " + ul1.GetType());
            Console.WriteLine("Variable type: " + ul2.GetType());
            Console.WriteLine("Variable type: " + ob1.GetType());
            Console.WriteLine("Variable type: " + ob2.GetType());
            Console.WriteLine("Variable type: " + str1.GetType());
            Console.WriteLine("Variable type: " + str2.GetType());
            Console.ReadKey();
        }
    }
}
