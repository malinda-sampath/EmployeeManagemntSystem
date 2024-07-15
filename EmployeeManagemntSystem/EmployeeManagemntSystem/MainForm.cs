using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagemntSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if ( check == DialogResult.Yes)
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }   
        }

        private void dashboard1_Load(object sender, EventArgs e)
        {

        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = true;
            addEmployee1.Visible = false;
            salary1.Visible = false;

            Dashboard dashfForm = dashboard1 as Dashboard;

            if(dashfForm != null)
            {
                dashfForm.RefreshData();
            }
        }

        private void addEmployee_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addEmployee1.Visible = true;
            salary1.Visible = false;

            AddEmployee addEmForm = addEmployee1 as AddEmployee;

            if(addEmForm != null)
            {
                addEmForm.RefreshData();
            }
        }

        private void salary_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addEmployee1.Visible = false;
            salary1.Visible = true;

            Salary salaryForm = salary1 as Salary;

            if(salaryForm != null)
            {
                salaryForm.RefreshData();
            }
        }

        private void dashboard1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
