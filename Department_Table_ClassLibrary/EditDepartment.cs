using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentTable
{
    public  class EditDepartment
    {
        string? connection = "Server=LAPTOP-4UV87UTN;Database=Durgabhavani;Trusted_Connection = true;TrustServerCertificate=True";
        SqlConnection? con;
        string? query;
        public void UpdateDepartmentData()
        {
            Console.WriteLine("Enter Department ID  where to Update ");
            int DeptId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Updated Department Name");
            string DeptName = Console.ReadLine();
            Console.WriteLine("Enter Department Short Name");
            string DeptShortName = Console.ReadLine();



            con = new SqlConnection(connection);
            con.Open();
            query = "update Department set DeptName='" + DeptName + "',DeptShortName='" + DeptShortName + "' where DeptId=" + DeptId + "";
            SqlCommand cmd = new SqlCommand(query, con);
            int objDone = cmd.ExecuteNonQuery();
            con.Close();
            if (objDone == 1)
            {
                Console.WriteLine("Updated Record Successfully");
            }
        }
        public void DeletDepartmentData()
        {
            Console.WriteLine("Enter Department ID  to Delete ");
            int DeptId = int.Parse(Console.ReadLine());
            con = new SqlConnection(connection);
            con.Open();
            query = "delete Department where DeptId=" + DeptId + "";
            SqlCommand cmd = new SqlCommand(query, con);
            int objDone = cmd.ExecuteNonQuery();
            cmd.Clone();
            if (objDone == 1)
            {
                Console.WriteLine("Department Record Deleted Successfully");
            }
        }
    }
}
