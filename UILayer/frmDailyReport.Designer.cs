namespace UILayer
{
    partial class frmDailyReport
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
            this.dgvDailyReport = new System.Windows.Forms.DataGridView();
            this.dtpDailyReport = new System.Windows.Forms.DateTimePicker();
            this.btnReport = new System.Windows.Forms.Button();
            this.grpDailyReport = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailyReport)).BeginInit();
            this.grpDailyReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDailyReport
            // 
            this.dgvDailyReport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(175)))), ((int)(((byte)(192)))));
            this.dgvDailyReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDailyReport.Location = new System.Drawing.Point(6, 120);
            this.dgvDailyReport.Name = "dgvDailyReport";
            this.dgvDailyReport.RowHeadersWidth = 51;
            this.dgvDailyReport.RowTemplate.Height = 29;
            this.dgvDailyReport.Size = new System.Drawing.Size(247, 251);
            this.dgvDailyReport.TabIndex = 0;
            // 
            // dtpDailyReport
            // 
            this.dtpDailyReport.Location = new System.Drawing.Point(6, 26);
            this.dtpDailyReport.Name = "dtpDailyReport";
            this.dtpDailyReport.Size = new System.Drawing.Size(247, 27);
            this.dtpDailyReport.TabIndex = 1;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.btnReport.Location = new System.Drawing.Point(6, 72);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(247, 29);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "DAILY REPORT";
            this.btnReport.UseVisualStyleBackColor = false;
            // 
            // grpDailyReport
            // 
            this.grpDailyReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.grpDailyReport.Controls.Add(this.btnReport);
            this.grpDailyReport.Controls.Add(this.dtpDailyReport);
            this.grpDailyReport.Controls.Add(this.dgvDailyReport);
            this.grpDailyReport.Location = new System.Drawing.Point(3, 6);
            this.grpDailyReport.Name = "grpDailyReport";
            this.grpDailyReport.Size = new System.Drawing.Size(259, 378);
            this.grpDailyReport.TabIndex = 3;
            this.grpDailyReport.TabStop = false;
            this.grpDailyReport.Text = "DAILY REPORT";
            // 
            // frmDailyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(175)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(266, 390);
            this.Controls.Add(this.grpDailyReport);
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "frmDailyReport";
            this.Text = "frmDailyReport";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailyReport)).EndInit();
            this.grpDailyReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvDailyReport;
        private DateTimePicker dtpDailyReport;
        private Button btnReport;
        private GroupBox grpDailyReport;
    }
}