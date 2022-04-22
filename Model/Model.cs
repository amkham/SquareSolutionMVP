using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareSolution.Model
{
    public class Model
    {
        private double x1;
        private double x2;

        public delegate void ModelDelegate(double x1, double x2);
        public event ModelDelegate ModelNotify;


        public double X1 { get => x1; set => x1 = value; }
        public double X2 { get => x2; set => x2 = value; }

        public void Solution(double a, double b, double c)
        {
            double d = b * b - 4 * a * c;
            if (d >= 0)
            {
               x1 = (-b + Math.Sqrt(d)) / (2 * a);
               x2 = (-b - Math.Sqrt(d)) / (2 * a);
            }
            ModelNotify.Invoke(x1, x2);
        }

    }
}
