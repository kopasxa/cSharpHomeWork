using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures {
    class Circle : GeoFigure {
        public double _radius { get; set; }
        
        public Circle(string figure, double radius) : base(figure) {
            _radius = radius;
        }

        public override double Area() {
             
            return Square = pi * _radius * _radius;
            
        }

        public override double Perimeter() {
            
            return _perimeter = 2 * pi * _radius;
            
        }
        public override void Print() {
            Console.WriteLine($" Площадь круга {Area()} \n периметр круга {Perimeter()} \n");
        }
    }
}
