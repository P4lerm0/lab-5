using System;

namespace lab_5_part_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задайте первое число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Задайте второе число");
            int b = Convert.ToInt32(Console.ReadLine());
            int d = 0;
            while (a > 0)
            {
                int c = a % 10;
                if (c != b)
                    d = d * 10 + c; //3; 3*10+6=36; 36*10+5=365
                a = a / 10;
            }
            while (d > 0)
            {
                a = a * 10 + d % 10; //5; 5*10+6=56; 56*10+3=563
                d = d / 10; //36; 3; 0
            }
            Console.Write(a);
        }
    }
}
