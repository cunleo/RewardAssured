namespace RewardAssured
{
    partial class FrmSystemUsers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSystemUsers));
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ModuleDGV = new System.Windows.Forms.DataGridView();
            this.Modules = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Open = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.PanAction = new System.Windows.Forms.FlowLayoutPanel();
            this.mnuAction = new System.Windows.Forms.MenuStrip();
            this.mnuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBrowse = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAction = new System.Windows.Forms.Label();
            this.PanFooter = new System.Windows.Forms.Panel();
            this.cmdOk = new System.Windows.Forms.Button();
            this.chkSelectAll = new System.Windows.Forms.CheckBox();
            this.cmdClose = new System.Windows.Forms.Button();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.tUserName = new System.Windows.Forms.TextBox();
            this.tConfirmPwd = new System.Windows.Forms.TextBox();
            this.tPwd = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.cboUser = new System.Windows.Forms.ComboBox();
            this.TableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ModuleDGV)).BeginInit();
            this.Panel1.SuspendLayout();
            this.PanAction.SuspendLayout();
            this.mnuAction.SuspendLayout();
            this.PanFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.ColumnCount = 1;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel1.Controls.Add(this.ModuleDGV, 0, 1);
            this.TableLayoutPanel1.Controls.Add(this.Panel1, 0, 0);
            this.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 2;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(295, 412);
            this.TableLayoutPanel1.TabIndex = 127;
            // 
            // ModuleDGV
            // 
            this.ModuleDGV.AllowUserToAddRows = false;
            this.ModuleDGV.AllowUserToDeleteRows = false;
            this.ModuleDGV.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.ModuleDGV.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.ModuleDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ModuleDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modules,
            this.Open});
            this.ModuleDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ModuleDGV.Location = new System.Drawing.Point(1, 156);
            this.ModuleDGV.Margin = new System.Windows.Forms.Padding(1);
            this.ModuleDGV.MultiSelect = false;
            this.ModuleDGV.Name = "ModuleDGV";
            this.ModuleDGV.RowHeadersWidth = 21;
            this.ModuleDGV.Size = new System.Drawing.Size(293, 255);
            this.ModuleDGV.TabIndex = 44;
            // 
            // Modules
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SeaShell;
            this.Modules.DefaultCellStyle = dataGridViewCellStyle1;
            this.Modules.Frozen = true;
            this.Modules.HeaderText = "Modules";
            this.Modules.Name = "Modules";
            this.Modules.ReadOnly = true;
            this.Modules.ToolTipText = "Application Modules";
            this.Modules.Width = 200;
            // 
            // Open
            // 
            this.Open.HeaderText = "Allow";
            this.Open.Name = "Open";
            this.Open.ToolTipText = "Click to Toggle Open options";
            this.Open.Width = 45;
            // 
            // Panel1
            // 
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.PanAction);
            this.Panel1.Controls.Add(this.PanFooter);
            this.Panel1.Controls.Add(this.UsernameLabel);
            this.Panel1.Controls.Add(this.PasswordLabel);
            this.Panel1.Controls.Add(this.tUserName);
            this.Panel1.Controls.Add(this.tConfirmPwd);
            this.Panel1.Controls.Add(this.tPwd);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.cboUser);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Margin = new System.Windows.Forms.Padding(0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(295, 155);
            this.Panel1.TabIndex = 45;
            // 
            // PanAction
            // 
            this.PanAction.BackColor = System.Drawing.Color.FloralWhite;
            this.PanAction.Controls.Add(this.mnuAction);
            this.PanAction.Controls.Add(this.lblAction);
            this.PanAction.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanAction.Location = new System.Drawing.Point(0, 0);
            this.PanAction.Margin = new System.Windows.Forms.Padding(10);
            this.PanAction.Name = "PanAction";
            this.PanAction.Size = new System.Drawing.Size(293, 26);
            this.PanAction.TabIndex = 61;
            // 
            // mnuAction
            // 
            this.mnuAction.AllowMerge = false;
            this.mnuAction.BackColor = System.Drawing.Color.AntiqueWhite;
            this.mnuAction.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNew,
            this.mnuEdit,
            this.mnuBrowse,
            this.mnuDelete});
            this.mnuAction.Location = new System.Drawing.Point(1, 0);
            this.mnuAction.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.mnuAction.Name = "mnuAction";
            this.mnuAction.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mnuAction.Size = new System.Drawing.Size(135, 24);
            this.mnuAction.TabIndex = 52;
            this.mnuAction.Text = "mnuAction";
            // 
            // mnuNew
            // 
            this.mnuNew.Font = new System.Drawing.Font("Tahoma", 8F);
            this.mnuNew.Name = "mnuNew";
            this.mnuNew.Size = new System.Drawing.Size(40, 20);
            this.mnuNew.Text = "New";
            this.mnuNew.Click += new System.EventHandler(this.mnuNew_Click);
            // 
            // mnuEdit
            // 
            this.mnuEdit.Font = new System.Drawing.Font("Tahoma", 8F);
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(37, 20);
            this.mnuEdit.Text = "Edit";
            this.mnuEdit.Click += new System.EventHandler(this.mnuEdit_Click);
            // 
            // mnuBrowse
            // 
            this.mnuBrowse.Font = new System.Drawing.Font("Tahoma", 8F);
            this.mnuBrowse.Name = "mnuBrowse";
            this.mnuBrowse.Size = new System.Drawing.Size(54, 20);
            this.mnuBrowse.Text = "Browse";
            this.mnuBrowse.Visible = false;
            // 
            // mnuDelete
            // 
            this.mnuDelete.Font = new System.Drawing.Font("Tahoma", 8F);
            this.mnuDelete.Name = "mnuDelete";
            this.mnuDelete.Size = new System.Drawing.Size(50, 20);
            this.mnuDelete.Text = "Delete";
            this.mnuDelete.Click += new System.EventHandler(this.mnuDelete_Click);
            // 
            // lblAction
            // 
            this.lblAction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAction.ForeColor = System.Drawing.Color.Red;
            this.lblAction.Location = new System.Drawing.Point(137, 5);
            this.lblAction.Margin = new System.Windows.Forms.Padding(0);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(151, 14);
            this.lblAction.TabIndex = 11;
            this.lblAction.Text = "?";
            this.lblAction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PanFooter
            // 
            this.PanFooter.BackColor = System.Drawing.Color.AntiqueWhite;
            this.PanFooter.Controls.Add(this.cmdOk);
            this.PanFooter.Controls.Add(this.chkSelectAll);
            this.PanFooter.Controls.Add(this.cmdClose);
            this.PanFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanFooter.Location = new System.Drawing.Point(0, 112);
            this.PanFooter.Name = "PanFooter";
            this.PanFooter.Size = new System.Drawing.Size(293, 41);
            this.PanFooter.TabIndex = 60;
            // 
            // cmdOk
            // 
            this.cmdOk.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cmdOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmdOk.Location = new System.Drawing.Point(142, 4);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(82, 34);
            this.cmdOk.TabIndex = 48;
            this.cmdOk.Text = "&Ok";
            this.cmdOk.UseVisualStyleBackColor = true;
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // chkSelectAll
            // 
            this.chkSelectAll.AutoSize = true;
            this.chkSelectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.chkSelectAll.Location = new System.Drawing.Point(5, 12);
            this.chkSelectAll.Name = "chkSelectAll";
            this.chkSelectAll.Size = new System.Drawing.Size(76, 19);
            this.chkSelectAll.TabIndex = 19;
            this.chkSelectAll.Text = "Select All";
            this.chkSelectAll.UseVisualStyleBackColor = true;
            this.chkSelectAll.CheckedChanged += new System.EventHandler(this.chkSelectAll_CheckedChanged);
            // 
            // cmdClose
            // 
            this.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmdClose.Location = new System.Drawing.Point(225, 4);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(64, 34);
            this.cmdClose.TabIndex = 46;
            this.cmdClose.Text = "&Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(5, 33);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(68, 15);
            this.UsernameLabel.TabIndex = 8;
            this.UsernameLabel.Text = "&User name";
            this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(5, 62);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(61, 15);
            this.PasswordLabel.TabIndex = 10;
            this.PasswordLabel.Text = "&Password";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tUserName
            // 
            this.tUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tUserName.Location = new System.Drawing.Point(115, 35);
            this.tUserName.Name = "tUserName";
            this.tUserName.Size = new System.Drawing.Size(148, 21);
            this.tUserName.TabIndex = 0;
            // 
            // tConfirmPwd
            // 
            this.tConfirmPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tConfirmPwd.Location = new System.Drawing.Point(115, 87);
            this.tConfirmPwd.Name = "tConfirmPwd";
            this.tConfirmPwd.PasswordChar = '*';
            this.tConfirmPwd.Size = new System.Drawing.Size(105, 21);
            this.tConfirmPwd.TabIndex = 2;
            this.tConfirmPwd.UseSystemPasswordChar = true;
            // 
            // tPwd
            // 
            this.tPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tPwd.Location = new System.Drawing.Point(115, 61);
            this.tPwd.Name = "tPwd";
            this.tPwd.PasswordChar = '*';
            this.tPwd.Size = new System.Drawing.Size(107, 21);
            this.tPwd.TabIndex = 1;
            this.tPwd.UseSystemPasswordChar = true;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(5, 90);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(107, 15);
            this.Label1.TabIndex = 15;
            this.Label1.Text = "&Confirm Password";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboUser
            // 
            this.cboUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUser.FormattingEnabled = true;
            this.cboUser.Location = new System.Drawing.Point(115, 34);
            this.cboUser.Name = "cboUser";
            this.cboUser.Size = new System.Drawing.Size(164, 23);
            this.cboUser.TabIndex = 16;
            this.cboUser.SelectedIndexChanged += new System.EventHandler(this.cboUser_SelectedIndexChanged);
            // 
            // FrmSystemUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(295, 412);
            this.Controls.Add(this.TableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSystemUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Users";
            this.Load += new System.EventHandler(this.FrmSystemUsers_Load);
            this.TableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ModuleDGV)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.PanAction.ResumeLayout(false);
            this.PanAction.PerformLayout();
            this.mnuAction.ResumeLayout(false);
            this.mnuAction.PerformLayout();
            this.PanFooter.ResumeLayout(false);
            this.PanFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.DataGridView ModuleDGV;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Modules;
        internal System.Windows.Forms.DataGridViewCheckBoxColumn Open;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.CheckBox chkSelectAll;
        internal System.Windows.Forms.Label UsernameLabel;
        internal System.Windows.Forms.Label PasswordLabel;
        internal System.Windows.Forms.TextBox tUserName;
        internal System.Windows.Forms.TextBox tConfirmPwd;
        internal System.Windows.Forms.TextBox tPwd;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox cboUser;
        internal System.Windows.Forms.Panel PanFooter;
        internal System.Windows.Forms.Button cmdOk;
        internal System.Windows.Forms.Button cmdClose;
        internal System.Windows.Forms.FlowLayoutPanel PanAction;
        internal System.Windows.Forms.MenuStrip mnuAction;
        internal System.Windows.Forms.ToolStripMenuItem mnuNew;
        internal System.Windows.Forms.ToolStripMenuItem mnuEdit;
        internal System.Windows.Forms.ToolStripMenuItem mnuBrowse;
        internal System.Windows.Forms.ToolStripMenuItem mnuDelete;
        internal System.Windows.Forms.Label lblAction;
    }
}