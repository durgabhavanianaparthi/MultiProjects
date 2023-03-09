using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4_Bhavani_Emp
{
    public  class EmployeeConsoleEntry
    {
        string? connection;
        SqlConnection? con;
        string? query;
        public void AddEmployee()
        {
            Console.WriteLine("Enter Employee Name ");
            string EmpName = Console.ReadLine();
            Console.WriteLine("Enter Employee Age");
            int EmpAge = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Gender");
            string EmpGender = Console.ReadLine();
            Console.WriteLine("Enter Department ID Based on Employee");
            int DeptId = int.Parse(Console.ReadLine());



            connection = "Server=LAPTOP-4UV87UTN;Database=Durgabhavani;Trusted_Connection = true;TrustServerCertificate=True";
            con = new SqlConnection(connection);
            con.Open();

            query = "insert into  Emp values('" + EmpName + "'," + EmpAge + ",'" + EmpGender + "'," + DeptId + ")";
            SqlCommand cmd = new SqlCommand(query, con);
            int isDone = cmd.ExecuteNonQuery();
            con.Close();
            if (isDone == 1)
            {
                Console.WriteLine("Employee Record inserted Successfully");
            }
        }
    }
}

