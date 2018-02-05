namespace Limra
{
    partial class ReportsGeneralDaily
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
            this.comboBoxDocType = new System.Windows.Forms.ComboBox();
            this.comboBoxReportType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFromAcc = new System.Windows.Forms.TextBox();
            this.labelFromAcc = new System.Windows.Forms.Label();
            this.textBoxToAcc = new System.Windows.Forms.TextBox();
            this.labelToAcc = new System.Windows.Forms.Label();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "نوع المستند:";
            // 
            // comboBoxDocType
            // 
            this.comboBoxDocType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDocType.FormattingEnabled = true;
            this.comboBoxDocType.Items.AddRange(new object[] {
            "كلى",
            "قيود يومية",
            "سندات صرف",
            "سندات قبض",
            "فواتير مبيعات",
            "مردودات مبيعات",
            "اوامر توريد مخزنية",
            "اوامر صرف مخزنية"});
            this.comboBoxDocType.Location = new System.Drawing.Point(95, 31);
            this.comboBoxDocType.Name = "comboBoxDocType";
            this.comboBoxDocType.Size = new System.Drawing.Size(181, 21);
            this.comboBoxDocType.TabIndex = 1;
            // 
            // comboBoxReportType
            // 
            this.comboBoxReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReportType.FormattingEnabled = true;
            this.comboBoxReportType.Items.AddRange(new object[] {
            "حسب ارقام الوثائق",
            "حسب ارقام الحسابات - تحليلى",
            "حسب ارقام الحسابات - اجمالى"});
            this.comboBoxReportType.Location = new System.Drawing.Point(95, 67);
            this.comboBoxReportType.Name = "comboBoxReportType";
            this.comboBoxReportType.Size = new System.Drawing.Size(181, 21);
            this.comboBoxReportType.TabIndex = 3;
            this.comboBoxReportType.SelectedIndexChanged += new System.EventHandler(this.comboBoxReportType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "نوع التقرير:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "من تاريخ:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(254, 108);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "الى تاريخ:";
            // 
            // textBoxFromAcc
            // 
            this.textBoxFromAcc.Location = new System.Drawing.Point(77, 153);
            this.textBoxFromAcc.Name = "textBoxFromAcc";
            this.textBoxFromAcc.Size = new System.Drawing.Size(100, 20);
            this.textBoxFromAcc.TabIndex = 9;
            this.textBoxFromAcc.Visible = false;
            // 
            // labelFromAcc
            // 
            this.labelFromAcc.AutoSize = true;
            this.labelFromAcc.Location = new System.Drawing.Point(12, 156);
            this.labelFromAcc.Name = "labelFromAcc";
            this.labelFromAcc.Size = new System.Drawing.Size(59, 13);
            this.labelFromAcc.TabIndex = 8;
            this.labelFromAcc.Text = "من حساب:";
            this.labelFromAcc.Visible = false;
            // 
            // textBoxToAcc
            // 
            this.textBoxToAcc.Location = new System.Drawing.Point(254, 149);
            this.textBoxToAcc.Name = "textBoxToAcc";
            this.textBoxToAcc.Size = new System.Drawing.Size(100, 20);
            this.textBoxToAcc.TabIndex = 11;
            this.textBoxToAcc.Visible = false;
            // 
            // labelToAcc
            // 
            this.labelToAcc.AutoSize = true;
            this.labelToAcc.Location = new System.Drawing.Point(189, 152);
            this.labelToAcc.Name = "labelToAcc";
            this.labelToAcc.Size = new System.Drawing.Size(62, 13);
            this.labelToAcc.TabIndex = 10;
            this.labelToAcc.Text = "الى حساب:";
            this.labelToAcc.Visible = false;
            // 
            // buttonPrint
            // 
            this.buttonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPrint.Location = new System.Drawing.Point(47, 213);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(276, 34);
            this.buttonPrint.TabIndex = 12;
            this.buttonPrint.Text = "طباعة";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // ReportsGeneralDaily
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(375, 259);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.textBoxToAcc);
            this.Controls.Add(this.labelToAcc);
            this.Controls.Add(this.textBoxFromAcc);
            this.Controls.Add(this.labelFromAcc);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxReportType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxDocType);
            this.Controls.Add(this.label1);
            this.Name = "ReportsGeneralDaily";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقارير اليومية العامة";
            this.Load += new System.EventHandler(this.ReportsGeneralDaily_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxDocType;
        private System.Windows.Forms.ComboBox comboBoxReportType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFromAcc;
        private System.Windows.Forms.Label labelFromAcc;
        private System.Windows.Forms.TextBox textBoxToAcc;
        private System.Windows.Forms.Label labelToAcc;
        private System.Windows.Forms.Button buttonPrint;
    }
}