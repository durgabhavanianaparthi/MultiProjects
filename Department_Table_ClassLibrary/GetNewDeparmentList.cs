using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentTable
{
    public  class GetNewDeparmentList : Properties
    {
        string connection;
        SqlConnection con;
        string query;
        List<GetNewDeparmentList> newList = new List<GetNewDeparmentList>();
        public void DepartmentNewList()
        {
            connection = "Server=LAPTOP-4UV87UTN;Database=Durgabhavani;Trusted_Connection = true;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            query = "Select * from Department";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    newList.Add(new GetNewDeparmentList()
                    {
                        DeptId = (int)dr["DeptId"],
                        DeptName = dr["DeptName"].ToString(),
                        DeptShortName = dr["DeptShortName"].ToString(),

                    });
                }
                con.Close();
            }
        }
        public void DisplayNewList()
        {
            foreach (var item in newList)
            {
                Console.WriteLine("Department  ID : " + item.DeptId);
                Console.WriteLine("Department  Name : " + item.DeptName);
                Console.WriteLine("Department shortName : " + item.DeptShortName);
      
                Console.WriteLine("-------------------------------------------");
            }
        }
    }
}
    