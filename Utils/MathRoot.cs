using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class MathRoot
    {
        public static double GetRoot(double number, double n, double p)
        {
            double[] x = new double[2];
            x[0] = number;
            x[1] = number / n;
            while (Math.Abs(x[0] - x[1]) > p)
            {
                x[1] = x[0];
                x[0] = (1 / n) * (((n - 1) * x[1]) + (number / Math.Pow(x[1], n - 1)));
            }
           return x[0];
        }
    }
}
