using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise4 {
    class Program {
        static void Swap<T>(ref T lhs, ref T rhs) {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
        static void Main(string[] args) {
            Console.WriteLine(@"Задание 4. Даны целые положительные числа A и B (A < B). Вывести все целые
числа от A до B включительно; каждое число должно выводиться на новой строке;
при этом каждое число должно выводиться количество раз, равное его значению." + "\n");
            int a, b;
            Console.WriteLine("Enter first number: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("\n");

            if (!(b > a)) Swap<int>(ref a, ref b);

            for (int i = a; i <= b; i++) {
                for (int j = 0; j < i; j++) {
                    Console.Write(i + " ");
                }
                Console.Write("\n");
            }
        }
    }
}
