using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures {
    class Program {
        static void Main(string[] args) {
            double result = 0;
            GeoFigure[] figures = {
               new Triangle("треугольник", 2, 2, 8),
               new Square("квадрат", 4),
               new Rectangle("прямоугольник", 3, 9),
               new Romb("ромб", 2, 5, 3),
               new Parallelogram("параллелограмм", 4, 7, 6),
               new Trapezoid("трапеция", 7, 4, 7, 5, 3),
               new Circle("круг", 10),
               new Ellipse("эллипс", 7, 10)
            };

            foreach (GeoFigure item in figures) {
                item.PrintFigure();
                result += item.Area();
            }
         
            Console.WriteLine($"Сумма площади фигур {result} см2\n");

            GeoFigure[] geos = {
                new Triangle("треугольник", 3, 4, 5),
               new Square("квадрат", 8),
               new Rectangle("прямоугольник", 3, 7)
            };

            SosFigure sos = new SosFigure(geos);
        }
    }
}
