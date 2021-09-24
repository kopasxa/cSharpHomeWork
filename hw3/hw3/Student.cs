using System;

namespace hw3 {
    enum subject {
        Programming, Administration, Design
    }
    class Student {
        string surName,
            name,
            secondName,
            group;
        int age;
        int[][] appraisals = new int[3][];

        public Student(string name, string surName, string secondName, string group, int age) {
            this.name = name;
            this.surName = surName;
            this.secondName = secondName;
            this.group = group;
            this.age = age;
        }
        public Student() {
            this.name = "Alex";
            this.surName = "Alex";
            this.secondName = "Alex";
            this.group = "31R5GR";
            this.age = 18;
        }
        public float avr(int subj) {
            int sum = 0;
            for (int i = 0; i < appraisals[subj].Length; i++) {
                sum += appraisals[subj][i];
            }
            return sum / appraisals[subj].Length;
        }
        public void getAppr(int subj) {
            for (int i = 0; i < appraisals[subj].Length; i++) {
                Console.Write(appraisals[subj][i] + " ");
            }
        }
        public void addAppraisals(int subj, int appr) {
            if (subj < 3 && subj >= 0) { 
                if (appraisals[subj] != null) {
                    int[] tempArr = appraisals[subj];
                    appraisals[subj] = new int[appraisals[subj].Length + 1];
                    Array.Resize(ref tempArr, tempArr.Length + 1);
                    appraisals[subj] = tempArr;
                }
                else {
                    appraisals[subj] = new int[1];
                }
                appraisals[subj][appraisals[subj].Length - 1] = appr;
            }
        }
        public void addAppraisals() {
            Console.WriteLine("Programming, Administration, Design");
            Console.Write("Subject: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Appraisals: ");
            int app = int.Parse(Console.ReadLine());
            if (num < 3 && num >= 0) {
                if (appraisals[num] != null) {
                    int[] tempArr = appraisals[num];
                    appraisals[num] = new int[appraisals[num].Length + 1];
                    Array.Resize(ref tempArr, tempArr.Length + 1);
                    appraisals[num] = tempArr;
                }
                else {
                    appraisals[num] = new int[1];
                }
                appraisals[num][appraisals[num].Length - 1] = app;
            }
        }

        public void Print() {
            Console.Write($"Name: {this.name} {this.surName} {this.secondName}\nGroup: {this.group}\nAge: {this.age}\n");
        }
    }
}
