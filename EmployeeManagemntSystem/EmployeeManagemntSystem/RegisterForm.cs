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
    public partial class RegisterForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\malin\OneDrive\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30");
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void register_loginButton_Click(object sender, EventArgs e)
        {
            Form1 loginfrom = new Form1();
            loginfrom.Show();
            this.Hide();
        }

        private void register_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            register_password.PasswordChar = register_showPassword.Checked ? '\0' : '*';
        }

        private void register_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void register_signupbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(register_username.Text) || string.IsNullOrEmpty(register_password.Text) || string.IsNullOrEmpty(register_Cfmpassword.Text)) //check whether username and password are empty in the register form
            {
                MessageBox.Show("Please fill all blank fields","Error Message",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if(connect.State != ConnectionState.Open)
                {
                    if ( register_password.Text == register_Cfmpassword.Text)
                    {
                        try
                        {
                            connect.Open();

                            //check username is already taken
                            string selectUsername = "SELECT COUNT(id) FROM users WHERE username = @user";

                            using (SqlCommand checkUser = new SqlCommand(selectUsername, connect))
                            {
                                checkUser.Parameters.AddWithValue("@user", register_username.Text.Trim());
                                int count = (int)checkUser.ExecuteScalar();

                                if (count >= 1)
                                {
                                    MessageBox.Show(register_username.Text.Trim() + " is already taken",
                                        "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }

                            DateTime today = DateTime.Today;

                            string insertData = " INSERT INTO users " +
                                "(username,password,date_register)" +
                                "VALUES(@username,@password,@dateReg)";
                            //'@username' in the SQL command string is a parameter placeholder

                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@username", register_username.Text.Trim());
                                cmd.Parameters.AddWithValue("@password", register_password.Text.Trim());
                                cmd.Parameters.AddWithValue("@dateReg", today);

                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Registered successfully", "Information Message",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                                Form1 loginform = new Form1();
                                loginform.Show();
                                this.Hide();
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
                        MessageBox.Show("Password not match", "Information Message",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void register_Cfmpassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void register_showCfmPassword_CheckedChanged(object sender, EventArgs e)
        {
            register_Cfmpassword.PasswordChar = register_showCfmPassword.Checked ? '\0' : '*';
        }
    }
}
