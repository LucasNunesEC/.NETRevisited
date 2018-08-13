using System;

namespace Class05
{
    class Triangulo
    {
        public double ladoA, ladoB, ladoC;

        public double Area() {
            double p = (ladoA + ladoB + ladoC) / 2.0;
            return Math.Sqrt(p * (p - ladoA) * (p - ladoB) * (p - ladoC));
        }
    }
}
