using System;

namespace ex4 {
    class Program {
        static void Main(string[] args) {
            Random rand = new Random();
            int x, y;
            Console.WriteLine("Enter size by х:");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter size by y:");
            y = int.Parse(Console.ReadLine());

            int[,] arr = new int[y, x];

            for (int i = 0; i < arr.GetLength(0); i++) {
                for (int j = 0; j < arr.GetLength(1); j++) {
                    arr[i, j] = rand.Next(10, 99);
                }
            }

            for (int i = 0; i < arr.GetLength(0); i++) {
                for (int j = 0; j < arr.GetLength(1); j++) {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Which columns to swap?");
            Console.Write("A: ");
            int a = int.Parse(Console.ReadLine()) - 1;
            Console.Write("B: ");
            int b = int.Parse(Console.ReadLine()) - 1;

            int[] temp = new int [y];
            for (int i = 0; i < arr.GetLength(1); i++) {
                if (i == a) {
                    for (int j = 0; j < arr.GetLength(0); j++) {
                        temp[j] = arr[j, i];
                    }
                    for (int j = 0; j < arr.GetLength(0); j++) {
                        arr[j, i] = arr[j, b];
                    }
                    for (int j = 0; j < arr.GetLength(0); j++) {
                         arr[j, b] = temp[j];
                    }
                }
            }

            for (int i = 0; i < arr.GetLength(0); i++) {
                for (int j = 0; j < arr.GetLength(1); j++) {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
