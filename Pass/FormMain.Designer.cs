namespace Pass
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolAdd = new System.Windows.Forms.ToolStripButton();
            this.toolModify = new System.Windows.Forms.ToolStripButton();
            this.toolDelete = new System.Windows.Forms.ToolStripButton();
            this.toolCopyClipboard = new System.Windows.Forms.ToolStripButton();
            this.toolSave = new System.Windows.Forms.ToolStripButton();
            this.toolLock = new System.Windows.Forms.ToolStripButton();
            this.toolLabelLock = new System.Windows.Forms.ToolStripLabel();
            this.toolLabelSaved = new System.Windows.Forms.ToolStripLabel();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuSaveList = new System.Windows.Forms.MenuItem();
            this.menuBackupList = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuExit = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuChangePassword = new System.Windows.Forms.MenuItem();
            this.menuLock = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuAdd = new System.Windows.Forms.MenuItem();
            this.menuModify = new System.Windows.Forms.MenuItem();
            this.menuDelete = new System.Windows.Forms.MenuItem();
            this.menuItem15 = new System.Windows.Forms.MenuItem();
            this.menuCopyClipboard = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuShowPasswords = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuUnlockStart = new System.Windows.Forms.MenuItem();
            this.menuMinimizeOnLock = new System.Windows.Forms.MenuItem();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.statusCount = new System.Windows.Forms.StatusBarPanel();
            this.statusDummy = new System.Windows.Forms.StatusBarPanel();
            this.statusSaved = new System.Windows.Forms.StatusBarPanel();
            this.statusDummy2 = new System.Windows.Forms.StatusBarPanel();
            this.statusBackup = new System.Windows.Forms.StatusBarPanel();
            this.lstPass = new Pass.VisualStylesListView();
            this.clmName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmPassword = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmComments = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timerFormShown = new System.Windows.Forms.Timer(this.components);
            this.menuMinimizeOnCopy = new System.Windows.Forms.MenuItem();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusDummy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusSaved)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusDummy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBackup)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolAdd,
            this.toolModify,
            this.toolDelete,
            this.toolCopyClipboard,
            this.toolSave,
            this.toolLock,
            this.toolLabelLock,
            this.toolLabelSaved});
            this.toolStrip1.Location = new System.Drawing.Point(12, 4);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(984, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolAdd
            // 
            this.toolAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolAdd.Enabled = false;
            this.toolAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolAdd.Image")));
            this.toolAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAdd.Name = "toolAdd";
            this.toolAdd.Size = new System.Drawing.Size(23, 22);
            this.toolAdd.Text = "Add...";
            this.toolAdd.Click += new System.EventHandler(this.ToolAdd_Click);
            // 
            // toolModify
            // 
            this.toolModify.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolModify.Enabled = false;
            this.toolModify.Image = ((System.Drawing.Image)(resources.GetObject("toolModify.Image")));
            this.toolModify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolModify.Name = "toolModify";
            this.toolModify.Size = new System.Drawing.Size(23, 22);
            this.toolModify.Text = "Modify...";
            this.toolModify.Click += new System.EventHandler(this.ToolModify_Click);
            // 
            // toolDelete
            // 
            this.toolDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolDelete.Enabled = false;
            this.toolDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolDelete.Image")));
            this.toolDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDelete.Name = "toolDelete";
            this.toolDelete.Size = new System.Drawing.Size(23, 22);
            this.toolDelete.Text = "Delete...";
            this.toolDelete.Click += new System.EventHandler(this.ToolDelete_Click);
            // 
            // toolCopyClipboard
            // 
            this.toolCopyClipboard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolCopyClipboard.Enabled = false;
            this.toolCopyClipboard.Image = ((System.Drawing.Image)(resources.GetObject("toolCopyClipboard.Image")));
            this.toolCopyClipboard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCopyClipboard.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
            this.toolCopyClipboard.Name = "toolCopyClipboard";
            this.toolCopyClipboard.Size = new System.Drawing.Size(23, 22);
            this.toolCopyClipboard.Text = "Copy to clipboard";
            this.toolCopyClipboard.ToolTipText = "Copy to clipboard";
            this.toolCopyClipboard.Click += new System.EventHandler(this.ToolCopyClipboard_Click);
            // 
            // toolSave
            // 
            this.toolSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSave.Enabled = false;
            this.toolSave.Image = ((System.Drawing.Image)(resources.GetObject("toolSave.Image")));
            this.toolSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSave.Margin = new System.Windows.Forms.Padding(20, 1, 5, 2);
            this.toolSave.Name = "toolSave";
            this.toolSave.Size = new System.Drawing.Size(23, 22);
            this.toolSave.Text = "Save list";
            this.toolSave.Click += new System.EventHandler(this.ToolSave_Click);
            // 
            // toolLock
            // 
            this.toolLock.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolLock.Checked = true;
            this.toolLock.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolLock.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolLock.Image = ((System.Drawing.Image)(resources.GetObject("toolLock.Image")));
            this.toolLock.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolLock.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.toolLock.Name = "toolLock";
            this.toolLock.Size = new System.Drawing.Size(23, 22);
            this.toolLock.Text = "toolStripButton1";
            this.toolLock.ToolTipText = "Unlock";
            this.toolLock.Click += new System.EventHandler(this.ToolLock_Click);
            // 
            // toolLabelLock
            // 
            this.toolLabelLock.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolLabelLock.Name = "toolLabelLock";
            this.toolLabelLock.Size = new System.Drawing.Size(63, 22);
            this.toolLabelLock.Text = "List locked";
            // 
            // toolLabelSaved
            // 
            this.toolLabelSaved.Name = "toolLabelSaved";
            this.toolLabelSaved.Size = new System.Drawing.Size(79, 22);
            this.toolLabelSaved.Text = "List not saved";
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem2,
            this.menuItem3});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuSaveList,
            this.menuBackupList,
            this.menuItem8,
            this.menuExit});
            this.menuItem1.Text = "File";
            // 
            // menuSaveList
            // 
            this.menuSaveList.Enabled = false;
            this.menuSaveList.Index = 0;
            this.menuSaveList.Text = "Save list";
            this.menuSaveList.Click += new System.EventHandler(this.MenuSaveList_Click);
            // 
            // menuBackupList
            // 
            this.menuBackupList.Enabled = false;
            this.menuBackupList.Index = 1;
            this.menuBackupList.Text = "Backup list";
            this.menuBackupList.Click += new System.EventHandler(this.MenuBackupList_Click);
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 2;
            this.menuItem8.Text = "-";
            // 
            // menuExit
            // 
            this.menuExit.Index = 3;
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.MenuExit_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuChangePassword,
            this.menuLock,
            this.menuItem4,
            this.menuAdd,
            this.menuModify,
            this.menuDelete,
            this.menuItem15,
            this.menuCopyClipboard});
            this.menuItem2.Text = "List";
            // 
            // menuChangePassword
            // 
            this.menuChangePassword.Index = 0;
            this.menuChangePassword.Text = "Create master password...";
            this.menuChangePassword.Click += new System.EventHandler(this.MenuChangePassword_Click);
            // 
            // menuLock
            // 
            this.menuLock.Checked = true;
            this.menuLock.Index = 1;
            this.menuLock.Text = "Lock";
            this.menuLock.Click += new System.EventHandler(this.MenuLock_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 2;
            this.menuItem4.Text = "-";
            // 
            // menuAdd
            // 
            this.menuAdd.Enabled = false;
            this.menuAdd.Index = 3;
            this.menuAdd.Text = "Add...";
            this.menuAdd.Click += new System.EventHandler(this.MenuAdd_Click);
            // 
            // menuModify
            // 
            this.menuModify.Enabled = false;
            this.menuModify.Index = 4;
            this.menuModify.Text = "Modify...";
            this.menuModify.Click += new System.EventHandler(this.MenuModify_Click);
            // 
            // menuDelete
            // 
            this.menuDelete.Enabled = false;
            this.menuDelete.Index = 5;
            this.menuDelete.Text = "Delete...";
            this.menuDelete.Click += new System.EventHandler(this.MenuDelete_Click);
            // 
            // menuItem15
            // 
            this.menuItem15.Index = 6;
            this.menuItem15.Text = "-";
            // 
            // menuCopyClipboard
            // 
            this.menuCopyClipboard.Enabled = false;
            this.menuCopyClipboard.Index = 7;
            this.menuCopyClipboard.Text = "Copy to clipboard";
            this.menuCopyClipboard.Click += new System.EventHandler(this.MenuCopyClipboard_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 2;
            this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuShowPasswords,
            this.menuItem5,
            this.menuUnlockStart,
            this.menuMinimizeOnLock,
            this.menuMinimizeOnCopy});
            this.menuItem3.Text = "Settings";
            // 
            // menuShowPasswords
            // 
            this.menuShowPasswords.Index = 0;
            this.menuShowPasswords.Text = "Show passwords";
            this.menuShowPasswords.Click += new System.EventHandler(this.MenuShowPasswords_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 1;
            this.menuItem5.Text = "-";
            // 
            // menuUnlockStart
            // 
            this.menuUnlockStart.Index = 2;
            this.menuUnlockStart.Text = "Prompt to unlock list on start";
            this.menuUnlockStart.Click += new System.EventHandler(this.MenuUnlockStart_Click);
            // 
            // menuMinimizeOnLock
            // 
            this.menuMinimizeOnLock.Index = 3;
            this.menuMinimizeOnLock.Text = "Minimize on lock";
            this.menuMinimizeOnLock.Click += new System.EventHandler(this.MenuMinimizeOnLock_Click);
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 239);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusCount,
            this.statusDummy,
            this.statusSaved,
            this.statusDummy2,
            this.statusBackup});
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(1009, 22);
            this.statusBar1.TabIndex = 10;
            // 
            // statusCount
            // 
            this.statusCount.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.statusCount.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.statusCount.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None;
            this.statusCount.Name = "statusCount";
            this.statusCount.Text = "0 items";
            this.statusCount.Width = 51;
            // 
            // statusDummy
            // 
            this.statusDummy.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            this.statusDummy.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None;
            this.statusDummy.Name = "statusDummy";
            this.statusDummy.Width = 396;
            // 
            // statusSaved
            // 
            this.statusSaved.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.statusSaved.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.statusSaved.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None;
            this.statusSaved.Name = "statusSaved";
            this.statusSaved.Width = 10;
            // 
            // statusDummy2
            // 
            this.statusDummy2.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            this.statusDummy2.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None;
            this.statusDummy2.Name = "statusDummy2";
            this.statusDummy2.Width = 396;
            // 
            // statusBackup
            // 
            this.statusBackup.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.statusBackup.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.statusBackup.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None;
            this.statusBackup.Name = "statusBackup";
            this.statusBackup.Text = "Last backup: 2017-12-02";
            this.statusBackup.Width = 139;
            // 
            // lstPass
            // 
            this.lstPass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstPass.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmName,
            this.clmAddress,
            this.clmUsername,
            this.clmPassword,
            this.clmComments});
            this.lstPass.FullRowSelect = true;
            this.lstPass.Location = new System.Drawing.Point(12, 33);
            this.lstPass.MultiSelect = false;
            this.lstPass.Name = "lstPass";
            this.lstPass.Size = new System.Drawing.Size(983, 193);
            this.lstPass.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstPass.TabIndex = 0;
            this.lstPass.UseCompatibleStateImageBehavior = false;
            this.lstPass.View = System.Windows.Forms.View.Details;
            this.lstPass.SelectedIndexChanged += new System.EventHandler(this.LstPass_SelectedIndexChanged);
            this.lstPass.DoubleClick += new System.EventHandler(this.LstPass_DoubleClick);
            this.lstPass.KeyUp += new System.Windows.Forms.KeyEventHandler(this.LstPass_KeyUp);
            // 
            // clmName
            // 
            this.clmName.Text = "Name";
            this.clmName.Width = 172;
            // 
            // clmAddress
            // 
            this.clmAddress.Text = "Address";
            this.clmAddress.Width = 183;
            // 
            // clmUsername
            // 
            this.clmUsername.Text = "Username";
            this.clmUsername.Width = 172;
            // 
            // clmPassword
            // 
            this.clmPassword.Text = "Password";
            this.clmPassword.Width = 188;
            // 
            // clmComments
            // 
            this.clmComments.Text = "Comments";
            this.clmComments.Width = 239;
            // 
            // timerFormShown
            // 
            this.timerFormShown.Interval = 200;
            this.timerFormShown.Tick += new System.EventHandler(this.TimerFormShown_Tick);
            // 
            // menuMinimizeOnCopy
            // 
            this.menuMinimizeOnCopy.Index = 4;
            this.menuMinimizeOnCopy.Text = "Minimize on copy";
            this.menuMinimizeOnCopy.Click += new System.EventHandler(this.MenuMinimizeOnCopy_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 261);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lstPass);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu1;
            this.MinimumSize = new System.Drawing.Size(806, 300);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pass";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusDummy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusSaved)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusDummy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBackup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private VisualStylesListView lstPass;
        private System.Windows.Forms.ColumnHeader clmName;
        private System.Windows.Forms.ColumnHeader clmAddress;
        private System.Windows.Forms.ColumnHeader clmUsername;
        private System.Windows.Forms.ColumnHeader clmPassword;
        private System.Windows.Forms.ColumnHeader clmComments;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuBackupList;
        private System.Windows.Forms.MenuItem menuItem8;
        private System.Windows.Forms.MenuItem menuExit;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuAdd;
        private System.Windows.Forms.MenuItem menuModify;
        private System.Windows.Forms.MenuItem menuDelete;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuSaveList;
        private System.Windows.Forms.MenuItem menuItem15;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.StatusBarPanel statusCount;
        private System.Windows.Forms.StatusBarPanel statusDummy;
        private System.Windows.Forms.StatusBarPanel statusBackup;
        private System.Windows.Forms.ToolStripButton toolAdd;
        private System.Windows.Forms.ToolStripButton toolModify;
        private System.Windows.Forms.ToolStripButton toolDelete;
        private System.Windows.Forms.ToolStripButton toolCopyClipboard;
        private System.Windows.Forms.ToolStripButton toolSave;
        private System.Windows.Forms.MenuItem menuShowPasswords;
        private System.Windows.Forms.ToolStripButton toolLock;
        private System.Windows.Forms.ToolStripLabel toolLabelLock;
        private System.Windows.Forms.StatusBarPanel statusSaved;
        private System.Windows.Forms.StatusBarPanel statusDummy2;
        private System.Windows.Forms.MenuItem menuCopyClipboard;
        private System.Windows.Forms.MenuItem menuLock;
        private System.Windows.Forms.MenuItem menuUnlockStart;
        private System.Windows.Forms.MenuItem menuChangePassword;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.Timer timerFormShown;
        private System.Windows.Forms.MenuItem menuMinimizeOnLock;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.ToolStripLabel toolLabelSaved;
        private System.Windows.Forms.MenuItem menuMinimizeOnCopy;
    }
}

