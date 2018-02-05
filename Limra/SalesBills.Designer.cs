namespace Limra
{
    partial class SalesBills
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
            this.radioButtonCash = new System.Windows.Forms.RadioButton();
            this.radioButtonChique = new System.Windows.Forms.RadioButton();
            this.radioButtonPostponed = new System.Windows.Forms.RadioButton();
            this.textBoxBillNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCurrentDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAgentName = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelAgentName = new System.Windows.Forms.Label();
            this.textBoxAccouNum = new System.Windows.Forms.TextBox();
            this.labelAccountNum = new System.Windows.Forms.Label();
            this.labelCurrency = new System.Windows.Forms.Label();
            this.textBoxAgentPhone = new System.Windows.Forms.TextBox();
            this.labelLimit = new System.Windows.Forms.Label();
            this.textBoxLimit = new System.Windows.Forms.TextBox();
            this.labelAgentPhone = new System.Windows.Forms.Label();
            this.textBoxAccoName = new System.Windows.Forms.TextBox();
            this.labelAccountName = new System.Windows.Forms.Label();
            this.textBoxCurrency = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.labelCost = new System.Windows.Forms.Label();
            this.textBoxUnitMeasurements = new System.Windows.Forms.TextBox();
            this.labelUnitMeasurements = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.textBoxItemName = new System.Windows.Forms.TextBox();
            this.labelItemName = new System.Windows.Forms.Label();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.textBoxItemNum = new System.Windows.Forms.TextBox();
            this.labelItemNum = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxTotalBillCost = new System.Windows.Forms.TextBox();
            this.labelSalesBill = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonCash);
            this.groupBox1.Controls.Add(this.radioButtonChique);
            this.groupBox1.Controls.Add(this.radioButtonPostponed);
            this.groupBox1.Controls.Add(this.textBoxBillNum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxCurrentDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(807, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات اساسية";
            // 
            // radioButtonCash
            // 
            this.radioButtonCash.AutoSize = true;
            this.radioButtonCash.Location = new System.Drawing.Point(131, 18);
            this.radioButtonCash.Name = "radioButtonCash";
            this.radioButtonCash.Size = new System.Drawing.Size(43, 17);
            this.radioButtonCash.TabIndex = 6;
            this.radioButtonCash.TabStop = true;
            this.radioButtonCash.Text = "نقدا";
            this.radioButtonCash.UseVisualStyleBackColor = true;
            this.radioButtonCash.CheckedChanged += new System.EventHandler(this.radioButtonCash_CheckedChanged);
            // 
            // radioButtonChique
            // 
            this.radioButtonChique.AutoSize = true;
            this.radioButtonChique.Location = new System.Drawing.Point(184, 18);
            this.radioButtonChique.Name = "radioButtonChique";
            this.radioButtonChique.Size = new System.Drawing.Size(49, 17);
            this.radioButtonChique.TabIndex = 5;
            this.radioButtonChique.TabStop = true;
            this.radioButtonChique.Text = "شيك";
            this.radioButtonChique.UseVisualStyleBackColor = true;
            this.radioButtonChique.CheckedChanged += new System.EventHandler(this.radioButtonChique_CheckedChanged);
            // 
            // radioButtonPostponed
            // 
            this.radioButtonPostponed.AutoSize = true;
            this.radioButtonPostponed.Location = new System.Drawing.Point(241, 18);
            this.radioButtonPostponed.Name = "radioButtonPostponed";
            this.radioButtonPostponed.Size = new System.Drawing.Size(43, 17);
            this.radioButtonPostponed.TabIndex = 4;
            this.radioButtonPostponed.TabStop = true;
            this.radioButtonPostponed.Text = "آجل";
            this.radioButtonPostponed.UseVisualStyleBackColor = true;
            this.radioButtonPostponed.CheckedChanged += new System.EventHandler(this.radioButtonPostponed_CheckedChanged);
            // 
            // textBoxBillNum
            // 
            this.textBoxBillNum.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxBillNum.Location = new System.Drawing.Point(314, 19);
            this.textBoxBillNum.Name = "textBoxBillNum";
            this.textBoxBillNum.Size = new System.Drawing.Size(117, 20);
            this.textBoxBillNum.TabIndex = 3;
            this.textBoxBillNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(437, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "رقم الفاتورة";
            // 
            // textBoxCurrentDate
            // 
            this.textBoxCurrentDate.Location = new System.Drawing.Point(528, 18);
            this.textBoxCurrentDate.Name = "textBoxCurrentDate";
            this.textBoxCurrentDate.ReadOnly = true;
            this.textBoxCurrentDate.Size = new System.Drawing.Size(117, 20);
            this.textBoxCurrentDate.TabIndex = 1;
            this.textBoxCurrentDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(651, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "التاريخ";
            // 
            // textBoxAgentName
            // 
            this.textBoxAgentName.Location = new System.Drawing.Point(424, 16);
            this.textBoxAgentName.Name = "textBoxAgentName";
            this.textBoxAgentName.Size = new System.Drawing.Size(197, 20);
            this.textBoxAgentName.TabIndex = 14;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(627, 47);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(35, 13);
            this.labelDescription.TabIndex = 13;
            this.labelDescription.Text = "البيان:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(367, 42);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(254, 46);
            this.textBoxDescription.TabIndex = 12;
            // 
            // labelAgentName
            // 
            this.labelAgentName.AutoSize = true;
            this.labelAgentName.Location = new System.Drawing.Point(627, 19);
            this.labelAgentName.Name = "labelAgentName";
            this.labelAgentName.Size = new System.Drawing.Size(40, 13);
            this.labelAgentName.TabIndex = 11;
            this.labelAgentName.Text = "الاسم:";
            // 
            // textBoxAccouNum
            // 
            this.textBoxAccouNum.Location = new System.Drawing.Point(424, 16);
            this.textBoxAccouNum.Name = "textBoxAccouNum";
            this.textBoxAccouNum.Size = new System.Drawing.Size(169, 20);
            this.textBoxAccouNum.TabIndex = 10;
            // 
            // labelAccountNum
            // 
            this.labelAccountNum.AutoSize = true;
            this.labelAccountNum.Location = new System.Drawing.Point(599, 19);
            this.labelAccountNum.Name = "labelAccountNum";
            this.labelAccountNum.Size = new System.Drawing.Size(68, 13);
            this.labelAccountNum.TabIndex = 9;
            this.labelAccountNum.Text = "رقم الحساب:";
            // 
            // labelCurrency
            // 
            this.labelCurrency.AutoSize = true;
            this.labelCurrency.Location = new System.Drawing.Point(599, 70);
            this.labelCurrency.Name = "labelCurrency";
            this.labelCurrency.Size = new System.Drawing.Size(40, 13);
            this.labelCurrency.TabIndex = 7;
            this.labelCurrency.Text = "العملة:";
            // 
            // textBoxAgentPhone
            // 
            this.textBoxAgentPhone.Location = new System.Drawing.Point(435, 24);
            this.textBoxAgentPhone.Name = "textBoxAgentPhone";
            this.textBoxAgentPhone.Size = new System.Drawing.Size(157, 20);
            this.textBoxAgentPhone.TabIndex = 32;
            // 
            // labelLimit
            // 
            this.labelLimit.AutoSize = true;
            this.labelLimit.Location = new System.Drawing.Point(262, 27);
            this.labelLimit.Name = "labelLimit";
            this.labelLimit.Size = new System.Drawing.Size(50, 13);
            this.labelLimit.TabIndex = 31;
            this.labelLimit.Text = "حد الدين:";
            // 
            // textBoxLimit
            // 
            this.textBoxLimit.Location = new System.Drawing.Point(98, 24);
            this.textBoxLimit.Name = "textBoxLimit";
            this.textBoxLimit.Size = new System.Drawing.Size(158, 20);
            this.textBoxLimit.TabIndex = 30;
            this.textBoxLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelAgentPhone
            // 
            this.labelAgentPhone.AutoSize = true;
            this.labelAgentPhone.Location = new System.Drawing.Point(598, 27);
            this.labelAgentPhone.Name = "labelAgentPhone";
            this.labelAgentPhone.Size = new System.Drawing.Size(69, 13);
            this.labelAgentPhone.TabIndex = 27;
            this.labelAgentPhone.Text = "هاتف العميل:";
            // 
            // textBoxAccoName
            // 
            this.textBoxAccoName.Location = new System.Drawing.Point(367, 42);
            this.textBoxAccoName.Name = "textBoxAccoName";
            this.textBoxAccoName.Size = new System.Drawing.Size(226, 20);
            this.textBoxAccoName.TabIndex = 34;
            // 
            // labelAccountName
            // 
            this.labelAccountName.AutoSize = true;
            this.labelAccountName.Location = new System.Drawing.Point(596, 45);
            this.labelAccountName.Name = "labelAccountName";
            this.labelAccountName.Size = new System.Drawing.Size(73, 13);
            this.labelAccountName.TabIndex = 33;
            this.labelAccountName.Text = "اسم الحساب:";
            // 
            // textBoxCurrency
            // 
            this.textBoxCurrency.Location = new System.Drawing.Point(367, 67);
            this.textBoxCurrency.Name = "textBoxCurrency";
            this.textBoxCurrency.Size = new System.Drawing.Size(226, 20);
            this.textBoxCurrency.TabIndex = 36;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.buttonDelete);
            this.groupBox2.Controls.Add(this.buttonAdd);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(134, 638);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 512);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 47);
            this.button4.TabIndex = 3;
            this.button4.Text = "تحديث";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(6, 259);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(122, 47);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "حذف";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(6, 176);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(122, 47);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "إضافة";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = "جديد";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.labelAccountNum);
            this.groupBox3.Controls.Add(this.textBoxAccouNum);
            this.groupBox3.Controls.Add(this.textBoxCurrency);
            this.groupBox3.Controls.Add(this.textBoxAccoName);
            this.groupBox3.Controls.Add(this.labelAccountName);
            this.groupBox3.Controls.Add(this.labelCurrency);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(134, 50);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(673, 95);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "بيانات الحساب";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView2.Location = new System.Drawing.Point(3, 16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(358, 76);
            this.dataGridView2.TabIndex = 36;
            this.dataGridView2.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_CellMouseDoubleClick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(367, 15);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(51, 17);
            this.checkBox1.TabIndex = 35;
            this.checkBox1.Text = "عرض";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBox2);
            this.groupBox4.Controls.Add(this.dataGridView3);
            this.groupBox4.Controls.Add(this.labelAgentName);
            this.groupBox4.Controls.Add(this.textBoxAgentName);
            this.groupBox4.Controls.Add(this.labelDescription);
            this.groupBox4.Controls.Add(this.textBoxDescription);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(134, 145);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(673, 96);
            this.groupBox4.TabIndex = 39;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "بيانات العميل";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(367, 16);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(51, 17);
            this.checkBox2.TabIndex = 37;
            this.checkBox2.Text = "عرض";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView3.Location = new System.Drawing.Point(3, 16);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.Size = new System.Drawing.Size(358, 77);
            this.dataGridView3.TabIndex = 37;
            this.dataGridView3.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView3_CellMouseDoubleClick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkBox3);
            this.groupBox5.Controls.Add(this.textBoxCost);
            this.groupBox5.Controls.Add(this.labelCost);
            this.groupBox5.Controls.Add(this.textBoxUnitMeasurements);
            this.groupBox5.Controls.Add(this.labelUnitMeasurements);
            this.groupBox5.Controls.Add(this.textBoxQuantity);
            this.groupBox5.Controls.Add(this.labelQuantity);
            this.groupBox5.Controls.Add(this.textBoxItemName);
            this.groupBox5.Controls.Add(this.labelItemName);
            this.groupBox5.Controls.Add(this.dataGridView4);
            this.groupBox5.Controls.Add(this.textBoxItemNum);
            this.groupBox5.Controls.Add(this.labelItemNum);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(134, 241);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(673, 124);
            this.groupBox5.TabIndex = 40;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "بيانات الاصناف";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(390, 16);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(51, 17);
            this.checkBox3.TabIndex = 51;
            this.checkBox3.Text = "عرض";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(502, 94);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(98, 20);
            this.textBoxCost.TabIndex = 50;
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(606, 97);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(61, 13);
            this.labelCost.TabIndex = 49;
            this.labelCost.Text = "سعر الوحدة";
            // 
            // textBoxUnitMeasurements
            // 
            this.textBoxUnitMeasurements.Location = new System.Drawing.Point(340, 68);
            this.textBoxUnitMeasurements.Name = "textBoxUnitMeasurements";
            this.textBoxUnitMeasurements.Size = new System.Drawing.Size(260, 20);
            this.textBoxUnitMeasurements.TabIndex = 48;
            // 
            // labelUnitMeasurements
            // 
            this.labelUnitMeasurements.AutoSize = true;
            this.labelUnitMeasurements.Location = new System.Drawing.Point(606, 71);
            this.labelUnitMeasurements.Name = "labelUnitMeasurements";
            this.labelUnitMeasurements.Size = new System.Drawing.Size(36, 13);
            this.labelUnitMeasurements.TabIndex = 47;
            this.labelUnitMeasurements.Text = "الوحدة";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(340, 94);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(114, 20);
            this.textBoxQuantity.TabIndex = 46;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(460, 97);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(36, 13);
            this.labelQuantity.TabIndex = 45;
            this.labelQuantity.Text = "الكمية";
            // 
            // textBoxItemName
            // 
            this.textBoxItemName.Location = new System.Drawing.Point(340, 42);
            this.textBoxItemName.Name = "textBoxItemName";
            this.textBoxItemName.Size = new System.Drawing.Size(260, 20);
            this.textBoxItemName.TabIndex = 44;
            // 
            // labelItemName
            // 
            this.labelItemName.AutoSize = true;
            this.labelItemName.Location = new System.Drawing.Point(606, 45);
            this.labelItemName.Name = "labelItemName";
            this.labelItemName.Size = new System.Drawing.Size(61, 13);
            this.labelItemName.TabIndex = 43;
            this.labelItemName.Text = "اسم الصنف";
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView4.Location = new System.Drawing.Point(3, 16);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowHeadersVisible = false;
            this.dataGridView4.Size = new System.Drawing.Size(331, 105);
            this.dataGridView4.TabIndex = 38;
            this.dataGridView4.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView4_CellMouseDoubleClick);
            // 
            // textBoxItemNum
            // 
            this.textBoxItemNum.Location = new System.Drawing.Point(447, 16);
            this.textBoxItemNum.Name = "textBoxItemNum";
            this.textBoxItemNum.Size = new System.Drawing.Size(153, 20);
            this.textBoxItemNum.TabIndex = 42;
            // 
            // labelItemNum
            // 
            this.labelItemNum.AutoSize = true;
            this.labelItemNum.Location = new System.Drawing.Point(606, 19);
            this.labelItemNum.Name = "labelItemNum";
            this.labelItemNum.Size = new System.Drawing.Size(56, 13);
            this.labelItemNum.TabIndex = 41;
            this.labelItemNum.Text = "رقم الصنف";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dataGridView1);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox6.Location = new System.Drawing.Point(134, 365);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(673, 217);
            this.groupBox6.TabIndex = 41;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "عرض كلى";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(667, 198);
            this.dataGridView1.TabIndex = 52;
            // 
            // textBoxTotalBillCost
            // 
            this.textBoxTotalBillCost.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxTotalBillCost.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalBillCost.Location = new System.Drawing.Point(134, 595);
            this.textBoxTotalBillCost.Name = "textBoxTotalBillCost";
            this.textBoxTotalBillCost.ReadOnly = true;
            this.textBoxTotalBillCost.Size = new System.Drawing.Size(673, 26);
            this.textBoxTotalBillCost.TabIndex = 43;
            this.textBoxTotalBillCost.Text = "00";
            this.textBoxTotalBillCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelSalesBill
            // 
            this.labelSalesBill.AutoSize = true;
            this.labelSalesBill.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelSalesBill.Location = new System.Drawing.Point(134, 582);
            this.labelSalesBill.Name = "labelSalesBill";
            this.labelSalesBill.Size = new System.Drawing.Size(80, 13);
            this.labelSalesBill.TabIndex = 42;
            this.labelSalesBill.Text = "اجمالى الفاتورة:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.labelAgentPhone);
            this.groupBox7.Controls.Add(this.textBoxLimit);
            this.groupBox7.Controls.Add(this.labelLimit);
            this.groupBox7.Controls.Add(this.textBoxAgentPhone);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox7.Location = new System.Drawing.Point(134, 627);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(673, 61);
            this.groupBox7.TabIndex = 44;
            this.groupBox7.TabStop = false;
            // 
            // SalesBills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(807, 688);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.textBoxTotalBillCost);
            this.Controls.Add(this.labelSalesBill);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SalesBills";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فواتير مبيعات";
            this.Load += new System.EventHandler(this.SalesBills_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxAgentName;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelAgentName;
        private System.Windows.Forms.TextBox textBoxAccouNum;
        private System.Windows.Forms.Label labelAccountNum;
        private System.Windows.Forms.Label labelCurrency;
        private System.Windows.Forms.RadioButton radioButtonCash;
        private System.Windows.Forms.RadioButton radioButtonChique;
        private System.Windows.Forms.RadioButton radioButtonPostponed;
        private System.Windows.Forms.TextBox textBoxBillNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCurrentDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAgentPhone;
        private System.Windows.Forms.Label labelLimit;
        private System.Windows.Forms.TextBox textBoxLimit;
        private System.Windows.Forms.Label labelAgentPhone;
        private System.Windows.Forms.TextBox textBoxAccoName;
        private System.Windows.Forms.Label labelAccountName;
        private System.Windows.Forms.TextBox textBoxCurrency;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.TextBox textBoxUnitMeasurements;
        private System.Windows.Forms.Label labelUnitMeasurements;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.TextBox textBoxItemName;
        private System.Windows.Forms.Label labelItemName;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.TextBox textBoxItemNum;
        private System.Windows.Forms.Label labelItemNum;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxTotalBillCost;
        private System.Windows.Forms.Label labelSalesBill;
        private System.Windows.Forms.GroupBox groupBox7;
    }
}