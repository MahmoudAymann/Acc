namespace Limra
{
    partial class CurrencyInfo
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
            this.buttonLoad_CI = new System.Windows.Forms.Button();
            this.buttonDelete_CI = new System.Windows.Forms.Button();
            this.buttonAdd_CI = new System.Windows.Forms.Button();
            this.buttonNew_CI = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonEditApproval_CI = new System.Windows.Forms.Button();
            this.buttonEdit_CI = new System.Windows.Forms.Button();
            this.labelLight = new System.Windows.Forms.Label();
            this.buttonSearch_CI = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.radioButtonForeign = new System.Windows.Forms.RadioButton();
            this.radioButton_local = new System.Windows.Forms.RadioButton();
            this.textBoxChange = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNickname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCurrencyName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonLoad_CI);
            this.groupBox1.Controls.Add(this.buttonDelete_CI);
            this.groupBox1.Controls.Add(this.buttonAdd_CI);
            this.groupBox1.Controls.Add(this.buttonNew_CI);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.labelLight);
            this.groupBox1.Controls.Add(this.buttonSearch_CI);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 507);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // buttonLoad_CI
            // 
            this.buttonLoad_CI.Image = global::Limra.Properties.Resources.if_view_refreshs;
            this.buttonLoad_CI.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonLoad_CI.Location = new System.Drawing.Point(6, 445);
            this.buttonLoad_CI.Name = "buttonLoad_CI";
            this.buttonLoad_CI.Size = new System.Drawing.Size(113, 56);
            this.buttonLoad_CI.TabIndex = 22;
            this.buttonLoad_CI.Text = "تحديث";
            this.buttonLoad_CI.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonLoad_CI.UseVisualStyleBackColor = true;
            this.buttonLoad_CI.Click += new System.EventHandler(this.buttonLoad_CI_Click);
            // 
            // buttonDelete_CI
            // 
            this.buttonDelete_CI.Image = global::Limra.Properties.Resources.if_delete;
            this.buttonDelete_CI.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonDelete_CI.Location = new System.Drawing.Point(6, 150);
            this.buttonDelete_CI.Name = "buttonDelete_CI";
            this.buttonDelete_CI.Size = new System.Drawing.Size(113, 57);
            this.buttonDelete_CI.TabIndex = 21;
            this.buttonDelete_CI.Text = "مسح";
            this.buttonDelete_CI.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDelete_CI.UseVisualStyleBackColor = true;
            this.buttonDelete_CI.Click += new System.EventHandler(this.buttonDelete_CI_Click);
            // 
            // buttonAdd_CI
            // 
            this.buttonAdd_CI.Image = global::Limra.Properties.Resources.if_save;
            this.buttonAdd_CI.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAdd_CI.Location = new System.Drawing.Point(6, 87);
            this.buttonAdd_CI.Name = "buttonAdd_CI";
            this.buttonAdd_CI.Size = new System.Drawing.Size(113, 57);
            this.buttonAdd_CI.TabIndex = 20;
            this.buttonAdd_CI.Text = "حفظ";
            this.buttonAdd_CI.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAdd_CI.UseVisualStyleBackColor = true;
            this.buttonAdd_CI.Click += new System.EventHandler(this.buttonAdd_CI_Click);
            // 
            // buttonNew_CI
            // 
            this.buttonNew_CI.Image = global::Limra.Properties.Resources.if_plus_add;
            this.buttonNew_CI.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonNew_CI.Location = new System.Drawing.Point(6, 12);
            this.buttonNew_CI.Name = "buttonNew_CI";
            this.buttonNew_CI.Size = new System.Drawing.Size(113, 69);
            this.buttonNew_CI.TabIndex = 12;
            this.buttonNew_CI.Text = "جديد";
            this.buttonNew_CI.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonNew_CI.UseVisualStyleBackColor = true;
            this.buttonNew_CI.Click += new System.EventHandler(this.buttonNew_CI_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonEditApproval_CI);
            this.groupBox2.Controls.Add(this.buttonEdit_CI);
            this.groupBox2.Location = new System.Drawing.Point(6, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(113, 126);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "التعديل";
            // 
            // buttonEditApproval_CI
            // 
            this.buttonEditApproval_CI.BackColor = System.Drawing.Color.Green;
            this.buttonEditApproval_CI.Enabled = false;
            this.buttonEditApproval_CI.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditApproval_CI.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEditApproval_CI.Location = new System.Drawing.Point(6, 82);
            this.buttonEditApproval_CI.Name = "buttonEditApproval_CI";
            this.buttonEditApproval_CI.Size = new System.Drawing.Size(101, 30);
            this.buttonEditApproval_CI.TabIndex = 20;
            this.buttonEditApproval_CI.Text = "تنفيذ";
            this.buttonEditApproval_CI.UseVisualStyleBackColor = false;
            this.buttonEditApproval_CI.Click += new System.EventHandler(this.buttonEditApproval_CI_Click);
            // 
            // buttonEdit_CI
            // 
            this.buttonEdit_CI.Image = global::Limra.Properties.Resources.if_edit;
            this.buttonEdit_CI.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonEdit_CI.Location = new System.Drawing.Point(6, 19);
            this.buttonEdit_CI.Name = "buttonEdit_CI";
            this.buttonEdit_CI.Size = new System.Drawing.Size(101, 57);
            this.buttonEdit_CI.TabIndex = 19;
            this.buttonEdit_CI.Text = "تعديل";
            this.buttonEdit_CI.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEdit_CI.UseVisualStyleBackColor = true;
            this.buttonEdit_CI.Click += new System.EventHandler(this.buttonEdit_CI_Click);
            // 
            // labelLight
            // 
            this.labelLight.BackColor = System.Drawing.Color.Red;
            this.labelLight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLight.Location = new System.Drawing.Point(17, 298);
            this.labelLight.Name = "labelLight";
            this.labelLight.Size = new System.Drawing.Size(16, 15);
            this.labelLight.TabIndex = 7;
            // 
            // buttonSearch_CI
            // 
            this.buttonSearch_CI.Image = global::Limra.Properties.Resources.if_search;
            this.buttonSearch_CI.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSearch_CI.Location = new System.Drawing.Point(6, 345);
            this.buttonSearch_CI.Name = "buttonSearch_CI";
            this.buttonSearch_CI.Size = new System.Drawing.Size(113, 56);
            this.buttonSearch_CI.TabIndex = 5;
            this.buttonSearch_CI.Text = "بحث";
            this.buttonSearch_CI.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSearch_CI.UseVisualStyleBackColor = true;
            this.buttonSearch_CI.Click += new System.EventHandler(this.buttonSearch_CI_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonAll);
            this.groupBox3.Controls.Add(this.radioButtonForeign);
            this.groupBox3.Controls.Add(this.radioButton_local);
            this.groupBox3.Controls.Add(this.textBoxChange);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBoxNickname);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textBoxCurrencyName);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(125, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(424, 106);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.AutoSize = true;
            this.radioButtonAll.Enabled = false;
            this.radioButtonAll.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAll.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButtonAll.Location = new System.Drawing.Point(45, 72);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new System.Drawing.Size(46, 21);
            this.radioButtonAll.TabIndex = 13;
            this.radioButtonAll.TabStop = true;
            this.radioButtonAll.Text = "الكل";
            this.radioButtonAll.UseVisualStyleBackColor = true;
            this.radioButtonAll.CheckedChanged += new System.EventHandler(this.radioButtonAll_CheckedChanged);
            // 
            // radioButtonForeign
            // 
            this.radioButtonForeign.AutoSize = true;
            this.radioButtonForeign.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonForeign.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButtonForeign.Location = new System.Drawing.Point(9, 47);
            this.radioButtonForeign.Name = "radioButtonForeign";
            this.radioButtonForeign.Size = new System.Drawing.Size(82, 21);
            this.radioButtonForeign.TabIndex = 1;
            this.radioButtonForeign.TabStop = true;
            this.radioButtonForeign.Text = "عملة اجنبية";
            this.radioButtonForeign.UseVisualStyleBackColor = true;
            this.radioButtonForeign.CheckedChanged += new System.EventHandler(this.radioButtonForeign_CheckedChanged);
            // 
            // radioButton_local
            // 
            this.radioButton_local.AutoSize = true;
            this.radioButton_local.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_local.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButton_local.Location = new System.Drawing.Point(12, 24);
            this.radioButton_local.Name = "radioButton_local";
            this.radioButton_local.Size = new System.Drawing.Size(80, 21);
            this.radioButton_local.TabIndex = 0;
            this.radioButton_local.TabStop = true;
            this.radioButton_local.Text = "عملة محلية";
            this.radioButton_local.UseVisualStyleBackColor = true;
            this.radioButton_local.CheckedChanged += new System.EventHandler(this.radioButton_local_CheckedChanged);
            // 
            // textBoxChange
            // 
            this.textBoxChange.Enabled = false;
            this.textBoxChange.Location = new System.Drawing.Point(141, 72);
            this.textBoxChange.Name = "textBoxChange";
            this.textBoxChange.Size = new System.Drawing.Size(217, 25);
            this.textBoxChange.TabIndex = 12;
            this.textBoxChange.TextChanged += new System.EventHandler(this.textBoxChange_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(364, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "الفكة:";
            // 
            // textBoxNickname
            // 
            this.textBoxNickname.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxNickname.Enabled = false;
            this.textBoxNickname.Location = new System.Drawing.Point(141, 46);
            this.textBoxNickname.Name = "textBoxNickname";
            this.textBoxNickname.Size = new System.Drawing.Size(217, 25);
            this.textBoxNickname.TabIndex = 10;
            this.textBoxNickname.TextChanged += new System.EventHandler(this.textBoxNickname_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(364, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "رمز العملة:";
            // 
            // textBoxCurrencyName
            // 
            this.textBoxCurrencyName.Enabled = false;
            this.textBoxCurrencyName.Location = new System.Drawing.Point(141, 20);
            this.textBoxCurrencyName.Name = "textBoxCurrencyName";
            this.textBoxCurrencyName.Size = new System.Drawing.Size(217, 25);
            this.textBoxCurrencyName.TabIndex = 8;
            this.textBoxCurrencyName.TextChanged += new System.EventHandler(this.textBoxCurrencyName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(364, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "اسم العملة:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(125, 106);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(424, 401);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CurrencyInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(549, 507);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "CurrencyInfo";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "بيانات العملات";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSearch_CI;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButtonForeign;
        private System.Windows.Forms.RadioButton radioButton_local;
        private System.Windows.Forms.TextBox textBoxChange;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNickname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCurrencyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelLight;
        private System.Windows.Forms.RadioButton radioButtonAll;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonNew_CI;
        private System.Windows.Forms.Button buttonAdd_CI;
        private System.Windows.Forms.Button buttonDelete_CI;
        private System.Windows.Forms.Button buttonEdit_CI;
        private System.Windows.Forms.Button buttonEditApproval_CI;
        private System.Windows.Forms.Button buttonLoad_CI;
    }
}