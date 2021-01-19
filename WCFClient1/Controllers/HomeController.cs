using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WCFClient1.Helper;
using WCFClient1.Models;
using WCFClient1.ServiceReference1;

namespace WCFClient1.Controllers
{
    public class HomeController : Controller
    {
        private ServiceReference1.ServiceClient client;
        public HomeController()
        {
            client = new ServiceReference1.ServiceClient();
        }
        public ActionResult Index(string keysearch)
        {
            if (!String.IsNullOrEmpty(keysearch))// check neu field search co value thi se lay nhung ban ghi theo key search
            {
                return View(client.GetEmployeeBySearch(keysearch));
            }
            return View(client.GetListEmployee());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create(EmployeeViewModel employee)
        {
            if (ModelState.IsValid)
            {
                var intEmployee = ConverTypeHelper.ConvertViewStudentToServiceStudent(employee);
                client.AddEmployee(intEmployee);
                return RedirectToAction("Index");
            }
            return View(employee);
        }

      
    }
}