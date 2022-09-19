using CRUDUsingADO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CRUDUsingADO.Controllers
{
    public class HomeController : Controller
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default",                                              // Route name
                "{controller}/{action}/{id}",                           // URL with parameters
                new { controller = "Home", action = "Index", id = "" }  // Parameter defaults
            );
        }
        protected void Application_Start()
        {
            RegisterRoutes(RouteTable.Routes);
        }
        // GET: Home
        public ActionResult Index()
        {
            EmloyeeDBContext db = new EmloyeeDBContext();
            List<Employee> obj = db.GetEmployees();
        
            return View(obj);
        }

        public ActionResult Create()
        {
            

            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            try
            {
                if (ModelState.IsValid == true)
                {
                    EmloyeeDBContext context = new EmloyeeDBContext();
                    bool check = context.AddEmployee(emp);
                    if (check == true)
                    {
                        TempData["InsertMessage"] = "Data has been inserted successfully";
                        ModelState.Clear();
                        return RedirectToAction("Index");
                    }
                }

                return View();
            }
            catch
            {
                return View();
            }

            }
        public ActionResult Edit(int EId)
        {
            EmloyeeDBContext context = new EmloyeeDBContext();
            var row = context.GetEmployees().Find(model => model.EId==EId);

            return View(row);
        }
        [HttpPost]
        public ActionResult Edit(int EId,Employee emp)
        {
            if (ModelState.IsValid == true)
            {
                EmloyeeDBContext context = new EmloyeeDBContext();
                bool check = context.UpdateEmployee(emp);
                if (check == true)
                {
                    TempData["UpdateMessage"] = "Data has been inserted successfully";
                    ModelState.Clear();
                    return RedirectToAction("Index");
                }
            }
            return View();
        }
        public ActionResult Delete(int EId)
        {
            EmloyeeDBContext context = new EmloyeeDBContext();
            var row = context.GetEmployees().Find(model => model.EId == EId);

            return View(row);
        }
        [HttpPost]
        public ActionResult Delete(int EId,Employee emp)
        {

            if (ModelState.IsValid == true)
            {
                EmloyeeDBContext context = new EmloyeeDBContext();
                bool check = context.DeleteEmployee(EId);
                if (check == true)
                {
                    TempData["DeleteMessage"] = "Data has been Deleted successfully";
                    ModelState.Clear();
                    return RedirectToAction("Index");
                }
            }
            return View();

        }
    }
}