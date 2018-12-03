using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoSys.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public String LastName { get; set; }
        public String FirstName { get; set; }
        public DateTime TimeLogin { get; set; }
        public ICollection<States> States { get; set; }
    }
}