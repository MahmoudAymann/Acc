namespace Limra
{
    partial class RelayDailyRestrictions
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxCurrentDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.buttonBackOne = new System.Windows.Forms.Button();
            this.buttonBackAll = new System.Windows.Forms.Button();
            this.buttonSendAll = new System.Windows.Forms.Button();
            this.buttonSendOne = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.textBoxEnterDate = new System.Windows.Forms.TextBox();
            this.radioButtonDocument = new System.Windows.Forms.RadioButton();
            this.labelDocNum = new System.Windows.Forms.Label();
            this.textBoxDocNum = new System.Windows.Forms.TextBox();
            this.radioButtonDay = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxCurrentDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(883, 66);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // textBoxCurrentDate
            // 
            this.textBoxCurrentDate.Location = new System.Drawing.Point(646, 28);
            this.textBoxCurrentDate.Name = "textBoxCurrentDate";
            this.textBoxCurrentDate.ReadOnly = true;
            this.textBoxCurrentDate.Size = new System.Drawing.Size(163, 23);
            this.textBoxCurrentDate.TabIndex = 25;
            this.textBoxCurrentDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(815, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 22);
            this.label3.TabIndex = 24;
            this.label3.Text = "التاريخ:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_Search);
            this.groupBox2.Controls.Add(this.buttonSave);
            this.groupBox2.Controls.Add(this.buttonNew);
            this.groupBox2.Controls.Add(this.buttonLoad);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(135, 700);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            // 
            // button_Search
            // 
            this.button_Search.Image = global::Limra.Properties.Resources.if_search;
            this.button_Search.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_Search.Location = new System.Drawing.Point(5, 287);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(123, 62);
            this.button_Search.TabIndex = 4;
            this.button_Search.Text = "بحث";
            this.button_Search.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Image = global::Limra.Properties.Resources.if_save;
            this.buttonSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSave.Location = new System.Drawing.Point(3, 203);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(123, 68);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "حفظ";
            this.buttonSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Image = global::Limra.Properties.Resources.if_plus_add;
            this.buttonNew.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonNew.Location = new System.Drawing.Point(5, 19);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(124, 84);
            this.buttonNew.TabIndex = 0;
            this.buttonNew.Text = "جديد";
            this.buttonNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonNew.UseVisualStyleBackColor = true;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Image = global::Limra.Properties.Resources.if_view_refreshs;
            this.buttonLoad.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonLoad.Location = new System.Drawing.Point(6, 636);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(123, 57);
            this.buttonLoad.TabIndex = 2;
            this.buttonLoad.Text = "تحديث";
            this.buttonLoad.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonLoad.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox4.Location = new System.Drawing.Point(135, 257);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(320, 509);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "السندات الغير مرحلة";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(314, 490);
            this.dataGridView1.TabIndex = 8;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox5.Location = new System.Drawing.Point(560, 257);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(323, 509);
            this.groupBox5.TabIndex = 33;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "السندات المرحلة";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(317, 490);
            this.dataGridView2.TabIndex = 9;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.buttonBackOne);
            this.groupBox6.Controls.Add(this.buttonBackAll);
            this.groupBox6.Controls.Add(this.buttonSendAll);
            this.groupBox6.Controls.Add(this.buttonSendOne);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(455, 257);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(105, 509);
            this.groupBox6.TabIndex = 34;
            this.groupBox6.TabStop = false;
            // 
            // buttonBackOne
            // 
            this.buttonBackOne.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackOne.Location = new System.Drawing.Point(5, 265);
            this.buttonBackOne.Name = "buttonBackOne";
            this.buttonBackOne.Size = new System.Drawing.Size(90, 41);
            this.buttonBackOne.TabIndex = 11;
            this.buttonBackOne.Text = "<";
            this.buttonBackOne.UseVisualStyleBackColor = true;
            this.buttonBackOne.Click += new System.EventHandler(this.buttonBackOne_Click);
            // 
            // buttonBackAll
            // 
            this.buttonBackAll.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackAll.Location = new System.Drawing.Point(5, 312);
            this.buttonBackAll.Name = "buttonBackAll";
            this.buttonBackAll.Size = new System.Drawing.Size(90, 41);
            this.buttonBackAll.TabIndex = 10;
            this.buttonBackAll.Text = "<<";
            this.buttonBackAll.UseVisualStyleBackColor = true;
            this.buttonBackAll.Click += new System.EventHandler(this.buttonBackAll_Click);
            // 
            // buttonSendAll
            // 
            this.buttonSendAll.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSendAll.Location = new System.Drawing.Point(5, 96);
            this.buttonSendAll.Name = "buttonSendAll";
            this.buttonSendAll.Size = new System.Drawing.Size(90, 41);
            this.buttonSendAll.TabIndex = 9;
            this.buttonSendAll.Text = ">>";
            this.buttonSendAll.UseVisualStyleBackColor = true;
            this.buttonSendAll.Click += new System.EventHandler(this.buttonSendAll_Click);
            // 
            // buttonSendOne
            // 
            this.buttonSendOne.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSendOne.Location = new System.Drawing.Point(5, 49);
            this.buttonSendOne.Name = "buttonSendOne";
            this.buttonSendOne.Size = new System.Drawing.Size(90, 41);
            this.buttonSendOne.TabIndex = 8;
            this.buttonSendOne.Text = ">";
            this.buttonSendOne.UseVisualStyleBackColor = true;
            this.buttonSendOne.Click += new System.EventHandler(this.buttonSendOne_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(656, 69);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(47, 16);
            this.labelDate.TabIndex = 0;
            this.labelDate.Text = "التاريخ:";
            // 
            // textBoxEnterDate
            // 
            this.textBoxEnterDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEnterDate.Location = new System.Drawing.Point(452, 66);
            this.textBoxEnterDate.Name = "textBoxEnterDate";
            this.textBoxEnterDate.Size = new System.Drawing.Size(198, 23);
            this.textBoxEnterDate.TabIndex = 1;
            // 
            // radioButtonDocument
            // 
            this.radioButtonDocument.AutoSize = true;
            this.radioButtonDocument.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDocument.Location = new System.Drawing.Point(531, 23);
            this.radioButtonDocument.Name = "radioButtonDocument";
            this.radioButtonDocument.Size = new System.Drawing.Size(73, 22);
            this.radioButtonDocument.TabIndex = 3;
            this.radioButtonDocument.TabStop = true;
            this.radioButtonDocument.Text = "مستند";
            this.radioButtonDocument.UseVisualStyleBackColor = true;
            this.radioButtonDocument.CheckedChanged += new System.EventHandler(this.radioButtonDocument_CheckedChanged);
            // 
            // labelDocNum
            // 
            this.labelDocNum.AutoSize = true;
            this.labelDocNum.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDocNum.Location = new System.Drawing.Point(656, 131);
            this.labelDocNum.Name = "labelDocNum";
            this.labelDocNum.Size = new System.Drawing.Size(82, 16);
            this.labelDocNum.TabIndex = 22;
            this.labelDocNum.Text = "رقم المستند:";
            // 
            // textBoxDocNum
            // 
            this.textBoxDocNum.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDocNum.Location = new System.Drawing.Point(452, 129);
            this.textBoxDocNum.Name = "textBoxDocNum";
            this.textBoxDocNum.Size = new System.Drawing.Size(198, 23);
            this.textBoxDocNum.TabIndex = 23;
            this.textBoxDocNum.TextChanged += new System.EventHandler(this.textBoxDocNum_TextChanged);
            // 
            // radioButtonDay
            // 
            this.radioButtonDay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonDay.AutoSize = true;
            this.radioButtonDay.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDay.Location = new System.Drawing.Point(620, 23);
            this.radioButtonDay.Name = "radioButtonDay";
            this.radioButtonDay.Size = new System.Drawing.Size(49, 22);
            this.radioButtonDay.TabIndex = 1;
            this.radioButtonDay.TabStop = true;
            this.radioButtonDay.Text = "يوم";
            this.radioButtonDay.UseVisualStyleBackColor = true;
            this.radioButtonDay.CheckedChanged += new System.EventHandler(this.radioButtonDay_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Limra.Properties.Resources.choose_time;
            this.pictureBox1.Location = new System.Drawing.Point(3, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.pictureBox1);
            this.groupBox7.Controls.Add(this.radioButtonDay);
            this.groupBox7.Controls.Add(this.textBoxDocNum);
            this.groupBox7.Controls.Add(this.labelDocNum);
            this.groupBox7.Controls.Add(this.radioButtonDocument);
            this.groupBox7.Controls.Add(this.textBoxEnterDate);
            this.groupBox7.Controls.Add(this.labelDate);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox7.Location = new System.Drawing.Point(135, 66);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(748, 191);
            this.groupBox7.TabIndex = 31;
            this.groupBox7.TabStop = false;
            this.groupBox7.Visible = false;
            // 
            // RelayDailyRestrictions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(883, 766);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "RelayDailyRestrictions";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "ترحيل القيود اليومية";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxCurrentDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button buttonBackOne;
        private System.Windows.Forms.Button buttonBackAll;
        private System.Windows.Forms.Button buttonSendAll;
        private System.Windows.Forms.Button buttonSendOne;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox textBoxEnterDate;
        private System.Windows.Forms.RadioButton radioButtonDocument;
        private System.Windows.Forms.Label labelDocNum;
        private System.Windows.Forms.TextBox textBoxDocNum;
        private System.Windows.Forms.RadioButton radioButtonDay;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox7;
    }
}