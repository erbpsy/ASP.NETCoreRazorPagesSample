using System;
using System.Collections.Generic;
using System.Text;

namespace Management.Model
{
  public class Employee 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Gender { get; set; }
        public Department? Department { get; set; }
        public string PhotoPath { get; set; }
        public string Email { get; set; }
    }
}
