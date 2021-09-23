using MVCWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            User user = new User()
            {
                Id = 1,
                FirstName = "Ariel",
                LastName = "Rodriguez",
                Age = 29
            };

            return View(user);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact(int id=0)
        {
            ViewBag.Message = id;

            return View();
        }
    }
}