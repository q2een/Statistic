using System;
using System.Collections.Generic;
using System.Linq;

namespace LW1
{
    /// <summary>
    /// <c>Data</c> - Класс для работы с данными.
    /// </summary>
    public class Data
    {
        // Событие, срабатывающие при обновления данных.
        public event Action<Data, Dictionary<double, double>> OnNewDataSample;

        // Коллекция элементов "Ключ- Значение", где ключ - Х, значение - У(Х).
        private Dictionary<double, double> sample = new Dictionary<double, double>();

        // Значение исходной функции. Х и У(Х).
        public Dictionary<double, double> XY 
        {
            get
            {
                return sample;
            }
            set
            {
                sample = value;
                
                if(OnNewDataSample != null)
                    OnNewDataSample.Invoke(this,sample);
            }
        }

        // Массив, содержащий значения Х.
        public double[] X
        {
            get
            {
                return this.XY.Keys.ToArray();
            }
        }

        // Массив, содержащий значения У(Х).
        public double[] Y
        {
            get
            {
                return this.XY.Values.ToArray();
            }
        }

        #region Статистика.

        /// <summary>
        /// Сумма.
        /// </summary>
        public double Sum
        {
            get { return Y.Sum(); }
        }

        /// <summary>
        /// Максимальное значение.
        /// </summary>
        public double Max
        {
            get { return Y.Max(); }
        }

        /// <summary>
        /// Минимальное значение.
        /// </summary>
        public double Min
        {
            get { return Y.Min(); }
        }

        /// <summary>
        /// Интервал.
        /// </summary>
        public double Interval
        {
            get { return Max - Min; }     
        }

        /// <summary>
        /// Среднее.
        /// </summary>
        public double Average
        {
            get { return Y.Average(); }
        }

        /// <summary>
        /// Счет.
        /// </summary>
        public int Length
        {
            get { return XY.Count(); }
        }

        /// <summary>
        /// Дисперсия.
        /// </summary>
        public double Dispersion
        {
            get { return Y.Select(item => Math.Pow(item - this.Average, 2)).Sum() / (this.Length-1); }
        }

        /// <summary>
        /// Стандартная ошибка.
        /// </summary>
        public double StandardError
        {
            get { return StandardDeviation / Math.Sqrt(Length); }
        }

        /// <summary>
        /// Стандартное отклонение.
        /// </summary>
        public double StandardDeviation
        {
            get { return Math.Sqrt(Dispersion); }
        }

        /// <summary>
        /// Медиана.
        /// </summary>
        public double Median
        {
            get
            {
                int halfIndex = this.Length / 2;
                var sorted = Y.OrderBy(n => n).ToArray();

                if (this.Length % 2 == 0)
                    return (sorted[halfIndex] + sorted[(halfIndex - 1)]) / 2;

                return sorted[halfIndex];
            }
        }

        /// <summary>
        /// Мода.
        /// </summary>
        public double? Mode
        {
            get
            {
                var first = this.Y.GroupBy(item => item).Select(z=> new {Value = z.Key, Count = z.Count()}).OrderByDescending(i=> i.Count).First();
                return first.Count > 1 ? (double?)first.Value : null;
            }
        }

        /// <summary>
        /// Асимметричность.
        /// </summary>
        public double Kurtosis
        {
            get
            {
                return (Length / (double)((Length - 1) * (Length - 2))) * Y.Select(x => Math.Pow((x - Average) / StandardDeviation, 3)).Sum();
            }
        }

        /// <summary>
        /// Эксцесс.
        /// </summary>
        public double Skewness
        {
            get
            {
                return ((Length * (Length + 1) / (double)((Length - 1) * (Length - 2) * (Length - 3)))) *
                    Y.Select(x => Math.Pow((x - Average) / StandardDeviation, 4)).Sum()
                    - ((3 * Math.Pow((Length - 1), 2)) / (double)(((Length - 2) * (Length - 3))));
            }  
        }

        #endregion

        // Размер выборки для полиномиальной регрессии.
        public int RegressionSampleLength { get; set; }

        // Размер выборки для полиномиальной регрессии.
        public int FourierSampleLength { get; set; }

        /// <summary>
        /// <c>Data</c> - Класс для работы с данными.
        /// </summary>
        public Data()
            : this(new Dictionary<double, double>())
        {
        }

        /// <summary>
        /// <c>Data</c> - Класс для работы с данными.
        /// </summary>
        /// <param name="sample">Коллекция элементов "Ключ- Значение", где ключ - Х, значение - У(Х)</param>
        public Data(Dictionary<double, double> sample)
        {
            XY = sample;
        }

        /// <summary>
        /// Удаляет все элементы коллекции.
        /// </summary>
        public void Clear()
        {
            XY.Clear();
        }

        #region Регрессия.

        public double[] GetExponentialRegression()
        {
            var range = GetMaxPositiveRange();
            double A = 0, B = 0, C = 0, D = 0;
            double[] coefficients = new double[2];
            int N = range[1] - range[0]+1;

            for (int i = range[0]; i < range[1]+1; i++)
            {
                A += X[i];
                B += Math.Log(Y[i]);
                C += X[i] * X[i];
                D += X[i] * Math.Log(Y[i]);
            }
            coefficients[1] = (A * B - N * D) / (A * A - N * C);
            coefficients[0] = Math.Exp((B - coefficients[1] * A) / N);

            return coefficients;
        }

        public double[] GetExpRegressinYFromX(double[] coefficients)
        {
            var res = new List<double>();
            var range = GetMaxPositiveRange();
            var xValues = X.Skip(range[0]).Take(range[1] - range[0]+1).ToArray();

            foreach(var x in xValues)
            {
                res.Add(coefficients[0] * Math.Exp(coefficients[1] * x));
            }

            return res.ToArray();
        }

        public int[] GetMaxPositiveRange()
        {
            var dic = new Dictionary<int, int>();
            int curindex = -1;
            for (int i = 0; i < Length; i++)
            {
                if (Y[i] > 0)
                {
                    curindex = curindex > 0 ? curindex : i;
                    continue;
                }

                if (curindex > 0)
                {
                    dic.Add(curindex, i-1);
                    curindex = -1;
                }
            }

            var z = dic.OrderByDescending(s => s.Value - s.Key).First();

            return new int[] { z.Key, z.Value };
        }

        /// <summary>
        /// Возвращает массив коэффициентов полинома y*(X), учитывая заданную погрешность.
        /// </summary>
        /// <remarks>
        /// y*(X) = a[0] + a[1]*x + a[2]*x^2 + ... + a[m]*x^m.
        /// </remarks>
        /// <param name="error">Допустимая погрешность</param>
        /// <returns>Массив коэффициентов полинома</returns>
        public double[] GetRegressionCoefficients(double error)
        {
            return PolynomialRegression.GetCoefficients(X.Take(RegressionSampleLength).ToArray(), Y.Take(RegressionSampleLength).ToArray(), error);
        }

        /// <summary>
        /// Возвращает массив коэффициентов полинома y*(X), учитывая заданную ступень полинома.
        /// </summary>
        /// <remarks>
        /// y*(X) = a[0] + a[1]*x + a[2]*x^2 + ... + a[m]*x^m.
        /// </remarks>
        /// <param name="polynomialDegree">Степень полинома</param>
        /// <returns>Массив коэффициентов полинома</returns>
        public double[] GetRegressionCoefficients(byte polynomialDegree)
        {
            return PolynomialRegression.GetCoefficients(X.Take(RegressionSampleLength).ToArray(), Y.Take(RegressionSampleLength).ToArray(), polynomialDegree);
        }

        /// <summary>
        /// Возвращает массив коэффициентов полинома y*(X).
        /// </summary>
        /// <remarks>
        /// y*(X) = a[0] + a[1]*x + a[2]*x^2 + ... + a[m]*x^m.
        /// </remarks>
        /// <param name="error">Допустимая погрешность</param>
        /// <returns>Массив коэффициентов полинома</returns>
        public double[] GetRegressionYFromXValue(double error)
        {
            return PolynomialRegression.GetYFromXValue(X.Take(RegressionSampleLength).ToArray(), Y.Take(RegressionSampleLength).ToArray(), error);
        }

        /// <summary>
        /// Возвращает массив коэффициентов полинома y*(X) c заданной степенью полинома.
        /// </summary>
        /// <remarks>
        /// y*(X) = a[0] + a[1]*x + a[2]*x^2 + ... + a[m]*x^m.
        /// </remarks>
        /// <param name="polynomialDegree">Степень полинома</param>
        /// <returns>Массив коэффициентов полинома</returns>
        public double[] GetRegressionYFromXValue(byte polynomialDegree)
        {
            return PolynomialRegression.GetYFromXValue(X.Take(RegressionSampleLength).ToArray(), Y.Take(RegressionSampleLength).ToArray(), polynomialDegree);
        }

        /// <summary>
        /// Возвращает массив значений y*(х), при коэффициентах <c>coefficients</c>.
        /// </summary>
        /// <remarks>
        /// y*(X) = a[0] + a[1]*x + a[2]*x^2 + ... + a[m]*x^m.
        /// </remarks>
        /// <param name="coefficients">Массив коэффициентов полинома</param>
        /// <returns>Массив значений y*(Х)</returns>
        public double[] GetRegressionYFromXValue(double[] coefficients)
        {
            return PolynomialRegression.GetYFromXValue(coefficients, X.Take(RegressionSampleLength).ToArray());
        }

        /// <summary>
        /// Возвращает среднеквадратичную погрешность для полиномиальной регрессии.
        /// </summary>
        /// <param name="coefficients">Массив полученных при полиномиальной регрессии коэффициентов</param>
        /// <returns>Среднеквадратичная погрешность</returns>
        public double GetRegressionError(double[] coefficients)
        {
            return PolynomialRegression.GetError(Y.Take(RegressionSampleLength).ToArray(), GetRegressionYFromXValue(coefficients));
        }

        #endregion

        #region Ряд Фурье.

        /// <summary>
        /// Возвращает коллекцию объектов <c>Harmonic</c>, содержащую информацию о гармониках раяда Фурье.
        /// </summary>
        /// <param name="frequency">Частота повторения функции(T=1/f)</param>
        /// <param name="step">Шаг, с которым расположены абсциссы Y(x)</param>
        /// <param name="harmonicsCount">Количество гармони</param>
        /// <returns>Коллекцию объектов <c>Harmonic</c></returns>
        public List<Harmonic> GetFourierHarmonics(double frequency, double step, int harmonicsCount)
        {
            var harmonics = new List<Harmonic>();

            for (int i = 0; i <= harmonicsCount; i++)
            {
                double F = frequency * i;
                double coef = 2.0 / (double)FourierSampleLength;
                double A = 0, B = 0;

                for (int j = 0; j < FourierSampleLength; j++)
                {
                    double Z = 2 * Math.PI * F * step * j;
                    A += coef*Y[j] * Math.Cos(Z);
                    B += coef*Y[j] * Math.Sin(Z);
                }

                double M = Math.Sqrt((A * A) + (B * B));
                double Phi = -Math.Acos(A / M);
                harmonics.Add(new Harmonic(F,A,B,M, B < 0 ? -Phi : Phi));
            }

            return harmonics;
        }

        /// <summary>
        /// Возвращает коллекцию объектов <c>Harmonic</c>, содержащую информацию о гармониках раяда Фурье, 
        /// удовлетворяющих заданную допустимую погрешность <c>error</c>.
        /// </summary>
        /// <param name="frequency">Частота повторения функции(T=1/f)</param>
        /// <param name="step">Шаг, с которым расположены абсциссы Y(x)</param>
        /// <param name="error">Допустимая погрешность</param>
        /// <returns>Коллекцию объектов <c>Harmonic</c></returns>
        public List<Harmonic> GetFourierHarmonics(double frequency, double step, double error)
        {
            int harmonicsCount = 1;
            double curError = Double.MaxValue;
            List<Harmonic> result = null;

            while (curError > error && harmonicsCount <= 25)
            {
                result = GetFourierHarmonics(frequency, step, harmonicsCount);
                curError = GetFourierError(result);
                harmonicsCount++;
            }

            if (harmonicsCount >= 25)
                throw new Exception("Невозможно получить количество гармоник, удовлетворяющих заданной погрешности");

            return result;
        }

        /// <summary>
        /// Возвращает значения Y(x) синтезированной функции.
        /// </summary>
        /// <param name="harmonics">Коллекция объектов <c>Harmonic</c></param>
        /// <returns>Значения Y(x) синтезированной функции.</returns>
        public double[] GetFourierYFromXValue(List<Harmonic> harmonics)
        {
            var result = new List<double>();
            for (int j = 0; j < FourierSampleLength; j++)
            {
                double y = Y.Take(FourierSampleLength).Average()/2.0;

                for (int i = 1; i < harmonics.Count; i++)
                    y += harmonics[i].Аmplitude * Math.Cos(2 * Math.PI * i * harmonics[1].Frequency * X[j] + harmonics[i].Phase);

                result.Add(y);
            }
            return result.ToArray();
        }

        /// <summary>
        /// Возвращает погрешность синтезированной функции, полученной из заданных гармоник.
        /// </summary>
        /// <param name="harmonics">Коллекцию объектов <c>Harmonic</c></param>
        /// <returns>Погрешность синтезированной функции</returns>
        public double GetFourierError(List<Harmonic> harmonics)
        {
            var fourierY = GetFourierYFromXValue(harmonics);

            double error = 1.0 / (FourierSampleLength + 1);
            double sum = 0;
            for (int i = 0; i < FourierSampleLength; i++)
            {
                sum += Math.Pow(Y[i] - fourierY[i], 2);
            }

            return Math.Sqrt(error * sum);
        }
        
        #endregion
    }
}
