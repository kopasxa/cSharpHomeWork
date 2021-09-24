using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise3 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(@"Задание 3. Числовые значения символов нижнего регистра в коде ASCII
отличаются от значений символов верхнего регистра на величину 32. Используя эту
информацию, написать программу, которая считывает с клавиатуры и конвертирует
все символы нижнего регистра в символы верхнего регистра и наоборот." + "\n");
            Console.WriteLine("Введите Символ: ");
            char symbol;
            int numASCII = 0;

            do {
                numASCII = Console.ReadKey().KeyChar;
                if (numASCII >= 65 && numASCII <= 90) {
                    numASCII += 32;
                }
                else if (numASCII >= 97 && numASCII <= 122) {
                    numASCII -= 32;
                }
                symbol = (char)numASCII;
                Console.Write(symbol);
            }
            while (numASCII != 46);
        }
    }
}
