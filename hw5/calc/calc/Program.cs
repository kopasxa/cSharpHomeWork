using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc {
    class Program {
        static void Main(string[] args) {
            double x, y;
            int a1 = -1, b1 = 3, a2 = -2, b2 = 6;

            try {
                Solve(a1, b1, a2, b2, out x, out y);
                Console.WriteLine("x = " + x + ";\ny = " + y + ";");
            }
            catch (ArgumentOutOfRangeException e) {
                Console.WriteLine("Решение не существует. " + e.Message);
            }
        }
        private static void Solve(int a1, int b1, int a2, int b2, out double x, out double y) {
            if (a1 == 0 && b1 == 0 && (a2 != 0 || b2 != 0))
                throw new ArgumentOutOfRangeException("first equation zero");

            else if ((a1 != 0 || b1 != 0) && a2 == 0 && b2 == 0)
                throw new ArgumentOutOfRangeException("second equation zero");

            else if (a1 == 0 && b1 == 0 && a2 == 0 && b2 == 0)
                throw new ArgumentOutOfRangeException("zero everywhere");

            else if (a1 == a2 && b1 == b2)
                throw new ArgumentOutOfRangeException("a1 = a2 && b1 = b2");

            else if (a1 * b2 == b1 * a2)
                throw new ArgumentOutOfRangeException("a1 * b2 = b1 * a2");
            else
                x = y = 0;
        }
    }
}
