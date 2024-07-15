using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EmployeeManagemntSystem
{
    public partial class Salary : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\malin\OneDrive\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30");
        public Salary()
        {
            InitializeComponent();
            displayEmployee();
            disableFields();
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
            displayEmployee();
            disableFields();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void disableFields() 
        {
            salary_employeeID.Enabled = false;
            salary_employeeName.Enabled = false;
            salary_employeePosition.Enabled = false;
        }

        public void displayEmployee()
        {
            //create an instance of the EmployeeData class
            SalaryData ed = new SalaryData();
            //referrence to the salaryEmployeeListData()
            List<SalaryData> listData = ed.salaryEmployeeListData();

            dataGridView1.DataSource = listData;
        }

        private void salary_updateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(salary_employeeID.Text) || string.IsNullOrEmpty(salary_employeeName.Text) ||
               string.IsNullOrEmpty(salary_employeePosition.Text) || string.IsNullOrEmpty(salary_employeeSalary.Text))
            {
                MessageBox.Show("Please fill all blank fields", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to UPDATE " +
                    "Employee ID: " + salary_employeeID.Text.Trim() + "?", "Confirmation Message",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (check == DialogResult.Yes)
                {
                    if (connect.State == ConnectionState.Closed)
                    {
                        try
                        {

                            connect.Open();

                            DateTime today = DateTime.Today;

                            string updateData = "UPDATE employees SET salary=@salary,update_date=@updateDate WHERE employee_id=@employeeID";

                            using (SqlCommand cmd = new SqlCommand(updateData,connect)) 
                            {
                                cmd.Parameters.AddWithValue("@salary", salary_employeeSalary.Text.Trim());
                                cmd.Parameters.AddWithValue("@updateDate",today);
                                cmd.Parameters.AddWithValue("@employeeID", salary_employeeID.Text.Trim());

                                cmd.ExecuteNonQuery();

                                displayEmployee();

                                MessageBox.Show("Updated successfully !", "Information Message", 
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                                clearFields();
                            }

                        }
                        catch (SqlException sqlEx)
                        {
                            MessageBox.Show("Sql error: " + sqlEx.Message, "Error Message",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message, "Error Message",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Cancelled", "Information Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public void clearFields()
        {
            salary_employeeID.Text = "";
            salary_employeeName.Text = "";
            salary_employeePosition.Text = "";
            salary_employeeSalary.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                salary_employeeID.Text = row.Cells[1].Value.ToString();
                salary_employeeName.Text = row.Cells[2].Value.ToString();
                salary_employeePosition.Text = row.Cells[3].Value.ToString();
                salary_employeeSalary.Text = row.Cells[4].Value.ToString();

            }
            else
            {
                // Handle the case when the header row or an invalid row is clicked
                // For example, you can show a message or just do nothing
                MessageBox.Show("Header row clicked. Please select a valid row.", "Error Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void salary_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}
