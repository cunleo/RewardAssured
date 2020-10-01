namespace RewardAssured
{
    partial class FrmServices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServices));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
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
            this.label9 = new System.Windows.Forms.Label();
            this.tReward = new System.Windows.Forms.TextBox();
            this.tRewardBalance = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tAmountPaid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tServiceValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdClient = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tTransNo = new System.Windows.Forms.TextBox();
            this.tServiceDetails = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tClientsDetails = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tRefNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.PanFooter.SuspendLayout();
            this.PanAction.SuspendLayout();
            this.mnuAction.SuspendLayout();
            this.PanButton.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpDate);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.PanFooter);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.tReward);
            this.panel1.Controls.Add(this.tRewardBalance);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tAmountPaid);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tServiceValue);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmdClient);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tTransNo);
            this.panel1.Controls.Add(this.tServiceDetails);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tClientsDetails);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tRefNo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 303);
            this.panel1.TabIndex = 1;
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(367, 5);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(124, 25);
            this.dtpDate.TabIndex = 229;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(326, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 228;
            this.label6.Text = "Date:";
            // 
            // PanFooter
            // 
            this.PanFooter.BackColor = System.Drawing.Color.AntiqueWhite;
            this.PanFooter.Controls.Add(this.PanAction);
            this.PanFooter.Controls.Add(this.PanButton);
            this.PanFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanFooter.Location = new System.Drawing.Point(0, 254);
            this.PanFooter.Margin = new System.Windows.Forms.Padding(0);
            this.PanFooter.Name = "PanFooter";
            this.PanFooter.Size = new System.Drawing.Size(498, 49);
            this.PanFooter.TabIndex = 227;
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
            this.mnuEdit.Enabled = false;
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
            this.PanButton.Location = new System.Drawing.Point(319, 0);
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
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 17);
            this.label9.TabIndex = 211;
            this.label9.Text = "Reward drawals:";
            // 
            // tReward
            // 
            this.tReward.BackColor = System.Drawing.Color.White;
            this.tReward.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tReward.Location = new System.Drawing.Point(118, 221);
            this.tReward.Name = "tReward";
            this.tReward.Size = new System.Drawing.Size(131, 25);
            this.tReward.TabIndex = 210;
            this.tReward.TabStop = false;
            this.tReward.TextChanged += new System.EventHandler(this.tReward_TextChanged);
            this.tReward.Leave += new System.EventHandler(this.tReward_Leave);
            // 
            // tRewardBalance
            // 
            this.tRewardBalance.BackColor = System.Drawing.Color.FloralWhite;
            this.tRewardBalance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tRewardBalance.Location = new System.Drawing.Point(364, 219);
            this.tRewardBalance.Name = "tRewardBalance";
            this.tRewardBalance.ReadOnly = true;
            this.tRewardBalance.Size = new System.Drawing.Size(130, 25);
            this.tRewardBalance.TabIndex = 209;
            this.tRewardBalance.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(256, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 17);
            this.label8.TabIndex = 208;
            this.label8.Text = "Available Reward:";
            // 
            // tAmountPaid
            // 
            this.tAmountPaid.BackColor = System.Drawing.Color.White;
            this.tAmountPaid.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tAmountPaid.Location = new System.Drawing.Point(118, 194);
            this.tAmountPaid.Name = "tAmountPaid";
            this.tAmountPaid.Size = new System.Drawing.Size(131, 25);
            this.tAmountPaid.TabIndex = 207;
            this.tAmountPaid.TabStop = false;
            this.tAmountPaid.TextChanged += new System.EventHandler(this.tAmountPaid_TextChanged);
            this.tAmountPaid.Leave += new System.EventHandler(this.tAmountPaid_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 17);
            this.label7.TabIndex = 206;
            this.label7.Text = "Amount Paid:";
            // 
            // tServiceValue
            // 
            this.tServiceValue.BackColor = System.Drawing.Color.White;
            this.tServiceValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tServiceValue.Location = new System.Drawing.Point(118, 166);
            this.tServiceValue.Name = "tServiceValue";
            this.tServiceValue.Size = new System.Drawing.Size(131, 25);
            this.tServiceValue.TabIndex = 205;
            this.tServiceValue.TabStop = false;
            this.tServiceValue.TextChanged += new System.EventHandler(this.tServiceValue_TextChanged);
            this.tServiceValue.Leave += new System.EventHandler(this.tServiceValue_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 204;
            this.label5.Text = "Service Value:";
            // 
            // cmdClient
            // 
            this.cmdClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdClient.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmdClient.Location = new System.Drawing.Point(251, 34);
            this.cmdClient.Name = "cmdClient";
            this.cmdClient.Size = new System.Drawing.Size(33, 27);
            this.cmdClient.TabIndex = 203;
            this.cmdClient.Text = "...";
            this.cmdClient.UseVisualStyleBackColor = true;
            this.cmdClient.Click += new System.EventHandler(this.cmdClient_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Trans. No:";
            // 
            // tTransNo
            // 
            this.tTransNo.BackColor = System.Drawing.Color.FloralWhite;
            this.tTransNo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tTransNo.Location = new System.Drawing.Point(118, 6);
            this.tTransNo.Name = "tTransNo";
            this.tTransNo.ReadOnly = true;
            this.tTransNo.Size = new System.Drawing.Size(130, 25);
            this.tTransNo.TabIndex = 8;
            this.tTransNo.TabStop = false;
            // 
            // tServiceDetails
            // 
            this.tServiceDetails.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tServiceDetails.Location = new System.Drawing.Point(118, 91);
            this.tServiceDetails.Multiline = true;
            this.tServiceDetails.Name = "tServiceDetails";
            this.tServiceDetails.Size = new System.Drawing.Size(375, 72);
            this.tServiceDetails.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Service Details:";
            // 
            // tClientsDetails
            // 
            this.tClientsDetails.BackColor = System.Drawing.Color.FloralWhite;
            this.tClientsDetails.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tClientsDetails.Location = new System.Drawing.Point(118, 63);
            this.tClientsDetails.Name = "tClientsDetails";
            this.tClientsDetails.Size = new System.Drawing.Size(375, 25);
            this.tClientsDetails.TabIndex = 3;
            this.tClientsDetails.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Client Details:";
            // 
            // tRefNo
            // 
            this.tRefNo.BackColor = System.Drawing.Color.White;
            this.tRefNo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tRefNo.Location = new System.Drawing.Point(118, 35);
            this.tRefNo.Name = "tRefNo";
            this.tRefNo.ReadOnly = true;
            this.tRefNo.Size = new System.Drawing.Size(131, 25);
            this.tRefNo.TabIndex = 1;
            this.tRefNo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client RefNo:";
            // 
            // lvList
            // 
            this.lvList.BackColor = System.Drawing.Color.FloralWhite;
            this.lvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvList.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvList.FullRowSelect = true;
            this.lvList.GridLines = true;
            this.lvList.Location = new System.Drawing.Point(3, 20);
            this.lvList.MultiSelect = false;
            this.lvList.Name = "lvList";
            this.lvList.Size = new System.Drawing.Size(233, 280);
            this.lvList.TabIndex = 262;
            this.lvList.UseCompatibleStateImageBehavior = false;
            this.lvList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Code";
            this.columnHeader1.Width = 45;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Level";
            this.columnHeader2.Width = 2;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "%";
            this.columnHeader3.Width = 38;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Amount";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 67;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Client Details";
            this.columnHeader5.Width = 208;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(749, 309);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lvList, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(507, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(239, 303);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(239, 17);
            this.label10.TabIndex = 205;
            this.label10.Text = "Reward Distribution";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(749, 309);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmServices";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Services and Payments";
            this.Load += new System.EventHandler(this.FrmServices_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanFooter.ResumeLayout(false);
            this.PanAction.ResumeLayout(false);
            this.PanAction.PerformLayout();
            this.mnuAction.ResumeLayout(false);
            this.mnuAction.PerformLayout();
            this.PanButton.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tTransNo;
        private System.Windows.Forms.TextBox tServiceDetails;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tClientsDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tRefNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tReward;
        private System.Windows.Forms.TextBox tRewardBalance;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tAmountPaid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tServiceValue;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Button cmdClient;
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
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.ListView lvList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label10;
    }
}