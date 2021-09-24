using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataType {
    class Program {
        public struct Coefficient {
            public int a, b;
        }

        static void Main(string[] args) {
            while (true) {
                Console.WriteLine("\nВведите 2 числа через запятую");
                string line = Console.ReadLine();
                Coefficient k = new Coefficient();
                try {
                    Parse(line, ref k.a, ref k.b);
                    Console.WriteLine(k.a + "  " + k.b);
                    break;
                }
                catch (FormatException e) {
                    Console.WriteLine("Ошибка: \"{0}\"", e.Message);
                    continue;
                }
            }
        }

        static void Parse(string data, ref int a, ref int b) {
            if (string.IsNullOrEmpty(data)) {
                throw new FormatException("Не строка");
            }

            data = data.Trim();
            int commaPlace = check(data);

            string data1 = data.Substring(0, commaPlace);
            string data2 = data.Substring(commaPlace + 1, data.Length - commaPlace - 1);

            a = ToNumber(data1);
            b = ToNumber(data2);
        }

        static int check(string data) {
            if (data[0] == ',' || data[data.Length - 1] == ',')
                throw new FormatException("Напишите пожалуйста с запятой");

            int i = 0;
            int commaPlace = -1;
            int commaQuantity = 0;
            foreach (char el in data) {
                if (el == ',') {
                    commaPlace = i;
                    commaQuantity++;
                }
                i++;
            }
            if (commaQuantity > 1) {
                throw new FormatException("Много аргументов");
            }
            if (commaQuantity < 1) {
                throw new FormatException("Мало аргументов");
            }
            return commaPlace;
        }

        static int ToNumber(string line) {
            int x;
            bool rez = int.TryParse(line, out x);
            if (rez) {
                return x;
            }
            else {
                throw new FormatException("Не int");
            }
        }
    }
}
