using ClassLibrary1;
using System.Data.SqlClient;

namespace Test4_Bhavani_Emp
{
    public class DB_Connection_Employee : EmployeeList
    {
       
            SqlConnection con;
            SqlCommand cmd;
            string conStr = "";
            public DB_Connection_Employee()
            {
                try
                {
                conStr = DB_Connection_project.conStr;
                }
                catch (System.Exception EX)
                {
                    Console.WriteLine(EX.Message);
                }
            }
            //private int EstablishingDbConnection(Query)
            //public getDataMethod(query)//establish db connection and execute query and get return type
            //public setdatamethod(query)
            private SqlConnection DBConnection(string query)
            {
                con = new SqlConnection(conStr);
                return con;
            }
            public string InsertEmployeeDataIntoDB(string query)
            {
                bool isDataInserted = true;
                var Emplist = EmployeeListMethod();
                foreach (var dept in Emplist)
                {
                    DBConnection(query);
                    cmd = new SqlCommand(query, con);
                    con.Open();
                    cmd.Parameters.Add("@EmpName", System.Data.SqlDbType.NVarChar, 100).Value = dept.EmpName;
                    cmd.Parameters.Add("@EmpAge", System.Data.SqlDbType.NVarChar, 100).Value = dept.EmpAge;
                    cmd.Parameters.Add("@Gender", System.Data.SqlDbType.NVarChar, 100).Value = dept.EmpGender;
                    cmd.Parameters.Add("@DeptID", System.Data.SqlDbType.NVarChar, 100).Value = dept.DeptId;
                    int result = cmd.ExecuteNonQuery();
                    if (result == 0)
                    {
                        isDataInserted = false;
                        break;
                    }
                    con.Close();
                }
                return isDataInserted == true ? "Success" : "Falied";
            }
            List<DB_Connection_Employee> newList = new List<DB_Connection_Employee>();
            public string SelectEmployeeDataToNewList(string query)
            {
                bool isDataSelected = true;
                DBConnection(query);
                con.Open();
                cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        newList.Add(new DB_Connection_Employee()
                        {
                            EmpId = (int)dr["EmpId"],
                            EmpName = dr["EmpName"].ToString(),
                            EmpAge = (int)dr["EmpAge"],
                            EmpGender = Convert.ToChar(dr["EmpGender"].ToString()),
                            DeptId = (int)dr["DeptId"]
                        });
                    }
                }
                con.Close();
                return isDataSelected == true ? "Successfully Selected From DataBase" : "No Data Selected";
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

        internal void InsertDepartmentDataIntoDB(string v)
        {
            throw new NotImplementedException();
        }

        internal void SelectEmployeeDataToNewList()
        {
            throw new NotImplementedException();
        }
    }
}

       