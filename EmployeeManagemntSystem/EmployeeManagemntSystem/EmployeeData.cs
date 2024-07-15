using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeeManagemntSystem
{
    class EmployeeData
    {
        public int ID { set; get; } //0
        public string EmployeeID { set; get; } //1
        public string Name { set; get; } //2
        public string Gender { set; get; } //3
        public string Contact {  set; get; } //4
        public string Position { set; get; } //5
        public string Image { set; get; } //6
        public decimal Salary { set; get; } //7
        public string Status { set; get; } //8
        public string Insert_Date { set; get; } //9
        public string Update_Date { set; get; } //10

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\malin\OneDrive\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30");

        public List<EmployeeData> employeeListData()
        {
            //creating a object called listdata
            List<EmployeeData> listdata =new List<EmployeeData>();

            if(connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM employees WHERE delete_date IS NULL";

                    using(SqlCommand cmd = new SqlCommand(selectData,connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            EmployeeData ed = new EmployeeData();
                            ed.ID = (int)reader["id"];
                            ed.EmployeeID = reader["employee_id"].ToString();
                            ed.Name = reader["full_name"].ToString();
                            ed.Gender = reader["gender"].ToString();
                            ed.Contact = reader["contact_number"].ToString();
                            ed.Position = reader["position"].ToString();
                            ed.Image = reader["image"].ToString();
                            ed.Salary = (decimal)reader["salary"];
                            ed.Status = reader["status"].ToString();
                            ed.Insert_Date = reader["insert_date"].ToString();
                            ed.Update_Date = reader["update_date"].ToString();

                            listdata.Add(ed);
                        }
                    }
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
