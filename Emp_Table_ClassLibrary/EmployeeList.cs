using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4_Bhavani_Emp
{
    public  class EmployeeList: EmployeeProperties
    {
        public List<EmployeeList> EmployeeListMethod()
        {
            List<EmployeeList> employeeList = new List<EmployeeList>
            {
                 new EmployeeList {EmpName = "Vinay", EmpAge = 20,EmpGender='M',DeptId=1},
                 new EmployeeList {EmpName = "Sravan", EmpAge = 21,EmpGender='M',DeptId=2},
                 new EmployeeList {EmpName = "Durga", EmpAge = 22,EmpGender='F',DeptId=3},
                 new EmployeeList {EmpName = "Mounika", EmpAge = 23,EmpGender='F',DeptId=4},
                 new EmployeeList {EmpName = "Dawood", EmpAge = 24,EmpGender='M',DeptId=5}
            };
            return employeeList;
        }
    }
}
