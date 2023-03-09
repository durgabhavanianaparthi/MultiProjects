// See https://aka.ms/new-console-template for more information
using Department_Table_ClassLibrary;
using Emp_Table_ClassLibrary;

Console.WriteLine("Hello, World!");

    Console.WriteLine("Select One Option" + Environment.NewLine + "1.Emp table" + Environment.NewLine + "2.Department table");
    int option1=0;
    option1 = int.Parse(Console.ReadLine());
    switch (option1)
    {
        case 1:
            EmpExecutablepart objEmpExecutablepart = new EmpExecutablepart();
            objEmpExecutablepart.ExecutableMethod();
            break;
        case 2:
        DepartmentExecutionPart objDepartmentExecutionPart = new DepartmentExecutionPart();

            objDepartmentExecutionPart.DepartmentExecuteMethod();
            break;
    }
