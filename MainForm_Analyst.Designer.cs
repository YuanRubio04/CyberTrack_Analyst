namespace CyberTrack_Analyst
{
    partial class MainForm_Analyst
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
            this.menuStrip1_Analyst = new System.Windows.Forms.MenuStrip();
            this.msMainFormDashboard_Analyst = new System.Windows.Forms.ToolStripMenuItem();
            this.msMainFormSubmitReport_Analyst = new System.Windows.Forms.ToolStripMenuItem();
            this.msMainFormAllCases_Analyst = new System.Windows.Forms.ToolStripMenuItem();
            this.msMainFormAuditLogs_Analyst = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1_Analyst.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1_Analyst
            // 
            this.menuStrip1_Analyst.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msMainFormDashboard_Analyst,
            this.msMainFormSubmitReport_Analyst,
            this.msMainFormAllCases_Analyst,
            this.msMainFormAuditLogs_Analyst});
            this.menuStrip1_Analyst.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1_Analyst.Name = "menuStrip1_Analyst";
            this.menuStrip1_Analyst.Size = new System.Drawing.Size(1284, 28);
            this.menuStrip1_Analyst.TabIndex = 1;
            this.menuStrip1_Analyst.Text = "menuStrip1";
            // 
            // msMainFormDashboard_Analyst
            // 
            this.msMainFormDashboard_Analyst.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMainFormDashboard_Analyst.Name = "msMainFormDashboard_Analyst";
            this.msMainFormDashboard_Analyst.Size = new System.Drawing.Size(97, 24);
            this.msMainFormDashboard_Analyst.Text = "Dashboard";
            // 
            // msMainFormSubmitReport_Analyst
            // 
            this.msMainFormSubmitReport_Analyst.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMainFormSubmitReport_Analyst.Name = "msMainFormSubmitReport_Analyst";
            this.msMainFormSubmitReport_Analyst.Size = new System.Drawing.Size(123, 24);
            this.msMainFormSubmitReport_Analyst.Text = "Submit Report";
            // 
            // msMainFormAllCases_Analyst
            // 
            this.msMainFormAllCases_Analyst.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMainFormAllCases_Analyst.Name = "msMainFormAllCases_Analyst";
            this.msMainFormAllCases_Analyst.Size = new System.Drawing.Size(83, 24);
            this.msMainFormAllCases_Analyst.Text = "All Cases";
            // 
            // msMainFormAuditLogs_Analyst
            // 
            this.msMainFormAuditLogs_Analyst.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMainFormAuditLogs_Analyst.Name = "msMainFormAuditLogs_Analyst";
            this.msMainFormAuditLogs_Analyst.Size = new System.Drawing.Size(97, 24);
            this.msMainFormAuditLogs_Analyst.Text = "Audit Logs";
            // 
            // MainForm_Analyst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 961);
            this.Controls.Add(this.menuStrip1_Analyst);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1_Analyst;
            this.Name = "MainForm_Analyst";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm_Analyst";
            this.menuStrip1_Analyst.ResumeLayout(false);
            this.menuStrip1_Analyst.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1_Analyst;
        private System.Windows.Forms.ToolStripMenuItem msMainFormDashboard_Analyst;
        private System.Windows.Forms.ToolStripMenuItem msMainFormSubmitReport_Analyst;
        private System.Windows.Forms.ToolStripMenuItem msMainFormAllCases_Analyst;
        private System.Windows.Forms.ToolStripMenuItem msMainFormAuditLogs_Analyst;
    }
}

