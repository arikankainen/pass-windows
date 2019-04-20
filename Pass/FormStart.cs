using System;
using System.Threading;
using System.Windows.Forms;

namespace Pass
{
    public partial class FormStart : Form
    {
        public string Pass
        {
            get { return textBox1.Text; }
        }

        private bool readyForEnter = false;

        public FormStart()
        {
            InitializeComponent();
            AddLines();
        }

        private void AddLines()
        {
            Line(panel1.Height, (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left));
        }

        private void Line(int top, AnchorStyles a)
        {
            Label labelLine = new Label();
            labelLine.Top = top;
            labelLine.Left = 0;
            labelLine.AutoSize = false;
            labelLine.Height = 2;
            labelLine.Width = panel1.Width + 1;
            labelLine.BorderStyle = BorderStyle.Fixed3D;
            labelLine.Anchor = a;
            this.Controls.Add(labelLine);
            labelLine.BringToFront();
        }

        private void FormStart_Shown(object sender, EventArgs e)
        {
            textBox1.Focus();
            timer1.Start();
        }

        private void TextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (readyForEnter) this.Close();
            }

            else if (e.KeyCode == Keys.Escape)
            {
                textBox1.Clear();
                this.Close();
            }

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            readyForEnter = true;
            timer1.Stop();
        }
    }
}
