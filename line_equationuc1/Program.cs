using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace line_equationuc1
{
    internal class Program
    {
        static double distance(int x1, int x2, int y1, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow (y2 - y1, 2)*1.0);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Math.Round(distance(2, 3, 3, 2) * 100000.0) / 100000.0);
        }
    }
}
