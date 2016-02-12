using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Diagnostics;

namespace Pass
{
    public partial class FormMain : Form, IMessageFilter
    {
        private Settings settings = new Settings();
        private string appDir = Path.GetDirectoryName(Application.ExecutablePath);
        private string passFile;

        private string pass;
        public string Pass
        {
            set 
            { 
                pass = value;
                btnAdd.Enabled = true;
                btnChangePass.Text = "Change master password";
            }
        }

        public FormMain()
        {
            InitializeComponent();
            Application.AddMessageFilter(this);
            passFile = Path.Combine(appDir, "pass.dat");
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Width = settings.LoadSetting("WinWidth", "int", "900");
            this.Height = settings.LoadSetting("WinHeight", "int", "500");

            Screen screen = Screen.FromPoint(Cursor.Position);
            this.Left = screen.WorkingArea.Left + (screen.WorkingArea.Size.Width / 2) - (this.Width / 2);
            this.Top = screen.WorkingArea.Top + (screen.WorkingArea.Size.Height / 2) - (this.Height / 2) - 1;

            clmSite.Width = settings.LoadSetting("ColumnSite", "int", "170");
            clmAddress.Width = settings.LoadSetting("ColumnAddress", "int", "170");
            clmUsername.Width = settings.LoadSetting("ColumnUsername", "int", "170");
            clmPassword.Width = settings.LoadSetting("ColumnPassword", "int", "170");
            clmComments.Width = settings.LoadSetting("ColumnComments", "int", "170");
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            listLoad();
        }

        private void listLoad()
        {
            try
            {
                lstPass.Items.Clear();

                if (File.Exists(passFile))
                {
                    using (StreamReader reader = File.OpenText(passFile))
                    {
                        lstPass.BeginUpdate();

                        while (reader.Peek() >= 0)
                        {
                            string EncryptedLine = reader.ReadLine();
                            string line = StringCipher.Decrypt(EncryptedLine, pass);

                            List<string> list = line.Split('|').ToList<string>();

                            ListViewItem item = new ListViewItem(list[0]);
                            item.Tag = null;
                            item.SubItems.Add(list[1]);
                            item.SubItems.Add(list[2]);
                            item.SubItems.Add(list[3]);
                            item.SubItems.Add(list[4]);
                            lstPass.Items.Add(item);
                        }

                        lstPass.EndUpdate();

                    }

                }

            }

            catch (Exception ex)
            {
                lstPass.EndUpdate();
                Application.DoEvents();
                btnAdd.Enabled = false;
                btnChangePass.Enabled = false;
                MessageBox.Show("Invalid master password", "Pass", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void listSave()
        {
            try
            {
                if (lstPass.Items.Count > 0)
                {
                    using (StreamWriter sw = new StreamWriter(passFile))
                    {
                        foreach (ListViewItem item in lstPass.Items)
                        {
                            string site = item.SubItems[0].Text;
                            string address = item.SubItems[1].Text;
                            string username = item.SubItems[2].Text;
                            string password = item.SubItems[3].Text;
                            string comment = item.SubItems[4].Text;

                            string str = site + "|" + address + "|" + username + "|" + password + "|" + comment;
                            string encryptedStr = StringCipher.Encrypt(str, pass);

                            sw.WriteLine(encryptedStr);
                        }
                    }
                }

                else
                {
                    try
                    {
                        File.Delete(passFile);
                    }
                    catch { }
                }

            }

            catch { }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            listSave();
            btnSave.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAdd form = new FormAdd();
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                ListViewItem item = new ListViewItem(form.Site);
                item.Tag = null;
                item.SubItems.Add(form.Address);
                item.SubItems.Add(form.Username);
                item.SubItems.Add(form.Password);
                item.SubItems.Add(form.Comments);
                lstPass.Items.Add(item);
                btnSave.Enabled = true;
            }

            form.Dispose();

            lstPassIndexChanged();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (lstPass.SelectedItems.Count > 0)
            {
                FormAdd form = new FormAdd();
                form.Site = lstPass.SelectedItems[0].Text;
                form.Address = lstPass.SelectedItems[0].SubItems[1].Text;
                form.Username = lstPass.SelectedItems[0].SubItems[2].Text;
                form.Password = lstPass.SelectedItems[0].SubItems[3].Text;
                form.Comments = lstPass.SelectedItems[0].SubItems[4].Text;
                form.ShowDialog();

                if (form.DialogResult == DialogResult.OK)
                {
                    ListViewItem item = lstPass.SelectedItems[0];
                    item.Text = form.Site;
                    item.Tag = null;
                    item.SubItems[1].Text = form.Address;
                    item.SubItems[2].Text = form.Username;
                    item.SubItems[3].Text = form.Password;
                    item.SubItems[4].Text = form.Comments;
                    btnSave.Enabled = true;
                }

                form.Dispose();
            }

            lstPassIndexChanged();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstPass.SelectedItems.Count > 0)
            {
                var result = MessageBox.Show("Really delete item?", "Pass", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    int selected = lstPass.SelectedItems[0].Index;
                    lstPass.SelectedItems[0].Remove();

                    if (lstPass.Items.Count > 0)
                    {
                        if (lstPass.Items.Count > selected) lstPass.Items[selected].Selected = true;
                        else lstPass.Items[lstPass.Items.Count - 1].Selected = true;
                    }

                    btnSave.Enabled = true;
                }
            }
        }

        private void lstPass_DoubleClick(object sender, EventArgs e)
        {
            btnCopyPassword.PerformClick();
        }

        private void lstPass_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstPassIndexChanged();
        }

        private void lstPassIndexChanged()
        {
            if (lstPass.SelectedItems.Count == 1)
            {
                btnModify.Enabled = true;
                btnDelete.Enabled = true;

                if (lstPass.SelectedItems[0].SubItems[2].Text.Length > 0 || lstPass.SelectedItems[0].SubItems[3].Text.Length > 0) btnCopyPassword.Enabled = true;
                else btnCopyPassword.Enabled = false;
            }

            else
            {
                btnModify.Enabled = false;
                btnDelete.Enabled = false;
                btnCopyPassword.Enabled = false;
            }
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            FormChangePassword form = new FormChangePassword();
            if (btnChangePass.Text == "Create master password") form.CreateNew = true;
            form.ShowDialog();
            
            if (form.DialogResult == DialogResult.OK)
            {
                pass = form.Password;
                btnSave.Enabled = true;
                btnAdd.Enabled = true;
                btnChangePass.Text = "Change master password";
            }
            
            form.Dispose();
        }

        private void btnSave_EnabledChanged(object sender, EventArgs e)
        {
            if (btnSave.Enabled)
            {
                //btnSave.ForeColor = Color.Red;
                //btnSave.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                //btnSave.BackColor = Color.FromArgb(250, 150, 150);
            }

            else
            {
                //btnSave.ForeColor = SystemColors.ControlText;
                //btnSave.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
                //btnSave.BackColor = SystemColors.Control;
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btnSave.Enabled)
            {
                var result = MessageBox.Show("List not saved. Save now?", "Pass", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                
                if (result == DialogResult.Yes)
                {
                    listSave();
                }

                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }

            }

            if (!e.Cancel)
            {
                if (this.WindowState == FormWindowState.Minimized) this.Opacity = 0.0;
                this.WindowState = FormWindowState.Normal;

                settings.SaveSetting("WinWidth", this.Width.ToString());
                settings.SaveSetting("WinHeight", this.Height.ToString());

                settings.SaveSetting("ColumnSite", clmSite.Width.ToString());
                settings.SaveSetting("ColumnAddress", clmAddress.Width.ToString());
                settings.SaveSetting("ColumnUsername", clmUsername.Width.ToString());
                settings.SaveSetting("ColumnPassword", clmPassword.Width.ToString());
                settings.SaveSetting("ColumnComments", clmComments.Width.ToString());
            }

        }

        private void btnCopyPassword_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Site = lstPass.SelectedItems[0].Text;
            login.Address = lstPass.SelectedItems[0].SubItems[1].Text;
            login.Username = lstPass.SelectedItems[0].SubItems[2].Text;
            login.Password = lstPass.SelectedItems[0].SubItems[3].Text;
            login.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void lstPass_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Insert) btnAdd.PerformClick();
            else if (e.KeyCode == Keys.Delete) btnDelete.PerformClick();
            //else if (e.KeyCode == Keys.M) btnModify.PerformClick();
            else if (e.KeyCode == Keys.Space) btnCopyPassword.PerformClick();
        }




    }
}
