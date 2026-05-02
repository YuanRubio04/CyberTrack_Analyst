namespace CyberTrack_Analyst
{
    partial class MenuButton_Analyst
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuButton_Analyst));
            this.grpMenuButton_Analyst = new System.Windows.Forms.GroupBox();
            this.grbUserLogo_Analyst = new System.Windows.Forms.GroupBox();
            this.picUserPhoto_Analyst = new System.Windows.Forms.PictureBox();
            this.lblUserRole_Analyst = new System.Windows.Forms.Label();
            this.lblUserName_Analyst = new System.Windows.Forms.Label();
            this.dgvMenuButtonLine1_Analyst = new System.Windows.Forms.Label();
            this.dgvMenuButtonLOGOUT_Analyst = new System.Windows.Forms.Button();
            this.grpMenuButton_Analyst.SuspendLayout();
            this.grbUserLogo_Analyst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserPhoto_Analyst)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMenuButton_Analyst
            // 
            this.grpMenuButton_Analyst.Controls.Add(this.grbUserLogo_Analyst);
            this.grpMenuButton_Analyst.Controls.Add(this.dgvMenuButtonLine1_Analyst);
            this.grpMenuButton_Analyst.Controls.Add(this.dgvMenuButtonLOGOUT_Analyst);
            this.grpMenuButton_Analyst.Location = new System.Drawing.Point(12, 12);
            this.grpMenuButton_Analyst.Name = "grpMenuButton_Analyst";
            this.grpMenuButton_Analyst.Size = new System.Drawing.Size(610, 587);
            this.grpMenuButton_Analyst.TabIndex = 2;
            this.grpMenuButton_Analyst.TabStop = false;
            // 
            // grbUserLogo_Analyst
            // 
            this.grbUserLogo_Analyst.Controls.Add(this.picUserPhoto_Analyst);
            this.grbUserLogo_Analyst.Controls.Add(this.lblUserRole_Analyst);
            this.grbUserLogo_Analyst.Controls.Add(this.lblUserName_Analyst);
            this.grbUserLogo_Analyst.Location = new System.Drawing.Point(211, 192);
            this.grbUserLogo_Analyst.Name = "grbUserLogo_Analyst";
            this.grbUserLogo_Analyst.Size = new System.Drawing.Size(183, 74);
            this.grbUserLogo_Analyst.TabIndex = 88;
            this.grbUserLogo_Analyst.TabStop = false;
            // 
            // picUserPhoto_Analyst
            // 
            this.picUserPhoto_Analyst.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picUserPhoto_Analyst.BackgroundImage")));
            this.picUserPhoto_Analyst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picUserPhoto_Analyst.ErrorImage = null;
            this.picUserPhoto_Analyst.InitialImage = null;
            this.picUserPhoto_Analyst.Location = new System.Drawing.Point(11, 19);
            this.picUserPhoto_Analyst.Name = "picUserPhoto_Analyst";
            this.picUserPhoto_Analyst.Size = new System.Drawing.Size(44, 42);
            this.picUserPhoto_Analyst.TabIndex = 5;
            this.picUserPhoto_Analyst.TabStop = false;
            // 
            // lblUserRole_Analyst
            // 
            this.lblUserRole_Analyst.AutoSize = true;
            this.lblUserRole_Analyst.Location = new System.Drawing.Point(71, 47);
            this.lblUserRole_Analyst.Name = "lblUserRole_Analyst";
            this.lblUserRole_Analyst.Size = new System.Drawing.Size(42, 13);
            this.lblUserRole_Analyst.TabIndex = 5;
            this.lblUserRole_Analyst.Text = "ADMIN";
            // 
            // lblUserName_Analyst
            // 
            this.lblUserName_Analyst.AutoSize = true;
            this.lblUserName_Analyst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName_Analyst.Location = new System.Drawing.Point(71, 19);
            this.lblUserName_Analyst.Name = "lblUserName_Analyst";
            this.lblUserName_Analyst.Size = new System.Drawing.Size(99, 16);
            this.lblUserName_Analyst.TabIndex = 5;
            this.lblUserName_Analyst.Text = "Skibidi Toilet";
            // 
            // dgvMenuButtonLine1_Analyst
            // 
            this.dgvMenuButtonLine1_Analyst.AutoSize = true;
            this.dgvMenuButtonLine1_Analyst.Location = new System.Drawing.Point(95, 269);
            this.dgvMenuButtonLine1_Analyst.Name = "dgvMenuButtonLine1_Analyst";
            this.dgvMenuButtonLine1_Analyst.Size = new System.Drawing.Size(415, 13);
            this.dgvMenuButtonLine1_Analyst.TabIndex = 9;
            this.dgvMenuButtonLine1_Analyst.Text = "____________________________________________________________________";
            // 
            // dgvMenuButtonLOGOUT_Analyst
            // 
            this.dgvMenuButtonLOGOUT_Analyst.BackColor = System.Drawing.Color.Black;
            this.dgvMenuButtonLOGOUT_Analyst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMenuButtonLOGOUT_Analyst.ForeColor = System.Drawing.Color.White;
            this.dgvMenuButtonLOGOUT_Analyst.Location = new System.Drawing.Point(98, 298);
            this.dgvMenuButtonLOGOUT_Analyst.Name = "dgvMenuButtonLOGOUT_Analyst";
            this.dgvMenuButtonLOGOUT_Analyst.Size = new System.Drawing.Size(412, 46);
            this.dgvMenuButtonLOGOUT_Analyst.TabIndex = 8;
            this.dgvMenuButtonLOGOUT_Analyst.Text = "LOG OUT";
            this.dgvMenuButtonLOGOUT_Analyst.UseVisualStyleBackColor = false;
            // 
            // MenuButton_Analyst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 611);
            this.Controls.Add(this.grpMenuButton_Analyst);
            this.Name = "MenuButton_Analyst";
            this.Text = "MenuButton_Analyst";
            this.grpMenuButton_Analyst.ResumeLayout(false);
            this.grpMenuButton_Analyst.PerformLayout();
            this.grbUserLogo_Analyst.ResumeLayout(false);
            this.grbUserLogo_Analyst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserPhoto_Analyst)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMenuButton_Analyst;
        private System.Windows.Forms.GroupBox grbUserLogo_Analyst;
        private System.Windows.Forms.PictureBox picUserPhoto_Analyst;
        private System.Windows.Forms.Label lblUserRole_Analyst;
        private System.Windows.Forms.Label lblUserName_Analyst;
        private System.Windows.Forms.Label dgvMenuButtonLine1_Analyst;
        private System.Windows.Forms.Button dgvMenuButtonLOGOUT_Analyst;
    }
}