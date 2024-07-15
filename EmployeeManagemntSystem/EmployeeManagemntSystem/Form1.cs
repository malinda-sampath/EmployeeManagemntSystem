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
    public partial class Form1 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\malin\OneDrive\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30");
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void login_signupButton_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void login_password_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void login_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showPassword.Checked ? '\0' : '*';
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(login_username.Text) || string.IsNullOrEmpty(login_password.Text))
            {
                MessageBox.Show("Please fill all blank fields", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();

                        string selectData = "SELECT * FROM users WHERE username = @username AND password = @password";

                        using (SqlCommand cmd=new SqlCommand(selectData,connect))
                        {
                            cmd.Parameters.AddWithValue("@username", login_username.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", login_password.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if(table.Rows.Count >= 1)
                            {
                                MessageBox.Show("Login Successful !", "Information Message",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                                MainForm mainform = new MainForm();
                                mainform.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect username or password", "Information Message",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
