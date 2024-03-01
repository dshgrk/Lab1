using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntervalTrackBar
{
    //[ToolboxBitmap(typeof(IntervalTrackBar), "IntervalTrackBar.ico")]

    [ToolboxBitmap(@"E:\УНИВЕРСИТЕТ\2 курс\2 семестр\Шарп\Lab1\IntervalTrackBar\IntervalTrackBar.ico")]
    //[ToolboxBitmap(typeof(IntervalTrackBar), @"E:\УНИВЕРСИТЕТ\2 курс\2 семестр\Шарп\Lab1\IntervalTrackBar\IntervalTrackBar.ico")]

    public partial class IntervalTrackBar : UserControl
    {
        private TrackBar minTrackBar;
        private TrackBar maxTrackBar;
        private Label labelMin;
        private Label labelMax;
        private TextBox output;
        private Font myFont = new Font("Times New Roman", 10);

        public int MinValue
        {
            get { return minTrackBar.Value; }
            set { minTrackBar.Value = value; }
        }

        public int MaxValue
        {
            get { return maxTrackBar.Value; }
            set { maxTrackBar.Value = value; }
        }

        public IntervalTrackBar()
        {
            InitializeComponents();
            SizeChanged += IntervalTrackBar_Resize;
        }

        private void InitializeComponents()
        {
            minTrackBar = new TrackBar();
            maxTrackBar = new TrackBar();
            labelMin = new Label();
            labelMax = new Label();
            output = new TextBox();

            //налаштування міток що знаходяться зліва від трекбарів
            labelMin.Text = "min";
            labelMax.Text = "max";
            labelMin.BackColor = Color.Transparent;
            labelMax.BackColor= Color.Transparent;
            labelMin.TextAlign = ContentAlignment.MiddleLeft;
            labelMax.TextAlign = ContentAlignment.MiddleLeft;
            labelMin.AutoSize = true;
            labelMax.AutoSize = true;
            labelMin.Dock = DockStyle.Top;
            labelMax.Dock = DockStyle.Top;
            labelMin.Font = myFont;
            labelMax.Font = myFont;
            
            //налаштування самих трекбарів
            minTrackBar.Orientation = Orientation.Horizontal;
            maxTrackBar.Orientation = Orientation.Horizontal;
            minTrackBar.Dock = DockStyle.Fill;
            maxTrackBar.Dock = DockStyle.Fill;
            minTrackBar.MinimumSize = new Size(110, 30);
            maxTrackBar.MinimumSize = new Size(110, 30);
            //minTrackBar.AutoSize = true;
            //maxTrackBar.AutoSize = true;
            minTrackBar.Maximum = 10;
            maxTrackBar.Maximum = 10;

            //налаштування текстбоксу в який виводиться інформація 
            output.BackColor = Color.White;
            output.MinimumSize = new Size(55, 50);
            output.Enabled = false;
            output.ForeColor = Color.Black;
            output.Multiline = true;
            output.Text = "Оберіть інтервал";
            output.Dock = DockStyle.Fill;
            output.TextAlign = HorizontalAlignment.Center;
            output.Font = myFont;
            
            //створюю табличну панельку та налаштовую її
            TableLayoutPanel panel = new TableLayoutPanel();

            panel.Dock = DockStyle.Fill;
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            panel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            panel.BackColor = Color.Transparent;
           
            //додаю всі мої елементи в панель
            panel.Controls.Add(labelMin, 0, 0);
            panel.Controls.Add(minTrackBar, 1, 0);
            panel.Controls.Add(labelMax, 0, 1);
            panel.Controls.Add(maxTrackBar, 1, 1);
            panel.Controls.Add(output, 1, 2);

            //встановлюю мінімальний розмір для всього елементу
            MinimumSize = new Size(205, 187);

            Controls.Add(panel);
           
            minTrackBar.Scroll += (sender, e) => { OnValueChanged(EventArgs.Empty); };
            maxTrackBar.Scroll += (sender, e) => { OnValueChanged(EventArgs.Empty); };

            AutoScaleMode = AutoScaleMode.Font;

        }

        private void IntervalTrackBar_Resize(object sender, EventArgs e)
        {
            if (Width == 200) 
            {
                output.Font = myFont;
                labelMin.Font = myFont;
                labelMax.Font = myFont;
            }
            else if (Width > 200 && Width <= 230)
            {
                output.Font = new Font(output.Font.OriginalFontName, 12);
                labelMin.Font = new Font(labelMin.Font.OriginalFontName, 12);
                labelMax.Font = new Font(labelMin.Font.OriginalFontName, 12);
            }
            else if (Width > 230 && Width <= 260)
            {
                output.Font = new Font(output.Font.OriginalFontName, 14);
                labelMin.Font = new Font(labelMin.Font.OriginalFontName, 14);
                labelMax.Font = new Font(labelMin.Font.OriginalFontName, 14);
            }
            else if (Width > 260 && Width <= 290)
            {
                output.Font = new Font(output.Font.OriginalFontName, 16);
                labelMin.Font = new Font(labelMin.Font.OriginalFontName, 16);
                labelMax.Font = new Font(labelMin.Font.OriginalFontName, 16);
            }
            else if (Width > 290 && Width <= 320)
            {
                output.Font = new Font(output.Font.OriginalFontName, 18);
                labelMin.Font = new Font(labelMin.Font.OriginalFontName, 18);
                labelMax.Font = new Font(labelMin.Font.OriginalFontName, 18);
            }
            else if (Width > 320 && Width <= 350)
            {
                output.Font = new Font(output.Font.OriginalFontName, 20);
                labelMin.Font = new Font(labelMin.Font.OriginalFontName, 20);
                labelMax.Font = new Font(labelMin.Font.OriginalFontName, 20);
            }
            else if (Width > 350 && Width <= 380)
            {
                output.Font = new Font(output.Font.OriginalFontName, 22);
                labelMin.Font = new Font(labelMin.Font.OriginalFontName, 22);
                labelMax.Font = new Font(labelMin.Font.OriginalFontName, 22);
            }
        }


        protected virtual void OnValueChanged(EventArgs e)
        {
            EventHandler handler = ValueChanged;
            handler?.Invoke(this, e);

            if (MinValue < MaxValue)
            {
                minTrackBar.BackColor = Color.DarkSeaGreen;
                maxTrackBar.BackColor = Color.DarkSeaGreen;
            }
            else if (MinValue > MaxValue)
            {
                minTrackBar.BackColor = Color.IndianRed;
                maxTrackBar.BackColor = Color.IndianRed;
            }
            else 
            {
                minTrackBar.BackColor = Color.Beige;
                maxTrackBar.BackColor = Color.Beige;
            }


            if (MinValue < MaxValue)
            output.Text = $"Обрано інтервал від {MinValue} до {MaxValue}";
            else
            output.Text = "Оберіть правильний інтервал!!!";

        }

        public event EventHandler ValueChanged;
    }
}

