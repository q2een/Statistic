using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test
{
    class Program
    {
        public static double[] GetExponentialRegression(double[] x, double[] y)
        {
            double A = 0, B=0, C=0, D=0;
            double[] coefficients = new double[2];
            for (int i = 0; i < y.Length; i++)
            {
                A += x[i];
                B += Math.Log(y[i]);
                C += x[i] * x[i];
                D += x[i] * Math.Log(y[i]); 
            }
            coefficients[1] = (A * B - y.Length * D) / (A * A - y.Length * C);
            coefficients[0] = Math.Exp((B- coefficients[1]* A)/ y.Length);

            Console.WriteLine($"{coefficients[0]}\n{coefficients[1]}");
            return coefficients; 
        }
           
        static void Main(string[] args)
        {
            double[] x = new double[] { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            double[] y = new double[] { 3.5,5,6.2,9,13,16,23,30,40 };
            GetExponentialRegression(x, y);

            Console.ReadLine();
        }
    }

}
