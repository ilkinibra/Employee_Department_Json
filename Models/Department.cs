using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Json.Models
{
    class Department
    {
        public string Name { get; set; }
       public List<Employee> Employees { get; set; }
    }
}
