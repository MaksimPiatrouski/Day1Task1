using System;
using Utils;

namespace Main
{
    public class Runner
    {
        public static void Main()
        {
            double number;
            double x = 0;
            double n = 0;
            double p = 0;

            Console.Write("Enter number: ");
            String aString = Console.ReadLine();
            if (double.TryParse(aString, out number))
                x = number;

            Console.Write("Enter root: ");
            String nString = Console.ReadLine();
            if (double.TryParse(nString, out number))
                n = number;

            Console.Write("Enter precision: ");
            String pString = Console.ReadLine();
            if (double.TryParse(pString, out number))
                p = number;

            double result = MathRoot.GetRoot(x, n, p);

            Console.WriteLine("/nResult: " + result);

            //compare result with Math.Pow result
            double resultPow = Math.Pow(x, 1/n);

            result = Math.Round(result, Convert.ToInt32(n));
            resultPow = Math.Round(resultPow, Convert.ToInt32(n));

            bool equalResults;
            if (result == resultPow)
            {
                equalResults = true;
            }
            else
            {
                equalResults = false;
            }
            Console.WriteLine(equalResults);
            Console.ReadKey();
        }
    }
}
