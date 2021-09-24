using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace hw8 {
    class AngloRusskiy {
        private Dictionary<string, List<string>> slovar;
        public AngloRusskiy() {
            slovar = new Dictionary<string, List<string>>();
        }
        public void Add(string str1, string str2) {
            if (slovar.ContainsKey(str1)) slovar[str1].Add(str2);
            else slovar.Add(str1, new List<string> { str2 });
        }
        public void Del(string str) {
            if (slovar.ContainsKey(str)) slovar.Remove(str);
        }
        public void Del(string str1, string str2) {
            if (slovar.ContainsKey(str1) && slovar[str1].Contains(str2)) slovar[str1].Remove(str2);
        }
        public void Print(string str) {
            if (slovar.ContainsKey(str)) {
                Console.Write(str + " = ");
                Console.WriteLine(string.Join(" ", slovar[str]));
            }
            else Console.WriteLine("не знаю такого слова " + str);
        }
    }

    class RusskoAngl {
        private Dictionary<string, List<string>> slovar;
        public RusskoAngl() {
            slovar = new Dictionary<string, List<string>>();
        }
        public void Add(string str1, string str2) {
            if (slovar.ContainsKey(str1)) slovar[str1].Add(str2);
            else slovar.Add(str1, new List<string> { str2 });
        }
        public void Del(string str) {
            if (slovar.ContainsKey(str)) slovar.Remove(str);
        }
        public void Del(string str1, string str2) {
            if (slovar.ContainsKey(str1) && slovar[str1].Contains(str2)) slovar[str1].Remove(str2);
        }
        public void Print(string str) {
            if (slovar.ContainsKey(str)) {
                Console.Write(str + " = ");
                Console.WriteLine(string.Join(" ", slovar[str]));
            }
            else Console.WriteLine("не знаю такого слова " + str);
        }
    }
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Выберите направление: (1 - англорусский, 2 - русскоанглийский)");
            int num = int.Parse(Console.ReadLine());
            if (num == 1) {
                AngloRusskiy slovar = new AngloRusskiy();
                slovar.Add("Ukraine", "Украина");
                slovar.Add("Russia", "Россия");
                while (true) {
                    Console.WriteLine("Напишите слово на английском языке: ");
                    string slovo = Console.ReadLine();
                    if (slovo != "break;") slovar.Print(slovo);
                    else break;
                }
            }
            else if (num == 2) {
                RusskoAngl slovar = new RusskoAngl();
                slovar.Add("Украина", "Ukraine");
                slovar.Add("Россия", "Russia");
                while (true) {
                    Console.WriteLine("Напишите слово на русском языке: ");
                    string slovo = Console.ReadLine();
                    if (slovo != "break;") slovar.Print(slovo);
                    else break;
                }
            }
            else {
                Process.GetCurrentProcess().Kill();
            }
        }
    }
}
