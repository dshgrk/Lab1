namespace IntervalTrackBarUsing
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.intervalTrackBar1 = new IntervalTrackBar.IntervalTrackBar();
            this.SuspendLayout();
            // 
            // intervalTrackBar1
            // 
            this.intervalTrackBar1.Location = new System.Drawing.Point(198, 108);
            this.intervalTrackBar1.MaxValue = 0;
            this.intervalTrackBar1.MinimumSize = new System.Drawing.Size(205, 187);
            this.intervalTrackBar1.MinValue = 0;
            this.intervalTrackBar1.Name = "intervalTrackBar1";
            this.intervalTrackBar1.Size = new System.Drawing.Size(409, 216);
            this.intervalTrackBar1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.intervalTrackBar1);
            this.Name = "Form1";
            this.Text = "ElementTesting";
            this.ResumeLayout(false);

        }

        #endregion

        private IntervalTrackBar.IntervalTrackBar intervalTrackBar1;
    }
}

