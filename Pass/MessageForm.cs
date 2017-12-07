using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AK
{
    class MessageForm
    {
        public Icon Icon
        {
            set
            {
                form.Icon = value;
                if (value != null) form.ShowIcon = true;
                else form.ShowIcon = false;
            }
        }

        public int Width
        {
            set { form.Width = value; }
        }

        public string Text
        {
            set { form.Text = value; }
        }

        public string LabelText
        {
            set
            {
                label.Text = value;
                Size labelSize = TextRenderer.MeasureText(label.Text, label.Font, new Size(label.Width, 0), TextFormatFlags.WordBreak);
                int difference = form.Height - label.Height;
                form.Height = difference + labelSize.Height;
            }
        }

        public ContentAlignment LabelTextAlign
        {
            set { label.TextAlign = value; }
        }

        public string ButtonLeftText
        {
            set { buttonLeft.Text = value; }
        }

        public string ButtonCenterText
        {
            set { buttonCenter.Text = value; }
        }

        public string ButtonRightText
        {
            set { buttonRight.Text = value; }
        }

        public bool ShowLeftButton
        {
            set { buttonLeft.Visible = value; }
        }

        public bool ShowCenterButton
        {
            set { buttonCenter.Visible = value; }
        }

        public bool ShowRightButton
        {
            set { buttonRight.Visible = value; }
        }

        public int ButtonLeftWidth
        {
            set
            {
                buttonLeft.Width = value;
                buttonLeft.Left = 20;
            }
        }

        public int ButtonCenterWidth
        {
            set
            {
                buttonCenter.Width = value;
                buttonCenter.Left = (form.ClientRectangle.Width / 2) - (buttonCenter.Width / 2);
            }
        }

        public int ButtonRightWidth
        {
            set
            {
                buttonRight.Width = value;
                buttonRight.Left = form.ClientRectangle.Width - 20 - buttonCenter.Width;
            }
        }

        private bool buttonLeftClicked = false;
        public bool ButtonLeftClicked
        {
            get { return buttonLeftClicked; }
        }

        private bool buttonCenterClicked = false;
        public bool ButtonCenterClicked
        {
            get { return buttonCenterClicked; }
        }

        private bool buttonRightClicked = false;
        public bool ButtonRightClicked
        {
            get { return buttonRightClicked; }
        }

        Form form = new Form();
        Button buttonLeft = new Button();
        Button buttonCenter = new Button();
        Button buttonRight = new Button();
        Panel panel = new Panel();
        Label labelLine = new Label();
        Label label = new Label();

        private int buttonMargin = 15;
        private int labelMargin = 25;

        public MessageForm()
        {
            form.Height = 250;
            form.Width = 350;
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.StartPosition = FormStartPosition.CenterParent;
            form.AutoScaleMode = AutoScaleMode.Dpi;
            form.ShowInTaskbar = false;
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.ShowIcon = false;

            buttonLeft.Width = 90;
            buttonLeft.Left = 20;
            buttonLeft.Top = form.ClientRectangle.Height - buttonLeft.Height - buttonMargin;
            buttonLeft.Text = "Left";
            buttonLeft.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            buttonLeft.Click += new EventHandler(buttonLeft_Click);

            buttonCenter.Width = 90;
            buttonCenter.Left = (form.ClientRectangle.Width / 2) - (buttonCenter.Width / 2);
            buttonCenter.Top = form.ClientRectangle.Height - buttonLeft.Height - buttonMargin;
            buttonCenter.Text = "Center";
            buttonCenter.Anchor = AnchorStyles.Bottom;
            buttonCenter.Click += new EventHandler(buttonCenter_Click);

            buttonRight.Width = 90;
            buttonRight.Left = form.ClientRectangle.Width - 20 - buttonCenter.Width;
            buttonRight.Top = form.ClientRectangle.Height - buttonLeft.Height - buttonMargin;
            buttonRight.Text = "Right";
            buttonRight.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            buttonRight.Click += new EventHandler(buttonRight_Click);

            panel.Left = 0;
            panel.Top = 0;
            panel.Width = form.ClientRectangle.Width;
            panel.Height = buttonLeft.Top - buttonMargin - 1;
            panel.BackColor = Color.White;
            panel.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Top;

            labelLine.AutoSize = false;
            labelLine.Height = 2;
            labelLine.Width = form.ClientRectangle.Width + 1;
            labelLine.BorderStyle = BorderStyle.Fixed3D;
            labelLine.Top = panel.Bottom;
            labelLine.Left = 0;
            labelLine.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;

            label.AutoSize = false;
            label.Top = labelMargin;
            label.Left = labelMargin;
            label.Width = panel.Width - (labelMargin * 2);
            label.Height = panel.Height - (labelMargin * 2);
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Top;

            form.Controls.Add(panel);
            form.Controls.Add(buttonLeft);
            form.Controls.Add(buttonCenter);
            form.Controls.Add(buttonRight);
            form.Controls.Add(labelLine);

            panel.Controls.Add(label);
        }

        #region Events

        private void buttonLeft_Click(Object sender, EventArgs e)
        {
            buttonLeftClicked = true;
            form.Close();
        }

        private void buttonCenter_Click(Object sender, EventArgs e)
        {
            buttonCenterClicked = true;
            form.Close();
        }

        private void buttonRight_Click(Object sender, EventArgs e)
        {
            buttonRightClicked = true;
            form.Close();
        }
        
        #endregion

        public void ShowDialog()
        {
            form.ShowDialog();
        }

        private void setLabelText(string text)
        {
        }

    }
}
