using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam.assets {
    class wordForDictionary {
        public Dictionary<int, string> _myWord;

        public wordForDictionary() {
            _myWord = new Dictionary<int, string>();
        }

        public void print(Dictionary<int, string> myWord) {
            foreach (KeyValuePair<int, string> key in myWord) {
                Console.WriteLine($"{key.Key + 1} : {key.Value}");
            }
            Console.WriteLine();
        }

        public void add(string word) {
            if (this._myWord.ContainsValue(word) == false) {
                this._myWord.Add(this._myWord.Count, word);
            }
        }
    }
}
