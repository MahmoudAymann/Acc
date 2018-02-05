namespace Limra
{
    partial class SubAccountReport
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_AccNumber_AnalyticalSubaccountReport = new System.Windows.Forms.TextBox();
            this.textBox_AccName_AnalyticalSubaccountReport = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Print = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_SubAccont = new System.Windows.Forms.RadioButton();
            this.radioButton_MainAccount = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = " رقم:";
            // 
            // textBox_AccNumber_AnalyticalSubaccountReport
            // 
            this.textBox_AccNumber_AnalyticalSubaccountReport.Location = new System.Drawing.Point(6, 19);
            this.textBox_AccNumber_AnalyticalSubaccountReport.Name = "textBox_AccNumber_AnalyticalSubaccountReport";
            this.textBox_AccNumber_AnalyticalSubaccountReport.Size = new System.Drawing.Size(188, 20);
            this.textBox_AccNumber_AnalyticalSubaccountReport.TabIndex = 1;
            this.textBox_AccNumber_AnalyticalSubaccountReport.TextChanged += new System.EventHandler(this.textBox_AccNumber_AnalyticalSubaccountReport_TextChanged);
            // 
            // textBox_AccName_AnalyticalSubaccountReport
            // 
            this.textBox_AccName_AnalyticalSubaccountReport.Location = new System.Drawing.Point(6, 45);
            this.textBox_AccName_AnalyticalSubaccountReport.Name = "textBox_AccName_AnalyticalSubaccountReport";
            this.textBox_AccName_AnalyticalSubaccountReport.Size = new System.Drawing.Size(188, 20);
            this.textBox_AccName_AnalyticalSubaccountReport.TabIndex = 5;
            this.textBox_AccName_AnalyticalSubaccountReport.TextChanged += new System.EventHandler(this.textBox_AccName_AnalyticalSubaccountReport_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "اسم الحساب:";
            // 
            // button_Print
            // 
            this.button_Print.Location = new System.Drawing.Point(10, 130);
            this.button_Print.Name = "button_Print";
            this.button_Print.Size = new System.Drawing.Size(281, 36);
            this.button_Print.TabIndex = 11;
            this.button_Print.Text = "طباعة";
            this.button_Print.UseVisualStyleBackColor = true;
            this.button_Print.Click += new System.EventHandler(this.button_Print_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(299, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(267, 174);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_AccName_AnalyticalSubaccountReport);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_AccNumber_AnalyticalSubaccountReport);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(10, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 76);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // radioButton_SubAccont
            // 
            this.radioButton_SubAccont.AutoSize = true;
            this.radioButton_SubAccont.Location = new System.Drawing.Point(21, 12);
            this.radioButton_SubAccont.Name = "radioButton_SubAccont";
            this.radioButton_SubAccont.Size = new System.Drawing.Size(87, 17);
            this.radioButton_SubAccont.TabIndex = 14;
            this.radioButton_SubAccont.TabStop = true;
            this.radioButton_SubAccont.Text = "حساب فرعى";
            this.radioButton_SubAccont.UseVisualStyleBackColor = true;
            // 
            // radioButton_MainAccount
            // 
            this.radioButton_MainAccount.AutoSize = true;
            this.radioButton_MainAccount.Location = new System.Drawing.Point(137, 12);
            this.radioButton_MainAccount.Name = "radioButton_MainAccount";
            this.radioButton_MainAccount.Size = new System.Drawing.Size(93, 17);
            this.radioButton_MainAccount.TabIndex = 15;
            this.radioButton_MainAccount.TabStop = true;
            this.radioButton_MainAccount.Text = "حساب رئيسى";
            this.radioButton_MainAccount.UseVisualStyleBackColor = true;
            // 
            // SubAccountReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(566, 174);
            this.Controls.Add(this.radioButton_MainAccount);
            this.Controls.Add(this.radioButton_SubAccont);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_Print);
            this.Name = "SubAccountReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "كشف حساب تحليلي";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_AccName_AnalyticalSubaccountReport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Print;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox textBox_AccNumber_AnalyticalSubaccountReport;
        private System.Windows.Forms.RadioButton radioButton_SubAccont;
        private System.Windows.Forms.RadioButton radioButton_MainAccount;
    }
}