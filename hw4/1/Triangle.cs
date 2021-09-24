using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures {
    class Triangle : GeoFigure {
        public double _sideA { get; set; }
        public double _sideB { get; set; }
        public double _sideC { get; set; }
        public Triangle(string figure,double sideA, double sideB, double sideC): base(figure) {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public override double Perimeter() {
            _perimeter= _sideA + _sideB + _sideC;
            return _perimeter;
        }

        public override double Area() {
            double P = 0.5*(_sideA + _sideB + _sideC);
            Square = Math.Sqrt(P * (P - _sideA) * (P - _sideB) * (P - _sideC));
            return Square;
        }
        public override void Print() {
            Console.WriteLine($"Площадь треугольника {Area()} \n периметр треугольника {Perimeter()} \n");
        }
    }
}
