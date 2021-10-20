using System;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, x1, x2, x;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
   
            d = Math.Pow(b, 2) - 4 * a * c;
            if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine(x1);
                Console.WriteLine(x2);
            }
            else if (d == 0)
            {
                

                    x = -b / (2 * a);

                Console.WriteLine(x);
            }

            else
                Console.WriteLine("Коренів немає");






           
        }
    }
}
