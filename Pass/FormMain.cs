using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Pass
{
    public partial class FormMain : Form, IMessageFilter
    {
        private Settings settings = new Settings();
        private string appDir = Path.GetDirectoryName(Application.ExecutablePath);
        private string passFile;
        private string firstline = "73hfa8ka-4jw3-5jsc-jldf-lfgjsadgmdlk3hlgfjsf-3562-sdg5-423d-3468jkjsäsköldsakölf";
        private string separator = "c3b19327-3a2e-4bac-b8a9-2b20b167c1e94083d8ce-4ebf-4112-b33d-eca6ac3f79b7ca238cd2";
        private string newline = "9ed3a5d1-901b-49fa-b9c6-700bbd534fa798bb6729-b934-47fa-af34-3e8038c01c6571544560";
        private bool passwordOk = false;
        private int formWidth2Buttons = 300;
        private int formWidth3Buttons = 360;

        private string pass;
        public string Pass
        {
            set 
            { 
                pass = value;
                menuAdd.Enabled = toolAdd.Enabled = true;
                menuChangePassword.Text = "Change master password...";
            }
        }

        public FormMain()
        {
            InitializeComponent();
            Application.AddMessageFilter(this);
            toolStrip1.Renderer = new MySR();
            passFile = Path.Combine(appDir, "pass.dat");
        }

        private void LoadList()
        {
            try
            {
                lstPass.Items.Clear();

                if (File.Exists(passFile))
                {
                    using (StreamReader reader = File.OpenText(passFile))
                    {
                        lstPass.BeginUpdate();

                        string strEncoded = reader.ReadLine();
                        string strDecoded = StringCipher.Decrypt(strEncoded, pass);

                        string[] lines = strDecoded.Split(new[] { newline }, StringSplitOptions.None);

                        foreach (string line in lines)
                        {
                            if (line.Length > 10 && line != firstline)
                            {
                                string[] columns = line.Split(new[] { separator }, StringSplitOptions.None);

                                ListViewItem item = new ListViewItem(columns[0]);
                                item.SubItems.Add(columns[1]);
                                item.SubItems.Add(columns[2]);
                                item.SubItems.Add(HidePassword(columns[3]));
                                item.SubItems.Add(columns[4]);
                                item.Tag = columns[3];
                                lstPass.Items.Add(item);
                            }
                        }

                        lstPass.EndUpdate();
                    }
                }

                passwordOk = true;
            }

            catch
            {
                lstPass.EndUpdate();
                lstPass.Items.Clear();
                Application.DoEvents();
                passwordOk = false;

                bool tryAgain = false;

                AK.MessageForm form = new AK.MessageForm();
                form.Text = this.Text;
                form.Icon = this.Icon;
                form.Width = formWidth2Buttons;
                form.ButtonLeftText = "Yes";
                form.ButtonRightText = "No";
                form.ShowCenterButton = false;
                form.LabelText = "Invalid password. Try again?";
                form.LabelTextAlign = ContentAlignment.MiddleCenter;
                form.ShowDialog();
                if (form.ButtonLeftClicked) tryAgain = true;

                if (tryAgain) menuLock.PerformClick();
            }
        }

        private void SaveList()
        {
            if (!menuLock.Checked)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(passFile))
                    {
                        string str = firstline + newline;

                        foreach (ListViewItem item in lstPass.Items)
                        {
                            string site = item.SubItems[0].Text;
                            string address = item.SubItems[1].Text;
                            string username = item.SubItems[2].Text;
                            string password = item.Tag.ToString();
                            string comment = item.SubItems[4].Text;

                            str += site + separator + address + separator + username + separator + password + separator + comment + newline;
                        }

                        string encryptedStr = StringCipher.Encrypt(str, pass);
                        sw.WriteLine(encryptedStr);
                    }
                }

                catch { }
            }
        }

        private void HidePasswords()
        {
            if (menuShowPasswords.Checked)
            {
                foreach (ListViewItem item in lstPass.Items)
                {
                    item.SubItems[3].Text = item.Tag.ToString();
                }
            }

            else
            {
                foreach (ListViewItem item in lstPass.Items)
                {
                    int length = item.Tag.ToString().Length;
                    string chars = new String('x', length);
                    item.SubItems[3].Text = chars;
                }
            }
        }

        private string HidePassword(string password)
        {
            if (menuShowPasswords.Checked) return password;
            else return new String('x', password.Length);
        }

        private void UpdateStatusCount()
        {
            if (!menuLock.Checked)
            {
                int count = lstPass.Items.Count;
                statusCount.Text = count.ToString() + " items";
            }

            else statusCount.Text = "";
        }

        private void UpdateStatusBackup()
        {
            if (!menuLock.Checked)
            {
                try
                {
                    List<string> backupList = new List<string>(Directory.GetFiles(appDir, "pass_backup_*.dat", SearchOption.TopDirectoryOnly));
                    backupList.Sort();
                    backupList.Reverse();

                    DateTime last = DateTime.MinValue;
                    string lastBackup = "never";
                    if (backupList.Count > 0)
                    {
                        string format = "yyyy-MM-dd_HH-mm-ss";
                        CultureInfo provider = CultureInfo.InvariantCulture;
                        last = DateTime.ParseExact(Path.GetFileNameWithoutExtension(backupList[0]).Replace("pass_backup_", ""), format, provider);

                        TimeSpan daysAgo = DateTime.Now - last;
                        int days = (int)daysAgo.TotalDays;

                        string daysText = days.ToString() + " days ago";

                        lastBackup = last.ToString(@"d.M.yyyy HH:mm:ss") + "  (" + daysText + ")";
                    }

                    statusBackup.Text = "Last backup: " + lastBackup;
                }

                catch { }
            }

            else statusBackup.Text = "";
        }

        private void CheckEnabled()
        {
            if (File.Exists(passFile))
            {
                menuLock.Enabled = toolLock.Enabled = true;
                menuChangePassword.Text = "Change master password...";

                if (passwordOk)
                {
                    menuLock.Checked = toolLock.Checked = false;
                    menuAdd.Enabled = toolAdd.Enabled = true;
                    menuChangePassword.Enabled = true;
                    toolLock.ToolTipText = "Lock list";
                    toolLabelLock.Text = "";
                }

                else
                {
                    menuLock.Checked = toolLock.Checked = true;
                    menuAdd.Enabled = toolAdd.Enabled = false;
                    menuChangePassword.Enabled = false;
                    toolLock.ToolTipText = "Unlock list";
                    toolLabelLock.Text = "List locked";
                }
            }

            else
            {
                menuLock.Enabled = toolLock.Enabled = menuLock.Checked = toolLock.Checked = false;
                toolLabelLock.Text = "";
                menuChangePassword.Text = "Create master password...";
            }

            if (lstPass.SelectedItems.Count == 1)
            {
                menuModify.Enabled = toolModify.Enabled = true;
                menuDelete.Enabled = toolDelete.Enabled = true;

                if (lstPass.SelectedItems[0].SubItems[2].Text.Length > 0 || lstPass.SelectedItems[0].SubItems[3].Text.Length > 0) menuCopyClipboard.Enabled = toolCopyClipboard.Enabled = true;
                else menuCopyClipboard.Enabled = toolCopyClipboard.Enabled = false;
            }

            else
            {
                menuModify.Enabled = toolModify.Enabled = false;
                menuDelete.Enabled = toolDelete.Enabled = false;
                menuCopyClipboard.Enabled = toolCopyClipboard.Enabled = false;
            }

            if (lstPass.Items.Count > 0)
            {
                menuBackupList.Enabled = true;
            }

            else
            {
                menuBackupList.Enabled = false;
            }

            if (menuSaveList.Enabled) toolLabelSaved.Text = "List not saved";
            else toolLabelSaved.Text = "";

            UpdateStatusCount();
            UpdateStatusBackup();
        }

        private DialogResult AskToSaveList()
        {
            DialogResult result;

            AK.MessageForm form = new AK.MessageForm();
            form.Text = this.Text;
            form.Icon = this.Icon;
            form.Width = formWidth3Buttons;
            form.ButtonLeftText = "Yes";
            form.ButtonCenterText = "No";
            form.ButtonRightText = "Cancel";
            form.LabelText = "List not saved. Save now?";
            form.LabelTextAlign = ContentAlignment.MiddleCenter;
            form.ShowDialog();

            if (form.ButtonLeftClicked) result = DialogResult.Yes;
            else if (form.ButtonCenterClicked) result = DialogResult.No;
            else result = DialogResult.Cancel;

            return result;
        }

        private void FormShown()
        {
            if (File.Exists(passFile) && menuUnlockStart.Checked) menuLock.PerformClick();
            else if (!File.Exists(passFile)) menuChangePassword.PerformClick();
        }

        // ************ FORM EVENTS ************** //

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Width = settings.LoadSetting("WinWidth", "int", "926");
            this.Height = settings.LoadSetting("WinHeight", "int", "500");

            clmName.Width = settings.LoadSetting("ColumnSite", "int", "170");
            clmAddress.Width = settings.LoadSetting("ColumnAddress", "int", "170");
            clmUsername.Width = settings.LoadSetting("ColumnUsername", "int", "170");
            clmPassword.Width = settings.LoadSetting("ColumnPassword", "int", "170");
            clmComments.Width = settings.LoadSetting("ColumnComments", "int", "170");

            Screen screen = Screen.FromPoint(Cursor.Position);
            this.Left = screen.WorkingArea.Left + (screen.WorkingArea.Size.Width / 2) - (this.Width / 2);
            this.Top = screen.WorkingArea.Top + (screen.WorkingArea.Size.Height / 2) - (this.Height / 2);

            menuShowPasswords.Checked = settings.LoadSetting("ShowPasswords", "bool", "false");
            menuUnlockStart.Checked = settings.LoadSetting("UnlockOnStart", "bool", "true");
            menuMinimizeOnLock.Checked = settings.LoadSetting("MinimizeOnLock", "bool", "false");
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            CheckEnabled();
            timerFormShown.Start();
        }

        private void timerFormShown_Tick(object sender, EventArgs e)
        {
            timerFormShown.Stop();
            FormShown();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (menuSaveList.Enabled)
            {
                DialogResult result = AskToSaveList();

                if (result == DialogResult.Yes) SaveList();
                else if (result == DialogResult.Cancel) e.Cancel = true;
            }

            if (!e.Cancel)
            {
                if (this.WindowState == FormWindowState.Minimized) this.Opacity = 0.0;
                this.WindowState = FormWindowState.Normal;

                settings.SaveSetting("WinWidth", this.Width.ToString());
                settings.SaveSetting("WinHeight", this.Height.ToString());

                settings.SaveSetting("ColumnSite", clmName.Width.ToString());
                settings.SaveSetting("ColumnAddress", clmAddress.Width.ToString());
                settings.SaveSetting("ColumnUsername", clmUsername.Width.ToString());
                settings.SaveSetting("ColumnPassword", clmPassword.Width.ToString());
                settings.SaveSetting("ColumnComments", clmComments.Width.ToString());
            }
        }

        private void lstPass_DoubleClick(object sender, EventArgs e)
        {
            menuCopyClipboard.PerformClick();
        }

        private void lstPass_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Insert) menuAdd.PerformClick();
            else if (e.KeyCode == Keys.Delete && menuDelete.Enabled) menuDelete.PerformClick();
            else if (e.KeyCode == Keys.Back && menuModify.Enabled) menuModify.PerformClick();
            else if (e.KeyCode == Keys.Space && menuModify.Enabled) menuModify.PerformClick();
            else if (e.KeyCode == Keys.Enter && menuCopyClipboard.Enabled) menuCopyClipboard.PerformClick();
            else if (e.KeyCode == Keys.S && e.Modifiers == Keys.Control && menuSaveList.Enabled) menuSaveList.PerformClick();
            else if (e.KeyCode == Keys.L && e.Modifiers == Keys.Control && menuLock.Enabled) menuLock.PerformClick();
        }

        private void lstPass_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckEnabled();
        }

        // ************ MENU EVENTS ************** //

        private void menuSaveList_Click(object sender, EventArgs e)
        {
            SaveList();
            menuSaveList.Enabled = toolSave.Enabled = false;
            toolLabelSaved.Text = "";
        }

        private void menuBackupList_Click(object sender, EventArgs e)
        {
            bool cancel = false;

            if (menuSaveList.Enabled)
            {
                DialogResult result = AskToSaveList();

                if (result == DialogResult.Yes)
                {
                    SaveList();
                    menuSaveList.Enabled = toolSave.Enabled = false;
                }

                else if (result == DialogResult.Cancel) cancel = true;
            }

            if (!cancel)
            {
                if (File.Exists(passFile))
                {
                    string backupFile = Path.Combine(appDir, "pass_backup_" + DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".dat");

                    if (File.Exists(backupFile)) File.Delete(backupFile);
                    File.Copy(passFile, backupFile);

                    UpdateStatusBackup();

                    AK.MessageForm form = new AK.MessageForm();
                    form.Text = this.Text;
                    form.Icon = this.Icon;
                    form.Width = formWidth2Buttons;
                    form.ButtonCenterText = "OK";
                    form.ShowLeftButton = false;
                    form.ShowRightButton = false;
                    form.LabelText = "List backed up successfully.";
                    form.LabelTextAlign = ContentAlignment.MiddleCenter;
                    form.ShowDialog();

                }
            }
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuAdd_Click(object sender, EventArgs e)
        {
            FormAdd form = new FormAdd();
            form.ShowPassword = menuShowPasswords.Checked;
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                ListViewItem item = new ListViewItem(form.SiteName);
                item.SubItems.Add(form.Address);
                item.SubItems.Add(form.Username);
                item.SubItems.Add(HidePassword(form.Password));
                item.SubItems.Add(form.Comments);
                item.Tag = form.Password;
                lstPass.Items.Add(item);

                menuSaveList.Enabled = toolSave.Enabled = true;
            }

            form.Dispose();
            CheckEnabled();
        }

        private void menuModify_Click(object sender, EventArgs e)
        {
            if (lstPass.SelectedItems.Count > 0)
            {
                FormAdd form = new FormAdd();
                form.ShowPassword = menuShowPasswords.Checked;
                form.SiteName = lstPass.SelectedItems[0].Text;
                form.Address = lstPass.SelectedItems[0].SubItems[1].Text;
                form.Username = lstPass.SelectedItems[0].SubItems[2].Text;
                form.Password = lstPass.SelectedItems[0].Tag.ToString();
                form.Comments = lstPass.SelectedItems[0].SubItems[4].Text;
                form.ShowDialog();

                if (form.DialogResult == DialogResult.OK)
                {
                    ListViewItem item = lstPass.SelectedItems[0];
                    item.Text = form.SiteName;
                    item.SubItems[1].Text = form.Address;
                    item.SubItems[2].Text = form.Username;
                    item.SubItems[3].Text = HidePassword(form.Password);
                    item.SubItems[4].Text = form.Comments;
                    item.Tag = form.Password;

                    menuSaveList.Enabled = toolSave.Enabled = true;
                }

                form.Dispose();
            }

            CheckEnabled();
        }

        private void menuDelete_Click(object sender, EventArgs e)
        {
            if (lstPass.SelectedItems.Count > 0)
            {
                string name = lstPass.SelectedItems[0].Text;

                DialogResult result;

                AK.MessageForm form = new AK.MessageForm();
                form.Text = this.Text;
                form.Icon = this.Icon;
                form.Width = formWidth2Buttons;
                form.ButtonLeftText = "Yes";
                form.ButtonRightText = "No";
                form.ShowCenterButton = false;
                form.LabelText = "Really delete \"" + name + "\"?";
                form.LabelTextAlign = ContentAlignment.MiddleCenter;
                form.ShowDialog();

                if (form.ButtonLeftClicked) result = DialogResult.Yes;
                else result = DialogResult.No;

                if (result == DialogResult.Yes)
                {
                    int selected = lstPass.SelectedItems[0].Index;
                    lstPass.SelectedItems[0].Remove();

                    if (lstPass.Items.Count > 0)
                    {
                        if (lstPass.Items.Count > selected) lstPass.Items[selected].Selected = true;
                        else lstPass.Items[lstPass.Items.Count - 1].Selected = true;
                    }

                    menuSaveList.Enabled = toolSave.Enabled = true;
                }
            }

            CheckEnabled();
        }

        private void menuCopyClipboard_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.SiteName = lstPass.SelectedItems[0].Text;
            login.Address = lstPass.SelectedItems[0].SubItems[1].Text;
            login.Username = lstPass.SelectedItems[0].SubItems[2].Text;
            login.Password = lstPass.SelectedItems[0].Tag.ToString();
            login.Show();

            this.WindowState = FormWindowState.Minimized;
        }

        private void menuChangePassword_Click(object sender, EventArgs e)
        {
            FormChangePassword form = new FormChangePassword();
            if (menuChangePassword.Text == "Create master password...") form.CreateNew = true;
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                pass = form.Password;
                menuAdd.Enabled = toolAdd.Enabled = true;
                menuSaveList.Enabled = toolSave.Enabled = true;
                menuSaveList.PerformClick();
                if (lstPass.Items.Count > 0) menuSaveList.Enabled = toolSave.Enabled = true;
                menuChangePassword.Text = "Change master password...";
                passwordOk = true;
            }

            form.Dispose();

            CheckEnabled();
        }

        private void menuLock_Click(object sender, EventArgs e)
        {
            bool cancel = false;

            if (menuSaveList.Enabled)
            {
                DialogResult result = AskToSaveList();

                if (result == DialogResult.Yes)
                {
                    SaveList();
                    menuSaveList.Enabled = toolSave.Enabled = false;
                }

                else if (result == DialogResult.Cancel) cancel = true;
            }

            if (!cancel)
            {
                passwordOk = false;
                pass = "";

                if (menuLock.Checked)
                {
                    FormStart start = new FormStart();
                    start.ShowDialog();
                    pass = start.Pass;
                    start.Dispose();

                    if (pass.Length > 0) LoadList();
                }

                else
                {
                    lstPass.Items.Clear();
                    menuSaveList.Enabled = toolSave.Enabled = false;
                    if (menuMinimizeOnLock.Checked) this.WindowState = FormWindowState.Minimized;
                }

                CheckEnabled();
            }
        }

        private void menuShowPasswords_Click(object sender, EventArgs e)
        {
            if (menuShowPasswords.Checked) menuShowPasswords.Checked = false;
            else menuShowPasswords.Checked = true;

            HidePasswords();
            settings.SaveSetting("ShowPasswords", menuShowPasswords.Checked.ToString());
        }

        private void menuUnlockStart_Click(object sender, EventArgs e)
        {
            if (menuUnlockStart.Checked) menuUnlockStart.Checked = false;
            else menuUnlockStart.Checked = true;

            settings.SaveSetting("UnlockOnStart", menuUnlockStart.Checked.ToString());
        }

        private void menuMinimizeOnLock_Click(object sender, EventArgs e)
        {
            if (menuMinimizeOnLock.Checked) menuMinimizeOnLock.Checked = false;
            else menuMinimizeOnLock.Checked = true;

            settings.SaveSetting("MinimizeOnLock", menuMinimizeOnLock.Checked.ToString());
        }

        // ************ TOOLBAR EVENTS ************** //

        private void toolAdd_Click(object sender, EventArgs e)
        {
            menuAdd.PerformClick();
        }

        private void toolModify_Click(object sender, EventArgs e)
        {
            menuModify.PerformClick();
        }

        private void toolDelete_Click(object sender, EventArgs e)
        {
            menuDelete.PerformClick();
        }

        private void toolCopyClipboard_Click(object sender, EventArgs e)
        {
            menuCopyClipboard.PerformClick();
        }

        private void toolSave_Click(object sender, EventArgs e)
        {
            menuSaveList.PerformClick();
        }

        private void toolLock_Click(object sender, EventArgs e)
        {
            menuLock.PerformClick();
        }

        // correcting a bug in the "system" renderer (white bottom line in toolstrip)
        public class MySR : ToolStripSystemRenderer
        {
            public MySR() { }

            protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
            {
                //base.OnRenderToolStripBorder(e);
            }
        }
    }
}
