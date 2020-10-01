namespace RewardAssured
{
    partial class FrmProgramParameterSub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProgramParameterSub));
            this.dGrid = new System.Windows.Forms.DataGridView();
            this.PanFooter = new System.Windows.Forms.Panel();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.cmdOk = new System.Windows.Forms.Button();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Percent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGrid)).BeginInit();
            this.PanFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGrid
            // 
            this.dGrid.AllowUserToAddRows = false;
            this.dGrid.AllowUserToDeleteRows = false;
            this.dGrid.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Level,
            this.Percent});
            this.dGrid.Location = new System.Drawing.Point(1, 1);
            this.dGrid.Name = "dGrid";
            this.dGrid.Size = new System.Drawing.Size(196, 277);
            this.dGrid.TabIndex = 295;
            // 
            // PanFooter
            // 
            this.PanFooter.BackColor = System.Drawing.Color.AntiqueWhite;
            this.PanFooter.Controls.Add(this.CmdCancel);
            this.PanFooter.Controls.Add(this.cmdOk);
            this.PanFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanFooter.Location = new System.Drawing.Point(0, 279);
            this.PanFooter.Name = "PanFooter";
            this.PanFooter.Size = new System.Drawing.Size(201, 43);
            this.PanFooter.TabIndex = 296;
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
            dataGridViewCellStyle2.Format = "N1";
            dataGridViewCellStyle2.NullValue = null;
            this.Percent.DefaultCellStyle = dataGridViewCellStyle2;
            this.Percent.HeaderText = "%";
            this.Percent.Name = "Percent";
            this.Percent.Width = 50;
            // 
            // FrmProgramParameterSub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(201, 322);
            this.Controls.Add(this.PanFooter);
            this.Controls.Add(this.dGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmProgramParameterSub";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Level % Distribution";
            this.Load += new System.EventHandler(this.FrmProgramParameterSub_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGrid)).EndInit();
            this.PanFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGrid;
        internal System.Windows.Forms.Panel PanFooter;
        internal System.Windows.Forms.Button CmdCancel;
        internal System.Windows.Forms.Button cmdOk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
        private System.Windows.Forms.DataGridViewTextBoxColumn Percent;
    }
}