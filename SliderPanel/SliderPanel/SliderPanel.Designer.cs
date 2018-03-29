namespace SliderPanel
{
    partial class SliderPanel
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // SliderPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "SliderPanel";
            this.Size = new System.Drawing.Size(569, 195);
            this.SizeChanged += new System.EventHandler(this.SliderPanel_SizeChanged);
            this.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.SliderPanel_ControlAdded);
            this.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.SliderPanel_ControlRemoved);
            this.Resize += new System.EventHandler(this.SliderPanel_Resize);
            this.ResumeLayout(false);

        }

        #endregion

    }
}
