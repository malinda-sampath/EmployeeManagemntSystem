namespace EmployeeManagemntSystem
{
    partial class AddEmployee
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.addemployee_clearbtn = new System.Windows.Forms.Button();
            this.addemployee_deletebtn = new System.Windows.Forms.Button();
            this.addemplyee_updatebtn = new System.Windows.Forms.Button();
            this.addemployee_addbtn = new System.Windows.Forms.Button();
            this.addemployee_importPicture_btn = new System.Windows.Forms.Button();
            this.addemployee_picture = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addemployee_position = new System.Windows.Forms.ComboBox();
            this.addemployee_status = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.addemployee_gender = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.addemployee_name = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.addemployee_phoneNum = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.addemployee_id = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addemployee_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(14, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 271);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(821, 220);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee\'s Data";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(14, 302);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(846, 248);
            this.panel2.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(560, 173);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(105, 42);
            this.button5.TabIndex = 4;
            this.button5.Text = "Add";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(435, 173);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 42);
            this.button4.TabIndex = 4;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(288, 173);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 42);
            this.button3.TabIndex = 4;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(163, 173);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 42);
            this.button2.TabIndex = 4;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(734, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Import";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(725, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 110);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.comboBox2.Location = new System.Drawing.Point(449, 53);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(215, 21);
            this.comboBox2.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(400, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Gender:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.comboBox1.Location = new System.Drawing.Point(98, 82);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(215, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Gender:";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(97, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(216, 20);
            this.textBox2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Full Name:";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(449, 14);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(216, 20);
            this.textBox3.TabIndex = 1;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(366, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Phone Number:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(97, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Employee\'s ID:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.addemployee_clearbtn);
            this.panel3.Controls.Add(this.addemployee_deletebtn);
            this.panel3.Controls.Add(this.addemplyee_updatebtn);
            this.panel3.Controls.Add(this.addemployee_addbtn);
            this.panel3.Controls.Add(this.addemployee_importPicture_btn);
            this.panel3.Controls.Add(this.addemployee_picture);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.addemployee_position);
            this.panel3.Controls.Add(this.addemployee_status);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.addemployee_gender);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.addemployee_name);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.addemployee_phoneNum);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.addemployee_id);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel3.Location = new System.Drawing.Point(14, 302);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(846, 248);
            this.panel3.TabIndex = 0;
            // 
            // addemployee_clearbtn
            // 
            this.addemployee_clearbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.addemployee_clearbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addemployee_clearbtn.FlatAppearance.BorderSize = 0;
            this.addemployee_clearbtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(137)))));
            this.addemployee_clearbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(137)))));
            this.addemployee_clearbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(137)))));
            this.addemployee_clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addemployee_clearbtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addemployee_clearbtn.ForeColor = System.Drawing.Color.White;
            this.addemployee_clearbtn.Location = new System.Drawing.Point(560, 173);
            this.addemployee_clearbtn.Name = "addemployee_clearbtn";
            this.addemployee_clearbtn.Size = new System.Drawing.Size(105, 42);
            this.addemployee_clearbtn.TabIndex = 4;
            this.addemployee_clearbtn.Text = "Clear";
            this.addemployee_clearbtn.UseVisualStyleBackColor = false;
            this.addemployee_clearbtn.Click += new System.EventHandler(this.addemployee_clearbtn_Click_1);
            // 
            // addemployee_deletebtn
            // 
            this.addemployee_deletebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.addemployee_deletebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addemployee_deletebtn.FlatAppearance.BorderSize = 0;
            this.addemployee_deletebtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(137)))));
            this.addemployee_deletebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(137)))));
            this.addemployee_deletebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(137)))));
            this.addemployee_deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addemployee_deletebtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addemployee_deletebtn.ForeColor = System.Drawing.Color.White;
            this.addemployee_deletebtn.Location = new System.Drawing.Point(435, 173);
            this.addemployee_deletebtn.Name = "addemployee_deletebtn";
            this.addemployee_deletebtn.Size = new System.Drawing.Size(105, 42);
            this.addemployee_deletebtn.TabIndex = 4;
            this.addemployee_deletebtn.Text = "Delete";
            this.addemployee_deletebtn.UseVisualStyleBackColor = false;
            this.addemployee_deletebtn.Click += new System.EventHandler(this.addemployee_deletebtn_Click_1);
            // 
            // addemplyee_updatebtn
            // 
            this.addemplyee_updatebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.addemplyee_updatebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addemplyee_updatebtn.FlatAppearance.BorderSize = 0;
            this.addemplyee_updatebtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(137)))));
            this.addemplyee_updatebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(137)))));
            this.addemplyee_updatebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(137)))));
            this.addemplyee_updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addemplyee_updatebtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addemplyee_updatebtn.ForeColor = System.Drawing.Color.White;
            this.addemplyee_updatebtn.Location = new System.Drawing.Point(288, 173);
            this.addemplyee_updatebtn.Name = "addemplyee_updatebtn";
            this.addemplyee_updatebtn.Size = new System.Drawing.Size(105, 42);
            this.addemplyee_updatebtn.TabIndex = 4;
            this.addemplyee_updatebtn.Text = "Update";
            this.addemplyee_updatebtn.UseVisualStyleBackColor = false;
            this.addemplyee_updatebtn.Click += new System.EventHandler(this.addemplyee_updatebtn_Click);
            // 
            // addemployee_addbtn
            // 
            this.addemployee_addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.addemployee_addbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addemployee_addbtn.FlatAppearance.BorderSize = 0;
            this.addemployee_addbtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(137)))));
            this.addemployee_addbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(137)))));
            this.addemployee_addbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(137)))));
            this.addemployee_addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addemployee_addbtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addemployee_addbtn.ForeColor = System.Drawing.Color.White;
            this.addemployee_addbtn.Location = new System.Drawing.Point(163, 173);
            this.addemployee_addbtn.Name = "addemployee_addbtn";
            this.addemployee_addbtn.Size = new System.Drawing.Size(105, 42);
            this.addemployee_addbtn.TabIndex = 4;
            this.addemployee_addbtn.Text = "Add";
            this.addemployee_addbtn.UseVisualStyleBackColor = false;
            this.addemployee_addbtn.Click += new System.EventHandler(this.addemployee_addbtn_Click);
            // 
            // addemployee_importPicture_btn
            // 
            this.addemployee_importPicture_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.addemployee_importPicture_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addemployee_importPicture_btn.FlatAppearance.BorderSize = 0;
            this.addemployee_importPicture_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(137)))));
            this.addemployee_importPicture_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(137)))));
            this.addemployee_importPicture_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addemployee_importPicture_btn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addemployee_importPicture_btn.ForeColor = System.Drawing.Color.White;
            this.addemployee_importPicture_btn.Location = new System.Drawing.Point(734, 159);
            this.addemployee_importPicture_btn.Name = "addemployee_importPicture_btn";
            this.addemployee_importPicture_btn.Size = new System.Drawing.Size(70, 23);
            this.addemployee_importPicture_btn.TabIndex = 4;
            this.addemployee_importPicture_btn.Text = "Import";
            this.addemployee_importPicture_btn.UseVisualStyleBackColor = false;
            this.addemployee_importPicture_btn.Click += new System.EventHandler(this.addemployee_importPicture_btn_Click);
            // 
            // addemployee_picture
            // 
            this.addemployee_picture.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.addemployee_picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addemployee_picture.Location = new System.Drawing.Point(725, 45);
            this.addemployee_picture.Name = "addemployee_picture";
            this.addemployee_picture.Size = new System.Drawing.Size(86, 110);
            this.addemployee_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addemployee_picture.TabIndex = 3;
            this.addemployee_picture.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(399, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Position:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // addemployee_position
            // 
            this.addemployee_position.FormattingEnabled = true;
            this.addemployee_position.Items.AddRange(new object[] {
            "Business Management",
            "Front-End Developer",
            "Back-End Developer",
            "Data Administrator",
            "UI/UX Designer"});
            this.addemployee_position.Location = new System.Drawing.Point(448, 63);
            this.addemployee_position.Name = "addemployee_position";
            this.addemployee_position.Size = new System.Drawing.Size(179, 21);
            this.addemployee_position.TabIndex = 2;
            // 
            // addemployee_status
            // 
            this.addemployee_status.FormattingEnabled = true;
            this.addemployee_status.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.addemployee_status.Location = new System.Drawing.Point(448, 100);
            this.addemployee_status.Name = "addemployee_status";
            this.addemployee_status.Size = new System.Drawing.Size(179, 21);
            this.addemployee_status.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(403, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Status:";
            // 
            // addemployee_gender
            // 
            this.addemployee_gender.FormattingEnabled = true;
            this.addemployee_gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.addemployee_gender.Location = new System.Drawing.Point(98, 100);
            this.addemployee_gender.Name = "addemployee_gender";
            this.addemployee_gender.Size = new System.Drawing.Size(186, 21);
            this.addemployee_gender.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(49, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Gender:";
            // 
            // addemployee_name
            // 
            this.addemployee_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addemployee_name.Location = new System.Drawing.Point(97, 63);
            this.addemployee_name.Name = "addemployee_name";
            this.addemployee_name.Size = new System.Drawing.Size(216, 20);
            this.addemployee_name.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(38, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Full Name:";
            // 
            // addemployee_phoneNum
            // 
            this.addemployee_phoneNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addemployee_phoneNum.Location = new System.Drawing.Point(449, 25);
            this.addemployee_phoneNum.Name = "addemployee_phoneNum";
            this.addemployee_phoneNum.Size = new System.Drawing.Size(178, 20);
            this.addemployee_phoneNum.TabIndex = 1;
            this.addemployee_phoneNum.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(366, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Phone Number:";
            this.label10.Click += new System.EventHandler(this.label5_Click);
            // 
            // addemployee_id
            // 
            this.addemployee_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addemployee_id.Location = new System.Drawing.Point(97, 24);
            this.addemployee_id.Name = "addemployee_id";
            this.addemployee_id.Size = new System.Drawing.Size(132, 20);
            this.addemployee_id.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Employee\'s ID:";
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddEmployee";
            this.Size = new System.Drawing.Size(875, 565);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addemployee_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button addemployee_clearbtn;
        private System.Windows.Forms.Button addemployee_deletebtn;
        private System.Windows.Forms.Button addemplyee_updatebtn;
        private System.Windows.Forms.Button addemployee_addbtn;
        private System.Windows.Forms.Button addemployee_importPicture_btn;
        private System.Windows.Forms.PictureBox addemployee_picture;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox addemployee_gender;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox addemployee_name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox addemployee_phoneNum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox addemployee_id;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox addemployee_status;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox addemployee_position;
    }
}
