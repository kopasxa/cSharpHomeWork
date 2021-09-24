using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces {
    abstract class Figure {
        public double Area;
        public double Perimeter;
        public virtual void Show() { }
    }

    class Triangle : Figure {
        double a;
        double b;
        double c;
        public Triangle() {
            this.a = 1;
            this.b = 1;
            this.c = 1;
        }
        public Triangle (double _a, double _b, double _c) {
            if (_a > 0 && _b > 0 && _c > 0) {
                this.a = _a;
                this.b = _b;
                this.c = _c;
            }
        }
        public new double Area {
            get { return a * b * 0.5; }
        }
        public new double Perimeter {
            get { return a + b + c; }
        }

        public new void Show() {
            Console.WriteLine("Площа: {0}", Area);
            Console.WriteLine("Периметр: {0}", Perimeter);
        }
    }

    class Square : Figure {
        double a;
        public Square() {
            this.a = 1;
        }
        public Square (double _a) {
            if (_a > 0) this.a = _a;
        }
        public new double Area {
            get { return a * a; }
        }
        public new double Perimeter {
            get { return 4 * a; }
        }

        public new void Show() {
            Console.WriteLine("Площа: {0}", Area);
            Console.WriteLine("Периметр: {0}", Perimeter);
        }
    }

    class Rectangle : Figure {
        double a;
        double b;
        public Rectangle() {
            this.a = 1;
            this.b = 1;
        }
        public Rectangle (double _a, double _b) {
            if (_a > 0 && _b > 0) {
                this.a = _a;
                this.b = _b;
            }
        }
        public new double Area {
            get { return a * b; }
        }
        public new double Perimeter {
            get { return (a + b) * 2; }
        }

        public new void Show() {
            Console.WriteLine("Площа: {0}", Area);
            Console.WriteLine("Периметр: {0}", Perimeter);
        }
    }

    class Rhombus : Figure {
        double a;
        double d1;
        double d2;
        public Rhombus() {
            this.a = 1;
            this.d1 = 1;
            this.d2 = 1;
        }
        public Rhombus(double _a, double _d1, double _d2) {
            if (_a > 0 && _d1 > 0 && _d2 > 0) {
                this.a = _a;
                this.d1 = _d1;
                this.d2 = _d2;
            }
        }
        public new double Area {
            get { return d1 * d2 * 0.5; }
        }
        public new double Perimeter {
            get { return 4 * a; }
        }

        public new void Show() {
            Console.WriteLine("Площа: {0}", Area);
            Console.WriteLine("Периметр: {0}", Perimeter);
        }
    }

    class Parallelogram : Figure {
        double a;
        double b;
        double d1;
        double d2;
        public Parallelogram() {
            this.a = 1;
            this.b = 1;
            this.d1 = 1;
            this.d2 = 1;
        }
        public Parallelogram (double _a, double _b, double _d1, double _d2) {
            if (_a > 0 && _b > 0 && _d1 > 0 && _d2 > 0) {
                this.a = _a;
                this.b = _b;
                this.d1 = _d1;
                this.d2 = _d2;
            }
        }
        public new double Area {
            get { return d1 * d2 * 0.5; }
        }
        public new double Perimeter {
            get { return (a + b) * 2; }
        }

        public new void Show() {
            Console.WriteLine("Площа: {0}", Area);
            Console.WriteLine("Периметр: {0}", Perimeter);
        }
    }

    class Trapezoid : Figure {
        double a;
        double b;
        double c;
        double d;
        public Trapezoid() {
            this.a = 1;
            this.b = 1;
            this.c = 1;
            this.d = 1;
        }
        public Trapezoid(double _a, double _b, double _d1, double _d2) {
            if (_a > 0 && _b > 0 && _d1 > 0 && _d2 > 0) {
                this.a = _a;
                this.b = _b;
                this.c = _d1;
                this.d = _d2;
            }
        }
        public new double Area {
            get { return ((1 / 4) * ((b + a) / (b - a)) * Math.Sqrt((-a + b + c + d) * (a - b + c - d) * (a - b - c + d))); }
        }
        public new double Perimeter {
            get { return a + b + c + d; }
        }

        public new void Show() {
            Console.WriteLine("Площа: {0}", Area);
            Console.WriteLine("Периметр: {0}", Perimeter);
        }
    }

    class Circle : Figure {
        double r;
        public Circle() {
            this.r = 1;
        }
        public Circle(double _r) {
            if (_r > 0) {
                this.r = _r;
            }
        }
        public new double Area {
            get { return 2 * Math.PI * r; }
        }
        public new double Perimeter {
            get { return 2 * Math.PI * r; }
        }

        public new void Show() {
            Console.WriteLine("Площа: {0}", Area);
            Console.WriteLine("Периметр: {0}", Perimeter);
        }
    }

    interface simpe {
        int Height {
            get;
            set;
        }
        int Base {
            get;
            set;
        }
        int Angle_between {
            get;
            set;
        }
        int Number_Parties {
            get;
            set;
        }
        int Lengths_Parties {
            get;
            set;
        }
        double Area {
            get;
        }
        double Perimeter {
            get;
        }
        void Show();
    }
    class Program {
        static void Main(string[] args) {
            Square C = new Square(10);
            C.Show();
        }
    }
}
