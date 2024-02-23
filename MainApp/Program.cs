using Domain;
using Infrastructure;

var emploees1 = new Emploee();
emploees1.FirstName="Kabir";
emploees1.LastName="Gafurov";
emploees1.BirthDate=new DateTime(2004,08,16);
emploees1.Salary=5000;

var emploeeServise=new EmployeeService();
emploeeServise.GetEmployees();
emploeeServise.AddEmoloyees(emploees1);
emploeeServise.CountEmployees();





var department1=new Department();
department1.Name="Naim";
department1.Desciption="Tojik";


var departmentServise=new DepartmentService();
departmentServise.GetDepartments();
departmentServise.AddDepartments(department1);
departmentServise.CountDepartments();


foreach (var item in emploeeServise.GetEmployees())
{
    System.Console.WriteLine(item.FirstName);
    System.Console.WriteLine(item.LastName);
    System.Console.WriteLine(item.Salary);
    System.Console.WriteLine(item.BirthDate);
}


