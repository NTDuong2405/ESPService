using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    public MyDbContext _dbContext = new MyDbContext();
    public Employee AddEmployee(Employee employee)
    {
        _dbContext.Employees.Add(employee);
        _dbContext.SaveChanges();
        return employee;
    }
    public List<Employee> GetListEmployee()
    {
        return _dbContext.Employees.ToList();
    }

    public List<Employee> GetEmployeeBySearch(string keyword)
    {
        return _dbContext.Employees.Where(d => d.Department.Contains(keyword)).ToList();
    }
}
