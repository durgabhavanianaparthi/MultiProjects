using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentTable
{
    public  class DepartmentConsoleEntry
    {  
            string? connection;
            SqlConnection? con;
            string? query;
            public void AddDepartment()
            {
                Console.WriteLine("Enter Department Name ");
                string DeptName = Console.ReadLine();
                Console.WriteLine("Enter Department Short Name"); 
                string DeptShortName = Console.ReadLine();



                connection = "Server=LAPTOP-4UV87UTN;Database=Durgabhavani;Trusted_Connection = true;TrustServerCertificate=True";
                con = new SqlConnection(connection);
                con.Open();
                query = "insert into Department values('" + DeptName + "','" + DeptShortName + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                int isDone = cmd.ExecuteNonQuery();
                con.Close();
                if (isDone == 1)
                {
                    Console.WriteLine("Department Record inserted Successfully");
                }
            }
        
    }
}
