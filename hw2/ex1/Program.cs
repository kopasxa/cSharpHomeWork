using System;

namespace ex1 {
    class Program {
        public static void smartFunc(ref int [] arr) {
            for (int i = arr.Length - 1; i >= 0; --i) {
                if (arr[i] != 0) {
                    for (int j = i + 1; j < arr.Length; j++) {
                        arr[j] = -1;
                    }
                    break;
                }
            }

            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] != 0) {
                    int newSize = arr.Length - i;
                    int[] newArr = new int [newSize];
                    int j = i;

                    for (int k = 0; k < newArr.Length; k++, j++) newArr[k] = arr[j];

                    Array.Resize(ref arr, newSize);
                    arr = newArr;
                    break;
                }
            }

        }
        static void Main(string[] args) {
            Random rand = new Random();
            int [] arr = new int[10];

            for (int i = 0; i < arr.Length; i++) {
                if (i > 3 && i < 7) {
                    arr[i] = rand.Next(1, 100);
                }
            }

            Console.Write("At the input we get: ");
            foreach (int i in arr) {
                Console.Write(i + " ");
            }

            smartFunc(ref arr);

            Console.Write("\nAt the output we get: ");
            foreach (int i in arr) {
                Console.Write(i + " ");
            }
            Console.Write("\n");
        }
    }
}
