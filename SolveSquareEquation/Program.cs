using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveSquareEquation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Input coefficients of lineal equation");
            float.TryParse(Console.ReadLine(), out float a);
            float.TryParse(Console.ReadLine(), out float b);
            float.TryParse(Console.ReadLine(), out float c);
            Console.WriteLine("Trying to solve the equation:{0} * x ^ 2 + {1} * x + {2} = 0", a, b, c);
            if (a == 0)
            {
                if ((b == 0) && (c == 0))
                {
                    Console.WriteLine("The answer is any number");
                }
                else if ((b == 0) && (c != 0))
                {
                    Console.WriteLine("The equation has no roots");
                }
                else
                {
                    Console.WriteLine("The equation has the following root:{0}", -c / b);
                }
            }
            else
            {
                var d = b * b - 4 * a * c;
                var nRoots = Math.Sign(d) + 1;
                if (nRoots > 0)
                {
                    var x1 = (-b - Math.Sqrt(d)) / (2 * a);
                    var x2 = (-b + Math.Sqrt(d)) / (2 * a);
                    Console.WriteLine("The equation has the following roots:");
                    Console.WriteLine("x1 = {0}", x1);
                    Console.WriteLine("x2 = {0}", x2);
                }
                else
                {
                    Console.WriteLine("The equation has no roots");
                }
            }
            Console.Read();
        }
    }
}
