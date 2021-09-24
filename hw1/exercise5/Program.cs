using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise5 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(@"Задание 5. Дано целое число N (> 0), найти число, полученное при прочтении
числа N справа налево. Например, если было введено число 345, то программа
должна вывести число 543." + "\n");

            int sum, number;
            Console.WriteLine("Введите число > 0");
            number = int.Parse(Console.ReadLine());

            if (number < 0) {
                Console.WriteLine("-_-");
            }
         
            while (number > 0) {
                sum = number % 10;
                number /= 10;
                Console.Write(sum);
            }

            Console.Write("\n");
        }
    }
}
