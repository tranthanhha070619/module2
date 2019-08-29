using System;
using System.Collections.Generic;
using System.Text;

namespace Phuongtrinhbac2.cs
{
    class QuadraticEquation
    {
        private double a;
        private double b;
        private double c;

        public QuadraticEquation(double a, double b, double c)  
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        public double A { get => a; set => a = value; }
        public double B { get => b; set => b = value; }
        public double C { get => c; set => c = value; }

        public double getDiscriminant()
        {
            double delta = (B * B) - 4 * (A * C);
            return delta;
        }
        public double getRoot()
        {
            return -B / (2 * A);
        }
        public double getRoot1()
        {
            return (-B + Math.Sqrt(getDiscriminant())) / (2 * A);
        }
        public double getRoot2()
        {
            return (-B - Math.Sqrt(getDiscriminant())) / (2 * A);
        }

        

    }
    
}
