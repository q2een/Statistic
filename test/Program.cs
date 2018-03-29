using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test
{
    class Program
    {
        public static List<Harmonic> GetCoefficients(double[] y, int harmonicsCount, double F, double T)
        {
            var harmonics = new List<Harmonic>();
            //double T = 0.125 * Math.Pow(10, -6);
            for (int i = 0; i <= harmonicsCount; i++)
            {
                //F *= i;
                double C = 0, S = 0;
                double P = Math.PI * F * T;
                for (int j = 0; j < y.Length; j++)
                {
                    double Z = 2 * P * j;
                    C += y[j] * Math.Cos(Z);
                    S += y[j] * Math.Sin(Z);
                }
                double R = Math.Sqrt((C * C) + (S * S));
                double Phi = -Math.Acos(C / R);//- P;
                Phi = S < 0 ? -Phi : Phi;
                harmonics.Add(new Harmonic(F, R, Phi));
            }

            return harmonics;
        }

        public static double[] GetYFromX(double[] x, List<Harmonic> harmonics, double iniu)
        {
            var result = new List<double>();
            foreach (var t in x)
            {
                double y = iniu;
                for (int i = 1; i < harmonics.Count; i++)
                {
                    y += harmonics[i].M * Math.Cos(2 * Math.PI * i * harmonics[1].Frequency * t + harmonics[i].Phi);
                }
                result.Add(y);
            }
            return result.ToArray();
        }

        static void Main(string[] args)
        {
            double T = 0.125 * Math.Pow(10, -6);
            foreach (var item in GetCoefficients(new double[] {1,1,1,1,1,1,1,1}, 1, 250000, T))
            {
                Console.WriteLine((item.Phi*(180/Math.PI)));
                double P = Math.PI * item.Frequency * T;
                double k = Math.Sin(P) / P;
                Console.WriteLine(item.M * T);
                Console.WriteLine(k * item.M * T);
                Console.WriteLine(k * item.M*k * T);
            }
            foreach(var z in GetYFromX(new double[] { 1,2,3,4,5,6,7,8}, GetCoefficients(new double[] { 2, 4, 6, 8, 10, 12, 14, 16 }, 10, 8, 1), 1))
                Console.WriteLine(z);
            Console.ReadLine();
        }
    }

    public struct Harmonic
    {
        public double Frequency { get; set; }
        public double A { get; set; }
        public double B { get; set; }
        public double M { get; set; }
        public double Phi { get; set; }

        public Harmonic(double f, double m, double phi)
            : this()
        {
            this.Frequency = f;
            this.M = m;
            this.Phi = phi;
        }
    }
}
