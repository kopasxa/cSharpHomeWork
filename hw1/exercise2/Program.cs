using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(@"Задание 2. Ввести с клавиатуры номер трамвайного билета (6-значное число) и проверить 
является ли данный билет счастливым (если на билете напечатано шестизначное число, и сумма 
первых трёх цифр равна сумме последних трёх, то этот билет считается счастливым).\n");
            int numTicket = 0, 
                sumLeft = 0,
                sumRight = 0;

            while (numTicket.ToString().Length != 6) {
                Console.Write("Введите номер билета (6 знаков): ");
                numTicket = int.Parse(Console.ReadLine());
                if (numTicket.ToString().Length != 6) {
                    Console.WriteLine("Номер введён неверно, попробуйте ещё раз (\n");
                }
            }

            while (numTicket.ToString().Length > 0 && numTicket > 9) {
                if (numTicket.ToString().Length > 3) {
                    sumRight += numTicket % 10;
                    numTicket /= 10;
                }
                else {
                    sumLeft += numTicket % 10;
                    numTicket /= 10;
                }
            }
            sumLeft += numTicket;

            if (sumLeft == sumRight) Console.WriteLine("Поздравляю, у вас счастливый билет!");
            else Console.WriteLine("Поздравляю, вам не повезло, но повезёт в следующий раз ;)");
        }
    }
}
