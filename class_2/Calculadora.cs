using System;

namespace class_2
{
    class Calculadora
    {
        public static double Pi = 3.14159;
        public static double CalculoCircle(double r)
        {
            return r * (2.0 * Pi);
        }
        public static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3.0);
        }
    }
}
