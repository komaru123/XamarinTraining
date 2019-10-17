using System;
using System.Collections.Generic;
using System.Text;

namespace ListViewSample
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return FirstName + " " + LastName; } }
        public string Department { get; set; }
    }
}
