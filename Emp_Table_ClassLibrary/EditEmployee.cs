using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4_Bhavani_Emp
{
    public class EditEmployee
    {
        string? connection = "Server=LAPTOP-4UV87UTN;Database=Durgabhavani;Trusted_Connection = true;TrustServerCertificate=True";
        SqlConnection? con;
        string? query;
        public void UpdateEmployeeData()
        {
            Console.WriteLine("Enter EmployeeID where to Update ");
            int eId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Updated Employee Name");
            string eName = Console.ReadLine();

            con = new SqlConnection(connection);
            con.Open();
            query = "update Emp set EmpName='" + eName + "' where EmpId=" + eId + "";
            SqlCommand cmd = new SqlCommand(query, con);
            int objDone = cmd.ExecuteNonQuery();
            cmd.Clone();
            if (objDone == 1)
            {
                Console.WriteLine("Updated Record Successfully");
            }
        }
        public void DeleteEmployeeData()
        {
            Console.WriteLine("Enter EmployeeID  to Delete ");
            int eId = int.Parse(Console.ReadLine());



            con = new SqlConnection(connection);
            con.Open();
            query = "delete Emp where EmpId=" + eId + "";
            SqlCommand cmd = new SqlCommand(query, con);
            int objDone = cmd.ExecuteNonQuery();
            cmd.Clone();
            if (objDone == 1)
            {
                Console.WriteLine("Employee Record Deleted Successfully");
            }
        }
    }
}
