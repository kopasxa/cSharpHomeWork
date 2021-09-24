using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace money {
    class Money {
        public long uah { get; private set; }
        public byte kop { get; private set; }

        public Money(long uah, byte kop) {
            if (kop >= 100 || kop < 0)
                throw new ArgumentException("Количество копеек должно быть от 0 до 99.");
            if (uah < 0)
                throw new ArgumentException("Количество рублей должно быть положительным.");
            this.uah = uah;
            this.kop = kop;
        }

        public override string ToString() {
            return string.Format($"{this.uah},{this.kop}");
        }

        public static Money operator +(Money a, Money b) {
            int kopSum = a.kop + b.kop;
            long uah = a.uah + b.uah + kopSum / 100;
            byte kop = (byte)(kopSum % 100);
            return new Money(uah, kop);
        }
        public static Money operator -(Money a, Money b) {
            int kopDiff = a.kop - b.kop;
            long uah = a.uah - b.uah;
            if (kopDiff < 0) {
                uah--;
                kopDiff += 100;
            }
            byte kop = (byte)(kopDiff % 100);
            return new Money(uah, kop);
        }

        public static Money operator *(Money a, int b) {
            int kopDiff = a.kop * b;
            long uah = a.uah * b;
            if (kopDiff < 0) {
                uah--;
                kopDiff += 100;
            }
            else if (kopDiff == 100) {
                uah++;
            }
            byte kop = (byte)(kopDiff % 100);
            return new Money(uah, kop);
        }

        public static Money operator /(Money a, int b) {
            int kopDiff = a.kop / b;
            long uah = a.uah / b;
            if (kopDiff < 0) {
                uah--;
                kopDiff += 100;
            }
            byte kop = (byte)(kopDiff % 100);
            return new Money(uah, kop);
        }

        public static Money operator --(Money a) {
            int kopDiff = a.kop;
            kopDiff--;
            long uah = a.uah;
            if (kopDiff < 0) {
                uah--;
                kopDiff += 100;
            }
            byte kop = (byte)(kopDiff % 100);
            return new Money(uah, kop);
        }

        public static Money operator ++(Money a) {
            int kopDiff = a.kop;
            kopDiff++;
            long uah = a.uah;
            if (kopDiff < 0) {
                uah--;
                kopDiff += 100;
            }
            byte kop = (byte)(kopDiff % 100);
            return new Money(uah, kop);
        }
        public static bool operator !=(Money a, Money b) {
            int kopDiff = a.kop;
            long uah = a.uah;
            if (a.uah == b.uah) {
                if (a.kop == b.kop) {
                    return false;
                }
                else {
                    return true;
                }
            }
            else {
                return true;
            }
        }
        public static bool operator ==(Money a, Money b) {
            int kopDiff = a.kop;
            if (a.uah == b.uah) {
                if (a.kop == b.kop) {
                    return true;
                }
                else {
                    return false;
                }
            }
            else {
                return false;
            }
        }

        public static bool operator >(Money a, Money b) {
            int kopDiff = a.kop;
            long uah = a.uah;
            if (a.uah >= b.uah) {
                if (a.kop > b.kop) {
                    return true;
                }
                else {
                    return false;
                }
            }
            else {
                return false;
            }
        }

        public static bool operator <(Money a, Money b) {
            int kopDiff = a.kop;
            long uah = a.uah;
            if (a.uah >= b.uah) {
                if (a.kop > b.kop) {
                    return false;
                }
                else {
                    return true;
                }
            }
            else {
                return true;
            }
        }

    }
    class Program {
        static public void Print(string s, int k) {
            for (int i = 0; i < k; i++) {
                Console.Write(s);
            }
        }
        static void Main(string[] args) {
            Money car = new Money(100000, 50);
            Money phone = new Money(4000, 0);
            Print("*", 7);
            Console.Write("MONEYS");
            Print("*", 7);
            
            while (true) {
                Console.WriteLine();
                Console.WriteLine($"1. +" +
                    $"\n2. -" +
                    $"\n3. *" +
                    $"\n4. /" +
                    $"\n5. ++" +
                    $"\n6. --" +
                    $"\n7. ==" +
                    $"\n8. !=" +
                    $"\n9. >" +
                    $"\n10. <" + 
                    $"\n0. For exit");
                int line = int.Parse(Console.ReadLine());

                if (line == 1) {
                    Console.WriteLine(car + " + " + phone + " = " + (car + phone));
                }
                else if (line == 2) {
                    Console.WriteLine(car + " - " + phone + " = " + (car - phone));
                }
                else if (line == 3) {
                    Console.WriteLine(car + " * 2 = " + (car * 2));
                }
                else if (line == 4) {
                    Console.WriteLine(car + " / 2 = " + (car / 2));
                }
                else if (line == 5) {
                    Console.WriteLine(car + "++ = " + (++car));
                }
                else if (line == 6) {
                    Console.WriteLine(car + "-- = " + (--car));
                }
                else if (line == 7) {
                    Console.WriteLine(car + " == " + phone + " = " + (car == phone));
                }
                else if (line == 8) {
                    Console.WriteLine(car + " != " + phone + " = " + (car != phone));
                }
                else if (line == 9) {
                    Console.WriteLine(car + " > " + phone + " = " + (car > phone));
                }
                else if (line == 10) {
                    Console.WriteLine(car + " < " + phone + " = " + (car < phone));
                }
                else if (line == 0) {
                    break;
                }
            }
        }
    }
}
