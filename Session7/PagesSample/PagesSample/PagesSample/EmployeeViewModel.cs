using System;
using System.Collections.Generic;
using System.Text;

namespace PagesSample
{
    class EmployeeViewModel
    {
        public List<Employee> Employees { get; set; }

        public EmployeeViewModel()
        {
            Employees = new Employee().getEmployee();
        }
    }
}
