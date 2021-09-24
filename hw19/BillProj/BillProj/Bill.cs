using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace BillProj {
    class Bill {
        public decimal paymentPerDay;      //   Оплата за день;
        public uint days;                  //   Количество дней;
        public decimal finePerDay;         //   Штраф за один день задержки оплаты
        public uint daysDelayedPayment;    //   Количество дней задержи оплаты;

        public decimal totalScore;        //• Сумма к оплате без штрафа(вычисляемое поле);
        public decimal totalFine;          //•    Штраф(вычисляемое поле);
        public decimal resultPayment;       //•   Общая сумма к оплате(вычисляемое поле).

        static bool FormatProcess = true;
        public static string PathSave { get; set; } = "Bill.xml";

        public Bill() { }
        public Bill(decimal _paymentPerDay, uint _days, decimal _finePerDay, uint _daysDelayedPayment) {
            paymentPerDay = _paymentPerDay;
            days = _days;
            finePerDay = _finePerDay;
            daysDelayedPayment = _daysDelayedPayment;
        }

        public void TotalScore() {
            totalScore = paymentPerDay * days;
        }
        public void TotalFine() {
            totalFine = finePerDay * daysDelayedPayment;
        }

        public void ResultPayment() {
            resultPayment = totalScore + totalFine;
        }

        public void MainMethod() {
            TotalScore();
            TotalFine();
            ResultPayment();
            Bill.SerializeXML(this);
        }

        public static void SerializeXML(Bill bill) {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(Bill));
            try {
                using (Stream fStream = File.Create(PathSave)) {
                    xmlFormat.Serialize(fStream, bill);
                }
                Console.WriteLine("XmlSerialize OK!\n");
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
            }
        }


        public static Bill DeSerialize() {
            //метод DeSerialize используется только при начале работы, в конструкторе, там же будет и Try/Catch

            XmlSerializer xmlFormat = new XmlSerializer(typeof(Bill));
            Bill bill = null;
            using (Stream fStream = File.OpenRead(PathSave)) {
                bill = (Bill)xmlFormat.Deserialize(fStream);
            }

            return bill;

        }

        public override string ToString() {
            return $"ok";
        }
    }
}
