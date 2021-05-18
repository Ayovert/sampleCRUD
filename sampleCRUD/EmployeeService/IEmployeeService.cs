using System;
using System.Collections.Generic;
using sampleCRUD.Model;

namespace sampleCRUD.EmployeeService
{
    public interface IEmployeeService
    {
        Employee AddEmployee(Employee employee);

        List<Employee> GetEmployees();

        void UpdateEmployee(Employee employee);

        void DeleteEmployee(int Id);
        Employee GetEmployee(int Id);
    }
}
