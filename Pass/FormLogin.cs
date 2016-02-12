﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Pass
{
    public partial class FormLogin : Form
    {
        private string site = null;
        public string Site
        {
            set { if (value.Length > 0) site = value; }
        }

        private string address = null;
        public string Address
        {
            set { if (value.Length > 0) address = value; }
        }

        private string username = null;
        public string Username
        {
            set { if (value.Length > 0) username = value; }
        }

        private string password = null;
        public string Password
        {
            set { if (value.Length > 0) password = value; }
        }

        public FormLogin()
        {
            InitializeComponent();
            addLines();
        }

        private void addLines()
        {
            line(panel1.Height, (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left));
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

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (btnNext.Text == "Next >")
            {
                Clipboard.SetText(password);
                labelName.Text = "Password copied to clipboard";
                btnNext.Text = "Close";
            }

            else this.Close();
        }

        private void FormLogin_Shown(object sender, EventArgs e)
        {
            labelSite.Text = site;

            if (address != null) btnOpenInBrowser.Enabled = true;

            if (username != null)
            {
                Clipboard.SetText(username);
                labelName.Text = "Username copied to clipboard";
                if (password != null) btnNext.Text = "Next >";
                else btnNext.Text = "Close";
            }

            else if (password != null)
            {
                Clipboard.SetText(password);
                labelName.Text = "Password copied to clipboard";
                btnNext.Text = "Close";
            }

        }

        private void btnOpenInBrowser_Click(object sender, EventArgs e)
        {
            Process.Start(address);
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Clipboard.Clear();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            Screen screen = Screen.FromPoint(Cursor.Position);
            //this.Left = screen.WorkingArea.Left + (screen.WorkingArea.Size.Width / 2) - (this.Width / 2);
            //this.Top = screen.WorkingArea.Top + (screen.WorkingArea.Size.Height / 2) - (this.Height / 2) - 1;
            this.Left = screen.WorkingArea.Left + screen.WorkingArea.Size.Width - this.Width - 50;
            this.Top = screen.WorkingArea.Top + screen.WorkingArea.Size.Height - this.Height - 50;
        }

    }
}
