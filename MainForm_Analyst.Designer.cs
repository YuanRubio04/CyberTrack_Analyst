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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.submitReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allCasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auditLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.submitReportToolStripMenuItem,
            this.allCasesToolStripMenuItem,
            this.auditLogsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1584, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            // 
            // submitReportToolStripMenuItem
            // 
            this.submitReportToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitReportToolStripMenuItem.Name = "submitReportToolStripMenuItem";
            this.submitReportToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.submitReportToolStripMenuItem.Text = "Submit Report";
            // 
            // allCasesToolStripMenuItem
            // 
            this.allCasesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allCasesToolStripMenuItem.Name = "allCasesToolStripMenuItem";
            this.allCasesToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.allCasesToolStripMenuItem.Text = "All Cases";
            // 
            // auditLogsToolStripMenuItem
            // 
            this.auditLogsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auditLogsToolStripMenuItem.Name = "auditLogsToolStripMenuItem";
            this.auditLogsToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.auditLogsToolStripMenuItem.Text = "Audit Logs";
            // 
            // MainForm_Analyst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 961);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm_Analyst";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm_Analyst";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem submitReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allCasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auditLogsToolStripMenuItem;
    }
}

