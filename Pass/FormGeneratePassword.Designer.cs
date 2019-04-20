namespace Pass
{
    partial class FormGeneratePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGeneratePassword));
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtNumbers = new System.Windows.Forms.TextBox();
            this.columnNew = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkNumbers = new System.Windows.Forms.CheckBox();
            this.checkLowercase = new System.Windows.Forms.CheckBox();
            this.txtLowercase = new System.Windows.Forms.TextBox();
            this.checkUppercase = new System.Windows.Forms.CheckBox();
            this.txtUppercase = new System.Windows.Forms.TextBox();
            this.checkSpecial1 = new System.Windows.Forms.CheckBox();
            this.txtSpecial1 = new System.Windows.Forms.TextBox();
            this.checkSpecial2 = new System.Windows.Forms.CheckBox();
            this.txtSpecial2 = new System.Windows.Forms.TextBox();
            this.numericPassLen = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCopyOld = new System.Windows.Forms.Button();
            this.btnCopyNew = new System.Windows.Forms.Button();
            this.btnClearClipboard = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPassLen)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewPassword.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Location = new System.Drawing.Point(108, 105);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(280, 20);
            this.txtNewPassword.TabIndex = 42;
            // 
            // txtNumbers
            // 
            this.txtNumbers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumbers.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumbers.Location = new System.Drawing.Point(158, 26);
            this.txtNumbers.Name = "txtNumbers";
            this.txtNumbers.Size = new System.Drawing.Size(243, 20);
            this.txtNumbers.TabIndex = 36;
            // 
            // columnNew
            // 
            this.columnNew.Text = "New episodes";
            this.columnNew.Width = 100;
            // 
            // columnAddress
            // 
            this.columnAddress.Text = "Address";
            this.columnAddress.Width = 272;
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 160;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(288, 475);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 33;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(369, 475);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(21, 18);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(142, 15);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Generate new password";
            this.labelName.UseMnemonic = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 51);
            this.panel1.TabIndex = 35;
            // 
            // checkNumbers
            // 
            this.checkNumbers.AutoSize = true;
            this.checkNumbers.Location = new System.Drawing.Point(19, 28);
            this.checkNumbers.Name = "checkNumbers";
            this.checkNumbers.Size = new System.Drawing.Size(71, 17);
            this.checkNumbers.TabIndex = 46;
            this.checkNumbers.Text = "Numbers:";
            this.checkNumbers.UseVisualStyleBackColor = true;
            // 
            // checkLowercase
            // 
            this.checkLowercase.AutoSize = true;
            this.checkLowercase.Location = new System.Drawing.Point(19, 54);
            this.checkLowercase.Name = "checkLowercase";
            this.checkLowercase.Size = new System.Drawing.Size(134, 17);
            this.checkLowercase.TabIndex = 48;
            this.checkLowercase.Text = "Lowercase characters:";
            this.checkLowercase.UseVisualStyleBackColor = true;
            // 
            // txtLowercase
            // 
            this.txtLowercase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLowercase.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLowercase.Location = new System.Drawing.Point(158, 52);
            this.txtLowercase.Name = "txtLowercase";
            this.txtLowercase.Size = new System.Drawing.Size(243, 20);
            this.txtLowercase.TabIndex = 47;
            // 
            // checkUppercase
            // 
            this.checkUppercase.AutoSize = true;
            this.checkUppercase.Location = new System.Drawing.Point(19, 80);
            this.checkUppercase.Name = "checkUppercase";
            this.checkUppercase.Size = new System.Drawing.Size(134, 17);
            this.checkUppercase.TabIndex = 50;
            this.checkUppercase.Text = "Uppercase characters:";
            this.checkUppercase.UseVisualStyleBackColor = true;
            // 
            // txtUppercase
            // 
            this.txtUppercase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUppercase.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUppercase.Location = new System.Drawing.Point(158, 78);
            this.txtUppercase.Name = "txtUppercase";
            this.txtUppercase.Size = new System.Drawing.Size(243, 20);
            this.txtUppercase.TabIndex = 49;
            // 
            // checkSpecial1
            // 
            this.checkSpecial1.AutoSize = true;
            this.checkSpecial1.Location = new System.Drawing.Point(19, 106);
            this.checkSpecial1.Name = "checkSpecial1";
            this.checkSpecial1.Size = new System.Drawing.Size(133, 17);
            this.checkSpecial1.TabIndex = 52;
            this.checkSpecial1.Text = "Special characters #1:";
            this.checkSpecial1.UseVisualStyleBackColor = true;
            // 
            // txtSpecial1
            // 
            this.txtSpecial1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSpecial1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpecial1.Location = new System.Drawing.Point(158, 104);
            this.txtSpecial1.Name = "txtSpecial1";
            this.txtSpecial1.Size = new System.Drawing.Size(243, 20);
            this.txtSpecial1.TabIndex = 51;
            // 
            // checkSpecial2
            // 
            this.checkSpecial2.AutoSize = true;
            this.checkSpecial2.Location = new System.Drawing.Point(19, 132);
            this.checkSpecial2.Name = "checkSpecial2";
            this.checkSpecial2.Size = new System.Drawing.Size(133, 17);
            this.checkSpecial2.TabIndex = 54;
            this.checkSpecial2.Text = "Special characters #2:";
            this.checkSpecial2.UseVisualStyleBackColor = true;
            // 
            // txtSpecial2
            // 
            this.txtSpecial2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSpecial2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpecial2.Location = new System.Drawing.Point(158, 130);
            this.txtSpecial2.Name = "txtSpecial2";
            this.txtSpecial2.Size = new System.Drawing.Size(243, 20);
            this.txtSpecial2.TabIndex = 53;
            // 
            // numericPassLen
            // 
            this.numericPassLen.Location = new System.Drawing.Point(19, 26);
            this.numericPassLen.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.numericPassLen.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericPassLen.Name = "numericPassLen";
            this.numericPassLen.Size = new System.Drawing.Size(56, 20);
            this.numericPassLen.TabIndex = 55;
            this.numericPassLen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericPassLen.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "characters";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtNumbers);
            this.groupBox1.Controls.Add(this.checkNumbers);
            this.groupBox1.Controls.Add(this.txtLowercase);
            this.groupBox1.Controls.Add(this.checkSpecial2);
            this.groupBox1.Controls.Add(this.checkLowercase);
            this.groupBox1.Controls.Add(this.txtSpecial2);
            this.groupBox1.Controls.Add(this.txtUppercase);
            this.groupBox1.Controls.Add(this.checkSpecial1);
            this.groupBox1.Controls.Add(this.checkUppercase);
            this.groupBox1.Controls.Add(this.txtSpecial1);
            this.groupBox1.Location = new System.Drawing.Point(24, 266);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 170);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Include characters";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.numericPassLen);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(24, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 65);
            this.groupBox2.TabIndex = 58;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Password length";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.Location = new System.Drawing.Point(108, 132);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(336, 23);
            this.btnGenerate.TabIndex = 60;
            this.btnGenerate.Text = "Generate new";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOldPassword.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldPassword.Location = new System.Drawing.Point(108, 76);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Size = new System.Drawing.Size(280, 20);
            this.txtOldPassword.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Old password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "New password:";
            // 
            // btnCopyOld
            // 
            this.btnCopyOld.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyOld.Location = new System.Drawing.Point(394, 74);
            this.btnCopyOld.Name = "btnCopyOld";
            this.btnCopyOld.Size = new System.Drawing.Size(50, 23);
            this.btnCopyOld.TabIndex = 63;
            this.btnCopyOld.Text = "Copy";
            this.btnCopyOld.UseVisualStyleBackColor = true;
            this.btnCopyOld.Click += new System.EventHandler(this.BtnCopyOld_Click);
            // 
            // btnCopyNew
            // 
            this.btnCopyNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyNew.Location = new System.Drawing.Point(394, 103);
            this.btnCopyNew.Name = "btnCopyNew";
            this.btnCopyNew.Size = new System.Drawing.Size(50, 23);
            this.btnCopyNew.TabIndex = 64;
            this.btnCopyNew.Text = "Copy";
            this.btnCopyNew.UseVisualStyleBackColor = true;
            this.btnCopyNew.Click += new System.EventHandler(this.BtnCopyNew_Click);
            // 
            // btnClearClipboard
            // 
            this.btnClearClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearClipboard.Location = new System.Drawing.Point(24, 475);
            this.btnClearClipboard.Name = "btnClearClipboard";
            this.btnClearClipboard.Size = new System.Drawing.Size(103, 23);
            this.btnClearClipboard.TabIndex = 65;
            this.btnClearClipboard.Text = "Clear clipboard";
            this.btnClearClipboard.UseVisualStyleBackColor = true;
            this.btnClearClipboard.Click += new System.EventHandler(this.BtnClearClipboard_Click);
            // 
            // FormGeneratePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(470, 511);
            this.Controls.Add(this.btnClearClipboard);
            this.Controls.Add(this.btnCopyNew);
            this.Controls.Add(this.btnCopyOld);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOldPassword);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(486, 501);
            this.Name = "FormGeneratePassword";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Generate Password";
            this.Load += new System.EventHandler(this.FormGeneratePassword_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPassLen)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtNumbers;
        private System.Windows.Forms.ColumnHeader columnNew;
        private System.Windows.Forms.ColumnHeader columnAddress;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkNumbers;
        private System.Windows.Forms.CheckBox checkLowercase;
        private System.Windows.Forms.TextBox txtLowercase;
        private System.Windows.Forms.CheckBox checkUppercase;
        private System.Windows.Forms.TextBox txtUppercase;
        private System.Windows.Forms.CheckBox checkSpecial1;
        private System.Windows.Forms.TextBox txtSpecial1;
        private System.Windows.Forms.CheckBox checkSpecial2;
        private System.Windows.Forms.TextBox txtSpecial2;
        private System.Windows.Forms.NumericUpDown numericPassLen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCopyOld;
        private System.Windows.Forms.Button btnCopyNew;
        private System.Windows.Forms.Button btnClearClipboard;
    }
}