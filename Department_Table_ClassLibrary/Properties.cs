using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentTable
{
    public  class Properties
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public string DeptShortName { get; set; }



        //public void GetProperties()
        //{
        //    Console.WriteLine("Enter DeptID  ");
        //    DeptID = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Enter DeptName ");
        //    DeptName = Console.ReadLine();
        //    Console.WriteLine("Enter DeptShortName  ");
        //    DeptShortName= Console.ReadLine();
        //}
        //public void ShowStudent()
        //{
        //    Console.WriteLine("DeptID : {0}" + Environment.NewLine + "DeptName : {1}" + Environment.NewLine + "DeptShortName : {2}", this.DeptID, this.DeptName, this.DeptShortName);
        //}
    }



    public class Department
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
    }
}
       

