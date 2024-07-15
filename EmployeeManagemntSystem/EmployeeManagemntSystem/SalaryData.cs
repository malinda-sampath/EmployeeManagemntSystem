using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace EmployeeManagemntSystem
{
    internal class SalaryData
    {
        public int ID { set; get; } //0
        public string EmployeeID { set; get; } //1
        public string Name { set; get; } //2
        public string Position { set; get; } //3
        public decimal Salary { set; get; } //4

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\malin\OneDrive\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30");

        public List<SalaryData> salaryEmployeeListData()
        {
            //creating a object called listdata
            List<SalaryData> listdata = new List<SalaryData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM employees WHERE status = 'Active' AND delete_date IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            SalaryData sd = new SalaryData();
                            sd.ID = (int)reader["id"];
                            sd.EmployeeID = reader["employee_id"].ToString();
                            sd.Name = reader["full_name"].ToString();
                            sd.Position = reader["position"].ToString();
                            sd.Salary = (decimal)reader["salary"];

                            listdata.Add(sd);
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

            return listdata;
        }

    }
}
