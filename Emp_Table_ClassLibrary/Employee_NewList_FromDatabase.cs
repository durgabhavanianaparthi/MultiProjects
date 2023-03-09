using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4_Bhavani_Emp
{
    public class Employee_NewList_FromDatabase: EmployeeProperties
    {
        string connection;
        SqlConnection con;
        string query;
        List<Employee_NewList_FromDatabase> newList = new List<Employee_NewList_FromDatabase>();
        public void EmployeeNewList()
        {
            connection = "Server=LAPTOP-4UV87UTN;Database=Durgabhavani;Trusted_Connection = true;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            query = "Select * from Emp";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    newList.Add(new Employee_NewList_FromDatabase()
                    {
                        EmpId = (int)dr["EmpId"],
                        EmpName = dr["EmpName"].ToString(),
                        EmpAge = (int)dr["EmpAge"],
                        EmpGender =Convert.ToChar( dr["EmpGender"].ToString()),
                        DeptId = (int)dr["DeptId"]
                    });
                }
                con.Close();
            }
        }
        public void DisplayNewList()
        {
            foreach (var item in newList)
            {
                Console.WriteLine("Employee ID : " + item.EmpId);
                Console.WriteLine("Employee Name : " + item.EmpName);
                Console.WriteLine("Employee Age : " + item.EmpAge);
                Console.WriteLine("Employee Gender : " + item.EmpGender);
                Console.WriteLine("Employee Dept ID : " + item.DeptId);
                Console.WriteLine("-------------------------------------------");
            }
        }
    }
}
    

