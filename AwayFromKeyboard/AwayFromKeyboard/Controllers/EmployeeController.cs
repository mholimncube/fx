using AwayFromKeyboard.Models;
using AwayFromKeyboard.MongoDBContext;
using MongoDB.Bson;
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
        DBContext _dbContext;

        public EmployeeController()
        {
            _dbContext = new DBContext();
        }
        [HttpPost]
        public ActionResult Index(Employee employee)
        {

            if (ModelState.IsValid)
            {
               if(employee.Name == null)
                {
                    return View();
                }
                var collection = _dbContext.Employees;
                collection.InsertOneAsync(employee);

                return RedirectToAction("employeeList");

            }
            return View();
        }
        public ActionResult employeeList()
        {
          
            var collection = _dbContext.Employees.Find(new BsonDocument()).ToList();
            return View(collection);
        }

    }
}