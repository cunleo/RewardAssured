namespace RewardAssured
{
    partial class FrmRegister
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegister));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.PanFooter = new System.Windows.Forms.Panel();
            this.PanAction = new System.Windows.Forms.FlowLayoutPanel();
            this.mnuAction = new System.Windows.Forms.MenuStrip();
            this.mnuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBrowse = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAction = new System.Windows.Forms.Label();
            this.PanButton = new System.Windows.Forms.Panel();
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdOk = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chkSelectAll = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tCoyRegNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmdGetFile = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tFileName = new System.Windows.Forms.TextBox();
            this.tCoyname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tRefNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewJobs = new System.Windows.Forms.DataGridView();
            this.Sn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobCommand = new System.Windows.Forms.DataGridViewButtonColumn();
            this.JobRefNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinancialAbility = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CompetentResources = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ExperienceOfLot = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ViewFile = new System.Windows.Forms.DataGridViewLinkColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.PanFooter.SuspendLayout();
            this.PanAction.SuspendLayout();
            this.mnuAction.SuspendLayout();
            this.PanButton.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJobs)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.PanFooter, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1268, 557);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Job/Contract Information";
            // 
            // PanFooter
            // 
            this.PanFooter.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tableLayoutPanel1.SetColumnSpan(this.PanFooter, 2);
            this.PanFooter.Controls.Add(this.PanAction);
            this.PanFooter.Controls.Add(this.PanButton);
            this.PanFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanFooter.Location = new System.Drawing.Point(0, 508);
            this.PanFooter.Margin = new System.Windows.Forms.Padding(0);
            this.PanFooter.Name = "PanFooter";
            this.PanFooter.Size = new System.Drawing.Size(1268, 49);
            this.PanFooter.TabIndex = 226;
            // 
            // PanAction
            // 
            this.PanAction.BackColor = System.Drawing.Color.White;
            this.PanAction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanAction.Controls.Add(this.mnuAction);
            this.PanAction.Controls.Add(this.lblAction);
            this.PanAction.Location = new System.Drawing.Point(4, 4);
            this.PanAction.Margin = new System.Windows.Forms.Padding(10);
            this.PanAction.Name = "PanAction";
            this.PanAction.Size = new System.Drawing.Size(195, 41);
            this.PanAction.TabIndex = 55;
            // 
            // mnuAction
            // 
            this.mnuAction.AllowMerge = false;
            this.mnuAction.BackColor = System.Drawing.Color.White;
            this.mnuAction.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNew,
            this.mnuEdit,
            this.mnuBrowse,
            this.mnuDelete});
            this.mnuAction.Location = new System.Drawing.Point(1, 0);
            this.mnuAction.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.mnuAction.Name = "mnuAction";
            this.mnuAction.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mnuAction.Size = new System.Drawing.Size(189, 24);
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
            this.mnuBrowse.Click += new System.EventHandler(this.mnuBrowse_Click);
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
            this.lblAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAction.ForeColor = System.Drawing.Color.Red;
            this.lblAction.Location = new System.Drawing.Point(12, 24);
            this.lblAction.Margin = new System.Windows.Forms.Padding(12, 0, 3, 0);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(175, 14);
            this.lblAction.TabIndex = 11;
            this.lblAction.Text = "?";
            this.lblAction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PanButton
            // 
            this.PanButton.Controls.Add(this.cmdClose);
            this.PanButton.Controls.Add(this.cmdOk);
            this.PanButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanButton.Location = new System.Drawing.Point(1089, 0);
            this.PanButton.Name = "PanButton";
            this.PanButton.Size = new System.Drawing.Size(179, 49);
            this.PanButton.TabIndex = 1;
            // 
            // cmdClose
            // 
            this.cmdClose.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClose.Location = new System.Drawing.Point(104, 4);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(72, 41);
            this.cmdClose.TabIndex = 17;
            this.cmdClose.Text = "&Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            // 
            // cmdOk
            // 
            this.cmdOk.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cmdOk.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOk.Location = new System.Drawing.Point(3, 4);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(101, 41);
            this.cmdOk.TabIndex = 15;
            this.cmdOk.Text = "&Ok";
            this.cmdOk.UseVisualStyleBackColor = true;
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.tCoyRegNo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.tCoyname);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tRefNo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 127);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1262, 5);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.chkSelectAll);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.checkBox11);
            this.panel4.Controls.Add(this.checkBox10);
            this.panel4.Controls.Add(this.checkBox9);
            this.panel4.Controls.Add(this.checkBox8);
            this.panel4.Controls.Add(this.checkBox7);
            this.panel4.Controls.Add(this.checkBox6);
            this.panel4.Controls.Add(this.checkBox5);
            this.panel4.Controls.Add(this.checkBox4);
            this.panel4.Controls.Add(this.checkBox3);
            this.panel4.Controls.Add(this.checkBox2);
            this.panel4.Controls.Add(this.checkBox1);
            this.panel4.Location = new System.Drawing.Point(591, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(671, 98);
            this.panel4.TabIndex = 6;
            // 
            // chkSelectAll
            // 
            this.chkSelectAll.AutoSize = true;
            this.chkSelectAll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSelectAll.ForeColor = System.Drawing.Color.Red;
            this.chkSelectAll.Location = new System.Drawing.Point(492, 78);
            this.chkSelectAll.Name = "chkSelectAll";
            this.chkSelectAll.Size = new System.Drawing.Size(73, 19);
            this.chkSelectAll.TabIndex = 12;
            this.chkSelectAll.Text = "Select All";
            this.chkSelectAll.UseVisualStyleBackColor = true;
            this.chkSelectAll.CheckedChanged += new System.EventHandler(this.chkSelectAll_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "REQUIRED DOCUMENTS";
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox11.Location = new System.Drawing.Point(492, 60);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(127, 19);
            this.checkBox11.TabIndex = 10;
            this.checkBox11.Text = "Compliant with ITF";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox10.Location = new System.Drawing.Point(492, 41);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(141, 19);
            this.checkBox10.TabIndex = 9;
            this.checkBox10.Text = "Compliant with FRCN";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox9.Location = new System.Drawing.Point(492, 22);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(152, 19);
            this.checkBox9.TabIndex = 8;
            this.checkBox9.Text = "Enquiries Authorisation ";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox8.Location = new System.Drawing.Point(232, 79);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(140, 19);
            this.checkBox8.TabIndex = 7;
            this.checkBox8.Text = "3yrs Audited Account";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox7.Location = new System.Drawing.Point(232, 60);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(174, 19);
            this.checkBox7.TabIndex = 6;
            this.checkBox7.Text = "Complaint with Pension Act";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox6.Location = new System.Drawing.Point(232, 41);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(238, 19);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "Memorandum and Artice of Association";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.Location = new System.Drawing.Point(232, 22);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(45, 19);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "TIN";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(8, 79);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(103, 19);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "VAT Certificate";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(8, 60);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(202, 19);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Current TAX Clearance Certificate";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(8, 41);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(206, 19);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Evidence of Filling Annual Reports";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(8, 22);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(142, 19);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Registration with CAC";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tCoyRegNo
            // 
            this.tCoyRegNo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tCoyRegNo.Location = new System.Drawing.Point(118, 71);
            this.tCoyRegNo.Name = "tCoyRegNo";
            this.tCoyRegNo.Size = new System.Drawing.Size(130, 25);
            this.tCoyRegNo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Coy. RegNo:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel3.Controls.Add(this.cmdGetFile);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.tFileName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1262, 27);
            this.panel3.TabIndex = 2;
            this.panel3.Visible = false;
            // 
            // cmdGetFile
            // 
            this.cmdGetFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdGetFile.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmdGetFile.Location = new System.Drawing.Point(425, 1);
            this.cmdGetFile.Name = "cmdGetFile";
            this.cmdGetFile.Size = new System.Drawing.Size(33, 27);
            this.cmdGetFile.TabIndex = 202;
            this.cmdGetFile.Text = "...";
            this.cmdGetFile.UseVisualStyleBackColor = true;
            this.cmdGetFile.Click += new System.EventHandler(this.cmdGetFile_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 210;
            this.label6.Text = "eDocument:";
            // 
            // tFileName
            // 
            this.tFileName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tFileName.Location = new System.Drawing.Point(118, 2);
            this.tFileName.Name = "tFileName";
            this.tFileName.Size = new System.Drawing.Size(307, 25);
            this.tFileName.TabIndex = 201;
            this.tFileName.Tag = "RctNo";
            // 
            // tCoyname
            // 
            this.tCoyname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tCoyname.Location = new System.Drawing.Point(118, 43);
            this.tCoyname.Name = "tCoyname";
            this.tCoyname.Size = new System.Drawing.Size(457, 25);
            this.tCoyname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Company Name:";
            // 
            // tRefNo
            // 
            this.tRefNo.BackColor = System.Drawing.Color.FloralWhite;
            this.tRefNo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tRefNo.Location = new System.Drawing.Point(118, 15);
            this.tRefNo.Name = "tRefNo";
            this.tRefNo.Size = new System.Drawing.Size(130, 25);
            this.tRefNo.TabIndex = 1;
            this.tRefNo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "RefNo:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewJobs);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 157);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1262, 348);
            this.panel2.TabIndex = 1;
            // 
            // dataGridViewJobs
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.dataGridViewJobs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewJobs.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dataGridViewJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJobs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sn,
            this.Bid,
            this.JobCommand,
            this.JobRefNo,
            this.Year,
            this.Lot,
            this.JobTitle,
            this.JobCategory,
            this.FinancialAbility,
            this.CompetentResources,
            this.ExperienceOfLot,
            this.ViewFile});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewJobs.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewJobs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewJobs.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewJobs.Name = "dataGridViewJobs";
            this.dataGridViewJobs.Size = new System.Drawing.Size(1262, 348);
            this.dataGridViewJobs.TabIndex = 6;
            this.dataGridViewJobs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewJobs_CellContentClick);
            // 
            // Sn
            // 
            this.Sn.HeaderText = "Sn";
            this.Sn.Name = "Sn";
            this.Sn.Width = 30;
            // 
            // Bid
            // 
            this.Bid.HeaderText = "BidRef";
            this.Bid.Name = "Bid";
            // 
            // JobCommand
            // 
            this.JobCommand.HeaderText = "";
            this.JobCommand.Name = "JobCommand";
            this.JobCommand.Width = 30;
            // 
            // JobRefNo
            // 
            this.JobRefNo.HeaderText = "JobRefNo";
            this.JobRefNo.Name = "JobRefNo";
            this.JobRefNo.Width = 20;
            // 
            // Year
            // 
            this.Year.HeaderText = "Year";
            this.Year.Name = "Year";
            // 
            // Lot
            // 
            this.Lot.HeaderText = "Lot";
            this.Lot.Name = "Lot";
            // 
            // JobTitle
            // 
            this.JobTitle.HeaderText = "Job Title";
            this.JobTitle.Name = "JobTitle";
            this.JobTitle.Width = 250;
            // 
            // JobCategory
            // 
            this.JobCategory.HeaderText = "Job Category";
            this.JobCategory.Name = "JobCategory";
            this.JobCategory.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.JobCategory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FinancialAbility
            // 
            this.FinancialAbility.HeaderText = "Financial Ability";
            this.FinancialAbility.Name = "FinancialAbility";
            this.FinancialAbility.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FinancialAbility.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CompetentResources
            // 
            this.CompetentResources.HeaderText = "Competent Resources Personnel";
            this.CompetentResources.Name = "CompetentResources";
            this.CompetentResources.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CompetentResources.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ExperienceOfLot
            // 
            this.ExperienceOfLot.HeaderText = "Experience Of Lot";
            this.ExperienceOfLot.Name = "ExperienceOfLot";
            this.ExperienceOfLot.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ExperienceOfLot.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ViewFile
            // 
            this.ViewFile.HeaderText = "eDoc";
            this.ViewFile.Name = "ViewFile";
            this.ViewFile.Text = "View File";
            this.ViewFile.UseColumnTextForLinkValue = true;
            this.ViewFile.Width = 60;
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1268, 557);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRegister";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contractor Register";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmRegister_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.PanFooter.ResumeLayout(false);
            this.PanAction.ResumeLayout(false);
            this.PanAction.PerformLayout();
            this.mnuAction.ResumeLayout(false);
            this.mnuAction.PerformLayout();
            this.PanButton.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJobs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewJobs;
        private System.Windows.Forms.TextBox tCoyRegNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tCoyname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tRefNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Panel PanFooter;
        internal System.Windows.Forms.FlowLayoutPanel PanAction;
        internal System.Windows.Forms.MenuStrip mnuAction;
        internal System.Windows.Forms.ToolStripMenuItem mnuNew;
        internal System.Windows.Forms.ToolStripMenuItem mnuEdit;
        internal System.Windows.Forms.ToolStripMenuItem mnuBrowse;
        internal System.Windows.Forms.ToolStripMenuItem mnuDelete;
        internal System.Windows.Forms.Label lblAction;
        internal System.Windows.Forms.Panel PanButton;
        internal System.Windows.Forms.Button cmdClose;
        internal System.Windows.Forms.Button cmdOk;
        private System.Windows.Forms.Panel panel3;
        internal System.Windows.Forms.Button cmdGetFile;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox tFileName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bid;
        private System.Windows.Forms.DataGridViewButtonColumn JobCommand;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobRefNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lot;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobCategory;
        private System.Windows.Forms.DataGridViewCheckBoxColumn FinancialAbility;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CompetentResources;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ExperienceOfLot;
        private System.Windows.Forms.DataGridViewLinkColumn ViewFile;
        private System.Windows.Forms.CheckBox chkSelectAll;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}