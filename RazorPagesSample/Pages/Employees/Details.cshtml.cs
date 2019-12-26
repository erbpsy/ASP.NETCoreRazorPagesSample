using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataManagement.Services;
using Management.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesSample.Pages.Employees
{
    public class DetailsModel : PageModel
    {
        public Employee employee { get; set; }
        public DetailsModel(IEmployee employeeRepository)
        {
            EmployeeRepository = employeeRepository;
        }

        public IEmployee EmployeeRepository { get; }

        public void OnGet(int Id)
        {
            employee = EmployeeRepository.GetEmployee(Id);
        }
    }
}