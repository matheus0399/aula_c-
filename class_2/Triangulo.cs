
using System;
namespace class_2 {
    class Triangulo {
        public double A;
        public double B;
        public double C;
        public double Area()
        {
            double p = 0.0, area = 0.0;
            p = (A + B + C) / 2.0;

            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
