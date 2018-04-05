namespace LW1
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCalulate = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnReport = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDrawGraphics = new System.Windows.Forms.ToolStripButton();
            this.tbError = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tabsMain = new System.Windows.Forms.TabControl();
            this.tabData = new System.Windows.Forms.TabPage();
            this.cbLinear = new System.Windows.Forms.CheckBox();
            this.cbRandomFactor = new System.Windows.Forms.CheckBox();
            this.tabStatistic = new System.Windows.Forms.TabPage();
            this.LinkRemoveSelection = new System.Windows.Forms.LinkLabel();
            this.linkSelectAll = new System.Windows.Forms.LinkLabel();
            this.cbMode = new System.Windows.Forms.CheckBox();
            this.cbMediana = new System.Windows.Forms.CheckBox();
            this.cbInterval = new System.Windows.Forms.CheckBox();
            this.cbKurtosis = new System.Windows.Forms.CheckBox();
            this.cbSkewness = new System.Windows.Forms.CheckBox();
            this.cbSum = new System.Windows.Forms.CheckBox();
            this.cbStandardError = new System.Windows.Forms.CheckBox();
            this.cbDispersion = new System.Windows.Forms.CheckBox();
            this.cbStandardDeviation = new System.Windows.Forms.CheckBox();
            this.cbCount = new System.Windows.Forms.CheckBox();
            this.cbAverage = new System.Windows.Forms.CheckBox();
            this.cbMin = new System.Windows.Forms.CheckBox();
            this.cbMax = new System.Windows.Forms.CheckBox();
            this.tabRegression = new System.Windows.Forms.TabPage();
            this.tbRegPoints = new System.Windows.Forms.TextBox();
            this.lblRegPoints = new System.Windows.Forms.Label();
            this.cbIsDegree = new System.Windows.Forms.CheckBox();
            this.tbDegree = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabFourier = new System.Windows.Forms.TabPage();
            this.lblFourierPoints = new System.Windows.Forms.Label();
            this.cbIsHarmonicCount = new System.Windows.Forms.CheckBox();
            this.tbFourierPoints = new System.Windows.Forms.TextBox();
            this.tbHarmonicCount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabWavelet = new System.Windows.Forms.TabPage();
            this.tabGA = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.LeftSlideBtn = new System.Windows.Forms.PictureBox();
            this.RightSlideBtn = new System.Windows.Forms.PictureBox();
            this.btnShowLegend = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sliderPanel = new SliderPanel.SliderPanel();
            this.panelData = new System.Windows.Forms.Panel();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.colDataX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelStatistics = new System.Windows.Forms.Panel();
            this.dgvStatistic = new System.Windows.Forms.DataGridView();
            this.colStatParam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelRegression = new System.Windows.Forms.Panel();
            this.dgvRegression = new System.Windows.Forms.DataGridView();
            this.colRegParam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRegValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelFourier = new System.Windows.Forms.Panel();
            this.dgvFourier = new System.Windows.Forms.DataGridView();
            this.colFourierParam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFourierValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cbExponentialRegression = new System.Windows.Forms.CheckBox();
            this.tsMenu.SuspendLayout();
            this.tabsMain.SuspendLayout();
            this.tabData.SuspendLayout();
            this.tabStatistic.SuspendLayout();
            this.tabRegression.SuspendLayout();
            this.tabFourier.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftSlideBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightSlideBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowLegend)).BeginInit();
            this.sliderPanel.SuspendLayout();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelStatistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistic)).BeginInit();
            this.panel7.SuspendLayout();
            this.panelRegression.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegression)).BeginInit();
            this.panel8.SuspendLayout();
            this.panelFourier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFourier)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMenu
            // 
            this.tsMenu.BackColor = System.Drawing.SystemColors.Control;
            this.tsMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.btnCalulate,
            this.toolStripSeparator2,
            this.btnReport,
            this.toolStripSeparator3,
            this.btnDrawGraphics,
            this.tbError,
            this.toolStripLabel2});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Padding = new System.Windows.Forms.Padding(0, 2, 1, 2);
            this.tsMenu.Size = new System.Drawing.Size(822, 27);
            this.tsMenu.TabIndex = 0;
            this.tsMenu.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(67, 20);
            this.toolStripLabel1.Text = "Вариант 10";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // btnCalulate
            // 
            this.btnCalulate.Image = global::LW1.Properties.Resources.build;
            this.btnCalulate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCalulate.Name = "btnCalulate";
            this.btnCalulate.Size = new System.Drawing.Size(64, 20);
            this.btnCalulate.Text = "Расчет";
            this.btnCalulate.Click += new System.EventHandler(this.btnCalulate_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // btnReport
            // 
            this.btnReport.Image = global::LW1.Properties.Resources.reportMI;
            this.btnReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(59, 20);
            this.btnReport.Text = "Отчет";
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
            // 
            // btnDrawGraphics
            // 
            this.btnDrawGraphics.Image = global::LW1.Properties.Resources.chart;
            this.btnDrawGraphics.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDrawGraphics.Name = "btnDrawGraphics";
            this.btnDrawGraphics.Size = new System.Drawing.Size(68, 20);
            this.btnDrawGraphics.Text = "График";
            this.btnDrawGraphics.Click += new System.EventHandler(this.btnDrawGraphics_Click);
            // 
            // tbError
            // 
            this.tbError.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tbError.Margin = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.tbError.MaxLength = 10;
            this.tbError.Name = "tbError";
            this.tbError.Size = new System.Drawing.Size(60, 23);
            this.tbError.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbError_KeyPress);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(86, 20);
            this.toolStripLabel2.Text = "Погрешность:";
            // 
            // tabsMain
            // 
            this.tabsMain.Controls.Add(this.tabData);
            this.tabsMain.Controls.Add(this.tabStatistic);
            this.tabsMain.Controls.Add(this.tabRegression);
            this.tabsMain.Controls.Add(this.tabFourier);
            this.tabsMain.Controls.Add(this.tabWavelet);
            this.tabsMain.Controls.Add(this.tabGA);
            this.tabsMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabsMain.ItemSize = new System.Drawing.Size(65, 25);
            this.tabsMain.Location = new System.Drawing.Point(0, 27);
            this.tabsMain.Name = "tabsMain";
            this.tabsMain.SelectedIndex = 0;
            this.tabsMain.Size = new System.Drawing.Size(822, 115);
            this.tabsMain.TabIndex = 2;
            // 
            // tabData
            // 
            this.tabData.Controls.Add(this.cbLinear);
            this.tabData.Controls.Add(this.cbRandomFactor);
            this.tabData.Location = new System.Drawing.Point(4, 29);
            this.tabData.Name = "tabData";
            this.tabData.Padding = new System.Windows.Forms.Padding(3);
            this.tabData.Size = new System.Drawing.Size(814, 82);
            this.tabData.TabIndex = 0;
            this.tabData.Text = "Данные";
            this.tabData.UseVisualStyleBackColor = true;
            // 
            // cbLinear
            // 
            this.cbLinear.AutoSize = true;
            this.cbLinear.Checked = true;
            this.cbLinear.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLinear.Location = new System.Drawing.Point(8, 51);
            this.cbLinear.Name = "cbLinear";
            this.cbLinear.Size = new System.Drawing.Size(147, 17);
            this.cbLinear.TabIndex = 2;
            this.cbLinear.Text = "Учесть линейный тренд";
            this.cbLinear.UseVisualStyleBackColor = true;
            // 
            // cbRandomFactor
            // 
            this.cbRandomFactor.AutoSize = true;
            this.cbRandomFactor.Checked = true;
            this.cbRandomFactor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRandomFactor.Location = new System.Drawing.Point(8, 19);
            this.cbRandomFactor.Name = "cbRandomFactor";
            this.cbRandomFactor.Size = new System.Drawing.Size(159, 17);
            this.cbRandomFactor.TabIndex = 1;
            this.cbRandomFactor.Text = "Учесть случайный фактор";
            this.cbRandomFactor.UseVisualStyleBackColor = true;
            // 
            // tabStatistic
            // 
            this.tabStatistic.Controls.Add(this.LinkRemoveSelection);
            this.tabStatistic.Controls.Add(this.linkSelectAll);
            this.tabStatistic.Controls.Add(this.cbMode);
            this.tabStatistic.Controls.Add(this.cbMediana);
            this.tabStatistic.Controls.Add(this.cbInterval);
            this.tabStatistic.Controls.Add(this.cbKurtosis);
            this.tabStatistic.Controls.Add(this.cbSkewness);
            this.tabStatistic.Controls.Add(this.cbSum);
            this.tabStatistic.Controls.Add(this.cbStandardError);
            this.tabStatistic.Controls.Add(this.cbDispersion);
            this.tabStatistic.Controls.Add(this.cbStandardDeviation);
            this.tabStatistic.Controls.Add(this.cbCount);
            this.tabStatistic.Controls.Add(this.cbAverage);
            this.tabStatistic.Controls.Add(this.cbMin);
            this.tabStatistic.Controls.Add(this.cbMax);
            this.tabStatistic.Location = new System.Drawing.Point(4, 29);
            this.tabStatistic.Name = "tabStatistic";
            this.tabStatistic.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatistic.Size = new System.Drawing.Size(814, 82);
            this.tabStatistic.TabIndex = 1;
            this.tabStatistic.Text = "Статистика";
            this.tabStatistic.UseVisualStyleBackColor = true;
            // 
            // LinkRemoveSelection
            // 
            this.LinkRemoveSelection.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(69)))));
            this.LinkRemoveSelection.AutoSize = true;
            this.LinkRemoveSelection.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(187)))), ((int)(((byte)(166)))));
            this.LinkRemoveSelection.Location = new System.Drawing.Point(678, 57);
            this.LinkRemoveSelection.Name = "LinkRemoveSelection";
            this.LinkRemoveSelection.Size = new System.Drawing.Size(96, 13);
            this.LinkRemoveSelection.TabIndex = 9;
            this.LinkRemoveSelection.TabStop = true;
            this.LinkRemoveSelection.Text = "Снять выделение";
            this.LinkRemoveSelection.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLables_LinkClicked);
            // 
            // linkSelectAll
            // 
            this.linkSelectAll.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(69)))));
            this.linkSelectAll.AutoSize = true;
            this.linkSelectAll.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(187)))), ((int)(((byte)(166)))));
            this.linkSelectAll.Location = new System.Drawing.Point(678, 37);
            this.linkSelectAll.Name = "linkSelectAll";
            this.linkSelectAll.Size = new System.Drawing.Size(78, 13);
            this.linkSelectAll.TabIndex = 9;
            this.linkSelectAll.TabStop = true;
            this.linkSelectAll.Text = "Выделить все";
            this.linkSelectAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLables_LinkClicked);
            // 
            // cbMode
            // 
            this.cbMode.AutoSize = true;
            this.cbMode.Checked = true;
            this.cbMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMode.Location = new System.Drawing.Point(200, 10);
            this.cbMode.Name = "cbMode";
            this.cbMode.Size = new System.Drawing.Size(85, 17);
            this.cbMode.TabIndex = 6;
            this.cbMode.Text = "Найти моду";
            this.cbMode.UseVisualStyleBackColor = true;
            // 
            // cbMediana
            // 
            this.cbMediana.AutoSize = true;
            this.cbMediana.Checked = true;
            this.cbMediana.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMediana.Location = new System.Drawing.Point(200, 33);
            this.cbMediana.Name = "cbMediana";
            this.cbMediana.Size = new System.Drawing.Size(103, 17);
            this.cbMediana.TabIndex = 6;
            this.cbMediana.Text = "Найти медиану";
            this.cbMediana.UseVisualStyleBackColor = true;
            // 
            // cbInterval
            // 
            this.cbInterval.AutoSize = true;
            this.cbInterval.Checked = true;
            this.cbInterval.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbInterval.Location = new System.Drawing.Point(322, 56);
            this.cbInterval.Name = "cbInterval";
            this.cbInterval.Size = new System.Drawing.Size(107, 17);
            this.cbInterval.TabIndex = 6;
            this.cbInterval.Text = "Найти интервал";
            this.cbInterval.UseVisualStyleBackColor = true;
            // 
            // cbKurtosis
            // 
            this.cbKurtosis.AutoSize = true;
            this.cbKurtosis.Checked = true;
            this.cbKurtosis.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbKurtosis.Location = new System.Drawing.Point(322, 33);
            this.cbKurtosis.Name = "cbKurtosis";
            this.cbKurtosis.Size = new System.Drawing.Size(151, 17);
            this.cbKurtosis.TabIndex = 6;
            this.cbKurtosis.Text = "Найти асимметричность";
            this.cbKurtosis.UseVisualStyleBackColor = true;
            // 
            // cbSkewness
            // 
            this.cbSkewness.AutoSize = true;
            this.cbSkewness.Checked = true;
            this.cbSkewness.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSkewness.Location = new System.Drawing.Point(322, 10);
            this.cbSkewness.Name = "cbSkewness";
            this.cbSkewness.Size = new System.Drawing.Size(102, 17);
            this.cbSkewness.TabIndex = 6;
            this.cbSkewness.Text = "Найти эксцесс";
            this.cbSkewness.UseVisualStyleBackColor = true;
            // 
            // cbSum
            // 
            this.cbSum.AutoSize = true;
            this.cbSum.Checked = true;
            this.cbSum.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSum.Location = new System.Drawing.Point(474, 56);
            this.cbSum.Name = "cbSum";
            this.cbSum.Size = new System.Drawing.Size(92, 17);
            this.cbSum.TabIndex = 6;
            this.cbSum.Text = "Найти сумму";
            this.cbSum.UseVisualStyleBackColor = true;
            // 
            // cbStandardError
            // 
            this.cbStandardError.AutoSize = true;
            this.cbStandardError.Checked = true;
            this.cbStandardError.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbStandardError.Location = new System.Drawing.Point(8, 33);
            this.cbStandardError.Name = "cbStandardError";
            this.cbStandardError.Size = new System.Drawing.Size(165, 17);
            this.cbStandardError.TabIndex = 5;
            this.cbStandardError.Text = "Найти стандартную ошибку";
            this.cbStandardError.UseVisualStyleBackColor = true;
            // 
            // cbDispersion
            // 
            this.cbDispersion.AutoSize = true;
            this.cbDispersion.Checked = true;
            this.cbDispersion.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDispersion.Location = new System.Drawing.Point(200, 56);
            this.cbDispersion.Name = "cbDispersion";
            this.cbDispersion.Size = new System.Drawing.Size(116, 17);
            this.cbDispersion.TabIndex = 8;
            this.cbDispersion.Text = "Найти дисперсию";
            this.cbDispersion.UseVisualStyleBackColor = true;
            // 
            // cbStandardDeviation
            // 
            this.cbStandardDeviation.AutoSize = true;
            this.cbStandardDeviation.Checked = true;
            this.cbStandardDeviation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbStandardDeviation.Location = new System.Drawing.Point(8, 56);
            this.cbStandardDeviation.Name = "cbStandardDeviation";
            this.cbStandardDeviation.Size = new System.Drawing.Size(186, 17);
            this.cbStandardDeviation.TabIndex = 7;
            this.cbStandardDeviation.Text = "Найти стандартное отклонение";
            this.cbStandardDeviation.UseVisualStyleBackColor = true;
            // 
            // cbCount
            // 
            this.cbCount.AutoSize = true;
            this.cbCount.Checked = true;
            this.cbCount.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCount.Location = new System.Drawing.Point(681, 10);
            this.cbCount.Name = "cbCount";
            this.cbCount.Size = new System.Drawing.Size(82, 17);
            this.cbCount.TabIndex = 2;
            this.cbCount.Text = "Найти счет";
            this.cbCount.UseVisualStyleBackColor = true;
            // 
            // cbAverage
            // 
            this.cbAverage.AutoSize = true;
            this.cbAverage.Checked = true;
            this.cbAverage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAverage.Location = new System.Drawing.Point(8, 10);
            this.cbAverage.Name = "cbAverage";
            this.cbAverage.Size = new System.Drawing.Size(152, 17);
            this.cbAverage.TabIndex = 1;
            this.cbAverage.Text = "Найти среднее значение";
            this.cbAverage.UseVisualStyleBackColor = true;
            // 
            // cbMin
            // 
            this.cbMin.AutoSize = true;
            this.cbMin.Checked = true;
            this.cbMin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMin.Location = new System.Drawing.Point(474, 10);
            this.cbMin.Name = "cbMin";
            this.cbMin.Size = new System.Drawing.Size(180, 17);
            this.cbMin.TabIndex = 4;
            this.cbMin.Text = "Найти минимальное значение";
            this.cbMin.UseVisualStyleBackColor = true;
            // 
            // cbMax
            // 
            this.cbMax.AutoSize = true;
            this.cbMax.Checked = true;
            this.cbMax.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMax.Location = new System.Drawing.Point(474, 33);
            this.cbMax.Name = "cbMax";
            this.cbMax.Size = new System.Drawing.Size(186, 17);
            this.cbMax.TabIndex = 3;
            this.cbMax.Text = "Найти максимальное значение";
            this.cbMax.UseVisualStyleBackColor = true;
            // 
            // tabRegression
            // 
            this.tabRegression.Controls.Add(this.cbExponentialRegression);
            this.tabRegression.Controls.Add(this.tbRegPoints);
            this.tabRegression.Controls.Add(this.lblRegPoints);
            this.tabRegression.Controls.Add(this.cbIsDegree);
            this.tabRegression.Controls.Add(this.tbDegree);
            this.tabRegression.Controls.Add(this.label5);
            this.tabRegression.Location = new System.Drawing.Point(4, 29);
            this.tabRegression.Name = "tabRegression";
            this.tabRegression.Size = new System.Drawing.Size(814, 82);
            this.tabRegression.TabIndex = 2;
            this.tabRegression.Text = "Регрессия";
            this.tabRegression.UseVisualStyleBackColor = true;
            // 
            // tbRegPoints
            // 
            this.tbRegPoints.Location = new System.Drawing.Point(128, 50);
            this.tbRegPoints.MaxLength = 4;
            this.tbRegPoints.Name = "tbRegPoints";
            this.tbRegPoints.Size = new System.Drawing.Size(54, 20);
            this.tbRegPoints.TabIndex = 11;
            this.tbRegPoints.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDegree_KeyPress);
            // 
            // lblRegPoints
            // 
            this.lblRegPoints.AutoSize = true;
            this.lblRegPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRegPoints.ForeColor = System.Drawing.Color.DimGray;
            this.lblRegPoints.Location = new System.Drawing.Point(22, 60);
            this.lblRegPoints.Name = "lblRegPoints";
            this.lblRegPoints.Size = new System.Drawing.Size(65, 13);
            this.lblRegPoints.TabIndex = 10;
            this.lblRegPoints.Text = "От 0 до 365";
            // 
            // cbIsDegree
            // 
            this.cbIsDegree.AutoSize = true;
            this.cbIsDegree.Location = new System.Drawing.Point(25, 14);
            this.cbIsDegree.Name = "cbIsDegree";
            this.cbIsDegree.Size = new System.Drawing.Size(184, 17);
            this.cbIsDegree.TabIndex = 4;
            this.cbIsDegree.Text = "Учитывать степень полинома :";
            this.cbIsDegree.UseVisualStyleBackColor = true;
            this.cbIsDegree.CheckedChanged += new System.EventHandler(this.cbIsDegree_CheckedChanged);
            // 
            // tbDegree
            // 
            this.tbDegree.Enabled = false;
            this.tbDegree.Location = new System.Drawing.Point(209, 12);
            this.tbDegree.MaxLength = 3;
            this.tbDegree.Name = "tbDegree";
            this.tbDegree.Size = new System.Drawing.Size(39, 20);
            this.tbDegree.TabIndex = 2;
            this.tbDegree.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDegree_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Количество точек";
            // 
            // tabFourier
            // 
            this.tabFourier.Controls.Add(this.lblFourierPoints);
            this.tabFourier.Controls.Add(this.cbIsHarmonicCount);
            this.tabFourier.Controls.Add(this.tbFourierPoints);
            this.tabFourier.Controls.Add(this.tbHarmonicCount);
            this.tabFourier.Controls.Add(this.label6);
            this.tabFourier.Location = new System.Drawing.Point(4, 29);
            this.tabFourier.Name = "tabFourier";
            this.tabFourier.Size = new System.Drawing.Size(814, 82);
            this.tabFourier.TabIndex = 3;
            this.tabFourier.Text = "Фурье";
            this.tabFourier.UseVisualStyleBackColor = true;
            // 
            // lblFourierPoints
            // 
            this.lblFourierPoints.AutoSize = true;
            this.lblFourierPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFourierPoints.ForeColor = System.Drawing.Color.DimGray;
            this.lblFourierPoints.Location = new System.Drawing.Point(22, 60);
            this.lblFourierPoints.Name = "lblFourierPoints";
            this.lblFourierPoints.Size = new System.Drawing.Size(65, 13);
            this.lblFourierPoints.TabIndex = 9;
            this.lblFourierPoints.Text = "От 0 до 365";
            // 
            // cbIsHarmonicCount
            // 
            this.cbIsHarmonicCount.AutoSize = true;
            this.cbIsHarmonicCount.Location = new System.Drawing.Point(25, 14);
            this.cbIsHarmonicCount.Name = "cbIsHarmonicCount";
            this.cbIsHarmonicCount.Size = new System.Drawing.Size(200, 17);
            this.cbIsHarmonicCount.TabIndex = 8;
            this.cbIsHarmonicCount.Text = "Учитывать количество гармоник :";
            this.cbIsHarmonicCount.UseVisualStyleBackColor = true;
            this.cbIsHarmonicCount.CheckedChanged += new System.EventHandler(this.cbIsHarmonicCount_CheckedChanged);
            // 
            // tbFourierPoints
            // 
            this.tbFourierPoints.Location = new System.Drawing.Point(128, 50);
            this.tbFourierPoints.MaxLength = 4;
            this.tbFourierPoints.Name = "tbFourierPoints";
            this.tbFourierPoints.Size = new System.Drawing.Size(54, 20);
            this.tbFourierPoints.TabIndex = 7;
            this.tbFourierPoints.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDegree_KeyPress);
            // 
            // tbHarmonicCount
            // 
            this.tbHarmonicCount.Enabled = false;
            this.tbHarmonicCount.Location = new System.Drawing.Point(225, 12);
            this.tbHarmonicCount.MaxLength = 3;
            this.tbHarmonicCount.Name = "tbHarmonicCount";
            this.tbHarmonicCount.Size = new System.Drawing.Size(39, 20);
            this.tbHarmonicCount.TabIndex = 7;
            this.tbHarmonicCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDegree_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Количество точек";
            // 
            // tabWavelet
            // 
            this.tabWavelet.BackColor = System.Drawing.Color.Transparent;
            this.tabWavelet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabWavelet.Location = new System.Drawing.Point(4, 29);
            this.tabWavelet.Name = "tabWavelet";
            this.tabWavelet.Size = new System.Drawing.Size(814, 82);
            this.tabWavelet.TabIndex = 4;
            this.tabWavelet.Text = "Вейвлет";
            this.tabWavelet.UseVisualStyleBackColor = true;
            // 
            // tabGA
            // 
            this.tabGA.Location = new System.Drawing.Point(4, 29);
            this.tabGA.Name = "tabGA";
            this.tabGA.Size = new System.Drawing.Size(814, 82);
            this.tabGA.TabIndex = 5;
            this.tabGA.Text = "ГА";
            this.tabGA.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.chart);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.sliderPanel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 142);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(822, 516);
            this.panel4.TabIndex = 3;
            // 
            // chart
            // 
            chartArea1.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea1.AlignmentStyle = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentStyles.AxesView;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.LineWidth = 2;
            chartArea1.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Stacked;
            chartArea1.AxisX.Title = "X";
            chartArea1.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisY.LineWidth = 2;
            chartArea1.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated270;
            chartArea1.AxisY.Title = "Y";
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Cursor = System.Windows.Forms.Cursors.Default;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Name = "mainLegend";
            legend1.Title = "Легенда:";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(0, 220);
            this.chart.Name = "chart";
            this.chart.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(187)))), ((int)(((byte)(166)))));
            series1.Legend = "mainLegend";
            series1.LegendText = "Исходная функция";
            series1.Name = "mainSeries";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Enabled = false;
            series2.Legend = "mainLegend";
            series2.LegendText = "Линия тренда";
            series2.Name = "synthesisSeries";
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(822, 296);
            this.chart.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(69)))));
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 195);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(822, 25);
            this.panel5.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(69)))));
            this.panel9.Controls.Add(this.LeftSlideBtn);
            this.panel9.Controls.Add(this.RightSlideBtn);
            this.panel9.Controls.Add(this.btnShowLegend);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(674, 0);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(2);
            this.panel9.Size = new System.Drawing.Size(148, 25);
            this.panel9.TabIndex = 1;
            // 
            // LeftSlideBtn
            // 
            this.LeftSlideBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LeftSlideBtn.Image = global::LW1.Properties.Resources.left;
            this.LeftSlideBtn.Location = new System.Drawing.Point(71, 3);
            this.LeftSlideBtn.Name = "LeftSlideBtn";
            this.LeftSlideBtn.Size = new System.Drawing.Size(18, 18);
            this.LeftSlideBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LeftSlideBtn.TabIndex = 1;
            this.LeftSlideBtn.TabStop = false;
            this.LeftSlideBtn.MouseEnter += new System.EventHandler(this.LeftSlideBtn_MouseEnter);
            this.LeftSlideBtn.MouseLeave += new System.EventHandler(this.LeftSlideBtn_MouseLeave);
            // 
            // RightSlideBtn
            // 
            this.RightSlideBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RightSlideBtn.Image = global::LW1.Properties.Resources.right;
            this.RightSlideBtn.Location = new System.Drawing.Point(95, 3);
            this.RightSlideBtn.Name = "RightSlideBtn";
            this.RightSlideBtn.Size = new System.Drawing.Size(18, 18);
            this.RightSlideBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RightSlideBtn.TabIndex = 1;
            this.RightSlideBtn.TabStop = false;
            this.RightSlideBtn.MouseEnter += new System.EventHandler(this.LeftSlideBtn_MouseEnter);
            this.RightSlideBtn.MouseLeave += new System.EventHandler(this.LeftSlideBtn_MouseLeave);
            // 
            // btnShowLegend
            // 
            this.btnShowLegend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(69)))));
            this.btnShowLegend.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnShowLegend.Image = global::LW1.Properties.Resources.legend_default;
            this.btnShowLegend.Location = new System.Drawing.Point(125, 2);
            this.btnShowLegend.Name = "btnShowLegend";
            this.btnShowLegend.Size = new System.Drawing.Size(21, 21);
            this.btnShowLegend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnShowLegend.TabIndex = 0;
            this.btnShowLegend.TabStop = false;
            this.toolTip.SetToolTip(this.btnShowLegend, "Показать/Скрыть легенду");
            this.btnShowLegend.Click += new System.EventHandler(this.btnShowLegend_Click);
            this.btnShowLegend.MouseEnter += new System.EventHandler(this.btnShowLegend_MouseEnter);
            this.btnShowLegend.MouseLeave += new System.EventHandler(this.btnShowLegend_MouseLeave);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(69)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(822, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "График";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sliderPanel
            // 
            this.sliderPanel.BlocksSize = 250;
            this.sliderPanel.Controls.Add(this.panelData);
            this.sliderPanel.Controls.Add(this.panelStatistics);
            this.sliderPanel.Controls.Add(this.panelRegression);
            this.sliderPanel.Controls.Add(this.panelFourier);
            this.sliderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.sliderPanel.Location = new System.Drawing.Point(0, 0);
            this.sliderPanel.MaxBlock = 4;
            this.sliderPanel.Name = "sliderPanel";
            this.sliderPanel.Size = new System.Drawing.Size(822, 195);
            this.sliderPanel.Startindex = 0;
            this.sliderPanel.TabIndex = 2;
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.dgvData);
            this.panelData.Controls.Add(this.panel2);
            this.panelData.Location = new System.Drawing.Point(0, 0);
            this.panelData.Name = "panelData";
            this.panelData.Padding = new System.Windows.Forms.Padding(0, 4, 2, 5);
            this.panelData.Size = new System.Drawing.Size(186, 195);
            this.panelData.TabIndex = 6;
            // 
            // dgvData
            // 
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDataX,
            this.colDataY});
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(0, 29);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.Size = new System.Drawing.Size(184, 161);
            this.dgvData.TabIndex = 6;
            // 
            // colDataX
            // 
            this.colDataX.HeaderText = "X";
            this.colDataX.Name = "colDataX";
            this.colDataX.ReadOnly = true;
            this.colDataX.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // colDataY
            // 
            this.colDataY.HeaderText = "Y";
            this.colDataY.Name = "colDataY";
            this.colDataY.ReadOnly = true;
            this.colDataY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(184, 25);
            this.panel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(69)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Данные";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelStatistics
            // 
            this.panelStatistics.Controls.Add(this.dgvStatistic);
            this.panelStatistics.Controls.Add(this.panel7);
            this.panelStatistics.Location = new System.Drawing.Point(215, 0);
            this.panelStatistics.Name = "panelStatistics";
            this.panelStatistics.Padding = new System.Windows.Forms.Padding(2, 4, 2, 5);
            this.panelStatistics.Size = new System.Drawing.Size(274, 195);
            this.panelStatistics.TabIndex = 7;
            // 
            // dgvStatistic
            // 
            this.dgvStatistic.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStatistic.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.dgvStatistic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatistic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStatParam,
            this.colStatValue});
            this.dgvStatistic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStatistic.Location = new System.Drawing.Point(2, 29);
            this.dgvStatistic.Name = "dgvStatistic";
            this.dgvStatistic.ReadOnly = true;
            this.dgvStatistic.Size = new System.Drawing.Size(270, 161);
            this.dgvStatistic.TabIndex = 6;
            // 
            // colStatParam
            // 
            this.colStatParam.HeaderText = "Параметр";
            this.colStatParam.Name = "colStatParam";
            this.colStatParam.ReadOnly = true;
            this.colStatParam.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // colStatValue
            // 
            this.colStatValue.HeaderText = "Значение";
            this.colStatValue.Name = "colStatValue";
            this.colStatValue.ReadOnly = true;
            this.colStatValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.panel7.Controls.Add(this.label1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(2, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(270, 25);
            this.panel7.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(69)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Статистики";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelRegression
            // 
            this.panelRegression.Controls.Add(this.dgvRegression);
            this.panelRegression.Controls.Add(this.panel8);
            this.panelRegression.Location = new System.Drawing.Point(424, 0);
            this.panelRegression.Name = "panelRegression";
            this.panelRegression.Padding = new System.Windows.Forms.Padding(2, 4, 2, 5);
            this.panelRegression.Size = new System.Drawing.Size(274, 195);
            this.panelRegression.TabIndex = 8;
            // 
            // dgvRegression
            // 
            this.dgvRegression.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRegression.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.dgvRegression.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegression.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRegParam,
            this.colRegValue});
            this.dgvRegression.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRegression.Location = new System.Drawing.Point(2, 29);
            this.dgvRegression.Name = "dgvRegression";
            this.dgvRegression.ReadOnly = true;
            this.dgvRegression.Size = new System.Drawing.Size(270, 161);
            this.dgvRegression.TabIndex = 6;
            // 
            // colRegParam
            // 
            this.colRegParam.HeaderText = "Параметр";
            this.colRegParam.Name = "colRegParam";
            this.colRegParam.ReadOnly = true;
            this.colRegParam.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // colRegValue
            // 
            this.colRegValue.HeaderText = "Значение";
            this.colRegValue.Name = "colRegValue";
            this.colRegValue.ReadOnly = true;
            this.colRegValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.panel8.Controls.Add(this.label3);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(2, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(270, 25);
            this.panel8.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(69)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Регрессия";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelFourier
            // 
            this.panelFourier.Controls.Add(this.dgvFourier);
            this.panelFourier.Controls.Add(this.panel3);
            this.panelFourier.Location = new System.Drawing.Point(635, 2);
            this.panelFourier.Name = "panelFourier";
            this.panelFourier.Padding = new System.Windows.Forms.Padding(2, 4, 0, 5);
            this.panelFourier.Size = new System.Drawing.Size(274, 195);
            this.panelFourier.TabIndex = 9;
            // 
            // dgvFourier
            // 
            this.dgvFourier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFourier.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.dgvFourier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFourier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFourierParam,
            this.colFourierValue});
            this.dgvFourier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFourier.Location = new System.Drawing.Point(2, 29);
            this.dgvFourier.Name = "dgvFourier";
            this.dgvFourier.ReadOnly = true;
            this.dgvFourier.Size = new System.Drawing.Size(272, 161);
            this.dgvFourier.TabIndex = 6;
            // 
            // colFourierParam
            // 
            this.colFourierParam.HeaderText = "Параметр";
            this.colFourierParam.Name = "colFourierParam";
            this.colFourierParam.ReadOnly = true;
            this.colFourierParam.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // colFourierValue
            // 
            this.colFourierValue.HeaderText = "Значение";
            this.colFourierValue.Name = "colFourierValue";
            this.colFourierValue.ReadOnly = true;
            this.colFourierValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
            this.panel3.Controls.Add(this.label7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(2, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(272, 25);
            this.panel3.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(69)))));
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(272, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ряд Фурье";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "data";
            this.saveFileDialog.Filter = "CSV файл|*.csv";
            this.saveFileDialog.Title = "Сохранение данных";
            // 
            // toolTip
            // 
            this.toolTip.IsBalloon = true;
            this.toolTip.ToolTipTitle = "Подсказка";
            this.toolTip.UseAnimation = false;
            // 
            // cbExponentialRegression
            // 
            this.cbExponentialRegression.AutoSize = true;
            this.cbExponentialRegression.Location = new System.Drawing.Point(278, 14);
            this.cbExponentialRegression.Name = "cbExponentialRegression";
            this.cbExponentialRegression.Size = new System.Drawing.Size(179, 17);
            this.cbExponentialRegression.TabIndex = 12;
            this.cbExponentialRegression.Text = "Экспоненциальная регрессия";
            this.cbExponentialRegression.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(822, 658);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.tabsMain);
            this.Controls.Add(this.tsMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(830, 685);
            this.Name = "MainForm";
            this.Text = "СМОД. Лабораторные работы";
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.tabsMain.ResumeLayout(false);
            this.tabData.ResumeLayout(false);
            this.tabData.PerformLayout();
            this.tabStatistic.ResumeLayout(false);
            this.tabStatistic.PerformLayout();
            this.tabRegression.ResumeLayout(false);
            this.tabRegression.PerformLayout();
            this.tabFourier.ResumeLayout(false);
            this.tabFourier.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LeftSlideBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightSlideBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowLegend)).EndInit();
            this.sliderPanel.ResumeLayout(false);
            this.panelData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panelStatistics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistic)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panelRegression.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegression)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panelFourier.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFourier)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.TabControl tabsMain;
        private System.Windows.Forms.TabPage tabStatistic;
        private System.Windows.Forms.TabPage tabData;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelRegression;
        private System.Windows.Forms.DataGridView dgvRegression;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelStatistics;
        private System.Windows.Forms.DataGridView dgvStatistic;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnCalulate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnReport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnDrawGraphics;
        private System.Windows.Forms.ToolStripTextBox tbError;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.TabPage tabRegression;
        private System.Windows.Forms.TabPage tabFourier;
        private System.Windows.Forms.TabPage tabWavelet;
        private System.Windows.Forms.TabPage tabGA;
        private System.Windows.Forms.CheckBox cbLinear;
        private System.Windows.Forms.CheckBox cbRandomFactor;
        private System.Windows.Forms.CheckBox cbSum;
        private System.Windows.Forms.CheckBox cbStandardError;
        private System.Windows.Forms.CheckBox cbDispersion;
        private System.Windows.Forms.CheckBox cbStandardDeviation;
        private System.Windows.Forms.CheckBox cbCount;
        private System.Windows.Forms.CheckBox cbAverage;
        private System.Windows.Forms.CheckBox cbMin;
        private System.Windows.Forms.CheckBox cbMax;
        private System.Windows.Forms.CheckBox cbMode;
        private System.Windows.Forms.CheckBox cbMediana;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.PictureBox btnShowLegend;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataX;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDegree;
        private System.Windows.Forms.CheckBox cbIsDegree;
        private System.Windows.Forms.CheckBox cbInterval;
        private System.Windows.Forms.CheckBox cbKurtosis;
        private System.Windows.Forms.CheckBox cbSkewness;
        private System.Windows.Forms.LinkLabel linkSelectAll;
        private System.Windows.Forms.LinkLabel LinkRemoveSelection;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRegParam;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRegValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatParam;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatValue;
        private System.Windows.Forms.CheckBox cbIsHarmonicCount;
        private System.Windows.Forms.TextBox tbHarmonicCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private SliderPanel.SliderPanel sliderPanel;
        private System.Windows.Forms.Panel panelFourier;
        private System.Windows.Forms.DataGridView dgvFourier;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFourierParam;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFourierValue;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox LeftSlideBtn;
        private System.Windows.Forms.PictureBox RightSlideBtn;
        private System.Windows.Forms.TextBox tbFourierPoints;
        private System.Windows.Forms.TextBox tbRegPoints;
        private System.Windows.Forms.Label lblRegPoints;
        private System.Windows.Forms.Label lblFourierPoints;
        private System.Windows.Forms.CheckBox cbExponentialRegression;
    }
}