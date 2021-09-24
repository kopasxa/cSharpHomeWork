using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures {
    class Rectangle:GeoFigure {
        public double _sideA { get; set; } 
        public double _sideB { get; set; } 

        public Rectangle(string figure, double sideA, double sideB) : base(figure) {
            _sideA = sideA;
            _sideB = sideB;
        }
        public override double Area() {
            return Square = _sideA * _sideB;

        }

        public override double Perimeter() {
            return _perimeter = 2 * (_sideA + _sideB);
        }

        public override void Print() {
            Console.WriteLine($"Площадь прямоугольника {Area()} \n периметр прямоугольника {Perimeter()}\n ");
        }
    }
}
