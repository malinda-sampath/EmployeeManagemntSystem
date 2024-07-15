namespace EmployeeManagemntSystem
{
    partial class Salary
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.salary_clearBtn = new System.Windows.Forms.Button();
            this.salary_updateBtn = new System.Windows.Forms.Button();
            this.salary_employeeSalary = new System.Windows.Forms.TextBox();
            this.salary_employeePosition = new System.Windows.Forms.TextBox();
            this.salary_employeeName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.salary_employeeID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.salary_clearBtn);
            this.panel1.Controls.Add(this.salary_updateBtn);
            this.panel1.Controls.Add(this.salary_employeeSalary);
            this.panel1.Controls.Add(this.salary_employeePosition);
            this.panel1.Controls.Add(this.salary_employeeName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.salary_employeeID);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(12, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 536);
            this.panel1.TabIndex = 0;
            // 
            // salary_clearBtn
            // 
            this.salary_clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.salary_clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salary_clearBtn.FlatAppearance.BorderSize = 0;
            this.salary_clearBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(137)))));
            this.salary_clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(137)))));
            this.salary_clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(137)))));
            this.salary_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salary_clearBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary_clearBtn.ForeColor = System.Drawing.Color.White;
            this.salary_clearBtn.Location = new System.Drawing.Point(140, 325);
            this.salary_clearBtn.Name = "salary_clearBtn";
            this.salary_clearBtn.Size = new System.Drawing.Size(105, 42);
            this.salary_clearBtn.TabIndex = 5;
            this.salary_clearBtn.Text = "Clear";
            this.salary_clearBtn.UseVisualStyleBackColor = false;
            this.salary_clearBtn.Click += new System.EventHandler(this.salary_clearBtn_Click);
            // 
            // salary_updateBtn
            // 
            this.salary_updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.salary_updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salary_updateBtn.FlatAppearance.BorderSize = 0;
            this.salary_updateBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(137)))));
            this.salary_updateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(137)))));
            this.salary_updateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(137)))));
            this.salary_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salary_updateBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary_updateBtn.ForeColor = System.Drawing.Color.White;
            this.salary_updateBtn.Location = new System.Drawing.Point(18, 325);
            this.salary_updateBtn.Name = "salary_updateBtn";
            this.salary_updateBtn.Size = new System.Drawing.Size(105, 42);
            this.salary_updateBtn.TabIndex = 5;
            this.salary_updateBtn.Text = "Update";
            this.salary_updateBtn.UseVisualStyleBackColor = false;
            this.salary_updateBtn.Click += new System.EventHandler(this.salary_updateBtn_Click);
            // 
            // salary_employeeSalary
            // 
            this.salary_employeeSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.salary_employeeSalary.Location = new System.Drawing.Point(28, 260);
            this.salary_employeeSalary.Multiline = true;
            this.salary_employeeSalary.Name = "salary_employeeSalary";
            this.salary_employeeSalary.Size = new System.Drawing.Size(210, 25);
            this.salary_employeeSalary.TabIndex = 3;
            // 
            // salary_employeePosition
            // 
            this.salary_employeePosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.salary_employeePosition.Location = new System.Drawing.Point(28, 197);
            this.salary_employeePosition.Multiline = true;
            this.salary_employeePosition.Name = "salary_employeePosition";
            this.salary_employeePosition.Size = new System.Drawing.Size(210, 25);
            this.salary_employeePosition.TabIndex = 3;
            // 
            // salary_employeeName
            // 
            this.salary_employeeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.salary_employeeName.Location = new System.Drawing.Point(28, 132);
            this.salary_employeeName.Multiline = true;
            this.salary_employeeName.Name = "salary_employeeName";
            this.salary_employeeName.Size = new System.Drawing.Size(210, 25);
            this.salary_employeeName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 14);
            this.label4.TabIndex = 2;
            this.label4.Text = "Salary:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Position: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Full Name:";
            // 
            // salary_employeeID
            // 
            this.salary_employeeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.salary_employeeID.Location = new System.Drawing.Point(28, 69);
            this.salary_employeeID.Multiline = true;
            this.salary_employeeID.Name = "salary_employeeID";
            this.salary_employeeID.Size = new System.Drawing.Size(210, 25);
            this.salary_employeeID.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(25, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 14);
            this.label11.TabIndex = 2;
            this.label11.Text = "Employee ID:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(297, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(563, 536);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employees";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(19, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(524, 469);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Salary";
            this.Size = new System.Drawing.Size(875, 565);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox salary_employeePosition;
        private System.Windows.Forms.TextBox salary_employeeName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox salary_employeeID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox salary_employeeSalary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button salary_clearBtn;
        private System.Windows.Forms.Button salary_updateBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
