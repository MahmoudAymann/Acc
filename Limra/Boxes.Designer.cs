namespace Limra
{
    partial class Boxes
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
            this.textBoxSerial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAccName = new System.Windows.Forms.TextBox();
            this.labelBoxName = new System.Windows.Forms.Label();
            this.textBoxAccNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonEditApprove_Boxes = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonLoad_Box = new System.Windows.Forms.Button();
            this.buttonDelete_Box = new System.Windows.Forms.Button();
            this.buttonAdd_Boxes = new System.Windows.Forms.Button();
            this.buttonNew_Box = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSerial
            // 
            this.textBoxSerial.Location = new System.Drawing.Point(247, 100);
            this.textBoxSerial.Name = "textBoxSerial";
            this.textBoxSerial.Size = new System.Drawing.Size(241, 23);
            this.textBoxSerial.TabIndex = 7;
            this.textBoxSerial.Enter += new System.EventHandler(this.textBoxSerial_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(494, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "رقم التسلسل:";
            // 
            // textBoxAccName
            // 
            this.textBoxAccName.Location = new System.Drawing.Point(247, 74);
            this.textBoxAccName.Name = "textBoxAccName";
            this.textBoxAccName.Size = new System.Drawing.Size(241, 23);
            this.textBoxAccName.TabIndex = 5;
            // 
            // labelBoxName
            // 
            this.labelBoxName.AutoSize = true;
            this.labelBoxName.Location = new System.Drawing.Point(495, 77);
            this.labelBoxName.Name = "labelBoxName";
            this.labelBoxName.Size = new System.Drawing.Size(87, 16);
            this.labelBoxName.TabIndex = 4;
            this.labelBoxName.Text = "اسم الصندوق:";
            // 
            // textBoxAccNum
            // 
            this.textBoxAccNum.Location = new System.Drawing.Point(247, 48);
            this.textBoxAccNum.Name = "textBoxAccNum";
            this.textBoxAccNum.Size = new System.Drawing.Size(241, 23);
            this.textBoxAccNum.TabIndex = 11;
            this.textBoxAccNum.TextChanged += new System.EventHandler(this.textBoxAccNum_TextChanged);
            this.textBoxAccNum.Enter += new System.EventHandler(this.textBoxAccNum_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(494, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "رقم حساب الصندوق:";
            // 
            // textBoxNum
            // 
            this.textBoxNum.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxNum.Location = new System.Drawing.Point(247, 22);
            this.textBoxNum.Name = "textBoxNum";
            this.textBoxNum.Size = new System.Drawing.Size(241, 23);
            this.textBoxNum.TabIndex = 9;
            this.textBoxNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(494, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "رقم الصندوق:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.buttonLoad_Box);
            this.groupBox1.Controls.Add(this.buttonDelete_Box);
            this.groupBox1.Controls.Add(this.buttonAdd_Boxes);
            this.groupBox1.Controls.Add(this.buttonNew_Box);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(131, 503);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonEditApprove_Boxes);
            this.groupBox5.Controls.Add(this.buttonEdit);
            this.groupBox5.Location = new System.Drawing.Point(6, 271);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(122, 114);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "التعديل";
            // 
            // buttonEditApprove_Boxes
            // 
            this.buttonEditApprove_Boxes.BackColor = System.Drawing.Color.Green;
            this.buttonEditApprove_Boxes.Enabled = false;
            this.buttonEditApprove_Boxes.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditApprove_Boxes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEditApprove_Boxes.Location = new System.Drawing.Point(6, 79);
            this.buttonEditApprove_Boxes.Name = "buttonEditApprove_Boxes";
            this.buttonEditApprove_Boxes.Size = new System.Drawing.Size(110, 27);
            this.buttonEditApprove_Boxes.TabIndex = 20;
            this.buttonEditApprove_Boxes.Text = "تنفيذ";
            this.buttonEditApprove_Boxes.UseVisualStyleBackColor = false;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Image = global::Limra.Properties.Resources.if_edit;
            this.buttonEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonEdit.Location = new System.Drawing.Point(6, 19);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(110, 57);
            this.buttonEdit.TabIndex = 6;
            this.buttonEdit.Text = "تعديل";
            this.buttonEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonLoad_Box
            // 
            this.buttonLoad_Box.Image = global::Limra.Properties.Resources.if_view_refreshs;
            this.buttonLoad_Box.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonLoad_Box.Location = new System.Drawing.Point(6, 448);
            this.buttonLoad_Box.Name = "buttonLoad_Box";
            this.buttonLoad_Box.Size = new System.Drawing.Size(122, 53);
            this.buttonLoad_Box.TabIndex = 5;
            this.buttonLoad_Box.Text = "تحديث";
            this.buttonLoad_Box.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonLoad_Box.UseVisualStyleBackColor = true;
            this.buttonLoad_Box.Click += new System.EventHandler(this.buttonLoad_Box_Click);
            // 
            // buttonDelete_Box
            // 
            this.buttonDelete_Box.Image = global::Limra.Properties.Resources.if_delete;
            this.buttonDelete_Box.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonDelete_Box.Location = new System.Drawing.Point(6, 208);
            this.buttonDelete_Box.Name = "buttonDelete_Box";
            this.buttonDelete_Box.Size = new System.Drawing.Size(122, 57);
            this.buttonDelete_Box.TabIndex = 3;
            this.buttonDelete_Box.Text = "حذف";
            this.buttonDelete_Box.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDelete_Box.UseVisualStyleBackColor = true;
            this.buttonDelete_Box.Click += new System.EventHandler(this.buttonDelete_Box_Click);
            // 
            // buttonAdd_Boxes
            // 
            this.buttonAdd_Boxes.Image = global::Limra.Properties.Resources.if_save;
            this.buttonAdd_Boxes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAdd_Boxes.Location = new System.Drawing.Point(6, 145);
            this.buttonAdd_Boxes.Name = "buttonAdd_Boxes";
            this.buttonAdd_Boxes.Size = new System.Drawing.Size(122, 57);
            this.buttonAdd_Boxes.TabIndex = 1;
            this.buttonAdd_Boxes.Text = "حفظ";
            this.buttonAdd_Boxes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAdd_Boxes.UseVisualStyleBackColor = true;
            this.buttonAdd_Boxes.Click += new System.EventHandler(this.buttonAdd_Boxes_Click);
            // 
            // buttonNew_Box
            // 
            this.buttonNew_Box.Image = global::Limra.Properties.Resources.if_plus_add;
            this.buttonNew_Box.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonNew_Box.Location = new System.Drawing.Point(6, 12);
            this.buttonNew_Box.Name = "buttonNew_Box";
            this.buttonNew_Box.Size = new System.Drawing.Size(122, 72);
            this.buttonNew_Box.TabIndex = 0;
            this.buttonNew_Box.Text = "جديد";
            this.buttonNew_Box.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonNew_Box.UseVisualStyleBackColor = true;
            this.buttonNew_Box.Click += new System.EventHandler(this.buttonNew_Box_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.labelBoxName);
            this.groupBox3.Controls.Add(this.textBoxAccName);
            this.groupBox3.Controls.Add(this.textBoxAccNum);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textBoxSerial);
            this.groupBox3.Controls.Add(this.textBoxNum);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(131, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(627, 129);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "بيانات اساسية";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView2.Location = new System.Drawing.Point(3, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(238, 107);
            this.dataGridView2.TabIndex = 12;
            this.dataGridView2.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_CellMouseDoubleClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Location = new System.Drawing.Point(131, 131);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(627, 372);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "بيانات الصناديق";
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
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(621, 353);
            this.dataGridView1.TabIndex = 3;
            // 
            // Boxes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(758, 503);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Boxes";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "الصناديق";
            this.Load += new System.EventHandler(this.Boxes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSerial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAccName;
        private System.Windows.Forms.Label labelBoxName;
        private System.Windows.Forms.TextBox textBoxAccNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonNew_Box;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonLoad_Box;
        private System.Windows.Forms.Button buttonDelete_Box;
        private System.Windows.Forms.Button buttonAdd_Boxes;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonEditApprove_Boxes;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}