using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace hw10 {
    class Program
    {
        static void Main(string[] args)
        {
            Tovar t1 = new Tovar { name = "water", price = 12.5 };
            Tovar t2 = new Tovar { name = "potato", price = 50 };
            Tovar t3 = new Tovar { name = "pasta", price = 125.46 };

            Zakaz z1 = new Zakaz();
            z1.tovars = new List<Tovar> { t1, t2 };
            z1.date = DateTime.Parse("31.07.2021");

            Zakaz z2 = new Zakaz();
            z2.tovars = new List<Tovar> { t2, t3,t1 };
            z2.date = DateTime.Now;

            Zakaz z3 = new Zakaz();
            z3.tovars = new List<Tovar> { t3 };
            z3.date = DateTime.Parse("29.03.2020");

            List<Zakaz> zakazs = new List<Zakaz> { z1, z2, z3 };

            XmlWriter xmlWriter = XmlWriter.Create("D:\\zakazs.xml");

            //Запись

            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("zakazs");

            for (int i = 0; i < zakazs.Count; i++)
            {
                xmlWriter.WriteStartElement("zakaz" + (i + 1).ToString());
                xmlWriter.WriteAttributeString("date", zakazs[i].date.ToShortDateString());

                for (int j = 0; j < zakazs[i].tovars.Count; j++)
                {
                    xmlWriter.WriteStartElement("tovar" + (j + 1).ToString());
                    xmlWriter.WriteAttributeString("name", zakazs[i].tovars[j].name);
                    xmlWriter.WriteAttributeString("price", zakazs[i].tovars[j].price.ToString());
                    xmlWriter.WriteEndElement();
                }

                xmlWriter.WriteEndElement();
            }


            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndDocument();
            xmlWriter.Close();




            //Чтение
            ReadXMLFile();
            Console.Read();
            //XmlTextReader xmlReader = new XmlTextReader();


        }



        static void ReadXMLFile()
        {
            
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("D://zakazs.xml");

            XmlElement xRoot = xDoc.DocumentElement;

            foreach (XmlNode xnode in xRoot)
            {
                if (xnode.Attributes.Count > 0)
                {
                    XmlNode attr = xnode.Attributes.GetNamedItem("date");
                    if (attr != null)
                        Console.WriteLine(attr.Value);
                }

                foreach (XmlNode childnode in xnode.ChildNodes)
                {

                    /*if (childnode.Name == "date")
                    {
                        Console.WriteLine($"Дата: {childnode.InnerText}");
                    }*/

                    if (childnode.Name.Contains("tovar"))
                    {
                        XmlNode attr2 = childnode.Attributes.GetNamedItem("name");
                        if (attr2 != null)
                            Console.WriteLine(attr2.Value);
                        XmlNode attr = childnode.Attributes.GetNamedItem("price");
                        if (attr != null)
                            Console.WriteLine(attr.Value);
                       
                        //Console.WriteLine($"Товар: {childnode.InnerText}");
                    }
                }
                Console.WriteLine();
            }

        }


    }
}
