namespace UILayer
{
    partial class frmReports
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
            this.pnlDailyReports = new System.Windows.Forms.Panel();
            this.lblDailyReport = new System.Windows.Forms.Label();
            this.pnlBenchmarkingReports = new System.Windows.Forms.Panel();
            this.lblBenchmarkingReports = new System.Windows.Forms.Label();
            this.pnlMealContentReports = new System.Windows.Forms.Panel();
            this.lblMealContent = new System.Windows.Forms.Label();
            this.pnlDailyReports.SuspendLayout();
            this.pnlBenchmarkingReports.SuspendLayout();
            this.pnlMealContentReports.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDailyReports
            // 
            this.pnlDailyReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(222)))), ((int)(((byte)(234)))));
            this.pnlDailyReports.Controls.Add(this.lblDailyReport);
            this.pnlDailyReports.Location = new System.Drawing.Point(18, 18);
            this.pnlDailyReports.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDailyReports.Name = "pnlDailyReports";
            this.pnlDailyReports.Size = new System.Drawing.Size(407, 97);
            this.pnlDailyReports.TabIndex = 0;
            this.pnlDailyReports.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDailyReports_Paint);
            // 
            // lblDailyReport
            // 
            this.lblDailyReport.AutoSize = true;
            this.lblDailyReport.Location = new System.Drawing.Point(133, 33);
            this.lblDailyReport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDailyReport.Name = "lblDailyReport";
            this.lblDailyReport.Size = new System.Drawing.Size(117, 25);
            this.lblDailyReport.TabIndex = 0;
            this.lblDailyReport.Text = "Daily Reports";
            this.lblDailyReport.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlBenchmarkingReports
            // 
            this.pnlBenchmarkingReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(208)))), ((int)(((byte)(225)))));
            this.pnlBenchmarkingReports.Controls.Add(this.lblBenchmarkingReports);
            this.pnlBenchmarkingReports.Location = new System.Drawing.Point(18, 123);
            this.pnlBenchmarkingReports.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBenchmarkingReports.Name = "pnlBenchmarkingReports";
            this.pnlBenchmarkingReports.Size = new System.Drawing.Size(407, 97);
            this.pnlBenchmarkingReports.TabIndex = 0;
            // 
            // lblBenchmarkingReports
            // 
            this.lblBenchmarkingReports.AutoSize = true;
            this.lblBenchmarkingReports.Location = new System.Drawing.Point(88, 33);
            this.lblBenchmarkingReports.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBenchmarkingReports.Name = "lblBenchmarkingReports";
            this.lblBenchmarkingReports.Size = new System.Drawing.Size(190, 25);
            this.lblBenchmarkingReports.TabIndex = 0;
            this.lblBenchmarkingReports.Text = "Benchmarking Reports";
            this.lblBenchmarkingReports.Click += new System.EventHandler(this.label2_Click);
            // 
            // pnlMealContentReports
            // 
            this.pnlMealContentReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.pnlMealContentReports.Controls.Add(this.lblMealContent);
            this.pnlMealContentReports.Location = new System.Drawing.Point(18, 228);
            this.pnlMealContentReports.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMealContentReports.Name = "pnlMealContentReports";
            this.pnlMealContentReports.Size = new System.Drawing.Size(407, 97);
            this.pnlMealContentReports.TabIndex = 0;
            // 
            // lblMealContent
            // 
            this.lblMealContent.AutoSize = true;
            this.lblMealContent.Location = new System.Drawing.Point(91, 33);
            this.lblMealContent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMealContent.Name = "lblMealContent";
            this.lblMealContent.Size = new System.Drawing.Size(184, 25);
            this.lblMealContent.TabIndex = 0;
            this.lblMealContent.Text = "Meal Content Reports";
            this.lblMealContent.Click += new System.EventHandler(this.label3_Click);
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(440, 343);
            this.Controls.Add(this.pnlMealContentReports);
            this.Controls.Add(this.pnlBenchmarkingReports);
            this.Controls.Add(this.pnlDailyReports);
            this.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReports";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmReports_FormClosing);
            this.pnlDailyReports.ResumeLayout(false);
            this.pnlDailyReports.PerformLayout();
            this.pnlBenchmarkingReports.ResumeLayout(false);
            this.pnlBenchmarkingReports.PerformLayout();
            this.pnlMealContentReports.ResumeLayout(false);
            this.pnlMealContentReports.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlDailyReports;
        private Label lblDailyReport;
        private Panel pnlBenchmarkingReports;
        private Label lblBenchmarkingReports;
        private Panel pnlMealContentReports;
        private Label lblMealContent;
    }
}