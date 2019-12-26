using Management.Model;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DataManagement.Services
{
    public interface IEmployee
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployee(int Id);
    }
}
