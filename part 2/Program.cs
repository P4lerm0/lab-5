﻿using System;

namespace lab_5_part_2
{
    class Program
    {
        static double Function(double x, double k)
        {

            double f = 2 * x / (k * k * k + 2 * k + 1);
            return f;
        }
        static void Main(string[] args)
        {
            {
                double x = Convert.ToDouble(Console.ReadLine());
                double sum = 0;
                Console.WriteLine("Сумма");
                for (int k = 0; k < 9; k++)
                {
                    double f = Function(x, k);
                    sum += f;
                }
                Console.WriteLine(sum);
                Console.WriteLine("Произведение");
                for (int k = 0; k < 9; k++)
                {
                    double f = Function(x, k);
                    sum *= f;
                }
                Console.WriteLine(sum);
            }
        }
    }
}
