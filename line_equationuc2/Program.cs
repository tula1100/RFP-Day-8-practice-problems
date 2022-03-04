using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace line_equationuc2
{
    internal class Program
    {
        public static void Check(int x1, int x2, int y1, int y2, int p1, int p2, int q1, int q2)
        {
            int a1 = (y2 - y1) * p1 + (x1 - x2) * q1 + (x2 * y1 - x1 * y2);

            if (a1 < 0)
            {
                int a2 = (y2 - y1) * p2 + (x1 - x2) * q2
                     + (x2 * y1 - x1 * y2);
                if (a2 >= 0)
                    Console.WriteLine("Intersecting");
                else if (a2 < 0)
                    Console.WriteLine("Not intersecting");
            }
            else if (a1 > 0)
            {

                int a2 = (y2 - y1) * p2 + (x1 - x2) * q2
                         + (x2 * y1 - x1 * y2);

                if (a2 <= 0)
                    Console.WriteLine("Intersecting");


                else if (a2 > 0)
                    Console.WriteLine("Not intersecting");
            }
            else
                Console.WriteLine(
                    "points are lying on the line");
        }
            static void Main(string[] args)
        {
            int x1 = 2, y1 = 3;
            int x2 = 6, y2 = 4;

            Console.WriteLine("Equation 1: (" + (y2 - y1)
                          + ")x+(" + (x1 - x2) + ")y+("
                          + (x2 * y1 - x1 * y2) + ") = 0");

            int p1 = 3, q1 = 4;
            int p2 = 7, q2 = 1;

            Console.WriteLine("Equation 2: (" + (q2 - q1)
                           + ")x+(" + (p1 - p2) + ")y+("
                           + (p2 * q1 - p1 * q2) + ") = 0");

            Check(x1, x2, y1, y2, p1, p2, q1, q2);
        }
    }
}
