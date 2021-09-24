using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures {
    class SosFigure {
        public double result = 0;
        public GeoFigure[] geoFigures { get; set; }
        public SosFigure(params GeoFigure[] geoFigures) {
            this.geoFigures = geoFigures;
            PrintShow();
        }
        
        public  double Area() {
            for (int i = 0; i < geoFigures.Length; i++)
            {
                result += geoFigures[i].Area();
            }
            return result;

        }
        public  void PrintShow() {
            Console.WriteLine($"Площадь составной фигуры {Area()} см2\n ");

        }
    }
}
