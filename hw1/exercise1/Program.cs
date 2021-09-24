using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(@"Задание 1. Написать программу, которая считывает символы с клавиатуры, пока не
будет введена точка.Программа должна сосчитать количество введенных
пользователем пробелов. \n");
            char endTyping = ' ';
            int countSpace = 0;
            Console.WriteLine("Введите строку: ");
            while (endTyping != '.') {
                endTyping = Console.ReadKey().KeyChar;
                if (endTyping == ' ') countSpace++;
            }
            Console.WriteLine("\nКоличество пробелов в строке: {0}", countSpace);
        }
    }
}
