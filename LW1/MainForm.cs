using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LW1
{
    public partial class MainForm : Form
    {
        // Экземпляр класса для работы с данными.
        private Data data;

        // Коэффициенты регрессии.
        private double[] regressionCoefficients;

        private List<Harmonic> fourierHarmonics;

        public MainForm()
        {
            data = new Data();
            data.OnNewDataSample += data_OnNewDataSample;
            InitializeComponent();
            sliderPanel.Beautify();
            sliderPanel.LeftSlideButton = LeftSlideBtn;
            sliderPanel.RightSlideButton = RightSlideBtn;
        }

        // Обработка собыия обновления данных.
        public void data_OnNewDataSample(Data sender, Dictionary<double, double> xy)
        {
            dgvData.Rows.Clear();
            foreach (var kv in xy)
            {
                AddDataGridRow(dgvData, String.Format("{0:0.00}", kv.Key), String.Format("{0:0.000}", kv.Value));
            }

            tbRegPoints.Text = (sender.Length >= 32 ? 32 : sender.Length) + "";
            lblRegPoints.Text = lblFourierPoints.Text = sender.Length == 0 ? "" : "От 0 до " + sender.Length;
            tbFourierPoints.Text = data.Length+"";
        }

        // Обработка события нажатия на кнопку "Расчет".
        private void btnCalulate_Click(object sender, EventArgs e)
        {
            switch (tabsMain.SelectedIndex)
            {
                case 0:                    
                    data.XY = Generate(10, cbRandomFactor.Checked, cbLinear.Checked);
                    break;
                case 1:
                    ShowStatistic();
                    break;
                case 2:
                    try
                    {
                        data.RegressionSampleLength = GetPointsCountFromTextBox(tbRegPoints.Text);

                        if (cbIsDegree.Checked)
                        {
                            byte deg = 0;
                            if(!Byte.TryParse(tbDegree.Text, out deg))
                                throw new Exception("Введите корректеную степень полинома");

                            regressionCoefficients = data.GetRegressionCoefficients(deg);
                        }
                        else
                        {
                            regressionCoefficients = data.GetRegressionCoefficients(Double.Parse(tbError.Text));
                        }

                        ShowRegression();
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Введите корректное значение погрешности", "Ошибка");
                    }
                    catch (Exception ex)
                    {
                        regressionCoefficients = null;
                        MessageBox.Show(ex.Message, "Ошибка");
                    }
                    break;
                case 3:
                    try
                    {
                        data.FourierSampleLength = GetPointsCountFromTextBox(tbFourierPoints.Text);
                        double frequency = 1.0 / (double)((double)data.FourierSampleLength * 0.2);
                        if (cbIsHarmonicCount.Checked)
                        {
                            byte count = 0;
                            if (!Byte.TryParse(tbHarmonicCount.Text, out count))
                                throw new Exception("Введите корректное значение количества гармоник");

                            fourierHarmonics = data.GetFourierHarmonics(frequency, 0.2, count);
                        }
                        else
                        {
                            fourierHarmonics = data.GetFourierHarmonics(frequency, 0.2, Double.Parse(tbError.Text));
                        }

                        ShowFourierHarmonics();
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Введите корректное значение погрешности", "Ошибка");
                    }
                    catch (Exception ex)
                    {
                        fourierHarmonics = null;
                        MessageBox.Show(ex.Message, "Ошибка");
                    }
                    
                    break;
            }
        }

        // Обработка события нажатия на кнопку "Отчет".
        private void btnReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (var sw = new System.IO.StreamWriter(saveFileDialog.FileName))
                    {
                        foreach (var kv in data.XY)
                            sw.WriteLine("{0:0.00};{1}", kv.Key, kv.Value);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
            /*
            using (var sw = new System.IO.StreamWriter("00.html"))
            {
                sw.Write(new HTMLReportBuilder().GetDataReport(data.XY));
            }*/
        }

        // Обработка события нажатия на кнопку "График".
        private void btnDrawGraphics_Click(object sender, EventArgs e)
        {            
            switch (tabsMain.SelectedIndex)
            {
                case 0:
                    DrawChart();
                    break;
                case 1:
                    
                    break;
                case 2:
                    if (cbExponentialRegression.Checked)
                    {
                        DrawExpRegression();
                        break;
                    }
                    DrawRegressionChart();
                    break;
                case 3:
                    DrowFourierChart();
                    break;

            }
        }

        // Обработка события изменения состояния флага "Учитывать степень полинома".
        private void cbIsDegree_CheckedChanged(object sender, EventArgs e)
        {
            tbDegree.Enabled = cbIsDegree.Checked;
            if (cbIsDegree.Checked)
                tbDegree.Focus();
        }

        // Обработка события изменения состояния флага "Учитывать количество гармоник".
        private void cbIsHarmonicCount_CheckedChanged(object sender, EventArgs e)
        {
            tbHarmonicCount.Enabled = cbIsHarmonicCount.Checked;
            if (cbIsHarmonicCount.Checked)
                tbHarmonicCount.Focus();
        }

        // Обработка события нажатия на кнопку для текстовго поля с возможностью ввода десятичных чисел. 
        private void tbError_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;

            if (key == 44 && tbError.Text.IndexOf(",") != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(key) && key != 44 && key != 8)
                e.Handled = true;
        }

        // Обработка события нажатия на кнопку для текстовго поля. 
        private void tbDegree_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;

            if (!Char.IsDigit(key) && key != 8)
                e.Handled = true;
        }

        // Обработка события клика на элемент LinkLable ("Выделить все" и "Снять выделение").
        private void LinkLables_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bool check = (sender as LinkLabel).Name == "linkSelectAll" ? true : false;

            foreach (var control in tabStatistic.Controls)
            {
                if (control is CheckBox)
                    (control as CheckBox).Checked = check;
            }
        }

        /// <summary>
        /// Выполняет генерацию данных по установленной формуле с учетом случайного фактора и линейного тренда
        /// </summary>
        /// <param name="variant">Вариант по списку</param>
        /// <param name="isRandom">Необходимо ли учитывать случайный фактор</param>
        /// <param name="isLinearTrend">Необходимо ли учитывать линейный тренд</param>
        /// <returns>Коллекция "Ключ-Значение", где ключ - Х, знчение - Y</returns>
        public Dictionary<double, double> Generate(int variant, bool isRandom, bool isLinearTrend)
        {
            var XY = new Dictionary<double, double>();

            double xMin = 0, xMax = 63.2, deltaX = 0.2;
            Random rndm = new Random();

            while (xMin < xMax)
            {
                double y = ((variant + 4) * Math.Sin((double)xMin / variant) * (isRandom ? rndm.Next(0, variant + 3) : 1)) +
                    (((variant + 2) / 2.0) * Math.Cos(xMin) * (isRandom ? rndm.Next(0, variant + 3) : 1)) -
                    (isRandom ? rndm.Next(variant / 2) : 0) + (isLinearTrend ? (variant * xMin) / (variant + 2) : 0);
                XY.Add(xMin, y);
                xMin += deltaX;
            }

            return XY;
        }

        /// <summary>
        /// Преобразовует строку в число, в случае, если число не соответствует количеству точку - выбрасывает исключение.
        /// </summary>
        /// <param name="num">Строка с числом точек</param>
        /// <returns>Преобразованное число</returns>
        private int GetPointsCountFromTextBox(string num)
        {
            int number = ushort.Parse(num);

            if (number < 0 || number > data.Length)
                throw new Exception("Введите корректное значение (от 0 до " + data.Length + ")");

            return number;
        }

        #region Вывод значений в DataGridView.

        /// <summary>
        /// Добавляет строку в <c>view</c>, которая имеет две ячейки со значениями <c>firstCellValue</c> и <c>secondCellValue</c>.
        /// </summary>
        /// <param name="view">Элемент DataGridView, в который будет добавлена строка</param>
        /// <param name="firstCellValue">Значение первой ячейки строки</param>
        /// <param name="secondCellValue">Значение второй ячейки строки</param>
        private void AddDataGridRow(DataGridView view, string firstCellValue, string secondCellValue)
        {
            var row = new DataGridViewRow();
            row.CreateCells(view);
            row.Cells[0].Value = firstCellValue;
            row.Cells[1].Value = secondCellValue;
            view.Rows.Add(row);
        }

        /// <summary>
        /// Добвляет новую строку в DataGridView, содержащий информацию о статистиках.
        /// </summary>
        /// <param name="firstCellValue">Значение первой ячейки строки</param>
        /// <param name="secondCellValue">Значение второй ячейки строки</param>
        private void AddStatisticDataGridRow(string firstCellValue, double? secondCellValue)
        {
            AddDataGridRow(dgvStatistic, firstCellValue, String.Format("{0:0.000}", secondCellValue));
        }

        // Вывод элементарных статистик.
        private void ShowStatistic()
        {
            if (data.Length == 0)
                return;

            dgvStatistic.Rows.Clear();

            if (cbAverage.Checked)
                AddStatisticDataGridRow("Среднее", data.Average);

            if (cbStandardError.Checked)
                AddStatisticDataGridRow("Станд. ошибка", data.StandardError);

            if (cbMediana.Checked)
                AddStatisticDataGridRow("Медиана", data.Median);

            if (cbMode.Checked)
                AddStatisticDataGridRow("Мода", data.Mode);

            if (cbStandardDeviation.Checked)
                AddStatisticDataGridRow("Станд. отклонение", data.StandardDeviation);

            if (cbDispersion.Checked)
                AddStatisticDataGridRow("Дисперсия выборки", data.Dispersion);

            if (cbSkewness.Checked)
                AddStatisticDataGridRow("Эксцесс", data.Skewness);

            if (cbKurtosis.Checked)
                AddStatisticDataGridRow("Асимметричность", data.Kurtosis);

            if (cbInterval.Checked)
                AddStatisticDataGridRow("Интервал", data.Interval);

            if (cbMin.Checked)
                AddStatisticDataGridRow("Минимум", data.Min);

            if (cbMax.Checked)
                AddStatisticDataGridRow("Максимум", data.Max);

            if (cbSum.Checked)
                AddStatisticDataGridRow("Сумма", data.Sum);

            if (cbCount.Checked)
                AddStatisticDataGridRow("Счет", data.Length);


        }

        // Вывод коэффициентов для полиномиальной регрессии.
        private void ShowRegression()
        {
            if (regressionCoefficients == null)
                return;

            dgvRegression.Rows.Clear();            
            AddDataGridRow(dgvRegression, "Степень полинома", (regressionCoefficients.Length - 1) + "");
            AddDataGridRow(dgvRegression, "Погрешность", String.Format("{0:0.000}",data.GetRegressionError(regressionCoefficients)));
            AddDataGridRow(dgvRegression, "Коэффициенты", "");
            for (int i = 0; i < regressionCoefficients.Length; i++)
            {
                var format = Math.Round(Math.Abs(regressionCoefficients[i]), 3) < 0.001 ?"{0:e3}" :"{0:0.000}";
                AddDataGridRow(dgvRegression, "A[" + i + "]", String.Format(format, regressionCoefficients[i]));
            }
        }

        // Вывод коэффициентов для ряда Фурье.
        private void ShowFourierHarmonics()
        {
            if(fourierHarmonics == null)
                return;
            
            dgvFourier.Rows.Clear();
            AddDataGridRow(dgvFourier, "Период", String.Format("{0:0.000}", data.FourierSampleLength * 0.2));
            AddDataGridRow(dgvFourier, "Δt", "0.200");
            AddDataGridRow(dgvFourier, "Погрешность", String.Format("{0:0.000}", data.GetFourierError(fourierHarmonics)));
            AddDataGridRow(dgvFourier, "Гармоник", String.Format("{0:0.000}", fourierHarmonics.Count));

            for (int i = 1; i< fourierHarmonics.Count; i++)
            {
                AddDataGridRow(dgvFourier, i + " Гармоника", "");
                AddDataGridRow(dgvFourier, "Частота", String.Format("{0:0.000}", fourierHarmonics[i].Frequency));
                AddDataGridRow(dgvFourier, "Коэффициет Фурье a[" + i +"]", String.Format("{0:0.000}", fourierHarmonics[i].A));
                AddDataGridRow(dgvFourier, "Коэффициет Фурье b[" + i + "]", String.Format("{0:0.000}", fourierHarmonics[i].B));
                AddDataGridRow(dgvFourier, "Амплитуда", String.Format("{0:0.000}", fourierHarmonics[i].Аmplitude));
                AddDataGridRow(dgvFourier, "Фаза, °", String.Format("{0:0.000}", fourierHarmonics[i].Phase*(180/Math.PI)));
            } 
        }
            
        #endregion

        #region Отрисовка графиков.

        private void DrawChart()
        {
            if (data.Length == 0)
                return;

            chart.Series["synthesisSeries"].Points.Clear();
            chart.Series["synthesisSeries"].Enabled = false;
            chart.Series[0].Points.Clear();
            
            foreach (var kv in data.XY)
                chart.Series[0].Points.AddXY(kv.Key, kv.Value);

            chart.ChartAreas[0].AxisY.Maximum = Math.Round(data.Max, 1);
            chart.ChartAreas[0].AxisY.Minimum = Math.Round(data.Min, 1);
            
        }

        private void DrawSynthesisSeries(string legend, double[] synthesisY)
        {
            chart.Series[0].Points.Clear();
            chart.Series["synthesisSeries"].Points.Clear();
            chart.Series["synthesisSeries"].LegendText = legend;
            chart.Series["synthesisSeries"].Enabled = true;

            foreach (var kv in data.XY.Take(synthesisY.Length))
                chart.Series[0].Points.AddXY(kv.Key, kv.Value);

            for (int i = 0; i < synthesisY.Length; i++)
                chart.Series[1].Points.AddXY(data.X[i], synthesisY[i]);

            chart.ChartAreas[0].AxisY.Maximum = Math.Round(data.Y.Take(synthesisY.Length).Max() + data.Average, 2);
            chart.ChartAreas[0].AxisY.Minimum = Math.Round(data.Y.Take(synthesisY.Length).Min() - data.Average, 2);
        }

        private void DrawRegressionChart()
        {
            if (regressionCoefficients == null || regressionCoefficients.Length == 0)
                return;
            
            var y = data.GetRegressionYFromXValue(regressionCoefficients);
            DrawSynthesisSeries("Линия тренда", y);
        }

        private void DrawExpRegression()
        {
            chart.Series[0].Points.Clear();
            chart.Series["synthesisSeries"].Points.Clear();
            chart.Series["synthesisSeries"].LegendText = "Линия тренда";
            chart.Series["synthesisSeries"].Enabled = true;

            var range = data.GetMaxPositiveRange();
            var synthesisY = data.GetExpRegressinYFromX(data.GetExponentialRegression());
            var xy = data.XY.Skip(range[0]).Take(range[1] - range[0] +1).ToArray();

            foreach (var kv in xy)
                chart.Series[0].Points.AddXY(kv.Key, kv.Value);

            for (int i = 0; i < synthesisY.Length; i++)
                chart.Series[1].Points.AddXY(xy[i].Key, synthesisY[i]);

            chart.ChartAreas[0].AxisY.Minimum = Math.Round(xy.Select(x => x.Value).Min(), 2);
            chart.ChartAreas[0].AxisY.Maximum = Math.Round(xy.Select(x => x.Value).Max(), 2);
        }

        private void DrowFourierChart()
        {
            if (fourierHarmonics == null || fourierHarmonics.Count() == 0)
                return;

            var y = data.GetFourierYFromXValue(fourierHarmonics);

            DrawSynthesisSeries("Синтезированная функция", y);
        }

        #endregion
               
        # region Button ShowLegend Events.
        private void btnShowLegend_Click(object sender, EventArgs e)
        {
            chart.Legends[0].Enabled = !chart.Legends[0].Enabled;
        }

        private void btnShowLegend_MouseEnter(object sender, EventArgs e)
        {
            btnShowLegend.Image = chart.Legends[0].Enabled ? Properties.Resources.legend_default : Properties.Resources.legend_active;
        }

        private void btnShowLegend_MouseLeave(object sender, EventArgs e)
        {
            btnShowLegend.Image = !chart.Legends[0].Enabled ? Properties.Resources.legend_default : Properties.Resources.legend_active;
        }
        #endregion

        #region Slider Buttons
        private void LeftSlideBtn_MouseEnter(object sender, EventArgs e)
        {
            var btn = (sender as PictureBox);

            if (btn == null)
                return;
            
            if (btn.Name == "LeftSlideBtn")
            {
                LeftSlideBtn.Image = Properties.Resources.left_active;
                return;
            }

            RightSlideBtn.Image = Properties.Resources.right_active;
        }

        private void LeftSlideBtn_MouseLeave(object sender, EventArgs e)
        {
            var btn = (sender as PictureBox);

            if (btn == null)
                return;

            if (btn.Name == "LeftSlideBtn")
            {
                LeftSlideBtn.Image = Properties.Resources.left;
                return;
            }

            RightSlideBtn.Image = Properties.Resources.right;
        }
        #endregion
    }
}
