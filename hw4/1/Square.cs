using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures {
    class Square : GeoFigure
    {
        public Square(string figure , double height) :base(figure) {
            _height = height;
        }

        public override double Area() {
            return Square = _height * _height;
        }

        public override double Perimeter() {
            return _perimeter = 4 * _height;
        }

        public override void Print() {
            Console.WriteLine($"Площадь квадрата {Area()} \n периметр квадрата {Perimeter()}\n");
        }
    }
}
