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
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace EmployeeManagemntSystem
{
    public partial class AddEmployee : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\malin\OneDrive\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30");

        public AddEmployee()
        {
            InitializeComponent();

            //to display the data from database to datagrid
            displayEmployeeData();
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
            displayEmployeeData();
        }

        public void displayEmployeeData()
        {
            EmployeeData ed = new EmployeeData();
            List<EmployeeData> listData = ed.employeeListData();

            dataGridView1.DataSource = listData;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void addemployee_addbtn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(addemployee_id.Text) || string.IsNullOrEmpty(addemployee_name.Text) ||
               string.IsNullOrEmpty(addemployee_gender.Text) || string.IsNullOrEmpty(addemployee_phoneNum.Text) ||
               string.IsNullOrEmpty(addemployee_position.Text) || string.IsNullOrEmpty(addemployee_status.Text) ||
               addemployee_picture.Image == null)
            {
                MessageBox.Show("Please fill all blank fields", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        string checkEmID = "SELECT * FROM employees WHERE employee_id = @emID AND delete_date IS NOT NULL";

                        using(SqlCommand cmd = new SqlCommand(checkEmID,connect))
                        {
                            cmd.Parameters.AddWithValue(@"emID", addemployee_id.Text.Trim());
                            object result = cmd.ExecuteScalar();
                            int count = (result != null) ? Convert.ToInt32(result) : 0;

                            if (count >= 1)
                            {
                                MessageBox.Show(addemployee_id.Text.Trim() + " is already taken",
                                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;

                                string insertData = "INSERT INTO employees" + "(employee_id,full_name," +
                                    "gender,contact_number,position,image,salary,insert_date,status)" +
                                    "VALUES (@employeeID,@fullName,@gender,@contactNo,@position,@image" +
                                    ",@salary,@insertDate,@status)";

                                string path = Path.Combine(@"D:\Study\C#\Projects\EmployeeManagemntSystem\EmployeeManagemntSystem\Directory\"
                                                        +addemployee_id.Text.Trim() + ".jpg");

                                string directotyPath = Path.GetDirectoryName(path);

                                if (!Directory.Exists(directotyPath))
                                {
                                    Directory.CreateDirectory(directotyPath);
                                }

                                File.Copy(addemployee_picture.ImageLocation, path, true);

                                using (SqlCommand command = new SqlCommand(insertData, connect))
                                {
                                    command.Parameters.AddWithValue("@employeeID",addemployee_id.Text.Trim());
                                    command.Parameters.AddWithValue("@fullName", addemployee_name.Text.Trim());
                                    command.Parameters.AddWithValue("@gender", addemployee_gender.Text.Trim());
                                    command.Parameters.AddWithValue("@contactNo", addemployee_phoneNum.Text.Trim());
                                    command.Parameters.AddWithValue("@position", addemployee_position.Text.Trim());
                                    command.Parameters.AddWithValue("@image", path);
                                    command.Parameters.AddWithValue("@salary", 0);
                                    command.Parameters.AddWithValue("@insertDate", today);
                                    command.Parameters.AddWithValue("@status", addemployee_status.Text.Trim());

                                    command.ExecuteNonQuery();

                                    displayEmployeeData();

                                    MessageBox.Show("Added successfully !", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    clearFields();
                                }
                            }
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
        }

        private void addemployee_importPicture_btn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg; *.png)|*.jpg; *.png";
                string imagePath = "";

                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    addemployee_picture.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked row is a valid data row
            if (e.RowIndex != -1)
            {
                // Retrieve the selected row
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Populate form fields with data from the selected row
                addemployee_id.Text = row.Cells[1].Value.ToString();

                //to prevent update the id
                //id box is in readonly mod
                //when the clear method called it again became normal state
                addemployee_id.Enabled = false;

                //prevent updating picture
                addemployee_importPicture_btn.Enabled = false;

                addemployee_name.Text = row.Cells[2].Value.ToString();
                addemployee_gender.Text = row.Cells[3].Value.ToString();
                addemployee_phoneNum.Text = row.Cells[4].Value.ToString();
                addemployee_position.Text = row.Cells[5].Value.ToString();


                // Handle the employee picture
                string imagePath = row.Cells[6].Value?.ToString();

                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    try
                    {
                        addemployee_picture.Image = Image.FromFile(imagePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading image: {ex.Message}");
                        addemployee_picture.Image = null;
                    }
                }
                else
                {
                    addemployee_picture.Image = null;
}
                addemployee_status.Text = row.Cells[8].Value.ToString();
            }
            else
            {
                // Handle the case when the header row or an invalid row is clicked
                // For example, you can show a message or just do nothing
                MessageBox.Show("Header row clicked. Please select a valid row.", "Error Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void clearFields()
        {
            addemployee_id.Text = "";

            //bring id box in to normal state
            //this desabled when the grid clicked
            addemployee_id.Enabled = true;
            //enable image btn
            addemployee_importPicture_btn.Enabled = true;

            addemployee_name.Text = "";
            addemployee_gender.SelectedIndex = -1;
            addemployee_phoneNum.Text = "";
            addemployee_position.SelectedIndex = -1;
            addemployee_status.SelectedIndex = -1;
            addemployee_picture.Image = null;
        }

        private void addemplyee_updatebtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(addemployee_id.Text) || string.IsNullOrEmpty(addemployee_name.Text) ||
               string.IsNullOrEmpty(addemployee_gender.Text) || string.IsNullOrEmpty(addemployee_phoneNum.Text) ||
               string.IsNullOrEmpty(addemployee_position.Text) || string.IsNullOrEmpty(addemployee_status.Text))
            {
                MessageBox.Show("Please fill all blank fields", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to UPDATE " +
                    "Employee ID: " + addemployee_id.Text.Trim() + "?", "Confirmation Message",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();
                        DateTime today = DateTime.Now;

                        string updateData = "UPDATE employees SET full_name=@fullName, gender=@gender, " +
                                "contact_number=@contactNo, position=@position, " +
                                "update_date=@updateDate, status=@status WHERE employee_id=@employeeID";

                        
                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@fullname",addemployee_name.Text.Trim());
                            cmd.Parameters.AddWithValue("@gender", addemployee_gender.Text.Trim());
                            cmd.Parameters.AddWithValue("@contactNo", addemployee_phoneNum.Text.Trim());
                            cmd.Parameters.AddWithValue("@position", addemployee_position.Text.Trim());
                            cmd.Parameters.AddWithValue("@updateDate", today);
                            cmd.Parameters.AddWithValue("@status", addemployee_status.Text.Trim());
                            cmd.Parameters.AddWithValue("@employeeID", addemployee_id.Text.Trim());

                            cmd.ExecuteNonQuery();

                            displayEmployeeData();

                            MessageBox.Show("Updated successfully !", "Information Message", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();
                            displayEmployeeData();

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
                else
                {
                    MessageBox.Show("Cancelled", "Information Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void addemployee_clearbtn_Click_1(object sender, EventArgs e)
        {
            clearFields();
        }

        private void addemployee_deletebtn_Click_1(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(addemployee_id.Text) || string.IsNullOrEmpty(addemployee_name.Text) ||
               string.IsNullOrEmpty(addemployee_gender.Text) || string.IsNullOrEmpty(addemployee_phoneNum.Text) ||
               string.IsNullOrEmpty(addemployee_position.Text) || string.IsNullOrEmpty(addemployee_status.Text))
            {
                MessageBox.Show("Please fill all blank fields", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to Delete " +
                        "Employee ID: " + addemployee_id.Text.Trim() + "?", "Confirmation Message",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();
                        DateTime today = DateTime.Today;

                        string updateData = "UPDATE employees SET delete_date = @deleteDate " +
                        "WHERE employee_id=@employeeID";


                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@deleteDate", today);
                            cmd.Parameters.AddWithValue("@employeeID", addemployee_id.Text.Trim());

                            cmd.ExecuteNonQuery();

                            displayEmployeeData();

                            MessageBox.Show("Deleted successfully !", "Information Message",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();
                            displayEmployeeData();

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
                else
                {
                    MessageBox.Show("Cancelled", "Information Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            displayEmployeeData();
        }

    }
}
