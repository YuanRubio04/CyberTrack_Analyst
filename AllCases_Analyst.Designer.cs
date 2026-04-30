namespace CyberTrack_Analyst
{
    partial class AllCases_Analyst
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllCases_Analyst));
            this.CATEGORY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ASSIGNED_TO = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SLA_STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REPORTED_ON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACTION = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label25 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.REPORTER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.CASE_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEVERITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // CATEGORY
            // 
            this.CATEGORY.HeaderText = "CATEGORY";
            this.CATEGORY.Name = "CATEGORY";
            this.CATEGORY.ReadOnly = true;
            this.CATEGORY.Width = 118;
            // 
            // ASSIGNED_TO
            // 
            this.ASSIGNED_TO.HeaderText = "ASSIGNED TO";
            this.ASSIGNED_TO.Name = "ASSIGNED_TO";
            this.ASSIGNED_TO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ASSIGNED_TO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ASSIGNED_TO.Width = 117;
            // 
            // SLA_STATUS
            // 
            this.SLA_STATUS.HeaderText = "SLA STATUS";
            this.SLA_STATUS.Name = "SLA_STATUS";
            this.SLA_STATUS.ReadOnly = true;
            this.SLA_STATUS.Width = 118;
            // 
            // REPORTED_ON
            // 
            this.REPORTED_ON.HeaderText = "REPORTED ON";
            this.REPORTED_ON.Name = "REPORTED_ON";
            this.REPORTED_ON.ReadOnly = true;
            this.REPORTED_ON.Width = 117;
            // 
            // ACTION
            // 
            this.ACTION.HeaderText = "ACTION";
            this.ACTION.Name = "ACTION";
            this.ACTION.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ACTION.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ACTION.Text = "MANAGE";
            this.ACTION.Width = 118;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(70, 56);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(84, 15);
            this.label25.TabIndex = 52;
            this.label25.Text = "N OF N Cases";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(1077, 29);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(162, 42);
            this.button4.TabIndex = 51;
            this.button4.Text = "EXPORT";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label27);
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Controls.Add(this.pictureBox3);
            this.groupBox5.Controls.Add(this.comboBox3);
            this.groupBox5.Controls.Add(this.comboBox2);
            this.groupBox5.Controls.Add(this.comboBox1);
            this.groupBox5.Controls.Add(this.textBox24);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Location = new System.Drawing.Point(20, 86);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1219, 136);
            this.groupBox5.TabIndex = 49;
            this.groupBox5.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(933, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 16);
            this.label13.TabIndex = 58;
            this.label13.Text = "Category";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(624, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 16);
            this.label11.TabIndex = 57;
            this.label11.Text = "Status";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(15, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 16);
            this.label12.TabIndex = 56;
            this.label12.Text = "Search";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(307, 79);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(64, 16);
            this.label27.TabIndex = 55;
            this.label27.Text = "Severity";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(15, 50);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(150, 15);
            this.label26.TabIndex = 54;
            this.label26.Text = "Filter and search incidents";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.ErrorImage = null;
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(18, 22);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 25);
            this.pictureBox3.TabIndex = 53;
            this.pictureBox3.TabStop = false;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(936, 98);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(261, 21);
            this.comboBox3.TabIndex = 27;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "New",
            "Investigating",
            "Contained",
            "Closed"});
            this.comboBox2.Location = new System.Drawing.Point(627, 98);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(261, 21);
            this.comboBox2.TabIndex = 26;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High",
            "Critical"});
            this.comboBox1.Location = new System.Drawing.Point(310, 98);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(261, 21);
            this.comboBox1.TabIndex = 25;
            // 
            // textBox24
            // 
            this.textBox24.Location = new System.Drawing.Point(18, 99);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(247, 20);
            this.textBox24.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(48, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "FILTERS";
            // 
            // REPORTER
            // 
            this.REPORTER.HeaderText = "REPORTER";
            this.REPORTER.Name = "REPORTER";
            this.REPORTER.ReadOnly = true;
            this.REPORTER.Width = 118;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.ErrorImage = null;
            this.pictureBox4.InitialImage = null;
            this.pictureBox4.Location = new System.Drawing.Point(20, 29);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(44, 42);
            this.pictureBox4.TabIndex = 47;
            this.pictureBox4.TabStop = false;
            // 
            // STATUS
            // 
            this.STATUS.HeaderText = "STATUS";
            this.STATUS.Name = "STATUS";
            this.STATUS.ReadOnly = true;
            this.STATUS.Width = 117;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.pictureBox1);
            this.groupBox7.Controls.Add(this.label2);
            this.groupBox7.Controls.Add(this.label1);
            this.groupBox7.Location = new System.Drawing.Point(12, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(754, 74);
            this.groupBox7.TabIndex = 43;
            this.groupBox7.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 42);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Incident Management Systtem";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "CYBERTRACK";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox9);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(772, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 74);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(257, 40);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(47, 20);
            this.textBox9.TabIndex = 25;
            this.textBox9.Text = "NO";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(157, 40);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(47, 20);
            this.textBox8.TabIndex = 24;
            this.textBox8.Text = "YES";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(51, 40);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(47, 20);
            this.textBox7.TabIndex = 23;
            this.textBox7.Text = "YES";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(210, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Delete:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Update:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Create:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Permissions";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(1089, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(183, 74);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(11, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 42);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(71, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "ANALYST";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(71, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Skibidi Toilet";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.pictureBox4);
            this.groupBox3.Location = new System.Drawing.Point(12, 92);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1260, 856);
            this.groupBox3.TabIndex = 44;
            this.groupBox3.TabStop = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CASE_ID,
            this.Title,
            this.SEVERITY,
            this.STATUS,
            this.CATEGORY,
            this.REPORTER,
            this.ASSIGNED_TO,
            this.SLA_STATUS,
            this.REPORTED_ON,
            this.ACTION});
            this.dataGridView2.Location = new System.Drawing.Point(20, 239);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1219, 598);
            this.dataGridView2.TabIndex = 70;
            // 
            // CASE_ID
            // 
            this.CASE_ID.HeaderText = "CASE ID";
            this.CASE_ID.Name = "CASE_ID";
            this.CASE_ID.ReadOnly = true;
            this.CASE_ID.Width = 118;
            // 
            // Title
            // 
            this.Title.HeaderText = "TITLE";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 117;
            // 
            // SEVERITY
            // 
            this.SEVERITY.HeaderText = "SEVERITY";
            this.SEVERITY.Name = "SEVERITY";
            this.SEVERITY.ReadOnly = true;
            this.SEVERITY.Width = 118;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(70, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(253, 18);
            this.label9.TabIndex = 48;
            this.label9.Text = "CASES MANAGEMENT - ADMIN";
            // 
            // AllCases_Analyst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 961);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "AllCases_Analyst";
            this.Text = "AllCases_Analyst";
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORY;
        private System.Windows.Forms.DataGridViewComboBoxColumn ASSIGNED_TO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLA_STATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn REPORTED_ON;
        private System.Windows.Forms.DataGridViewButtonColumn ACTION;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn REPORTER;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CASE_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEVERITY;
        private System.Windows.Forms.Label label9;
    }
}