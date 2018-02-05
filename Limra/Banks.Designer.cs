namespace Limra
{
    partial class Banks
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
            this.textBoxAccoNum_Bank = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxBankNum_Bank = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSerial_Bank = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAccoName_Bank = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonEditApprove = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonLoad_Bank = new System.Windows.Forms.Button();
            this.buttonDelete_Bank = new System.Windows.Forms.Button();
            this.buttonAdd_Bank = new System.Windows.Forms.Button();
            this.buttonNew_Bank = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxAccoNum_Bank
            // 
            this.textBoxAccoNum_Bank.Location = new System.Drawing.Point(258, 52);
            this.textBoxAccoNum_Bank.Name = "textBoxAccoNum_Bank";
            this.textBoxAccoNum_Bank.Size = new System.Drawing.Size(213, 23);
            this.textBoxAccoNum_Bank.TabIndex = 20;
            this.textBoxAccoNum_Bank.TextChanged += new System.EventHandler(this.textBoxAccoNum_Bank_TextChanged);
            this.textBoxAccoNum_Bank.Enter += new System.EventHandler(this.textBoxAccoNum_Bank_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(477, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "رقم حساب البنك:";
            // 
            // textBoxBankNum_Bank
            // 
            this.textBoxBankNum_Bank.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxBankNum_Bank.Location = new System.Drawing.Point(258, 26);
            this.textBoxBankNum_Bank.Name = "textBoxBankNum_Bank";
            this.textBoxBankNum_Bank.Size = new System.Drawing.Size(213, 23);
            this.textBoxBankNum_Bank.TabIndex = 18;
            this.textBoxBankNum_Bank.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(477, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "رقم البنك:";
            // 
            // textBoxSerial_Bank
            // 
            this.textBoxSerial_Bank.Location = new System.Drawing.Point(258, 104);
            this.textBoxSerial_Bank.Name = "textBoxSerial_Bank";
            this.textBoxSerial_Bank.Size = new System.Drawing.Size(213, 23);
            this.textBoxSerial_Bank.TabIndex = 16;
            this.textBoxSerial_Bank.Enter += new System.EventHandler(this.textBoxSerial_Bank_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(477, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "رقم التسلسل:";
            // 
            // textBoxAccoName_Bank
            // 
            this.textBoxAccoName_Bank.Location = new System.Drawing.Point(258, 78);
            this.textBoxAccoName_Bank.Name = "textBoxAccoName_Bank";
            this.textBoxAccoName_Bank.Size = new System.Drawing.Size(213, 23);
            this.textBoxAccoName_Bank.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(477, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "اسم حساب البنك:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Location = new System.Drawing.Point(140, 142);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(594, 381);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "بيانات البنوك";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(588, 362);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Controls.Add(this.textBoxAccoNum_Bank);
            this.groupBox3.Controls.Add(this.textBoxBankNum_Bank);
            this.groupBox3.Controls.Add(this.textBoxAccoName_Bank);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBoxSerial_Bank);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(140, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(594, 136);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "بيانات اساسية";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView2.Location = new System.Drawing.Point(3, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(249, 114);
            this.dataGridView2.TabIndex = 21;
            this.dataGridView2.Visible = false;
            this.dataGridView2.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_CellMouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.buttonLoad_Bank);
            this.groupBox1.Controls.Add(this.buttonDelete_Bank);
            this.groupBox1.Controls.Add(this.buttonAdd_Bank);
            this.groupBox1.Controls.Add(this.buttonNew_Bank);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 523);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonEditApprove);
            this.groupBox5.Controls.Add(this.buttonEdit);
            this.groupBox5.Location = new System.Drawing.Point(6, 239);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(128, 114);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "التعديل";
            // 
            // buttonEditApprove
            // 
            this.buttonEditApprove.BackColor = System.Drawing.Color.Green;
            this.buttonEditApprove.Enabled = false;
            this.buttonEditApprove.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditApprove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEditApprove.Location = new System.Drawing.Point(6, 79);
            this.buttonEditApprove.Name = "buttonEditApprove";
            this.buttonEditApprove.Size = new System.Drawing.Size(116, 27);
            this.buttonEditApprove.TabIndex = 20;
            this.buttonEditApprove.Text = "تنفيذ";
            this.buttonEditApprove.UseVisualStyleBackColor = false;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Image = global::Limra.Properties.Resources.if_edit;
            this.buttonEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonEdit.Location = new System.Drawing.Point(6, 19);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(116, 57);
            this.buttonEdit.TabIndex = 6;
            this.buttonEdit.Text = "تعديل";
            this.buttonEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonLoad_Bank
            // 
            this.buttonLoad_Bank.Image = global::Limra.Properties.Resources.if_view_refreshs;
            this.buttonLoad_Bank.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonLoad_Bank.Location = new System.Drawing.Point(6, 460);
            this.buttonLoad_Bank.Name = "buttonLoad_Bank";
            this.buttonLoad_Bank.Size = new System.Drawing.Size(128, 57);
            this.buttonLoad_Bank.TabIndex = 5;
            this.buttonLoad_Bank.Text = "تحديث";
            this.buttonLoad_Bank.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonLoad_Bank.UseVisualStyleBackColor = true;
            this.buttonLoad_Bank.Click += new System.EventHandler(this.buttonLoad_Bank_Click);
            // 
            // buttonDelete_Bank
            // 
            this.buttonDelete_Bank.Image = global::Limra.Properties.Resources.if_delete;
            this.buttonDelete_Bank.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonDelete_Bank.Location = new System.Drawing.Point(6, 176);
            this.buttonDelete_Bank.Name = "buttonDelete_Bank";
            this.buttonDelete_Bank.Size = new System.Drawing.Size(128, 57);
            this.buttonDelete_Bank.TabIndex = 3;
            this.buttonDelete_Bank.Text = "حذف";
            this.buttonDelete_Bank.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDelete_Bank.UseVisualStyleBackColor = true;
            this.buttonDelete_Bank.Click += new System.EventHandler(this.buttonDelete_Bank_Click);
            // 
            // buttonAdd_Bank
            // 
            this.buttonAdd_Bank.Image = global::Limra.Properties.Resources.if_save;
            this.buttonAdd_Bank.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAdd_Bank.Location = new System.Drawing.Point(6, 117);
            this.buttonAdd_Bank.Name = "buttonAdd_Bank";
            this.buttonAdd_Bank.Size = new System.Drawing.Size(128, 57);
            this.buttonAdd_Bank.TabIndex = 1;
            this.buttonAdd_Bank.Text = "إضافة";
            this.buttonAdd_Bank.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAdd_Bank.UseVisualStyleBackColor = true;
            this.buttonAdd_Bank.Click += new System.EventHandler(this.buttonAdd_Bank_Click);
            // 
            // buttonNew_Bank
            // 
            this.buttonNew_Bank.Image = global::Limra.Properties.Resources.if_plus_add;
            this.buttonNew_Bank.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonNew_Bank.Location = new System.Drawing.Point(6, 13);
            this.buttonNew_Bank.Name = "buttonNew_Bank";
            this.buttonNew_Bank.Size = new System.Drawing.Size(128, 70);
            this.buttonNew_Bank.TabIndex = 0;
            this.buttonNew_Bank.Text = "جديد";
            this.buttonNew_Bank.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonNew_Bank.UseVisualStyleBackColor = true;
            this.buttonNew_Bank.Click += new System.EventHandler(this.buttonNew_Bank_Click);
            // 
            // Banks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(734, 523);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Banks";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "Banks";
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxAccoNum_Bank;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxBankNum_Bank;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSerial_Bank;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAccoName_Bank;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonLoad_Bank;
        private System.Windows.Forms.Button buttonDelete_Bank;
        private System.Windows.Forms.Button buttonAdd_Bank;
        private System.Windows.Forms.Button buttonNew_Bank;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonEditApprove;
        private System.Windows.Forms.Button buttonEdit;
    }
}