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
    public partial class FormAdd : Form, IMessageFilter
    {
        private string modifyItem = "Modify item";

        public string Site
        {
            get { return txtSite.Text; }
            set 
            { 
                txtSite.Text = value;
                labelName.Text = modifyItem;
            }
        }

        public string Address
        {
            get 
            { 
                if (!txtAddress.Text.Contains("://") && txtAddress.Text.Length > 0) txtAddress.Text = "http://" + txtAddress.Text;
                return txtAddress.Text; 
            }
            set { txtAddress.Text = value; }
        }

        public string Username
        {
            get { return txtUsername.Text; }
            set { txtUsername.Text = value; }
        }

        public string Password
        {
            get { return txtPassword.Text; }
            set { txtPassword.Text = value; }
        }

        public string Comments
        {
            get { return txtComments.Text; }
            set { txtComments.Text = value; }
        }

        public FormAdd()
        {
            InitializeComponent();
            Application.AddMessageFilter(this);
            addLines();
        }

        private void addLines()
        {
            line(panel1.Height, (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left));
            line(this.ClientRectangle.Height - 51, (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left));
        }

        private void line(int top, AnchorStyles a)
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

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FormAdd_Shown(object sender, EventArgs e)
        {
            txtSite.Focus();
        }

        private void txt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnOk.PerformClick();
        }

        private void txtComments_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
