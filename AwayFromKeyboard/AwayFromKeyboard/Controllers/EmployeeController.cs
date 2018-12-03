using AwayFromKeyboard.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AwayFromKeyboard.Controllers
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

            }
            return View();
        }
    }
}