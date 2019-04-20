using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pass
{
    public partial class FormChangePassword : Form
    {
        public string Password
        {
            get { return txtPass1.Text; }
        }

        public bool CreateNew
        {
            set { labelName.Text = "Create master password"; }
        }

        public FormChangePassword()
        {
            InitializeComponent();
            AddLines();
        }

        private void AddLines()
        {
            Line(panel1.Height, (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left));
            Line(this.ClientRectangle.Height - 51, (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left));
        }

        private void Line(int top, AnchorStyles a)
        {
            Label labelLine = new Label();
            labelLine.Top = top;
            labelLine.Left = 0;
            labelLine.AutoSize = false;labelLine.Height = 2;
            labelLine.Width = panel1.Width + 1;
            labelLine.BorderStyle = BorderStyle.Fixed3D;
            labelLine.Anchor = a;
            this.Controls.Add(labelLine);
            labelLine.BringToFront();
        }

        private void FormChangePassword_Shown(object sender, EventArgs e)
        {
            txtPass1.Focus();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (txtPass1.Text.Length > 0 && txtPass1.Text == txtPass2.Text)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

    }
}
