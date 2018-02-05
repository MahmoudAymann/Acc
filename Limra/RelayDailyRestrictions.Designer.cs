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
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.labelTo = new System.Windows.Forms.Label();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.labelFrom = new System.Windows.Forms.Label();
            this.radioButtonDocument = new System.Windows.Forms.RadioButton();
            this.radioButtonDuration = new System.Windows.Forms.RadioButton();
            this.radioButtonDay = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxCurrentDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonCancelSearch = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxDocNum = new System.Windows.Forms.TextBox();
            this.labelDocNum = new System.Windows.Forms.Label();
            this.textBoxEnterDate = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonBackOne = new System.Windows.Forms.Button();
            this.buttonBackAll = new System.Windows.Forms.Button();
            this.buttonSendAll = new System.Windows.Forms.Button();
            this.buttonSendOne = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxTo
            // 
            this.textBoxTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTo.Location = new System.Drawing.Point(267, 69);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(168, 23);
            this.textBoxTo.TabIndex = 21;
            this.textBoxTo.Visible = false;
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTo.Location = new System.Drawing.Point(441, 73);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(33, 16);
            this.labelTo.TabIndex = 20;
            this.labelTo.Text = "الى:";
            this.labelTo.Visible = false;
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFrom.Location = new System.Drawing.Point(480, 69);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(198, 23);
            this.textBoxFrom.TabIndex = 19;
            this.textBoxFrom.Visible = false;
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFrom.Location = new System.Drawing.Point(684, 72);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(30, 16);
            this.labelFrom.TabIndex = 18;
            this.labelFrom.Text = "من:";
            this.labelFrom.Visible = false;
            // 
            // radioButtonDocument
            // 
            this.radioButtonDocument.AutoSize = true;
            this.radioButtonDocument.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDocument.Location = new System.Drawing.Point(307, 33);
            this.radioButtonDocument.Name = "radioButtonDocument";
            this.radioButtonDocument.Size = new System.Drawing.Size(73, 22);
            this.radioButtonDocument.TabIndex = 3;
            this.radioButtonDocument.TabStop = true;
            this.radioButtonDocument.Text = "مستند";
            this.radioButtonDocument.UseVisualStyleBackColor = true;
            this.radioButtonDocument.CheckedChanged += new System.EventHandler(this.radioButtonDocument_CheckedChanged);
            // 
            // radioButtonDuration
            // 
            this.radioButtonDuration.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonDuration.AutoSize = true;
            this.radioButtonDuration.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDuration.Location = new System.Drawing.Point(386, 33);
            this.radioButtonDuration.Name = "radioButtonDuration";
            this.radioButtonDuration.Size = new System.Drawing.Size(56, 22);
            this.radioButtonDuration.TabIndex = 2;
            this.radioButtonDuration.TabStop = true;
            this.radioButtonDuration.Text = "فترة";
            this.radioButtonDuration.UseVisualStyleBackColor = true;
            this.radioButtonDuration.CheckedChanged += new System.EventHandler(this.radioButtonDuration_CheckedChanged);
            // 
            // radioButtonDay
            // 
            this.radioButtonDay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonDay.AutoSize = true;
            this.radioButtonDay.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDay.Location = new System.Drawing.Point(448, 33);
            this.radioButtonDay.Name = "radioButtonDay";
            this.radioButtonDay.Size = new System.Drawing.Size(49, 22);
            this.radioButtonDay.TabIndex = 1;
            this.radioButtonDay.TabStop = true;
            this.radioButtonDay.Text = "يوم";
            this.radioButtonDay.UseVisualStyleBackColor = true;
            this.radioButtonDay.CheckedChanged += new System.EventHandler(this.radioButtonDay_CheckedChanged);
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 73);
            this.button1.TabIndex = 0;
            this.button1.Text = "جديد";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonLoad
            // 
            this.buttonLoad.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonLoad.Location = new System.Drawing.Point(6, 560);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(116, 57);
            this.buttonLoad.TabIndex = 2;
            this.buttonLoad.Text = "تحديث";
            this.buttonLoad.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxCurrentDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.radioButtonDay);
            this.groupBox1.Controls.Add(this.radioButtonDuration);
            this.groupBox1.Controls.Add(this.radioButtonDocument);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(883, 76);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // textBoxCurrentDate
            // 
            this.textBoxCurrentDate.Location = new System.Drawing.Point(646, 30);
            this.textBoxCurrentDate.Name = "textBoxCurrentDate";
            this.textBoxCurrentDate.ReadOnly = true;
            this.textBoxCurrentDate.Size = new System.Drawing.Size(163, 23);
            this.textBoxCurrentDate.TabIndex = 25;
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
            this.groupBox2.Controls.Add(this.groupBox7);
            this.groupBox2.Controls.Add(this.buttonSave);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.buttonLoad);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(128, 629);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            // 
            // buttonCancelSearch
            // 
            this.buttonCancelSearch.Location = new System.Drawing.Point(6, 82);
            this.buttonCancelSearch.Name = "buttonCancelSearch";
            this.buttonCancelSearch.Size = new System.Drawing.Size(104, 43);
            this.buttonCancelSearch.TabIndex = 5;
            this.buttonCancelSearch.Text = "الغاء البحث";
            this.buttonCancelSearch.UseVisualStyleBackColor = true;
            this.buttonCancelSearch.Click += new System.EventHandler(this.buttonCancelSearch_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSearch.Location = new System.Drawing.Point(6, 19);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(104, 57);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "بحث";
            this.buttonSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSave.Location = new System.Drawing.Point(6, 98);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(116, 57);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "حفظ";
            this.buttonSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxDocNum);
            this.groupBox3.Controls.Add(this.labelDocNum);
            this.groupBox3.Controls.Add(this.textBoxEnterDate);
            this.groupBox3.Controls.Add(this.labelDate);
            this.groupBox3.Controls.Add(this.textBoxFrom);
            this.groupBox3.Controls.Add(this.textBoxTo);
            this.groupBox3.Controls.Add(this.labelTo);
            this.groupBox3.Controls.Add(this.labelFrom);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(128, 76);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(755, 145);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "محرك البحث";
            // 
            // textBoxDocNum
            // 
            this.textBoxDocNum.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDocNum.Location = new System.Drawing.Point(480, 115);
            this.textBoxDocNum.Name = "textBoxDocNum";
            this.textBoxDocNum.Size = new System.Drawing.Size(178, 23);
            this.textBoxDocNum.TabIndex = 23;
            this.textBoxDocNum.Visible = false;
            this.textBoxDocNum.TextChanged += new System.EventHandler(this.textBoxDocNum_TextChanged);
            // 
            // labelDocNum
            // 
            this.labelDocNum.AutoSize = true;
            this.labelDocNum.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDocNum.Location = new System.Drawing.Point(664, 118);
            this.labelDocNum.Name = "labelDocNum";
            this.labelDocNum.Size = new System.Drawing.Size(82, 16);
            this.labelDocNum.TabIndex = 22;
            this.labelDocNum.Text = "رقم المستند:";
            this.labelDocNum.Visible = false;
            // 
            // textBoxEnterDate
            // 
            this.textBoxEnterDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEnterDate.Location = new System.Drawing.Point(480, 29);
            this.textBoxEnterDate.Name = "textBoxEnterDate";
            this.textBoxEnterDate.Size = new System.Drawing.Size(198, 23);
            this.textBoxEnterDate.TabIndex = 1;
            this.textBoxEnterDate.Visible = false;
            this.textBoxEnterDate.TextChanged += new System.EventHandler(this.textBoxEnterDate_TextChanged);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(684, 32);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(47, 16);
            this.labelDate.TabIndex = 0;
            this.labelDate.Text = "التاريخ:";
            this.labelDate.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox4.Location = new System.Drawing.Point(128, 221);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(325, 484);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "القيود اليومية";
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
            this.dataGridView1.Size = new System.Drawing.Size(319, 465);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonBackOne);
            this.groupBox5.Controls.Add(this.buttonBackAll);
            this.groupBox5.Controls.Add(this.buttonSendAll);
            this.groupBox5.Controls.Add(this.buttonSendOne);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(453, 221);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(102, 472);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            // 
            // buttonBackOne
            // 
            this.buttonBackOne.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackOne.Location = new System.Drawing.Point(6, 286);
            this.buttonBackOne.Name = "buttonBackOne";
            this.buttonBackOne.Size = new System.Drawing.Size(90, 41);
            this.buttonBackOne.TabIndex = 3;
            this.buttonBackOne.Text = "<";
            this.buttonBackOne.UseVisualStyleBackColor = true;
            this.buttonBackOne.Click += new System.EventHandler(this.buttonBackOne_Click);
            // 
            // buttonBackAll
            // 
            this.buttonBackAll.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackAll.Location = new System.Drawing.Point(6, 333);
            this.buttonBackAll.Name = "buttonBackAll";
            this.buttonBackAll.Size = new System.Drawing.Size(90, 41);
            this.buttonBackAll.TabIndex = 2;
            this.buttonBackAll.Text = "<<";
            this.buttonBackAll.UseVisualStyleBackColor = true;
            this.buttonBackAll.Click += new System.EventHandler(this.buttonBackAll_Click);
            // 
            // buttonSendAll
            // 
            this.buttonSendAll.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSendAll.Location = new System.Drawing.Point(6, 117);
            this.buttonSendAll.Name = "buttonSendAll";
            this.buttonSendAll.Size = new System.Drawing.Size(90, 41);
            this.buttonSendAll.TabIndex = 1;
            this.buttonSendAll.Text = ">>";
            this.buttonSendAll.UseVisualStyleBackColor = true;
            this.buttonSendAll.Click += new System.EventHandler(this.buttonSendAll_Click);
            // 
            // buttonSendOne
            // 
            this.buttonSendOne.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSendOne.Location = new System.Drawing.Point(6, 70);
            this.buttonSendOne.Name = "buttonSendOne";
            this.buttonSendOne.Size = new System.Drawing.Size(90, 41);
            this.buttonSendOne.TabIndex = 0;
            this.buttonSendOne.Text = ">";
            this.buttonSendOne.UseVisualStyleBackColor = true;
            this.buttonSendOne.Click += new System.EventHandler(this.buttonSendOne_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dataGridView2);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox6.Location = new System.Drawing.Point(555, 221);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(328, 484);
            this.groupBox6.TabIndex = 28;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "القيود اليومية المرحلة";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(322, 465);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.buttonSearch);
            this.groupBox7.Controls.Add(this.buttonCancelSearch);
            this.groupBox7.Location = new System.Drawing.Point(6, 178);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(116, 139);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "محرك البحث";
            // 
            // RelayDailyRestrictions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(883, 705);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "RelayDailyRestrictions";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "ترحيل القيود اليومية";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.RadioButton radioButtonDocument;
        private System.Windows.Forms.RadioButton radioButtonDuration;
        private System.Windows.Forms.RadioButton radioButtonDay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxCurrentDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxDocNum;
        private System.Windows.Forms.Label labelDocNum;
        private System.Windows.Forms.TextBox textBoxEnterDate;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSendAll;
        private System.Windows.Forms.Button buttonSendOne;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonBackOne;
        private System.Windows.Forms.Button buttonBackAll;
        private System.Windows.Forms.Button buttonCancelSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.GroupBox groupBox7;
    }
}