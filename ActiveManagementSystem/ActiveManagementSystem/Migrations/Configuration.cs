using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ActiveManagementSystem.Models;
using System.Data.Entity.Migrations;

namespace ActiveManagementSystem
{
    public class Configuration
    {
        protected override void Seed(ActiveManagementSystemContext context)
        {
            context.People.AddOrUpdate(x => x.PersonId,
                new Person() { PersonId = 1, Name = "Jane Austen" },
                new Person() { PersonId = 2, Name = "Charles Dickens" },
                new Person() { PersonId = 3, Name = "Miguel de Cervantes" }
                );

            context.Employees.AddOrUpdate(x => x.EmployeeId,
                new Employee()
                {
                    EmployeeId = 1,
                    PersonId = 1,
                },
                new Employee()
                {
                    EmployeeId = 2,
                    PersonId = 1,
                },
                new Employee()
                {
                    EmployeeId = 3,
                    PersonId = 2,

                },
                new Employee()
                {
                    EmployeeId = 4,
                    PersonId = 3,

                }
                );
        }
    }
    
}