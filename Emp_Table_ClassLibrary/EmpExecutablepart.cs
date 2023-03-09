using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test4_Bhavani_Emp;

namespace Emp_Table_ClassLibrary
{
   public  class EmpExecutablepart
   {
        public void ExecutableMethod()
        {  
        DB_Connection_Employee objDB_Connection_Employee = new DB_Connection_Employee();
        objDB_Connection_Employee.InsertEmployeeDataIntoDB("Insert Into Emp (EmpName, EmpAge,EmpGender,DeptId) VALUES(@EmpName,@EmpAge,@Gender,@DeptId)");

         objDB_Connection_Employee.SelectEmployeeDataToNewList("select * From Emp");
         objDB_Connection_Employee.DisplayNewList();


            EmployeeConsoleEntry obj = new EmployeeConsoleEntry();
            obj.AddEmployee();

            EditEmployee objEditEmployee = new EditEmployee();
            objEditEmployee.UpdateEmployeeData();
            objEditEmployee.DeleteEmployeeData();
            EmployeeList objEmployeeList = new EmployeeList();
            objEmployeeList.EmployeeListMethod();
            Employee_NewList_FromDatabase objEmployee_NewList_FromDatabase = new Employee_NewList_FromDatabase();
            objEmployee_NewList_FromDatabase.EmployeeNewList();
            objEmployee_NewList_FromDatabase.DisplayNewList();


        }
    }
}
