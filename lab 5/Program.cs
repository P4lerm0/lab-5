using System;

namespace lab_5_part_1
{
    class Program
    {
        static double Function(double x, double k)
        {

            double f = 2 * x / (k * k * k + 2 * x + 1);
            return f;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите цикл: for,while, do-while ");
            
            {
                string line = Console.ReadLine();

                switch (line)
                {
                    case "for":
                        for (int x = -5; x < 6; x++)
                        {
                            for (int k = 30; k < 41; k++)
                            {
                                double t = Function(x, k);
                                Console.Write($"{Math.Round(t, 4)}\t");

                            }
                            Console.WriteLine();

                        }
                        break;

                    case "while":
                        int y = -5;
                        while (y < 6)
                        {
                            int z = 30;
                            while (z < 41)
                            {
                                double t = Function(y, z);
                                Console.Write($"{Math.Round(t, 4)}\t");
                                z++;

                            }
                            Console.WriteLine();
                            y++;
                        }
                        break;

                    case "do-while":
                        int m = -5;
                        do
                        {
                            int n = 30;
                            do
                            {
                                double t = Function(m, n);
                                Console.Write($"{Math.Round(t, 4)}\t");
                                n++;
                            }

                            while (n < 41);
                            Console.WriteLine();
                            m++;
                        }
                        while (m < 6);

                        break;
                }

            }
        }
    }
}