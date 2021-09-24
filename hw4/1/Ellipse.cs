using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures {
    class Ellipse : GeoFigure {
        public double _Radius { get; set; }
        public double _radius { get; set; }
        public Ellipse(string figure, double Radius, double radius) : base(figure) {
            _Radius = Radius;
            _radius= radius;
        }

        public override double Area() {
            return Square = pi * _Radius * _radius;
        }

        public override double Perimeter() {
            return _perimeter = 4 * ((Math.PI*_Radius*_radius)+(_Radius-_radius)/(_Radius+_radius));
        }

        public override void Print() {
            Console.WriteLine($"Площадь эллипса {Area()} \n периметр эллипса {Perimeter()} \n");

        }
    }
}
