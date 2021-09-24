using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace exam.assets {
    class dictionary {
        private Dictionary<string, wordForDictionary> dict;

        public string name { get; set; }

        public dictionary () {
            dict = new Dictionary<string, wordForDictionary>();
            name = "dictionary";
        }

        public void addWord() {
            string value,
                key;

            Console.WriteLine("Enter a word: ");
            key = Console.ReadLine();

            Console.Write("Enter a translation word: ");
            value = Console.ReadLine();

            if (!this.dict.ContainsKey(key)) {
                wordForDictionary word = new wordForDictionary();
                word.add(value);

                dict.Add(key, word);
            }
            else {
                dict[key].add(value);
            }
        }

        public void edit () {
            string key,
                value;
            Console.Clear();

            Console.WriteLine("1. Edit word\n2. Edit word translation");
            int menu = int.Parse(Console.ReadLine());

            Console.Write("Enter a word: ");
            key = Console.ReadLine();

            if (menu == 1) {
                if (dict.ContainsKey(key)) {
                    wordForDictionary keyPare = dict[key];

                    Console.Write(key + " - ");
                    keyPare.print(keyPare._myWord);

                    Console.Write("Enter a new word: ");
                    value = Console.ReadLine();

                    dict.Remove(key);
                    dict.Add(value, keyPare);
                }
                else {
                    Console.WriteLine("Word not found (");
                }
            }
            else if (menu == 2) {
                if (dict.ContainsKey(key)) {
                    wordForDictionary keyPare = dict[key];
                    keyPare.print(keyPare._myWord);

                    Console.Write("Enter a number of word translation for edit: ");
                    int num = int.Parse(Console.ReadLine());

                    Console.Write("Enter a new word translation: ");
                    value = Console.ReadLine();

                    keyPare._myWord[num] = value;
                }
                else {
                    Console.WriteLine("Word not found (");
                }
            }
        }

        public void del() {
            string key;
            Console.Clear();

            Console.WriteLine("1. Edit word\n2. Edit word translation");
            int menu = int.Parse(Console.ReadLine());

            Console.Write("Enter a word: ");
            key = Console.ReadLine();

            if (menu == 1) {
                if (dict.ContainsKey(key)) {
                    wordForDictionary keyPare = dict[key];

                    Console.Write("Was deleted: " + key + " : ");
                    keyPare.print(keyPare._myWord);

                    dict.Remove(key);
                }
                else {
                    Console.WriteLine("Wrod not found (");
                }
            }
            else if (menu == 2) {
                if (dict.ContainsKey(key)) {
                    wordForDictionary keyPare = dict[key];
                    keyPare.print(keyPare._myWord);

                    Console.Write("Enter a number of word translation for edit: ");
                    int num = int.Parse(Console.ReadLine());

                    if (keyPare._myWord.Count != 1) {
                        Console.Write("Was deleted: " + keyPare._myWord[num]);
                    }
                    else {
                        Console.WriteLine("Error 400");
                    }
                }
                else {
                    Console.WriteLine("Word not found (");
                }
            }
        }

        public void print(Dictionary<string, wordForDictionary> gl) {
            foreach (KeyValuePair<string, wordForDictionary> kvp in gl) {
                Console.Write(kvp.Key + " - ");
                int count = 1;
                foreach (KeyValuePair<int, string> _kvp in kvp.Value._myWord) {
                    if (count == 1) {
                        Console.WriteLine(_kvp.Value);
                    }
                    else {
                        Console.WriteLine(_kvp.Value + " - ");
                    }
                    count++;
                }
            }
        }

        public void saveToXml() {
            XmlTextWriter writer = null;
            try {
                writer = new XmlTextWriter(this.name + ".xml", System.Text.Encoding.Unicode);
                writer.Formatting = Formatting.Indented;
                writer.WriteStartDocument();
                writer.WriteStartElement("Dictionary");
                writer.WriteAttributeString("Name", this.name); ;
                foreach (KeyValuePair<string, wordForDictionary> kvp in this.dict) {
                    writer.WriteStartElement("Word");
                    writer.WriteElementString("Name", kvp.Key);
                    foreach (KeyValuePair<int, string> kvp_ in kvp.Value._myWord) {
                        writer.WriteStartElement("Translations");
                        writer.WriteStartElement("Translation");
                        writer.WriteAttributeString("Number", kvp_.Key.ToString());
                        writer.WriteString(kvp_.Value);
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                    }
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
                Console.WriteLine("Dictionary writed in " + this.name + ".xml");
                Console.ReadKey();
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            finally {
                if (writer != null)
                    writer.Close();
            }
        }

        static string selectFile() {
            Console.Clear();
            DirectoryInfo dir = new DirectoryInfo(".");
            Console.WriteLine("\n\tDir:");
            FileInfo[] files = dir.GetFiles("*.xml");

            int i = 1;
            foreach (FileInfo f in files) {
                Console.WriteLine(i + ". " + f.Name);
                i++;
            }
            Console.WriteLine();
            Console.Write("Select a num file: ");

            try {
                int x = int.Parse(Console.ReadLine());
                return files[(x - 1)].FullName;
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
                return "";
            }
        }

        public void readXml() {
            string path = selectFile();

            XmlTextReader reader = null;
            try {
                reader = new XmlTextReader(path);
                reader.WhitespaceHandling = WhitespaceHandling.None;
                while (reader.Read()) {
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "Dictionary") {
                        if (reader.AttributeCount > 0) {
                            while (reader.MoveToNextAttribute()) {
                                if (reader.Name == "Name") {
                                    this.name = reader.Value;
                                    break;
                                }
                            }
                        }
                        while (reader.Read()) {
                            if (reader.NodeType == XmlNodeType.Element && reader.Name == "Word") {
                                string key = "";
                                wordForDictionary word = new wordForDictionary();

                                while (reader.Read()) {

                                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "Name") {
                                        reader.Read();
                                        key = reader.Value;
                                    }

                                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "Translations") {
                                        while (reader.Read()) {
                                            if (reader.NodeType == XmlNodeType.Element && reader.Name == "Translation") {
                                                reader.Read();
                                                word.add(reader.Value);
                                            }
                                            if (reader.NodeType == XmlNodeType.EndElement && reader.Name == "Translations") {
                                                this.dict.Add(key, word);
                                                break;
                                            }
                                        }
                                    }

                                    if (reader.NodeType == XmlNodeType.EndElement && reader.Name == "Word") {
                                        word = new wordForDictionary();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            finally {
                if (reader != null)
                    reader.Close();
            }
        }

        public void saveWord() {
            Console.Clear();

            string key;
            Console.Write("Enter a word: ");
            key = Console.ReadLine();

            Console.Clear();

            if (this.dict.ContainsKey(key) != false) {

                XmlTextWriter writer = null;
                try {
                    writer = new XmlTextWriter(key + ".xml", System.Text.Encoding.Unicode);
                    writer.Formatting = Formatting.Indented;
                    writer.WriteStartDocument();
                    writer.WriteStartElement("Word");
                    writer.WriteElementString("Name", key);
                    foreach (KeyValuePair<int, string> kvp_ in this.dict[key]._myWord) {
                        writer.WriteStartElement("Translations");
                        writer.WriteStartElement("Translation");
                        writer.WriteAttributeString("Number", kvp_.Key.ToString());
                        writer.WriteString(kvp_.Value);
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                    }
                    writer.WriteEndElement();
                    Console.WriteLine("Word written in " + key + ".xml");
                    Console.ReadKey();
                }
                catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                }
                finally {
                    if (writer != null)
                        writer.Close();
                }

            }
        }

        public void translate (string value) {
            if (this.dict.ContainsKey(value)) {
                wordForDictionary word = this.dict[value];
                Console.Write(value + " : ");
                word.print(word._myWord);
            }
            else {
                Console.WriteLine("err: word not found (");
            }
        }

        public override string ToString() {
            return string.Format("Dictionary: " + name);
        }
    }
}
