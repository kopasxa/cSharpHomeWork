using System;
using System.Timers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace tamagochi {
    class tamagotchi {
        private System.Timers.Timer aTimer;
        private static Random rand = new Random();
        static int randInt;
        public static string name;
        private static Dictionary<int, string> msgs = new Dictionary<int, string> {
            {1, "Я голоден"},
            {2, "Я хочу гулять"},
            {3, "Я хочу спать"},
            {4, "Я заболел"},
            {5, "Я хочу играть"}
        };

        public tamagotchi () {
            string name = "Gosha";
        }

        private static int 
            hungry = 3,
            stroll = 3,
            sleep = 3,
            disease = 3,
            play = 3;

        public void runGame() {
            Console.WriteLine("Тебя приветствует игра \"Тамагочи\" \nТвоя задача ухаживать за маленьким тамагочи и не дать ему умереть");
            Console.Write("Для начала дай ему имя: ");
            name = Console.ReadLine();

            SetTimer();
            
            if (Console.ReadKey().Key == ConsoleKey.Escape) {
                aTimer.Stop();
                aTimer.Dispose();
            }
            else {
                Console.WriteLine("no");
            }
        }

        private void SetTimer() {
            int randInt = rand.Next(5000, 7000);
            aTimer = new System.Timers.Timer(randInt);

            aTimer.Elapsed += randomIvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }
        private static void request(int num) {
            if (num == 1) {
                Console.WriteLine($"Ты хочешь покормить {name}? (д/н)");

                if (Console.ReadKey().Key == ConsoleKey.Y) hungry--;
                else if (Console.ReadKey().Key == ConsoleKey.L) Console.WriteLine($"{name} хорошо покушал");
            }
            else if (num == 2) {
                Console.WriteLine($"Ты хочешь {name} выгулять? (д/н)");

                if (Console.ReadKey().Key == ConsoleKey.Y) stroll--;
                else if (Console.ReadKey().Key == ConsoleKey.L) Console.WriteLine($"{name} прогулялся");
            }
            else if (num == 3) {
                Console.WriteLine($"Ты хочешь {name} уложить спать? (д/н)");

                if (Console.ReadKey().Key == ConsoleKey.Y) sleep--;
                else if (Console.ReadKey().Key == ConsoleKey.L) Console.WriteLine($"{name} поспал");
            }
            else if (num == 4) {
                Console.WriteLine($"Ты хочешь {name} вылечить? (д/н)");

                if (Console.ReadKey().Key == ConsoleKey.Y) disease--;
                else if (Console.ReadKey().Key == ConsoleKey.L) Console.WriteLine($"{name} здоров!");
            } 
            else if (num == 5) {
                Console.WriteLine($"Ты хочешь поиграть с {name}? (д/н)");

                if (Console.ReadKey().Key == ConsoleKey.Y) play--;
                else if (Console.ReadKey().Key == ConsoleKey.L) Console.WriteLine($"{name} вусело поиграл");
            }


            if (hungry == 0 || stroll == 0 || sleep == 0 || disease == 0 || play == 0) {
                Console.WriteLine("Вы проиграли! Нажмите enter чтобы заначть заново, esc чтобы выйти");
                if (Console.ReadKey().Key == ConsoleKey.Enter) hungry = stroll = sleep = disease = play = 3;
                else if (Console.ReadKey().Key == ConsoleKey.Escape) System.Environment.Exit(0);
            }
        }
        private static void randomIvent(Object source, ElapsedEventArgs e) {
            int newRandInt;
            do {
                newRandInt = rand.Next(1, msgs.Count());
            } while (randInt == newRandInt);
            randInt = newRandInt;
            Console.Clear();
            Console.WriteLine(msgs[randInt]);
            request(randInt);
        }
    }
}
