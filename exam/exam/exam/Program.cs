using exam.assets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam {
    class Program {
        static void Main(string[] args) {
            int menu = 0;
            dictionary myDict = default;

            while (true) {
                Console.WriteLine(@"1. create dictionary
2. load dictionary
3. save dictionary
4. exit
");

                int.TryParse(Console.ReadLine(), out menu);

                if (menu == 1) {
                    Console.Clear();
                    myDict = new dictionary();
                    Console.WriteLine("enter the name of the dictionary: ");
                    myDict.name = Console.ReadLine();

                    Console.WriteLine("you created: " + myDict);
                    Console.ReadKey();

                    MainMenu(myDict);
                }
                else if (menu == 2) {
                    myDict = new dictionary();
                    myDict.readXml();
                    MainMenu(myDict);
                }
                else if (menu == 3) {
                    myDict.saveToXml();
                    MainMenu(myDict);
                }
                else if (menu == 4) break;
                else Console.WriteLine("Err, try again (");

                Console.WriteLine("Done!");
            }
        }

        private static void MainMenu(dictionary myDict) {
            int menu;
            while (true) {
                Console.WriteLine(@"1. add word
2. replace word
3. delete word
4. search word translation
5. save word to xml file
6. exit
");

                int.TryParse(Console.ReadLine(), out menu);

                if (menu == 1) myDict.addWord();
                else if (menu == 2) myDict.edit();
                else if (menu == 3) myDict.del();
                else if (menu == 4) {
                    Console.WriteLine("Enter a word: ");
                    myDict.translate(Console.ReadLine());
                }
                else if (menu == 5) myDict.saveWord();
                else if (menu == 6) break;
                else {
                    Console.WriteLine("Err, try again (");
                }

                Console.WriteLine("Done!");
            }
        }
    }
}
