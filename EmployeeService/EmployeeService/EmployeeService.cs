using EmployeeService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
namespace EmployeeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeService" in both code and config file together.
    public class EmployeeService : IEmployeeService
    {
        public Employee GetEmployee(int id)
        {
            using (EmployeeDBEntities entities = new EmployeeDBEntities())
            {
                Employee employee = entities.spGetEmployee(id).Select(i => new Employee { dateOfBirth = i.DateOfBirth, gender = i.Gender, name = i.Name }).FirstOrDefault();
                return employee;
            }
        }

        public void SaveEmployee(Employee employee)
        {
            using (EmployeeDBEntities entities = new EmployeeDBEntities())
            {
                entities.spSaveEmployee(employee.name, employee.gender, employee.dateOfBirth);
                entities.SaveChanges();
            }
        }
    }
}
