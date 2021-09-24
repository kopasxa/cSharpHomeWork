using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures {
    public abstract class GeoFigure {
        public double _perimeter { get; set; } 
        public double Square { get; set; }   
        public string _figure { get; set; } 
        public double _height { get; set; } 

        public const double pi = 3.14;
        public GeoFigure(string figure)
        {
            _figure = figure;
        }

        public abstract double Perimeter();
        public abstract double Area();

        public  void PrintFigure() {
            Console.WriteLine($" Площадь {_figure}а {Area()} см2 \n Периметр {_figure} {Perimeter()} см \n");
        }

        public virtual void Print() {
            Console.WriteLine($" Площадь фигуры {Area()} см2 \n Периметр фигуры {Perimeter()} см ");
        }
    }
}
