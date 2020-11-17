using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Medias_de_dois_triangulos
{
    class Triangulos
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
       
        public Triangulos(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double CalculoTriangulo()
        {
            double P = (A + B + C) / 2.0;
            return P = Math.Sqrt(P * (P - A) * (P - B) * (P - C));
        }

        public override string ToString()
        {
            return CalculoTriangulo().ToString("f4", CultureInfo.InvariantCulture);
        }
    }
}
