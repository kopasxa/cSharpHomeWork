using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures {
    class Romb : GeoFigure {
        public double _diagonal1 { get; set; }
        public double _diagonal2 { get; set; }

        public Romb(string figure, double height) : base(figure) {
            _height = height; 
        }

        public Romb(string figure, double diagonal1, double diagonal2): base(figure) {
            _diagonal1 = diagonal1;
            _diagonal2 = diagonal2;
        }

        public Romb(string figure,double diagonal1, double diagonal2,double height) : base(figure) {
            _diagonal1 = diagonal1;
            _diagonal2 = diagonal2;
            _height = height;

        }
        
        public override double Area() {
            return Square= 0.5* (_diagonal1 * _diagonal2);
        }

        public override double Perimeter() {
            return _perimeter = 4 * _height;
        }

        public override void Print() {
            Console.WriteLine($"Площадь ромба {Area()} \n периметр ромба {Perimeter()} \n");
        }
    }
}
