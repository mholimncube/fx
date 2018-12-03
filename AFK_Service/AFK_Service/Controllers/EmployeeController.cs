using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AFK_Service.Models;
using System.Configuration;
using MongoDB.Driver;


namespace AFK_Service.Controllers
{
    public class EmployeeController : Controller
    {
       
        // GET: Employee
        [HttpPost]
        public ActionResult Index(Employee employee)
        {
            
            if (ModelState.IsValid)
            {
                string constr = ConfigurationManager.AppSettings["connectionString"];
                var Client = new MongoClient(constr);
                var DB = Client.GetDatabase("AFKdb");
                var collection = DB.GetCollection<Employee>("Employee");
                collection.InsertOneAsync(employee);

                return RedirectToAction("emplist");
                //this is testing

            }
            return View();
        }
    }
}