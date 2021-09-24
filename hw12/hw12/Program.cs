using System;
using System.IO;

namespace hw12 {
    class Program
    {
        static void Main(string[] args)
        {
            var bill = new Bill { PaymentPerDay = 100, Days = 50, FinePerDay = 20, DaysDelayedPayment = 10 };

            //save single bill (mode 1)
            Bill.SerializeComputableFields = false;
            Save(bill, "D:\\temp1.bill");

            //save single bill (mode 2)
            Bill.SerializeComputableFields = true;
            Save(bill, "D:\\temp2.bill");

            //load bill
            bill = LoadBill("D:\\temp2.bill");

            //create list of bills
            var bills = new Bills();
            bills.Add(bill);
            bills.Add(bill);
            bills.Add(bill);

            //save bills (mode 2)
            Save(bills, "D:\\temp1.bills");

            //load bills
            bills = LoadBills("D:\\temp1.bills");

            Console.Read();
        }

        static void Save(Bill bill, string fileName)
        {
            using (var file = File.Create(fileName))
            using (var bw = new BinaryWriter(file))
                bill.Serialize(bw);
        }

        static Bill LoadBill(string fileName)
        {
            using (var file = File.OpenRead(fileName))
            using (var br = new BinaryReader(file))
                return Bill.Deserialize(br);
        }

        static void Save(Bills bills, string fileName)
        {
            using (var file = File.Create(fileName))
            using (var bw = new BinaryWriter(file))
                bills.Serialize(bw);
        }

        static Bills LoadBills(string fileName)
        {
            using (var file = File.OpenRead(fileName))
            using (var br = new BinaryReader(file))
                return Bills.Deserialize(br);
        }
    }
}
