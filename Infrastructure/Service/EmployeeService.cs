using Domain;

namespace Infrastructure;

public class EmployeeService
{

   List<Emploee> _employees= new List<Emploee>();

    public List<Emploee> GetEmployees()
    {
        return _employees;
    }
    public void AddEmoloyees(Emploee emploee)
    {
        _employees.Add(emploee);
    }
     public int CountEmployees()
     {
        return _employees.Count;
     }

}
