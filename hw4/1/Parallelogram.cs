using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures {
    class Parallelogram:GeoFigure {
        public double _sideA { get; set; }  
        public double _sideB { get; set; }  

        public Parallelogram(string figure, double sideA , double height) : base(figure) {
            _sideA = sideA;
            _height = height;
        }

        public Parallelogram(string figure, double sideA, double height , double sideB) : base(figure) {
            _sideA = sideA;
            _sideB = sideB;
            _height = height;
        }
       

        public override double Area() {
            return Square = _sideA * _height;
        }

        public override double Perimeter() {
            return _perimeter = 2 * (_sideA + _sideB);
        }

        public override void Print() {
            Console.WriteLine($"Площадь параллелограмма {Area()} \n периметр параллелограмма {Perimeter()} \n");
        }
    }
}
