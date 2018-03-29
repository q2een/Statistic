using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LW1
{
    class FourierTransform
    {

        /*
        private readonly double[] y;
        private readonly int harmonicsCount = 10;
        private readonly double T;
        public List<Harmonic> Harmonics { get; set; }

        public static List<Harmonic> GetHarmonics(double[] y, double period,double dt,int harmonicsCount)
        {
            var har = new List<Harmonic>();

            double length = y.Length;
            double omega = (2 * Math.PI) / period;

            for (int i = 0; i <= harmonicsCount; i++)
            {
                double a = 0, b= 0;
                //omega *= i == 0 ? 1 : i;
                for (int j = 0; j < length; j++)
                {
                    a += y[j] * Math.Cos(omega * i * j * dt);
                    b += y[j] * Math.Sin(omega * i * j * dt);
                }

                double coefficient = 2.0 / length;

                har.Add(new Harmonic(omega, a * coefficient, b * coefficient, 0, 0));
            }

            return har;
        }
        /*
        public void GetCoefficients()
        {
            //double T = 0.125 * Math.Pow(10, -6);
            for (int i = 0; i <= harmonicsCount; i++)
            {
                double F = 1/Math.PI;
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
                Harmonics.Add(new Harmonic(F, C, S,R,Phi));
            }
        }

        public double[] GetYFromX(double[] x)
        {
            var result = new List<double>();
            foreach (var t in x)
            {
                double y = (Harmonics[0].A / (double)2);
                for (int i = 1; i <= harmonicsCount; i++)
                {
                    y += Harmonics[i].M * Math.Cos(2 * Math.PI * i * Harmonics[1].Frequency * t + Harmonics[i].Phase);
                }
                result.Add(y);
            }
            return result.ToArray();
        }

        public FourierTransform(double[] y, int harmonicsCount, double period)
        {
            this.y = y;
            this.harmonicsCount = harmonicsCount;
            this.T = period;
            this.Harmonics = new List<Harmonic>();
        }
    }
    /*
    public struct Harmonic
    {
        public double Frequency { get; set; }
        public double A { get; set; }
        public double B { get; set; }
        public double M { get; set; }
        public double Phase { get; set; }

        public Harmonic(double frequency, double a, double b, double m,  double phase): this()
        {
            this.Frequency = frequency;
            this.A = a;
            this.B = b;
            this.M = m;
            this.Phase = phase;
        }
    }*/

        /* 
           /// <summary>
           /// Возвращает коллекцию объектов <c>Harmonic</c>, содержащую информацию о гармониках раяда Фурье.
           /// </summary>
           /// <param name="period">Период повторения функции(T=1/f)</param>
           /// <param name="dt">Шаг, с которым расположены абсциссы Y(x)</param>
           /// <param name="harmonicsCount">Количество гармоник</param>
           /// <returns>Коллекцию объектов <c>Harmonic</c></returns>
           public List<Harmonic> GetFourierHarmonics(double period, double dt, int harmonicsCount)
           {
               var harmonics = new List<Harmonic>();

               double length = FourierSampleLength;
               double omega = (2 * Math.PI) / period;

               for (int i = 0; i <= harmonicsCount; i++)
               {
                   double a = 0, b = 0;
                   //omega *= i == 0 ? 1 : i;
                   for (int j = 0; j < length; j++)
                   {
                       a += Y[j] * Math.Cos(omega * i * j * dt);
                       b += Y[j] * Math.Sin(omega * i * j * dt);
                   }

                   double coefficient = 2.0 / length;

                   harmonics.Add(new Harmonic(omega, a * coefficient, b * coefficient));
               }

               return harmonics;
           }  

          /// <summary>
          /// Возвращает значения Y(x) синтезированной функции.
          /// </summary>
          /// <param name="harmonics">Коллекцию объектов <c>Harmonic</c></param>
          /// <returns>Значения Y(x) синтезированной функции.</returns>
          /* public double[] GetFourierYFromXValue(List<Harmonic> harmonics)
           {
               var result = new List<double>();

               for (int j = 0; j < FourierSampleLength; j++)
               {
                   double y = harmonics[0].A / 2.0;

                   for (int i = 1; i < harmonics.Count; i++)
                       y += harmonics[i].A * Math.Cos(harmonics[i].Omega * i * X[j]) + harmonics[i].B * Math.Sin(harmonics[i].Omega * i * X[j]);

                   result.Add(y);
               }
               return result.ToArray();
           } */

    }
}
