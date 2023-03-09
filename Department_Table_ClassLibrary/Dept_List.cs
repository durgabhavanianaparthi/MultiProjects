using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentTable
{
    public  class Dept_List: Properties
    {
        public List<Dept_List> Method()
        {
            List<Dept_List> departmentLists = new List<Dept_List>
            {
                new Dept_List { DeptId = 101, DeptName = "InformationTechnology", DeptShortName = "IT" },
                new Dept_List { DeptId = 102, DeptName = "HumanResource", DeptShortName = "HR" },
                new Dept_List { DeptId = 103, DeptName = "HealthDepartment", DeptShortName = "HD" },
                new Dept_List { DeptId = 104, DeptName = "ElectricityDepartment", DeptShortName = "ED" },
                new Dept_List { DeptId = 105, DeptName = "FinanceDepartment", DeptShortName = "FD" }
            };
            return departmentLists;
        }

    }
}
