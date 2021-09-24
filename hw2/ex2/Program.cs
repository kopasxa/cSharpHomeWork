using System;

namespace ex2 {
    class Program {
        static void Main(string[] args) {
            Random rand = new Random();
            int[] arr = new int[10];

            for (int i = 0; i < arr.Length; i++) arr[i] = rand.Next(-20, 20);

            Array.Sort(arr);

            Console.Write("\nAt the output we get: ");
            foreach (int i in arr) {
                Console.Write(i + " ");
            }
            Console.Write("\n");
        }
    }
}
