namespace Limra
{
    partial class StroingMeasurments
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
            this.textBoxMeasurements_SM = new System.Windows.Forms.TextBox();
            this.textBoxNickName_SM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonLoad_SM = new System.Windows.Forms.Button();
            this.buttonDelete_SM = new System.Windows.Forms.Button();
            this.buttonAdd_SM = new System.Windows.Forms.Button();
            this.buttonNew_SM = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonEditApproval_CI = new System.Windows.Forms.Button();
            this.labelLight2 = new System.Windows.Forms.Label();
            this.buttonEdit_SM = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "القياس:";
            // 
            // textBoxMeasurements_SM
            // 
            this.textBoxMeasurements_SM.Location = new System.Drawing.Point(227, 19);
            this.textBoxMeasurements_SM.Name = "textBoxMeasurements_SM";
            this.textBoxMeasurements_SM.Size = new System.Drawing.Size(185, 20);
            this.textBoxMeasurements_SM.TabIndex = 1;
            // 
            // textBoxNickName_SM
            // 
            this.textBoxNickName_SM.Location = new System.Drawing.Point(287, 54);
            this.textBoxNickName_SM.Name = "textBoxNickName_SM";
            this.textBoxNickName_SM.Size = new System.Drawing.Size(125, 20);
            this.textBoxNickName_SM.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "الرمز:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.buttonLoad_SM);
            this.groupBox1.Controls.Add(this.buttonDelete_SM);
            this.groupBox1.Controls.Add(this.buttonAdd_SM);
            this.groupBox1.Controls.Add(this.buttonNew_SM);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(133, 384);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // buttonLoad_SM
            // 
            this.buttonLoad_SM.Location = new System.Drawing.Point(5, 334);
            this.buttonLoad_SM.Name = "buttonLoad_SM";
            this.buttonLoad_SM.Size = new System.Drawing.Size(122, 44);
            this.buttonLoad_SM.TabIndex = 4;
            this.buttonLoad_SM.Text = "تحديث قاعدة البيانات";
            this.buttonLoad_SM.UseVisualStyleBackColor = true;
            this.buttonLoad_SM.Click += new System.EventHandler(this.buttonLoad_SM_Click);
            // 
            // buttonDelete_SM
            // 
            this.buttonDelete_SM.Location = new System.Drawing.Point(6, 127);
            this.buttonDelete_SM.Name = "buttonDelete_SM";
            this.buttonDelete_SM.Size = new System.Drawing.Size(122, 44);
            this.buttonDelete_SM.TabIndex = 2;
            this.buttonDelete_SM.Text = "حذف";
            this.buttonDelete_SM.UseVisualStyleBackColor = true;
            this.buttonDelete_SM.Click += new System.EventHandler(this.buttonDelete_SM_Click);
            // 
            // buttonAdd_SM
            // 
            this.buttonAdd_SM.Location = new System.Drawing.Point(6, 77);
            this.buttonAdd_SM.Name = "buttonAdd_SM";
            this.buttonAdd_SM.Size = new System.Drawing.Size(122, 44);
            this.buttonAdd_SM.TabIndex = 1;
            this.buttonAdd_SM.Text = "إضافة";
            this.buttonAdd_SM.UseVisualStyleBackColor = true;
            this.buttonAdd_SM.Click += new System.EventHandler(this.buttonAdd_SM_Click);
            // 
            // buttonNew_SM
            // 
            this.buttonNew_SM.Location = new System.Drawing.Point(6, 12);
            this.buttonNew_SM.Name = "buttonNew_SM";
            this.buttonNew_SM.Size = new System.Drawing.Size(122, 58);
            this.buttonNew_SM.TabIndex = 0;
            this.buttonNew_SM.Text = "جديد";
            this.buttonNew_SM.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxNickName_SM);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxMeasurements_SM);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(133, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(483, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(133, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(483, 284);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonEditApproval_CI);
            this.groupBox3.Controls.Add(this.labelLight2);
            this.groupBox3.Controls.Add(this.buttonEdit_SM);
            this.groupBox3.Location = new System.Drawing.Point(6, 177);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(121, 107);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "التعديل";
            // 
            // buttonEditApproval_CI
            // 
            this.buttonEditApproval_CI.Enabled = false;
            this.buttonEditApproval_CI.Location = new System.Drawing.Point(6, 64);
            this.buttonEditApproval_CI.Name = "buttonEditApproval_CI";
            this.buttonEditApproval_CI.Size = new System.Drawing.Size(109, 37);
            this.buttonEditApproval_CI.TabIndex = 10;
            this.buttonEditApproval_CI.Text = "تنفيذ";
            this.buttonEditApproval_CI.UseVisualStyleBackColor = true;
            this.buttonEditApproval_CI.Click += new System.EventHandler(this.buttonEditApproval_CI_Click);
            // 
            // labelLight2
            // 
            this.labelLight2.BackColor = System.Drawing.Color.Red;
            this.labelLight2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLight2.Location = new System.Drawing.Point(13, 33);
            this.labelLight2.Name = "labelLight2";
            this.labelLight2.Size = new System.Drawing.Size(16, 14);
            this.labelLight2.TabIndex = 10;
            // 
            // buttonEdit_SM
            // 
            this.buttonEdit_SM.Enabled = false;
            this.buttonEdit_SM.Location = new System.Drawing.Point(6, 19);
            this.buttonEdit_SM.Name = "buttonEdit_SM";
            this.buttonEdit_SM.Size = new System.Drawing.Size(109, 39);
            this.buttonEdit_SM.TabIndex = 9;
            this.buttonEdit_SM.Text = "تعديل";
            this.buttonEdit_SM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEdit_SM.UseVisualStyleBackColor = true;
            this.buttonEdit_SM.Click += new System.EventHandler(this.buttonEdit_SM_Click);
            // 
            // StroingMeasurments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 384);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "StroingMeasurments";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "وحدات قياس المخزون";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMeasurements_SM;
        private System.Windows.Forms.TextBox textBoxNickName_SM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonLoad_SM;
        private System.Windows.Forms.Button buttonDelete_SM;
        private System.Windows.Forms.Button buttonAdd_SM;
        private System.Windows.Forms.Button buttonNew_SM;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonEditApproval_CI;
        private System.Windows.Forms.Label labelLight2;
        private System.Windows.Forms.Button buttonEdit_SM;
    }
}