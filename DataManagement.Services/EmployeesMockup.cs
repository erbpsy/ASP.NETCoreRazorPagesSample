using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Management.Model;

namespace DataManagement.Services
{
    public class EmployeesMockup : IEmployee
    {
        private List<Employee> _employeeList;

        public EmployeesMockup()
        {
            _employeeList = new List<Employee>() {
                new Employee() { Id = 1, Name = "Bhanu Pratap", Gender = "Male", Department = Department.IT, Salary = 1250.45M, Email = "bhanu@razorpagessample.com", PhotoPath = "bhanu.png"},
                new Employee() { Id = 2, Name = "Deepak Vimal", Gender = "Male", Department = Department.IT, Salary = 1550.45M, Email = "deepak@razorpagessample.com", PhotoPath = "deepak.png"},
                new Employee() { Id = 3, Name = "Sandhya", Gender = "Female", Department = Department.IT, Salary = 1550.45M, Email = "sandhya@razorpagessample.com", PhotoPath = "sandhya.png"},
                new Employee() { Id = 4, Name = "Naval Kishore", Gender = "Male", Department = Department.IT, Salary = 1550.45M, Email = "naval@razorpagessample.com", PhotoPath = "naval.png"},
                new Employee() { Id = 5, Name = "Sonal Mlhotra", Gender = "Female", Department = Department.IT, Salary = 1550.45M, Email = "sonal@razorpagessample.com", PhotoPath = "sonal.png"},
                new Employee() { Id = 6, Name = "Kapil Sharma", Gender = "Male", Department = Department.HR, Salary = 1550.45M, Email = "kapil@razorpagessample.com", PhotoPath = "kapil.png"},
                new Employee() { Id = 7, Name = "Santosh Sharma", Gender = "Male", Department = Department.IT, Salary = 1550.45M, Email = "santosh@razorpagessample.com", PhotoPath = "santosh.png"}
            };
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }
       public Employee GetEmployee(int Id) {
           return _employeeList.FirstOrDefault(emp => emp.Id == Id);
        }
    }
}
