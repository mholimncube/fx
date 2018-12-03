using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AwayFromKeyboard.Models;

namespace AwayFromKeyboard
{
    public class ValuesController : ApiController
    {
        //Get api/values
        public IEnumerable<Employee> GET()
        {
            return new List<Employee>()
            {
                new Employee() { Employee_ID = 1,Name = "Mholi"},
                new Employee() {Employee_ID = 2, Name ="new employee" }
                };
        }
        //Get api/values/5
        public Employee Get(int id)
        {
            if (id == 1)
            {
                return new Employee() { Employee_ID = 1, Name = "Mholi" };
            }
            else if (id == 2)
            {
                return new Employee() { Employee_ID = 2, Name = "new employee" };
            }
            return null;
        }
        //Post api/values
        //public void Post([FromBody]String value)
        //{

        //}
        //Put api/values/5
        //public void Put(int id, [FromBody]String value)
        //{

        //}
    }
}
