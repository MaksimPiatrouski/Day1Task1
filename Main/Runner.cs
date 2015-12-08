using System;
using Utils;

namespace Main
{
    public class Runner
    {
        public static void Main()
        {
            int valueI;
            double valueD;
            double x = 0;
            int n = 0;
            double p = 0;
            double result;

            bool loop = true;
            while (loop)
            {
                Console.Write("Enter number: ");
                String aString = Console.ReadLine();
                if (double.TryParse(aString, out valueD))
                    x = valueD;

                Console.Write("Enter root: ");
                String nString = Console.ReadLine();
                if (int.TryParse(nString, out valueI))
                    n = valueI;

                Console.Write("Enter precision: ");
                String pString = Console.ReadLine();
                if (double.TryParse(pString, out valueD))
                    p = valueD;

                if (MathRoot.GetRoot(x, n, p, out result))
                {
                    Console.WriteLine("\nResult: " + result);

                    //compare result with Math.Pow result
                    double resultPow = Math.Pow(x, 1 / (double)n);
                    Console.WriteLine("\nResult: " + resultPow);

                    result = Math.Round(result, n);
                    resultPow = Math.Round(resultPow, n);

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
                    loop = Runner.Exit();
                }
                else
                {
                    Console.WriteLine("\nIllegal input\n");
                    loop = Runner.Exit();
                }
            }
        }
        public static bool Exit()
        {
            Console.WriteLine("\nPress any key to continue\n"
                            + "Press 0 to exit");
            string key = Console.ReadLine();
            switch (key)
            {
                case "0":
                    return false;

                default:
                    return true;
            }
        }
    }
}