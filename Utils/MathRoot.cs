using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class MathRoot
    {
        public static bool GetRoot(double number, int n, double p, out double result)
        {
            if (((number < 0 && n % 2 != 0) || number >= 0) && p > 0 && p < 1 && n != 0)
            {
                double[] x = new double[2];
                x[0] = number;
                x[1] = number / (double)n;
                while (Math.Abs(x[0] - x[1]) > p)
                {
                    x[1] = x[0];
                    x[0] = (1 / (double)n) * (((n - 1) * x[1]) + (number / Math.Pow(x[1], n - 1)));
                }
                result = x[0];
                return true;
            }
            else
            {
                result = 0;
                return false;
            }
        }
    }
}

