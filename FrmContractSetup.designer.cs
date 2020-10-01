namespace RewardAssured
{
    partial class FrmContractSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContractSetup));
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CmdClose = new System.Windows.Forms.Button();
            this.lvList = new System.Windows.Forms.ListView();
            this.ColName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PanCommands = new System.Windows.Forms.Panel();
            this.CmdInsert = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.numYear = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.cCateory = new System.Windows.Forms.ComboBox();
            this.tTitle = new System.Windows.Forms.TextBox();
            this.tLot = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.lblCount = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CmdCut = new System.Windows.Forms.Button();
            this.CmdOpen = new System.Windows.Forms.Button();
            this.TableLayoutPanel1.SuspendLayout();
            this.PanCommands.SuspendLayout();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutPanel1.Controls.Add(this.CmdClose, 0, 2);
            this.TableLayoutPanel1.Controls.Add(this.lvList, 0, 1);
            this.TableLayoutPanel1.Controls.Add(this.PanCommands, 1, 0);
            this.TableLayoutPanel1.Controls.Add(this.Panel1, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.Panel2, 0, 2);
            this.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 3;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(458, 501);
            this.TableLayoutPanel1.TabIndex = 5;
            // 
            // CmdClose
            // 
            this.CmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CmdClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CmdClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdClose.Location = new System.Drawing.Point(372, 474);
            this.CmdClose.Margin = new System.Windows.Forms.Padding(1);
            this.CmdClose.Name = "CmdClose";
            this.CmdClose.Size = new System.Drawing.Size(85, 26);
            this.CmdClose.TabIndex = 263;
            this.CmdClose.Text = "CLOSE";
            this.CmdClose.UseVisualStyleBackColor = true;
            // 
            // lvList
            // 
            this.lvList.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.ColName,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.TableLayoutPanel1.SetColumnSpan(this.lvList, 2);
            this.lvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvList.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvList.FullRowSelect = true;
            this.lvList.GridLines = true;
            this.lvList.Location = new System.Drawing.Point(3, 97);
            this.lvList.MultiSelect = false;
            this.lvList.Name = "lvList";
            this.lvList.Size = new System.Drawing.Size(452, 373);
            this.lvList.TabIndex = 261;
            this.lvList.UseCompatibleStateImageBehavior = false;
            this.lvList.View = System.Windows.Forms.View.Details;
            // 
            // ColName
            // 
            this.ColName.Text = "Year";
            this.ColName.Width = 53;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Lot";
            this.columnHeader1.Width = 78;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Title";
            this.columnHeader2.Width = 193;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Category";
            this.columnHeader3.Width = 106;
            // 
            // PanCommands
            // 
            this.PanCommands.BackColor = System.Drawing.Color.Tan;
            this.PanCommands.Controls.Add(this.CmdInsert);
            this.PanCommands.Controls.Add(this.CmdCut);
            this.PanCommands.Controls.Add(this.CmdOpen);
            this.PanCommands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanCommands.Location = new System.Drawing.Point(371, 0);
            this.PanCommands.Margin = new System.Windows.Forms.Padding(0);
            this.PanCommands.Name = "PanCommands";
            this.PanCommands.Size = new System.Drawing.Size(87, 94);
            this.PanCommands.TabIndex = 260;
            // 
            // CmdInsert
            // 
            this.CmdInsert.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdInsert.Location = new System.Drawing.Point(6, 15);
            this.CmdInsert.Name = "CmdInsert";
            this.CmdInsert.Size = new System.Drawing.Size(76, 36);
            this.CmdInsert.TabIndex = 11;
            this.CmdInsert.Text = "INSERT";
            this.CmdInsert.UseVisualStyleBackColor = true;
            this.CmdInsert.Click += new System.EventHandler(this.CmdInsert_Click);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Panel1.Controls.Add(this.label4);
            this.Panel1.Controls.Add(this.numYear);
            this.Panel1.Controls.Add(this.label11);
            this.Panel1.Controls.Add(this.cCateory);
            this.Panel1.Controls.Add(this.tTitle);
            this.Panel1.Controls.Add(this.tLot);
            this.Panel1.Controls.Add(this.label2);
            this.Panel1.Controls.Add(this.label1);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel1.Location = new System.Drawing.Point(3, 3);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(365, 88);
            this.Panel1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "Title:";
            // 
            // numYear
            // 
            this.numYear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numYear.Location = new System.Drawing.Point(101, 4);
            this.numYear.Maximum = new decimal(new int[] {
            2030,
            0,
            0,
            0});
            this.numYear.Minimum = new decimal(new int[] {
            2016,
            0,
            0,
            0});
            this.numYear.Name = "numYear";
            this.numYear.Size = new System.Drawing.Size(62, 25);
            this.numYear.TabIndex = 35;
            this.numYear.Value = new decimal(new int[] {
            2016,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(4, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 17);
            this.label11.TabIndex = 34;
            this.label11.Text = "Category:";
            // 
            // cCateory
            // 
            this.cCateory.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cCateory.FormattingEnabled = true;
            this.cCateory.Location = new System.Drawing.Point(101, 60);
            this.cCateory.Name = "cCateory";
            this.cCateory.Size = new System.Drawing.Size(258, 25);
            this.cCateory.TabIndex = 33;
            // 
            // tTitle
            // 
            this.tTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tTitle.Location = new System.Drawing.Point(101, 32);
            this.tTitle.Name = "tTitle";
            this.tTitle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tTitle.Size = new System.Drawing.Size(258, 25);
            this.tTitle.TabIndex = 32;
            // 
            // tLot
            // 
            this.tLot.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tLot.Location = new System.Drawing.Point(296, 4);
            this.tLot.Name = "tLot";
            this.tLot.Size = new System.Drawing.Size(63, 25);
            this.tLot.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Evaluation Year:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Lot:";
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.lblCount);
            this.Panel2.Controls.Add(this.Label3);
            this.Panel2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel2.Location = new System.Drawing.Point(3, 476);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(98, 22);
            this.Panel2.TabIndex = 262;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(40, 4);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(13, 13);
            this.lblCount.TabIndex = 2;
            this.lblCount.Text = "0";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(0, 5);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(42, 13);
            this.Label3.TabIndex = 1;
            this.Label3.Text = "Count:";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "RefNo";
            this.columnHeader4.Width = 5;
            // 
            // CmdCut
            // 
            this.CmdCut.Image = ((System.Drawing.Image)(resources.GetObject("CmdCut.Image")));
            this.CmdCut.Location = new System.Drawing.Point(46, 54);
            this.CmdCut.Name = "CmdCut";
            this.CmdCut.Size = new System.Drawing.Size(36, 25);
            this.CmdCut.TabIndex = 10;
            this.CmdCut.UseVisualStyleBackColor = true;
            this.CmdCut.Click += new System.EventHandler(this.CmdCut_Click);
            // 
            // CmdOpen
            // 
            this.CmdOpen.Image = ((System.Drawing.Image)(resources.GetObject("CmdOpen.Image")));
            this.CmdOpen.Location = new System.Drawing.Point(6, 54);
            this.CmdOpen.Name = "CmdOpen";
            this.CmdOpen.Size = new System.Drawing.Size(36, 25);
            this.CmdOpen.TabIndex = 9;
            this.CmdOpen.UseVisualStyleBackColor = true;
            this.CmdOpen.Click += new System.EventHandler(this.CmdOpen_Click);
            // 
            // FrmContractSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(458, 501);
            this.Controls.Add(this.TableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmContractSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contract Setup";
            this.Load += new System.EventHandler(this.FrmBank_Load);
            this.TableLayoutPanel1.ResumeLayout(false);
            this.PanCommands.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.Button CmdClose;
        internal System.Windows.Forms.ListView lvList;
        internal System.Windows.Forms.ColumnHeader ColName;
        internal System.Windows.Forms.Panel PanCommands;
        internal System.Windows.Forms.Button CmdInsert;
        internal System.Windows.Forms.Button CmdCut;
        internal System.Windows.Forms.Button CmdOpen;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Label lblCount;
        internal System.Windows.Forms.Label Label3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numYear;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cCateory;
        private System.Windows.Forms.TextBox tTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tLot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}