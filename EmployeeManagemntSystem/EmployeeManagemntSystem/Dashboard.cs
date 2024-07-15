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
    public partial class Dashboard : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\malin\OneDrive\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30");
        public Dashboard()
        {
            InitializeComponent();

            displayAE();
            displayTE();
            displayIE();
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
            displayAE();
            displayTE();
            displayIE();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void displayTE()
        {
            if(connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT COUNT(id) FROM employees WHERE delete_date IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read()) 
                        {
                            int count = Convert.ToInt32(reader[0]);
                            dashboard_TE.Text = count.ToString();

                        }
                        reader.Close();
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

        public void displayAE()
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT COUNT(id) FROM employees WHERE status=@status AND " +
                        "delete_date IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@status", "Active");
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            dashboard_AE.Text = count.ToString();

                        }
                        reader.Close();
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

        public void displayIE()
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT COUNT(id) FROM employees WHERE status=@status AND " +
                        "delete_date IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@status", "Inactive");
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            dashboard_IE.Text = count.ToString();

                        }
                        reader.Close();
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
}
