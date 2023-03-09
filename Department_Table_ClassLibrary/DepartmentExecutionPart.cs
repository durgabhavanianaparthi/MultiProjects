using DepartmentTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department_Table_ClassLibrary
{
    public  class DepartmentExecutionPart
    {
        public void DepartmentExecuteMethod()
        {   
             Dept_DB_Connection obj1 = new Dept_DB_Connection();
            //obj1.InsertDepartmentDataIntoDB("Insert Into Department (DeptId,DeptName,DeptShortName) VALUES(@DeptName,@DeptShortName)");
            obj1.InsertDepartmentDataIntoDB("insert into Department values (@DeptName,@DeptShortName)");
            obj1.SelectDepartmentDataToNewList("select * from Department");
            obj1.DisplayNewList();
           
            DepartmentConsoleEntry objConsole = new DepartmentConsoleEntry();
            objConsole.AddDepartment();
            EditDepartment objEditDepartments = new EditDepartment();
            objEditDepartments.UpdateDepartmentData();
           objEditDepartments.DeletDepartmentData();
           // Dept_List obj = new Dept_List();
           // obj.Method();
            //GetNewDeparmentList obj2 = new GetNewDeparmentList();
           // obj2.DepartmentNewList();
            //obj2.DisplayNewList();
        }
    }
    
}
