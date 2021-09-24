using System;

namespace ex3 {
    class Program {
        static void Main(string[] args) {
            Random rand = new Random();
            int[] arr = new int[10];

            for (int i = 0; i < arr.Length; i++) arr[i] = rand.Next(-10, 10);

            Console.Write("\nAt the output we get: ");
            foreach (int i in arr) {
                Console.Write(i + " ");
            }
            Console.Write("\n");

            Console.WriteLine("Enter a number between -10 and 10: ");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            int startIndex = -1;
            int index;
            for (int i = 0; i < arr.Length; i++) {
                index = Array.IndexOf(arr, num, startIndex + 1);
                if (index != -1) {
                    sum++;
                    startIndex = index;
                }
                else {
                    break;
                }
            }

            Console.WriteLine("Total found: " + sum);
        }
    }
}
