using ClassLibrary1;
using System.Data.SqlClient;

namespace DepartmentTable
{
    public  class Dept_DB_Connection : Dept_List
    {


        SqlConnection con;
        SqlCommand cmd;
        string conStr = "";
        public Dept_DB_Connection()
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
        public string InsertDepartmentDataIntoDB(string query)
        {
            bool isDataInserted = true;
            var Depttlist = Method();
            foreach (var dept in Depttlist)
            {
                DBConnection(query);
                cmd = new SqlCommand(query, con);
                con.Open();
                //cmd.Parameters.Add("@DeptId", System.Data.SqlDbType.Int).Value = dept.DeptId;
                cmd.Parameters.Add("@DeptName", System.Data.SqlDbType.NVarChar, 100).Value = dept.DeptName;
                cmd.Parameters.Add("@DeptShortName", System.Data.SqlDbType.NVarChar, 100).Value = dept.DeptShortName;
             
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
        List<Dept_DB_Connection> newList = new List<Dept_DB_Connection>();
        public string SelectDepartmentDataToNewList(string query)
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
                    newList.Add(new Dept_DB_Connection()
                    {
                        DeptId = (int)dr["DeptId"],
                        DeptName = dr["DeptName"].ToString(),
                        DeptShortName = dr["DeptShortName"].ToString()
                     
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
                Console.WriteLine("Department ID : " + item.DeptId);
                Console.WriteLine("Department Name : " + item.DeptName);
                Console.WriteLine("Department ShortName : " + item.DeptShortName);


                Console.WriteLine("-------------------------------------------");
            }
        }

        //internal void InsertDepartmentDataIntoDB()
        //{
        //    throw new NotImplementedException();
        //}

        //internal void SelectDepartmentDataToNewList(string v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
    

