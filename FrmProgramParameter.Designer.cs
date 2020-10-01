namespace RewardAssured
{
    partial class FrmProgramParameter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProgramParameter));
            this.CmdCancel = new System.Windows.Forms.Button();
            this.cmdOk = new System.Windows.Forms.Button();
            this.PanFooter = new System.Windows.Forms.Panel();
            this.Label3 = new System.Windows.Forms.Label();
            this.FolderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.numPyramidLevel = new System.Windows.Forms.NumericUpDown();
            this.dGrid = new System.Windows.Forms.DataGridView();
            this.numPercent = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numdrawable = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Percent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmd = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PanFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPyramidLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numdrawable)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdCancel
            // 
            this.CmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CmdCancel.Location = new System.Drawing.Point(101, 4);
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.Size = new System.Drawing.Size(80, 36);
            this.CmdCancel.TabIndex = 19;
            this.CmdCancel.Text = "&Close";
            this.CmdCancel.UseVisualStyleBackColor = true;
            // 
            // cmdOk
            // 
            this.cmdOk.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cmdOk.Location = new System.Drawing.Point(21, 4);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(80, 36);
            this.cmdOk.TabIndex = 20;
            this.cmdOk.Text = "&Ok";
            this.cmdOk.UseVisualStyleBackColor = true;
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // PanFooter
            // 
            this.PanFooter.BackColor = System.Drawing.Color.AntiqueWhite;
            this.PanFooter.Controls.Add(this.CmdCancel);
            this.PanFooter.Controls.Add(this.cmdOk);
            this.PanFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanFooter.Location = new System.Drawing.Point(0, 349);
            this.PanFooter.Name = "PanFooter";
            this.PanFooter.Size = new System.Drawing.Size(375, 43);
            this.PanFooter.TabIndex = 292;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(6, 8);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(84, 15);
            this.Label3.TabIndex = 274;
            this.Label3.Text = "Pyramid Level:";
            // 
            // numPyramidLevel
            // 
            this.numPyramidLevel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPyramidLevel.Location = new System.Drawing.Point(177, 4);
            this.numPyramidLevel.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numPyramidLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPyramidLevel.Name = "numPyramidLevel";
            this.numPyramidLevel.Size = new System.Drawing.Size(49, 23);
            this.numPyramidLevel.TabIndex = 293;
            this.numPyramidLevel.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numPyramidLevel.ValueChanged += new System.EventHandler(this.numPyramidLevel_ValueChanged);
            // 
            // dGrid
            // 
            this.dGrid.AllowUserToAddRows = false;
            this.dGrid.AllowUserToDeleteRows = false;
            this.dGrid.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Level,
            this.Percent,
            this.cmd});
            this.dGrid.Location = new System.Drawing.Point(9, 57);
            this.dGrid.Name = "dGrid";
            this.dGrid.Size = new System.Drawing.Size(359, 260);
            this.dGrid.TabIndex = 294;
            this.dGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGrid_CellClick);
            this.dGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGrid_CellContentClick);
            // 
            // numPercent
            // 
            this.numPercent.DecimalPlaces = 1;
            this.numPercent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numPercent.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numPercent.Location = new System.Drawing.Point(177, 30);
            this.numPercent.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numPercent.Name = "numPercent";
            this.numPercent.Size = new System.Drawing.Size(49, 23);
            this.numPercent.TabIndex = 296;
            this.numPercent.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numPercent.ValueChanged += new System.EventHandler(this.numPercent_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 15);
            this.label1.TabIndex = 295;
            this.label1.Text = "Total Distributory Percentage:";
            // 
            // numdrawable
            // 
            this.numdrawable.DecimalPlaces = 1;
            this.numdrawable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numdrawable.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numdrawable.Location = new System.Drawing.Point(171, 322);
            this.numdrawable.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numdrawable.Name = "numdrawable";
            this.numdrawable.Size = new System.Drawing.Size(49, 23);
            this.numdrawable.TabIndex = 298;
            this.numdrawable.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 15);
            this.label2.TabIndex = 297;
            this.label2.Text = "Max. drawable from Reward:";
            // 
            // Level
            // 
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.Level.DefaultCellStyle = dataGridViewCellStyle1;
            this.Level.HeaderText = "Level";
            this.Level.Name = "Level";
            this.Level.ReadOnly = true;
            this.Level.Width = 80;
            // 
            // Percent
            // 
            dataGridViewCellStyle2.NullValue = null;
            this.Percent.DefaultCellStyle = dataGridViewCellStyle2;
            this.Percent.HeaderText = "% distribution";
            this.Percent.Name = "Percent";
            this.Percent.ReadOnly = true;
            this.Percent.Width = 200;
            // 
            // cmd
            // 
            this.cmd.HeaderText = "";
            this.cmd.Name = "cmd";
            this.cmd.Text = "...";
            this.cmd.Width = 30;
            // 
            // FrmProgramParameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(375, 392);
            this.Controls.Add(this.numdrawable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numPercent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dGrid);
            this.Controls.Add(this.numPyramidLevel);
            this.Controls.Add(this.PanFooter);
            this.Controls.Add(this.Label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmProgramParameter";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Program Parameter";
            this.Load += new System.EventHandler(this.FrmProgramParameter_Load);
            this.PanFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numPyramidLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numdrawable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button CmdCancel;
        internal System.Windows.Forms.Button cmdOk;
        internal System.Windows.Forms.Panel PanFooter;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog1;
        private System.Windows.Forms.NumericUpDown numPyramidLevel;
        private System.Windows.Forms.DataGridView dGrid;
        private System.Windows.Forms.NumericUpDown numPercent;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numdrawable;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
        private System.Windows.Forms.DataGridViewTextBoxColumn Percent;
        private System.Windows.Forms.DataGridViewButtonColumn cmd;
    }
}