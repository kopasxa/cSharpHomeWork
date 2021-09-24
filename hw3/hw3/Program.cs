using System;

namespace hw3 {
    public struct Article {
        string id,
            name;
        public float price;
        ArticleType type;

        enum ArticleType {
            furniture, householdChemicals, foods, clothes
        }
    }
    struct Client {
        string id,
            fio,
            adress,
            phone;
        int allOrders;
        float allSumOrders;
        ClientType type;
        enum ClientType {
            vip, user, admin
        }
    }
    public struct RequestItem {
        public Article good;
        public int quantity;
    }
    struct Request {
        string idOrder;
        Client client;
        DateTime dateOrder;
        RequestItem [] orders;
        PayType Payment;

        public enum PayType {
            cash, check, credit
        }

        public float Sum {
            get {
                float Sum = 0;
                foreach (RequestItem item in orders) {
                    Sum += item.quantity * item.good.price;
                }
                return Sum;
            }
        }
    }

    class Program {
        static void Main(string[] args) {
            Student pavel = new Student("Pavel", "Korolenko", "Vladimirovich", "300RG2", 16);
            pavel.Print();
            Console.Write("Programming: ");
            pavel.addAppraisals(0, 12);
            pavel.addAppraisals(0, 10);
            pavel.addAppraisals(0, 2);
            pavel.getAppr(0);
            Console.WriteLine("\nAVRG: " + pavel.avr(0));
        }
    }
}
