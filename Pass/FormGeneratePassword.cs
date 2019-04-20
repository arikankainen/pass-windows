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
    public partial class FormGeneratePassword : Form
    {
        public DialogResult Result { get; private set; }

        public string OldPassword
        {
            set { txtOldPassword.Text = value; }
        }

        public string NewPassword
        {
            get { return txtNewPassword.Text; }
        }

        public FormGeneratePassword()
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
            labelLine.AutoSize = false;
            labelLine.Height = 2;
            labelLine.Width = panel1.Width + 1;
            labelLine.BorderStyle = BorderStyle.Fixed3D;
            labelLine.Anchor = a;
            this.Controls.Add(labelLine);
            labelLine.BringToFront();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text.Length >= 8) Result = DialogResult.OK;
            else Result = DialogResult.Cancel;
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Result = DialogResult.Cancel;
            this.Close();
        }

        private void FormGeneratePassword_Load(object sender, EventArgs e)
        {
            numericPassLen.Value = 32;
            txtNumbers.Text = "0123456789";
            txtUppercase.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            txtLowercase.Text = "abcdefghijklmnopqrstuvwxyz";
            txtSpecial1.Text = "!?@#$%&+-_";
            txtSpecial2.Text = "()[]{}<>/\\\'\".,:;~";

            checkNumbers.Checked = true;
            checkUppercase.Checked = true;
            checkLowercase.Checked = true;
            checkSpecial1.Checked = true;
            checkSpecial2.Checked = true;
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            string allCharacters = "";

            if (checkNumbers.Checked) allCharacters += txtNumbers.Text;
            if (checkUppercase.Checked) allCharacters += txtUppercase.Text;
            if (checkLowercase.Checked) allCharacters += txtLowercase.Text;
            if (checkSpecial1.Checked) allCharacters += txtSpecial1.Text;
            if (checkSpecial2.Checked) allCharacters += txtSpecial2.Text;

            string pass = "";

            if (allCharacters.Length > 0)
            {
                for (int i = 0; i < (int)numericPassLen.Value; i++)
                {
                    int rnd = random.Next(allCharacters.Length);
                    pass += allCharacters.Substring(rnd, 1);
                }

                txtNewPassword.Text = pass;
            }
        }

        private void BtnCopyOld_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtOldPassword.Text);
        }

        private void BtnCopyNew_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtNewPassword.Text);
        }

        private void BtnClearClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
        }
    }
}
