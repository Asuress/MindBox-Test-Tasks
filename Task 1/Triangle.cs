using System;

namespace MindBox_Test_Tasks
{
    class Triangle : Shape
    {
        public override double Area
        {
            get
            {
                double p = Perimeter / 2;
                return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            }
        }
        public override double Perimeter
        {
            get
            {
                return A + B + C;
            }
        }

        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }

        public bool IsRight
        {
            get
            {
                if (A > B && A > C)
                {
                    return A * A == B * B + C * C;
                }
                if (B > A && B > C)
                {
                    return B * B == A * A + C * C;
                }
                if (C > B && C > A)
                {
                    return C * C == A * A + B * B;
                }
                return false;
            }
        }
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
    }
}
