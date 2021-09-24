using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures {
    class Trapezoid : GeoFigure {
        public double _sideA { get; set; }
        public double _sideB { get; set; }
        public double _sideC { get; set; }
        public double _sideD { get; set; }


        public Trapezoid(string figure, double sideA, double sideB, double sideC, double sideD) : base(figure) {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
            _sideD = sideD;
        }
        public Trapezoid(string figure, double sideA, double sideB, double height) : base(figure) {
            _sideA = sideA;
            _sideB = sideB;
            _height = height;
        }
        public Trapezoid(string figure, double sideA, double sideB, double sideC, double sideD,double height) : base(figure) {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
            _sideD = sideD;
            _height = height;
        }

        public override double Area() {
            double v = (_sideA + _sideB);
            return Square = 0.5* v * _height;
        }

        public override double Perimeter() {
            return _perimeter = _sideA + _sideB + _sideC + _sideD;
        }

        public override void Print() {
            Console.WriteLine($"Площадь трапеции {Area()} \n периметр трапеции {Perimeter()} \n");
        }
    }
}
