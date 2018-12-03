using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using DemoSys.Models;
using System.Data.Entity.ModelConfiguration.Configuration;

namespace DemoSys.Models.DAL
{
    public class StateSystemContext
    {
        public DbSet<Employee> employees { get; set; }
        public DbSet<States> states { get; set; }
        public DbSet<Session> sessions { get; set; }


    }
}