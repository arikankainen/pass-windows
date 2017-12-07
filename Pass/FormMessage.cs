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
    public partial class FormMessage : Form
    {
        public string MessageTopic
        {
            set { this.Text = value; }
        }

        public string MessageName
        {
            set { labelName.Text = value; }
        }

        public string MessageText
        {
            set { labelText.Text = value; }
        }

        public int MessageWindowHeight
        {
            set { this.Height = value; }
        }

        public bool ShowButtonNo
        {
            set { btnNo.Visible = value; }
        }

        public bool ShowButtonCancel
        {
            set { btnCancel.Visible = value; }
        }

        public bool ShowButtonYes
        {
            set
            {
                btnOk.Visible = value;
                if (value) btnOk.Text = "Yes";
            }
        }

        public bool ShowButtonOk
        {
            set
            {
                btnOk.Visible = value;
                if (value) btnOk.Text = "OK";
            }
        }

        private bool okClicked = false;
        public bool OKClicked
        {
            get { return okClicked; }
        }

        private bool cancelClicked = false;
        public bool CancelClicked
        {
            get { return cancelClicked; }
        }

        private bool noClicked = false;
        public bool NoClicked
        {
            get { return noClicked; }
        }

        public bool AddLines
        {
            set { if (value) addLines(); }
        }

        public FormMessage()
        {
            InitializeComponent();
            line(panel1.Height, (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left));
            //addLines();
        }

        private void addLines()
        {
            line(this.ClientRectangle.Height - 51, (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left));
        }

        private void line(int top, AnchorStyles a)
        {
            Label labelLine = new Label();
            labelLine.Top = top;
            labelLine.Left = 0;
            labelLine.AutoSize = false; labelLine.Height = 2;
            labelLine.Width = panel1.Width + 1;
            labelLine.BorderStyle = BorderStyle.Fixed3D;
            labelLine.Anchor = a;
            this.Controls.Add(labelLine);
            labelLine.BringToFront();
        }

        private void FormMessage_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            okClicked = true;
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            noClicked = true;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cancelClicked = true;
            this.Close();
        }
    }
}
