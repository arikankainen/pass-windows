using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Pass
{
    public partial class FormHidden : Form
    {
        /*
        protected override void SetVisibleCore(bool value)
        {
            if (!IsHandleCreated && value)
            {
                base.CreateHandle();
                value = false;
            }
            base.SetVisibleCore(value);
        }
        */

        private string appDir = Path.GetDirectoryName(Application.ExecutablePath);
        private string passFile;

        public FormHidden()
        {
            InitializeComponent();
            passFile = Path.Combine(appDir, "pass.dat");
        }

        private void FormHidden_Load(object sender, EventArgs e)
        {
            string pass = null;

            try
            {
                if (File.Exists(passFile))
                {
                    FormStart start = new FormStart();
                    start.ShowDialog();
                    pass = start.Pass;
                    start.Dispose();

                    if (pass.Length > 0)
                    {
                        FormMain main = new FormMain();
                        main.Pass = pass;
                        main.ShowDialog();
                        main.Dispose();
                    }
                }

                else
                {
                    FormMain main = new FormMain();
                    main.ShowDialog();
                    main.Dispose();
                }

                this.Close();
            }
            
            catch (Exception ex)
            {
                label1.Text = ex.Message + Environment.NewLine + Environment.NewLine + ex.StackTrace;
            }

        }
    }
}
